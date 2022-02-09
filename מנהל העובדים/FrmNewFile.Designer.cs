namespace ManagerEmployees
{
    partial class FrmNewFile
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.RbtSQL = new System.Windows.Forms.RadioButton();
            this.RbtListEmps = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(140, 366);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "אישור";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(40, 366);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "ביטול";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // RbtSQL
            // 
            this.RbtSQL.Location = new System.Drawing.Point(373, 168);
            this.RbtSQL.Name = "RbtSQL";
            this.RbtSQL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RbtSQL.Size = new System.Drawing.Size(104, 24);
            this.RbtSQL.TabIndex = 2;
            this.RbtSQL.Text = "בסיס נתונים";
            this.RbtSQL.UseVisualStyleBackColor = true;
            // 
            // RbtListEmps
            // 
            this.RbtListEmps.Checked = true;
            this.RbtListEmps.Location = new System.Drawing.Point(373, 145);
            this.RbtListEmps.Name = "RbtListEmps";
            this.RbtListEmps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RbtListEmps.Size = new System.Drawing.Size(104, 24);
            this.RbtListEmps.TabIndex = 3;
            this.RbtListEmps.TabStop = true;
            this.RbtListEmps.Text = "רשימת עובדים";
            this.RbtListEmps.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(237, 119);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "בחר את סוג רשימת העובדים שברצונך ליצור";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(135, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "יצירת רשימת עובדים חדשה";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(414, 240);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "שם הקובץ:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(414, 280);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "מיקום:";
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(76, 276);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(314, 20);
            this.TxtLocation.TabIndex = 8;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(40, 237);
            this.TxtName.Name = "TxtName";
            this.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtName.Size = new System.Drawing.Size(350, 20);
            this.TxtName.TabIndex = 9;
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(40, 276);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(30, 20);
            this.BtnBrowser.TabIndex = 10;
            this.BtnBrowser.Text = "...";
            this.BtnBrowser.UseVisualStyleBackColor = true;
            this.BtnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // FrmNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 430);
            this.Controls.Add(this.BtnBrowser);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbtListEmps);
            this.Controls.Add(this.RbtSQL);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "יצירת קובץ חדש";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton RbtSQL;
        private System.Windows.Forms.RadioButton RbtListEmps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnBrowser;
    }
}