using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerEmployees
{
    public partial class FrmAddEmployee : Form
    {
        OpenFileDialog dial = new OpenFileDialog() { Filter = "קבצי תמונה|*.png" };
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // Check all textboxs is with data
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזן שם פרטי");
                return;
            }
            if (TxtFamily.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזן שם משפחה");
                return;
            }
            if (TxtIN.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזן מספר זהות");
                return;
            }
            if (TxtCity.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזנה עיר");
                return;
            }
            if (TxtAddress.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזנה כתובת");
                return;
            }
            if (TxtTelephone.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזן מספר טלפון");
                return;
            }
            if (CbxStatus.Text.Trim() == "") // ->לחבר ביחד עם בדיקה רגילה 
            {
                MessageBox.Show("לא הוזן מספר טלפון");
                return;
            }
            if (TxtMail.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזנה כתובת מייל");
                return;
            }
            if (TxtSalary.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזן סכום משכורת");
                return;
            }


            // check that mail and numbers is valids
            System.Text.RegularExpressions.Regex reg9Numbers = new System.Text.RegularExpressions.Regex("^\\d{9}$");
            if (!reg9Numbers.IsMatch(TxtIN.Text))
            {
                MessageBox.Show("מספר הזהות שהוזן אינו תקין");
                return;
            }
            if (TxtTelephone.Text.Trim() != "")
            {
                System.Text.RegularExpressions.Regex reg10Numbers = new System.Text.RegularExpressions.Regex("^\\d{10}$");
                if (!reg10Numbers.IsMatch(TxtTelephone.Text))
                {
                    MessageBox.Show("מספר הטלפון שהוזן אינו תקין");
                    return;
                }
            }
            if (TxtMail.Text.Trim() != "")
            {
                System.Text.RegularExpressions.Regex regMail = new System.Text.RegularExpressions.Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
                if (!regMail.IsMatch(TxtMail.Text))
                {
                    MessageBox.Show("כתובת המייל שהוזנה אינה תקינה");
                    return;
                }
            }
            System.Text.RegularExpressions.Regex regNumbers = new System.Text.RegularExpressions.Regex("^[0-9]{1,10}$");
            if (!regNumbers.IsMatch(TxtSalary.Text))
            {
                MessageBox.Show("סכום המשכורת  שהוזן אינו תקין");
                return;
            }

            //if all data is valid
            {
                dsEmpsTableAdapters.Employees3TableAdapter  tq = new  dsEmpsTableAdapters.Employees3TableAdapter ();
                if (tq.Insert(TxtName.Text, TxtFamily.Text, DateTime.Now, ((int)NudChilds.Value), TxtCity.Text, TxtAddress.Text, TxtTelephone.Text, TxtMail.Text, "מנהל", DateTime.Now, CbxStatus.SelectedIndex, GetBytesOfFile("c:\\0\\search.png")) == 1)
                {
                    DialogResult = DialogResult.OK;
                }
                //DataSet1TableAdapters.employeesTableAdapter y = new DataSet1TableAdapters.employeesTableAdapter();
                //if (y.InsertEmployee(TxtName.Text, TxtFamily.Text, TxtIN.Text, DtpStart.Value, (int)NudChilds.Value , TxtCity.Text,
                //  TxtAddress.Text, TxtTelephone.Text, TxtMail.Text, TxtDuty.Text, DtpEnterToWork.Value, CbxStatus.Text) == 1)
                /*{
                    // if user insert image - copy ImageFile to directory
                    if ((string)pic1.Tag == "2")
                        try
                        {
                            System.IO.File.Copy(dial.FileName, Application.StartupPath + "//images//" + (y.NewEmpNumber()) + ".png");
                        }
                        catch { }
                }*/
                Close();
            }
            //catch  { }
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            if (dial.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo y = new System.IO.FileInfo(dial.FileName);
                if (y.Length < 100000)
                {
                    pic1.Image = Image.FromFile(dial.FileName);
                    pic1.Tag = "2";
                }
                else
                    MessageBox.Show(".בחרת קובץ גדול מידי\n.KB 100-יש לבחור קובץ הקטן מ");
            }
        }

        /// <summary>
        /// reads all bytes that in file, and return all bytes as array.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Byte[] GetBytesOfFile(string path)
        {
            byte[] file = new byte[0];
            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
            catch
            {
                // file 0];
            }
            return file;
        }
    }
}