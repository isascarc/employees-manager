#region references

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Media;
using System.Runtime.InteropServices;

using Access = Microsoft.Office.Interop.Access;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Data.OleDb;
using System.Net.NetworkInformation;
using System.Globalization;
//using System.Threading;

#endregion

namespace ManagerEmployees
{
    public partial class FrmMain : Form
    {
        delegate string ExportToFile(int[] employees, string FileName);
        List<employee> emp = new List<employee>();
        List<string> ListNamesFiltered = new List<string>();
        List<int> salary = new List<int>();
        bool ModeSearch = false;
        readonly string[] Names = new string[] {"שם פרטי:",
            "שם משפחה:",
            "מצב אישי:", "ילדים:",
            "מספר זהות:","עיר:", "כתובת:","מספר טלפון נייד:",
            "מספר טלפון בבית:","כתובת דוא\"ל","תפקיד בחברה:","הערות:"
        };
        readonly string[] NamesToXml = new string[] {"שם_פרטי",
            "שם_משפחה",
            "מצב_אישי",
            "ילדים",
            "מספר_זהות",
            "עיר",
            "כתובת",
            "מספר_טלפון_נייד",
            "מספר_טלפון_בבית",
            "כתובת_דואר_אלקטרוני",
            "תפקיד_בחברה",
            "הערות"};
        System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
        // create objects for load image employee
        int IDForLoadImage = 0;
        Timer tmrLoadImage = new Timer() { Interval = 1000 };
        //
        Timer tmrShowMessageSuccssed = new Timer() { Interval = 5000 };

        public FrmMain()
        {
            InitializeComponent();
            Settings.LoadSettings();
            //Swich to hebrew lang
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo(1037));
            // load all employees
            loadFromSQL();
            tmrLoadImage.Tick += LoadImg;
            //
            tmrShowMessageSuccssed.Tick += tmrShowMessageSuccssed_Tick;
        }

        private void loadFromSQL()
        {
            // clear all items
            emp.Clear();
            lst_names.Items.Clear();
            // test - insert 2 emp. and order.
            /*string[] emp1 = new string[] { "12", "משה", "בניזרי", "d", DateTime.Now.ToShortDateString(), "a", "נ", "c", "d", "e", "f", "g", DateTime.Now.ToShortDateString(), "a" };
            string[] emp2 = new string[] { "13", "יששכר", "חטב", "d", DateTime.Now.ToShortDateString(), "a", "a", "a", "a", "a", "a", "a", DateTime.Now.ToShortDateString(), "a" };
            emp.Add(new employee(emp1));
            emp.Add(new employee(emp2));
            emp = emp.OrderBy(x => x.name).ToList();*/
            try
            {
                //tofix

                // load data from db
                dsEmployees.EmployeesDataTable dt = new dsEmployees.EmployeesDataTable();
                dsEmployeesTableAdapters.EmployeesTableAdapter ta = new dsEmployeesTableAdapters.EmployeesTableAdapter();
                ta.Fill(dt);
                /*DataSetEmps.tblEmployeesDataTable dt= new DataSetEmps.tblEmployeesDataTable();
                DataSetEmpsTableAdapters.tblEmployeesTableAdapter tblEmployees = new DataSetEmpsTableAdapters.tblEmployeesTableAdapter();
                tblEmployees.Fill(dt);*/
                /*DataSet2.employeesDataTable dt = new DataSet1.employeesDataTable();
                DataSet1TableAdapters.employeesTableAdapter adap = new DataSet1TableAdapters.employeesTableAdapter();
                adap.Fill(dt);*/
                // enter data into 'emp' list //need add: if the db empty, exit from method
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    emp.Add(new employee(dt[i].ItemArray.ToArray()));
                }
                emp = emp.OrderBy(x => x.name).ToList();
                for (int i = 0; i < emp.Count; i++)
                {
                    lst_names.Items.Add(emp[i].name + " " + emp[i].family);
                }
                for (int i = 0; i < lst_names.Items.Count; i++)
                {
                    ListNamesFiltered.Add(lst_names.Items[i].ToString());
                }
                if (lst_names.Items.Count > 0)
                {
                    lst_names.SelectedIndex = 0;
                    LoadEmployee(0);
                }
            }
            catch (Exception e)
            {
                //   MessageBox.Show("לא היה ניתן לפתוח את הקובץ");
            }

            //}
        }

        /// <summary>
        /// Load employee by index number.
        /// </summary>
        /// <param name="numEmp">the index of the employee to show</param>
        void LoadEmployee(int numEmp)
        {
            try
            {
                lbl_name_full.Text = emp[numEmp].name + " " + emp[numEmp].family;
                TxtName.Text = emp[numEmp].name;
                TxtFamily.Text = emp[numEmp].family;
                TxtBirthDate.Text = emp[numEmp].birth.ToShortDateString();
                TxtAge.Text = (DateTime.Now.Year - emp[numEmp].birth.Year).ToString() + " שנה";
                TxtEnterToWork.Text = emp[numEmp].startWork.ToShortDateString();
                TxtSeniority.Text = (DateTime.Now.Year - emp[numEmp].startWork.Year).ToString() + " שנה";
                TxtStatus.Text = emp[numEmp].Status;
                if (emp[numEmp].Childs != "0")
                    TxtStatus.Text += " + " + emp[numEmp].Childs;
                TxtIN.Text = emp[numEmp].ID.ToString();
                TxtCity.Text = emp[numEmp].City;
                TxtAddress.Text = emp[numEmp].Address;
                TxtTelephone.Text = emp[numEmp].Telephone;
                TxtMail.Text = emp[numEmp].Mail;
                TxtDuty.Text = emp[numEmp].Duty;
                TxtRemarks.Text = emp[numEmp].Remarks;
                TxtSalary.Text = emp[numEmp].salary.ToString();
                // load image of emp after 1 second
                //Thread v = new Thread (new ParameterizedThreadStart())
                pic1.Image = Properties.Resources.NoImage;
                IDForLoadImage = emp[numEmp]._ID;
                tmrLoadImage.Stop();
                tmrLoadImage.Start();
            }
            catch { }
        }

        void LoadImg(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            try
            {
                pic1.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\" + IDForLoadImage.ToString() + ".png");
            }
            catch { }
        }

        private void cmd_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lst_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmployee(lst_names.SelectedIndex);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שברצונך למחוק את " + lst_names.SelectedItem.ToString(), "", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                // delete selected employee fron 4 list emp's, and refresh panel
                int i = lst_names.SelectedIndex;
                //tofix
                /*DataSet1TableAdapters.employeesTableAdapter y = new DataSet1TableAdapters.employeesTableAdapter();
                if (Settings.AbsoluteDelete)
                    y.Delete(emp[i]._ID);
                else
                    y.VirtualDelete(emp[i]._ID);
                emp.RemoveAt(i);
                lst_names.Items.RemoveAt(i);
                lst_names.SelectedIndex = i == lst_names.Items.Count ? i - 1 : i;
                // message - delete commpleted
                SstExportingSucssed.Visible = true;
                */
            }
        }

        private void MitExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MitAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void MitOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dial = new OpenFileDialog() { Filter = "רשימות עובדים|*.emp", Title = "פתיחת קובץ" };
            if (dial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                emp.Clear();
                loadFromSQL();
                string[] ar = new string[] { "12", "a", "s", "d", DateTime.Now.ToShortDateString(), "a", "a", "a", "a", "a", "a", "a", DateTime.Now.ToShortDateString(), "a" };
                string[] ac = new string[] { "13", "יששכר", "חטב", "d", DateTime.Now.ToShortDateString(), "a", "a", "a", "a", "a", "a", "a", DateTime.Now.ToShortDateString(), "a" };
                emp.Add(new employee(ar));
                emp.Add(new employee(ac));
                emp = emp.OrderBy(x => x.name).ToList();
                for (int i = 0; i < emp.Count; i++)
                {
                    lst_names.Items.Add(emp[i].name + " " + emp[i].family);
                }
                for (int i = 0; i < lst_names.Items.Count; i++)
                {
                    ListNamesFiltered.Add(lst_names.Items[i].ToString());
                }
                if (lst_names.Items.Count > 0)
                {
                    lst_names.SelectedIndex = 0;
                    LoadEmployee(0);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintDialog dial = new PrintDialog();
            dial.Document = docToPrint;
            docToPrint.PrintPage += docToPrint_PrintPage;
            if (dial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dial.Document.Print();
            }
        }

        private void MitOptions_Click(object sender, EventArgs e)
        {
            FrmSettings frmSet = new FrmSettings();
            frmSet.ShowDialog();
            if (frmSet.NeedRefresh)
                loadFromSQL();
        }

        private void MitSearch_Click(object sender, EventArgs e)
        {
            //show search panel
            pnlSearch.Visible = true;
            TxtSaerch.Focus();
        }
        private void TxtSaerch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSaerch.Text.Trim() != "")
            {
                switch (CbxwhereSearch.SelectedIndex)
                {
                    case 0:

                        ModeSearch = true;
                        lst_names.Items.Clear();

                        //DateTime y = DateTime.Now;
                        // option 1 --> Fast more, clean פחות
                        //for (int i = 0; i < ListNames.Count; i++)
                        //{
                        //    if (ListNames[i].StartsWith(TxtSaerch.Text))
                        //    {
                        //        lst_names.Items.Add(ListNames[i]);
                        //    }
                        //}
                        // option 2:
                        lst_names.Items.AddRange(ListNamesFiltered.FindAll(x => x.StartsWith(TxtSaerch.Text)).ToArray());

                        // option 3:
                        //lst_names.Items.AddRange(ListNames.Where(x => x.StartsWith(TxtSaerch.Text)).ToArray());
                        //MessageBox.Show((DateTime.Now.Millisecond - y.Millisecond ).ToString());
                        break;
                    case 1:
                        string textTrim = TxtSaerch.Text.Trim();
                        bool b = false;
                        for (int i = 0; i < emp.Count; i++)
                        {
                            if (emp[i].ToArray().Any(x => x.StartsWith(textTrim)) == true)
                            {
                                b = true;
                                break;
                            }
                        }
                        MessageBox.Show(b.ToString());
                        break;
                    case 2:
                        break;
                }
            }
            else
            {
                lst_names.Items.Clear();
                for (int i = 0; i < emp.Count; i++)
                {
                    lst_names.Items.Add(emp[i].name + " " + emp[i].family);
                }
                ModeSearch = false;
            }
            if (lst_names.Items.Count != 0)
                lst_names.SetSelected(0, true);
        }

        private void BtnSaerch_Click(object sender, EventArgs e)
        {
            TxtSaerch.Text = "";
            // show lstEmp's and select this.
            pnlSearch.Visible = false;
            lst_names.Select();
        }

        private void MitGoToHomePage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("home page.url");
        }

        public void LoadCreateNewFile()
        {
            FrmNewFile NewList = new FrmNewFile();
            if (NewList.ShowDialog() == DialogResult.OK)
            {
                File.Create(CreateNewFile.Location + "\\" + CreateNewFile.NameFile + (CreateNewFile.TypeThisSQL ? ".sdf" : ".emp"));
            }
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            FrmAddEmployee AddEmp = new FrmAddEmployee();
            if (AddEmp.ShowDialog() == DialogResult.OK)
            {
                loadFromSQL(); // need 'code' fast and effective more
            }
        }

        private void lst_names_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lst_names.Text != null)
                LoadEmployee(ModeSearch ? ListNamesFiltered.IndexOf(lst_names.Text) : lst_names.SelectedIndex);
        }

        #region Exports

        //Export to all types of documents
        void docToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap memoryImage = new System.Drawing.Bitmap(panel1.DisplayRectangle.Width, panel1.DisplayRectangle.Height);
            panel1.DrawToBitmap(memoryImage, panel1.DisplayRectangle);
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        /// <summary>
        /// create word document or pdf file.
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="FileName"></param>
        /// <returns>path of the file.</returns>
        private string CreateDoc(int[] employees, string FileName)
        {
            //make application word and document
            Word.Application wApp = new Word.Application();
            Word.Document doc = wApp.Documents.Add();
            for (int em = 0; em < employees.Length; em++)
            {
                string[] DataEm = emp[employees[em]].ToArray();
                // add מקטע עמוד new
                if (em != 0)
                    wApp.Selection.InsertBreak(Word.WdBreakType.wdPageBreak);
                //add picture, if exists
                wApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                try
                {
                    wApp.Selection.InlineShapes.AddPicture(Application.StartupPath + "\\images\\" + emp[employees[em]]._ID.ToString() + ".png", SaveWithDocument: true);
                    wApp.Selection.TypeParagraph();
                }
                catch { }
                //add name and family as caption
                wApp.Selection.Font.Size = 18;
                wApp.Selection.Font.SizeBi = 18;
                wApp.Selection.TypeText(DataEm[0] + " " + DataEm[1]);
                wApp.Selection.TypeParagraph();
                //שינוי הפורמט לטקסט רגיל, והכנסת כל הנתונים
                wApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                wApp.Selection.Font.Size = 12;
                wApp.Selection.Font.SizeBi = 12;
                for (int i = 0; i < 11; i++)
                {
                    wApp.Selection.TypeText(Names[i] + " " + DataEm[i]);
                    wApp.Selection.TypeParagraph();
                }
            }
            string PathToSave = "";
            if (EmpToExport.ExpTo == TypeExport.pdf)
            {
                PathToSave = CreateName(FileName, ".pdf");
                doc.SaveAs2(PathToSave, Word.WdSaveFormat.wdFormatPDF);
            }
            else
            {
                PathToSave = CreateName(FileName, ".docx");
                doc.SaveAs2(PathToSave);
            }
            wApp.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            return PathToSave;
        }

        private string CreateWorksheet(int[] employees, string FileName)
        {
            Excel.Application xlApp = new Excel.Application();
            var XlWBooks = xlApp.Workbooks;
            var XlBook = XlWBooks.Add();
            xlApp.Workbooks.Add();
            var wrksheets = xlApp.Worksheets;
            wrksheets.Add(Type.Missing, Type.Missing, employees.Length - 1);
            Excel.Worksheet workSheet = xlApp.Worksheets[1];
            for (int em = 0; em < employees.Length; em++)
            {
                workSheet = xlApp.Worksheets[em + 1];
                string[] a = emp[em].ToArray();
                for (int i = 0; i < 11; i++)
                {
                    workSheet.Cells[i + 1, "A"] = Names[i];
                    workSheet.Cells[i + 1, "B"] = a[i];
                }
                try
                {
                    if (true)
                        workSheet.Shapes.AddPicture(Application.StartupPath + "\\images\\" + emp[em]._ID.ToString() + ".png",
                    Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse,
                    150f, 10f, 180, 200);
                }
                catch { }
                workSheet.Name = a[0] + " " + a[1];
            }
            string PathToSave = CreateName(FileName, ".xlsx");
            workSheet.SaveAs(PathToSave);
            //
            XlWBooks.Close();
            xlApp.Quit();
            return PathToSave;
        }


        private string CreateSlide(int[] employees, string FileName)
        {
            /*PowerPoint.Application ppApp = new PowerPoint.Application();
            PowerPoint.Presentation pre = ppApp.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoFalse);
            pre.ApplyTemplate("c:\\1.thmx");
            // add slides & data
            for (int i = 0; i < employees.Length; i++)
                pre.Slides.AddSlide(1, pre.SlideMaster.CustomLayouts._Index(2));
            pre.Slides.AddSlide(1, pre.SlideMaster.CustomLayouts._Index(1));
            pre.Slides[1].Shapes[1].TextFrame.TextRange.Text = employees.Length == 1 ? emp[employees[0]].name + " " + emp[employees[0]].family : "רשימת העובדים";
            for (int em = 0; em < employees.Length; em++)
            {
                string[] a = emp[employees[em]].ToArray();
                pre.Slides[em + 2].Shapes[1].TextFrame.TextRange.Text = a[0] + " " + a[1];
                for (int i = 1; i < 11; i++)
                {
                    pre.Slides[em + 2].Shapes[i + 1].TextFrame.TextRange.Text = Names[i] + " " + a[i];
                }
                // add picture, if exist
                /*try
                {
                    if (emp[lst_names.SelectedIndex].PicProfile != null)
                        workSheet.Shapes.AddPicture(emp[lst_names.SelectedIndex].stringOfImage,
                    Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse,
                    150f, 1f, emp[lst_names.SelectedIndex].PicProfile.Width,
                    emp[lst_names.SelectedIndex].PicProfile.Height);
                }
                catch { }*/

            //שמירה ושחרור הזכרון
            /*        string path = CheckName(FileName, ".pptx");
                    pre.SaveAs(path);
                    pre.Close();
                    ppApp.Quit();
                    Marshal.ReleaseComObject(pre);
                    //collect jank
                    GC.Collect();
                    GC.WaitForPendingFinalizers();*/
            return "";
        }


        private void ConvertToArchive(string Path)
        {
            FileInfo fi = new FileInfo(Path);
            FileStream inFile = fi.OpenRead();
            FileStream outFile = File.Create(System.IO.Path.ChangeExtension(fi.FullName, ".gz"));
            GZipStream Compress = new GZipStream(outFile, CompressionMode.Compress);
            inFile.CopyTo(Compress);
        }

        private static void SendMail(string pathFi)
        {
            FrmSendMail FrmMail = new FrmSendMail();
            if (FrmMail.ShowDialog() == DialogResult.OK)
            {
                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587;
                bool enableSSL = true;
                // set variables of the message: address, password
                string emailFrom = "isascarch@gmail.com";
                string password = "IC153486";
                using (MailMessage Mail = new MailMessage())
                {
                    //הכנסת הנתונים לתוך ההודעה האמיתית
                    Mail.From = new MailAddress(emailFrom);
                    Mail.To.Add(FrmMail.TxtSendTo.Text);
                    Mail.Subject = FrmMail.TxtSubject.Text;
                    Mail.Body = FrmMail.TxtBodyMessage.Text;
                    Mail.IsBodyHtml = true;
                    // add into message the file exported, and another files if selected.
                    Mail.Attachments.Add(new Attachment(pathFi));
                    for (int a = 0; a < FrmMail.files.Count; a++)
                        Mail.Attachments.Add(new Attachment(FrmMail.files[a]));
                    // send message in really
                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        try
                        {
                            smtp.Send(Mail);
                            MessageBox.Show("ההודעה נשלחה בהצלחה!", "שליחת מייל");
                        }
                        catch (Exception x) { MessageBox.Show(x.Message, "שליחת מייל"); }
                    }
                }
            }
        }

        /// <summary>
        /// get the full path file that don't exist.
        /// </summary>
        /// <param name="path">the full path with name of the file.</param>
        /// <param name="extention">the extention of the file, include dot.</param>
        /// <returns></returns>
        private string CreateName(string path, string extention)
        {
            if (!File.Exists(path + extention))
            {
                return path + extention;
            }
            else
            {
                string _path = path;
                int Counter = 0;
            Checker:
                Counter++;
                if (File.Exists(_path + " " + Counter.ToString() + extention))
                    goto Checker;
                return _path + " " + Counter.ToString() + extention;
            }
        }

        private string CreateHTMLFile(int[] employees, string FileName)
        {
            string file = Properties.Resources.index;
            string PathToFile = CreateName(FileName, ".html");
            using (StreamWriter streamWriter = new StreamWriter(PathToFile))
            {
                // Write first employee
                string[] DataEm = emp[employees[0]].ToArray();
                string _ID = DataEm[0] + DataEm[1];
                string buttons = returnActiveButton(_ID);
                string allText = string.Empty;
                for (int i = 0; i < 12; i++)
                {
                    allText += "<p>" + Names[i] + " " + DataEm[i] + "</p>";
                }
                string data = returnActiveText(_ID, _ID, allText);

                // weite all employees but first
                if (employees.Length > 1)
                {
                    for (int em = 1; em < employees.Length; em++)
                    {
                        DataEm = emp[employees[em]].ToArray();
                        allText = string.Empty;
                        _ID = DataEm[0] + DataEm[1];
                        buttons += returnButton(DataEm[0] + DataEm[1]);
                        for (int i = 0; i < 12; i++)
                        {
                            allText += "<p>" + Names[i] + " " + DataEm[i] + "</p>";
                        }
                        if (emp[lst_names.SelectedIndex].stringOfImage != "")
                            ;
                        /*FileTemp.WriteLine("<img src=\"" + Application.StartupPath + "\\" +
                  emp[employees[em]].stringOfImage + "\">");*/
                    }
                    data += returnText(_ID, _ID, allText);
                }
                file = file.Replace("buttons area", buttons).Replace("data area", data);
                streamWriter.Write(file);
            }
            // write css, js, and icon files - for HTML file.
            string CSSfile = Properties.Resources.styles;
            string JSFile = Properties.Resources.app;
            Icon IconFile = Properties.Resources.favicon;
            string RealPath = Path.GetDirectoryName(FileName);
            using (StreamWriter streamWriter = new StreamWriter(RealPath + "\\app.js"))
            {
                streamWriter.Write(JSFile);
            }
            using (StreamWriter streamWriter = new StreamWriter(RealPath + "\\styles.css"))
            {
                streamWriter.Write(CSSfile);
            }
            using (StreamWriter streamWriter = new StreamWriter(RealPath + "\\favicon.ico"))
            {
                IconFile.Save(streamWriter.BaseStream);
            }
            return PathToFile;
        }

        private string CreateDb(int[] employees, string FileName)
        {

            //Create db
            Access.Application acApp = new Access.Application();
            string PathToFile = CreateName(FileName, ".accdb");
            acApp.NewCurrentDatabase(PathToFile, Access.AcNewDatabaseFormat.acNewDatabaseFormatUserDefault);
            acApp.CloseCurrentDatabase();
            acApp.Quit(Access.AcQuitOption.acQuitSaveAll);
            //Collect jank
            Marshal.ReleaseComObject(acApp);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //-> Add table into the db
            String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + PathToFile;
            String tableName = "רשימת העובדים";
            string[] columns = new string[] {"שם_פרטי", "שם_משפחה", "מצב_אישי", "ילדים",
                "מספר_זהות","עיר", "כתובת","מספר_טלפון_נייד",
                "מספר_טלפון_בבית","כתובת_דואר_אלקטרוני", "תפקיד_בחברה","הערות"};
            // Create the qwery
            String createSQL = "CREATE TABLE [" + tableName + "] (id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL, ";
            for (int i = 0; i < columns.Length - 1; i++)
            {
                createSQL += columns[i] + " nvarchar (255), ";
            }
            createSQL += columns[columns.Length - 1] + " nvarchar (255))";
            //Connect to db
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand dbCmd = new OleDbCommand();
            conn.Open();
            dbCmd.Connection = conn;
            dbCmd.CommandText = createSQL;
            dbCmd.ExecuteNonQuery();
            //add data into table         ##the syntaxt :INSERT INTO employees (firstName, lastName)  VALUES  (@firstName,@Nqwwsw)
            for (int i = 0; i < employees.Length; i++)
            {
                //add captions
                createSQL = "INSERT INTO [" + tableName + "] (";
                for (int b = 0; b < columns.Length - 1; b++)
                {
                    createSQL += columns[b] + ", ";
                }
                //add sperator
                createSQL += columns[columns.Length - 1] + ") VALUES ('";
                //add data
                string[] a = emp[employees[i]].ToArray();
                for (int j = 0; j < a.Length - 1; j++)
                {
                    createSQL += a[j] + "', '";
                }
                createSQL += a[a.Length - 1] + "')";
                // executable qwery - insert values
                dbCmd.CommandText = createSQL;
                dbCmd.ExecuteNonQuery();
            }
            //Excutable qwery 
            dbCmd.Connection.Close();
            conn.Close();
            return "PathToFile";
        }

        private string CreateSQL(int[] employees, string FileName)
        {
            using (var connection = new SqlConnection("Server=(localdb)\\Projects;pwd=;database=master"))
            {
                string nameOnly = Path.GetFileName(FileName);
                string nameClear = nameOnly.Replace(" ", "_");
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText =
                    "CREATE DATABASE " + nameClear +
                    " ON PRIMARY " +
                    "(NAME = " + nameClear + @", SIZE = 5MB, FILENAME =""C:\Users\יששכר חטאב\Documents\" + nameClear + @".sdf"", MAXSIZE = 100MB, FILEGROWTH = 10%)";
                    //"CREATE DATABASE "+
                    //" LOG ON" +
                    //" (NAME = " + NameClear + "_log," +
                    //" FILENAME = '" + NameClear + "'," +
                    //" SIZE = 1MB," +
                    //" MAXSIZE = 5MB," +
                    //" FILEGROWTH = 10%)" +
                    //";";

                    // --> Add data into new DB.
                    command.ExecuteNonQuery();
                }
                catch { }
                return "";
            }
        }
        private string CreateTextFile(int[] employees, string FileName)
        {
            string PathToFile = CreateName(FileName, ".txt");
            using (System.IO.StreamWriter FileTemp = new System.IO.StreamWriter(PathToFile))
            {
                for (int em = 0; em < employees.Length; em++)
                {
                    if (em != 0)
                        FileTemp.WriteLine("");
                    string[] DataEm = emp[employees[em]].ToArray();
                    for (int i = 0; i < 12; i++)
                    {
                        FileTemp.WriteLine(Names[i] + " " + DataEm[i]);
                    }
                }
            }
            return PathToFile;
        }

        private string CreateXmlFile(int[] employees, string FileName)
        {
            string PathToFile = CreateName(FileName, ".xml");
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode xmlBooksNode = xmlDocument.CreateElement("עובדים");
            xmlDocument.AppendChild(xmlBooksNode);
            // add all parameters of all emp's in loop, and enter this into XmlDoc.
            for (int em = 0; em < employees.Length; em++)
            {
                string[] DataEm = emp[employees[em]].ToArray();
                XmlNode xmlBookNode = xmlDocument.CreateElement(DataEm[0].Replace(" ", "_") + "_" + DataEm[1].Replace(" ", "_"));
                xmlBooksNode.AppendChild(xmlBookNode);
                XmlNode[] xmlParams = new XmlNode[15];
                for (int i = 0; i < NamesToXml.Length; i++)
                {
                    xmlParams[i] = xmlDocument.CreateElement(NamesToXml[i]);
                    xmlParams[i].InnerText = DataEm[i];
                    xmlBookNode.AppendChild(xmlParams[i]);
                }
            }
            // write params into the file
            using (System.IO.StreamWriter FileTemp = new System.IO.StreamWriter(PathToFile))
            {
                FileTemp.WriteLine(xmlDocument.OuterXml);
            }
            return PathToFile;
        }

        private string CreateAspFile(int[] employees, string FileName)
        {
            return "";
        }

        public void ExportTo(object sender, EventArgs e)
        {
            ExportToFile MyCreateFile = null;
            switch (((ToolStripMenuItem)sender).Tag.ToString())
            {
                case "word":
                    MyCreateFile = new ExportToFile(CreateDoc);
                    EmpToExport.ExpTo = TypeExport.document;
                    break;
                case "excel":
                    MyCreateFile = new ExportToFile(CreateWorksheet);
                    EmpToExport.ExpTo = TypeExport.worksheet;
                    break;
                case "access":
                    MyCreateFile = new ExportToFile(CreateDb);
                    EmpToExport.ExpTo = TypeExport.DbAccesss;
                    break;
                case "powerpoint":
                    MyCreateFile = new ExportToFile(CreateSlide);
                    EmpToExport.ExpTo = TypeExport.slide;
                    break;
                case "pdf":
                    MyCreateFile = new ExportToFile(CreateDoc);
                    EmpToExport.ExpTo = TypeExport.pdf;
                    break;
                case "html":
                    MyCreateFile = new ExportToFile(CreateHTMLFile);
                    EmpToExport.ExpTo = TypeExport.html;
                    break;
                case "sql":
                    MyCreateFile = new ExportToFile(CreateSQL);
                    EmpToExport.ExpTo = TypeExport.DbSQL;
                    break;
                // from here - this empty.
                case "asp.net":
                    MyCreateFile = new ExportToFile(CreateAspFile);
                    EmpToExport.ExpTo = TypeExport.ASP;
                    break;
                case "xml":
                    MyCreateFile = new ExportToFile(CreateXmlFile);
                    EmpToExport.ExpTo = TypeExport.Xml;
                    break;
                case "text":
                    MyCreateFile = new ExportToFile(CreateTextFile);
                    EmpToExport.ExpTo = TypeExport.Text;
                    break;
            }
            EmpToExport.Path = Application.StartupPath;
            FrmOptionsExport MyExp = new FrmOptionsExport(ListNamesFiltered.ToArray(), lbl_name_full.Text, EmpToExport.ExpTo);
            if (MyExp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // --> מניעת התנגשויות הודעות על ייצוא
                tmrShowMessageSuccssed.Stop();

                SstExportingMessage.Visible = true;
                string MyPath = "";
                switch (EmpToExport.TypeToExport)
                {
                    case QuantityExport.This:
                        MyPath = MyCreateFile(new int[] { lst_names.SelectedIndex }, EmpToExport.Path + "\\" + EmpToExport.fileName);
                        break;
                    case QuantityExport.All:
                        int[] MyArr = new int[lst_names.Items.Count];
                        for (int z = 0; z < MyArr.Length; z++)
                            MyArr[z] = z;
                        MyPath = MyCreateFile(MyArr, EmpToExport.Path + "\\רשימת עובדים מלאה");
                        break;
                    case QuantityExport.Specific:
                        CheckedListBox.CheckedIndexCollection Checkeds = MyExp.ChlEmployees.CheckedIndices;
                        int[] MyArr2 = new int[Checkeds.Count];
                        for (int i = 0; i < MyArr2.Length; i++)
                            MyArr2[i] = Checkeds[i];
                        MyPath = MyCreateFile(MyArr2, EmpToExport.Path + "\\רשימת עובדים");
                        break;
                }
                // if selected: create archive, open in end, and send file in mail.
                if (EmpToExport.OpenInEnd)
                    System.Diagnostics.Process.Start(MyPath);
                if (EmpToExport.ToArchive)
                    ConvertToArchive(MyPath);
                if (EmpToExport.SendMail)
                    SendMail(MyPath);
                // create visuals effect
                // FileStream gunSoundFile = new FileStream("1.wav", FileMode.Open, FileAccess.Read);
                // new SoundPlayer(gunSoundFile).Play();
                SstExportingSucssed.Visible = true;
                SstExportingMessage.Visible = false;
            }
        }

        #endregion

        private void SstExportingSucssed_VisibleChanged(object sender, EventArgs e)
        {
            if (SstExportingSucssed.Visible)
                tmrShowMessageSuccssed.Start();
        }

        void tmrShowMessageSuccssed_Tick(object sender, EventArgs e)
        {
            SstExportingSucssed.Visible = false;
            tmrShowMessageSuccssed.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmRegExSearch().ShowDialog();
        }

        #region Create Html

        private string returnActiveButton(string name)
        {
            return string.Format("<button class='tab-btn active' data-id='{0}'>{0}</button>", name);
        }

        private string returnButton(string name)
        {
            return string.Format("<button class='tab-btn' data-id='{0}'>{0}</button>", name);
        }

        private string returnActiveText(string ID, string caption, string Text)
        {
            return string.Format("<div class='content active' id='{0}'> <h4>{1}</h4>{2}</div>", ID, caption, Text);
        }

        private string returnText(string ID, string caption, string Text)
        {
            return string.Format("<div class='content' id='{0}'> <h4>{1}</h4><p>{2}</p></div>", ID, caption, Text);
        }
        #endregion

        private void MitNew_Click(object sender, EventArgs e)
        {
            // Change status textboxs to edit mode.
            var allTextBoxs = panel1.Controls.OfType<TextBox>().ToArray();
            for (int i = 0; i < allTextBoxs.Length; i++)
            {
                allTextBoxs[i].Text = string.Empty;
                allTextBoxs[i].ReadOnly = false;
                allTextBoxs[i].BorderStyle = BorderStyle.Fixed3D;
            }
            btnCreate.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Change status textboxs to view mode.
            var allTextBoxs = panel1.Controls.OfType<TextBox>().ToArray();
            for (int i = 0; i < allTextBoxs.Length; i++)
            {
                //allTextBoxs[i].Text = string.Empty;
                allTextBoxs[i].ReadOnly = true;
                allTextBoxs[i].BorderStyle = BorderStyle.None;
            }
            btnCreate.Visible = false;
            btnCancel.Visible = false;
            // load previus employee 
            if (lst_names.SelectedIndex >= 0)
                LoadEmployee(lst_names.SelectedIndex);
        }

        private void ViewEmployeeMode()
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void ייצאלקובץJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] g = new string[] { "asd", "888" };
            using (StreamWriter streamWriter = new StreamWriter("c:\\01011\\2.json"))
            {
                streamWriter.Write(g);
            }
        }

        private void טעןתמונהלDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ImportImageFromDB("c:\\0\\favicon.ico", @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Database1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        private void ייצאתמונהמהDDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportImageFromDB(1, "c:\\0\\f.png", @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Database1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public static void ImportImageFromDB(int varID, string varPathToNewLocation, string con)
        {
            var varConnection = new SqlConnection(con);
            varConnection.Open();
            using (var sqlQuery = new SqlCommand(@"SELECT [image] FROM [dbo].[Employees3] WHERE [id] =2" /*@varID*/, varConnection))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
            }
        }

        public static void AddImageToDB (int varID, string FilePath, string strConnection)
        {
            byte[] file;
            using (var stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            var x = new SqlConnection(strConnection);
            x.Open();
            using (var sqlWrite = new SqlCommand("INSERT INTO Employees3 (image) Values(@File)", x))
            //using (var sqlWrite = new SqlCommand("UPDATE Employees3 SET Image = @Image WHERE(Id = @Id)", x))
            {
                sqlWrite.Parameters.Add("@id", SqlDbType.Int).Value = varID;
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                sqlWrite.ExecuteNonQuery();
            }
            //
            using (var fs = new FileStream(FilePath + ".ico", FileMode.Create, FileAccess.Write))
                fs.Write(file, 0, file.Length);
            //
        }
    }
}