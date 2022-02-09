namespace ManagerEmployees
{
    partial class FrmRegExSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtSearchRgx = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BtnSearchRegex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSearchRgx
            // 
            this.TxtSearchRgx.Location = new System.Drawing.Point(13, 50);
            this.TxtSearchRgx.Name = "TxtSearchRgx";
            this.TxtSearchRgx.Size = new System.Drawing.Size(298, 20);
            this.TxtSearchRgx.TabIndex = 0;
            this.TxtSearchRgx.TextChanged += new System.EventHandler(this.TxtSearchRgx_TextChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(325, 53);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 227;
            this.Label1.Text = "מה לחפש?";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(316, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 228;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(360, 98);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 229;
            this.label2.Text = "צמוד";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(325, 79);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 230;
            this.label3.Text = "אותיות שימוש";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox2.FlatAppearance.BorderSize = 4;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.checkBox2.Location = new System.Drawing.Point(316, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 231;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // BtnSearchRegex
            // 
            this.BtnSearchRegex.Location = new System.Drawing.Point(13, 152);
            this.BtnSearchRegex.Name = "BtnSearchRegex";
            this.BtnSearchRegex.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchRegex.TabIndex = 232;
            this.BtnSearchRegex.Text = "חפש";
            this.BtnSearchRegex.UseVisualStyleBackColor = true;
            this.BtnSearchRegex.Click += new System.EventHandler(this.BtnSearchRegex_Click);
            // 
            // FrmRegExSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 198);
            this.Controls.Add(this.BtnSearchRegex);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtSearchRgx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegExSearch";
            this.Text = "חיפוש מתקדם";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearchRgx;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BtnSearchRegex;
    }
}