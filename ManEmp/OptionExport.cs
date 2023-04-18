using System;
using System.Windows.Forms;

namespace ManagerEmployees
{
    public partial class FrmOptionsExport : Form
    {
        public FrmOptionsExport(string[] ListEmployees, string nameEmp, TypeExport typeEx)
        {
            InitializeComponent();
            TxtName.Text = nameEmp;
            TxtPath.Text = EmpToExport.Path;
            ChlEmployees.Items.AddRange(ListEmployees);
            //insert text by type file
            switch (typeEx)
            {
                case TypeExport.document:
                    this.Text = "ייצוא למסמך Word";
                    break;
                case TypeExport.worksheet:
                    this.Text = "ייצוא לגליון Excel";
                    break;
                case TypeExport.DbAccesss:
                    this.Text = " (Access) ייצוא לבסיס נתונים";
                    break;
                case TypeExport.slide:
                    this.Text = "ייצוא למצגת PowerPoint";
                    break;
                case TypeExport.pdf:
                    this.Text = "ייצוא לקובץ pdf";
                    break;
                case TypeExport.html:
                    this.Text = "ייצוא לקובץ html";
                    break;
                case TypeExport.Text:
                    this.Text = "ייצוא למסמך טקסט";
                    break;
                case TypeExport.DbSQL:
                    this.Text = " (SQL) ייצוא לבסיס נתונים";
                    break;
                case TypeExport.ASP:
                    this.Text = "ייצוא לגליון Excel";//לתקן
                    break;
                case TypeExport.Xml:
                    this.Text = "ייצוא לקובץ XML";
                    break;
            }
        }

        private void BtnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dial = new FolderBrowserDialog() { Description = "בחר היכן ברצונך לשמור את הקובץ" };
            if (dial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtPath.Text = dial.SelectedPath;
            }
        }

        private void FrmOptionsExportToPdf_FormClosing(object sender, FormClosingEventArgs e)
        {
            // copy data from the window to var['EmpToExport']
            EmpToExport.fileName = TxtName.Text;
            EmpToExport.Path = TxtPath.Text;
            EmpToExport.OpenInEnd = Cbx1.Checked;
            EmpToExport.SendMail = CbxSendInMail.Checked;
            EmpToExport.ToArchive = CbxSaveInArchive.Checked;
            // copy Employees selected to export
            if (RbtSelectEmployee.Checked)
            {
                EmpToExport.TypeToExport = QuantityExport.Specific;
                object[] ListEmpsSelected = new object[ChlEmployees.CheckedIndices.Count];
                ChlEmployees.CheckedIndices.CopyTo(ListEmpsSelected, 0);
                EmpToExport.EmpsToExport = ListEmpsSelected;
            }
            else if (RbtAll.Checked)
                EmpToExport.TypeToExport = QuantityExport.All;
            else
                EmpToExport.TypeToExport = QuantityExport.This;
        }

        private void RbtSelectEmployee_CheckedChanged(object sender, EventArgs e)
        {
            string[] ar = new string[] { "רשימת עובדים מלאה", "עובד נוכחי", "רשימת עובדים" };
            TxtName.Text = ar[int.Parse(((RadioButton)sender).TabIndex.ToString())];
            //refresh enabled of List employees
            ChlEmployees.Enabled = RbtSelectEmployee.Checked;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(TxtPath.Text))
                try
                {
                    System.IO.Directory.CreateDirectory(TxtPath.Text);
                }
                catch { }
        }
    }
}