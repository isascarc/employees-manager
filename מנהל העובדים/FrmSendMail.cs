using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerEmployees
{
    public partial class FrmSendMail : Form
    {
        public List<string> files = new List<string>();
        public FrmSendMail()
        {
            InitializeComponent();
            try
            {
                if (new Ping().Send("www.google.com.mx").Status == IPStatus.Success)
                {
                    LblWarning.Visible = false;
                    LblConnected.Visible = true;
                }
            }
            catch { }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //validation mail
            if (TxtSendTo.Text.Trim() == "")
            {
                MessageBox.Show("לא הוזנה כתובת מייל");
                TxtSendTo.Focus();
            }
            else
            {
                System.Text.RegularExpressions.Regex regMail = new System.Text.RegularExpressions.Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
                if (!regMail.IsMatch(TxtSendTo.Text))
                {
                    MessageBox.Show("כתובת המייל שהוזנה אינה תקינה");
                    TxtSendTo.Focus();
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BtnAddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog() { Multiselect = true };
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files.AddRange(dlg.FileNames);
            }
            LstFiles.Items.Clear();
            LstFiles.Items.AddRange(files.ToArray());
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("האם אתה בטוח שברצונך להסיר את כל הקבצים שצירפת להודעה שלך?", "מחיקת רשימת הקבצים") == System.Windows.Forms.DialogResult.OK)
            {
                files.Clear();
                LstFiles.Items.Clear();
            }
        }
    }
}