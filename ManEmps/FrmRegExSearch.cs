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
    public partial class FrmRegExSearch : Form
    {
        private System.Windows.Forms.CheckBox checkBox01 = new CheckBox();

        int CountSpaces = 0;
        List<int> indexSpaces = new List<int>();
        char[] textAsCars;
        public FrmRegExSearch()
        {
            InitializeComponent();

            this.checkBox1.Location = new System.Drawing.Point(10, 100);
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
        }

        private void TxtSearchRgx_TextChanged(object sender, EventArgs e)
        {
            // add checkboxs in spaces.
            textAsCars = TxtSearchRgx.Text.ToCharArray();
            if (textAsCars.Contains(' '))
            {
                this.Controls.Add(checkBox01);
            }
            for (int i = 0; i < textAsCars.Length; i++)
            {
                if (i == ' ')
                {
                    CountSpaces++;
                    indexSpaces.Add(i);
                }
            }
        }

        private void BtnSearchRegex_Click(object sender, EventArgs e)
        {
            
        }
    }
}
