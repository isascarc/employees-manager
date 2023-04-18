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
    public partial class FrmNewFile : Form
    {
        public FrmNewFile()
        {
            InitializeComponent();
            TxtLocation.Text = "c:\\";
            TxtName.Text = "file";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            CreateNewFile.TypeThisSQL = RbtSQL.Checked;
            CreateNewFile.NameFile = TxtName.Text;
            CreateNewFile.Location = TxtLocation.Text;
        }

        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dial = new FolderBrowserDialog();
            if (dial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                TxtLocation.Text = dial.SelectedPath;
        }
    }
}
