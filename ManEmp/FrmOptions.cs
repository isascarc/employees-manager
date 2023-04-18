using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerEmployees
{
    public partial class FrmSettings : Form
    {
        public bool NeedRefresh = false;
        public FrmSettings()
        {
            InitializeComponent();
            //load data from 'settings' class
            CbxAutoOpen.Checked = Settings.OpenAuto;
            CbxAbsoluteDelete.Checked = Settings.AbsoluteDelete;
            TxtPassword.Text = Settings.Password;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // write selected-settings of user to strings -> to file
            string[] lines = new string[3];
            lines[0] = CbxAutoOpen.Checked ? "0" : "1";
            lines[1] = CbxAbsoluteDelete.Checked ? "0" : "1";
            lines[2] = TxtPassword.Text;
            try
            {
                System.IO.File.WriteAllLines("settings.set", lines);
            }
            catch { }
            Settings.LoadSettings();
        }   

        private void BtnApply_Click(object sender, EventArgs e)
        {
            BtnApply.Enabled = false;
            BtnOK_Click(sender, e);
        }
        private void Changer(object sender, EventArgs e)
        {
            BtnApply.Enabled = true;
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (BtnShowPassword.Text == "הצג סיסמא")
            {
                BtnShowPassword.Text = "הסתר סיסמא";
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                BtnShowPassword.Text = "הצג סיסמא";
                TxtPassword.UseSystemPasswordChar = true;
         
            }
        }
     
        private void CbxAutoOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxAutoOpen.Checked)
            {
                TxtPassword.Enabled = false;
                BtnShowPassword.Enabled = false;
            }
            else
            {
                TxtPassword.Enabled = true ;
                BtnShowPassword.Enabled = true ;
            }
        }

        private void BtnRestoreDeleted_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שברצונך להשיב את כל העובדים המחוקים" , "", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {//fix
                /*
                // Restore all employee into 4 list emp's, and refresh panel
                DataSet1TableAdapters.employeesTableAdapter y = new DataSet1TableAdapters.employeesTableAdapter();
                int c= y.RestoreAllDeleted ();
                if (c > 0)
                    MessageBox.Show(string.Format(".השחזור בוצע בהלחה, ושוחזרו {0} עובדים", c.ToString()));
                else
                    MessageBox.Show("לא נמצאו עובדים מחוקים");*/
                NeedRefresh = true;
                /*emp.RemoveAt(i);
                lst_names.Items.RemoveAt(i);
                lst_names.SelectedIndex = i == lst_names.Items.Count ? i - 1 : i;
                // message - delete commpleted
                SstExportingSucssed.Visible = true;*/
            }
        }
    }   
}