namespace ManagerEmployees
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.BtnOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnApply = new System.Windows.Forms.Button();
            this.CbxAutoOpen = new System.Windows.Forms.CheckBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxAbsoluteDelete = new System.Windows.Forms.CheckBox();
            this.BtnShowPassword = new System.Windows.Forms.Button();
            this.BtnRestoreDeleted = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(134, 270);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "אישור";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(46, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "ביטול";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManagerEmployees.Properties.Resources.settings1;
            this.pictureBox1.Location = new System.Drawing.Point(322, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LblTitle.Location = new System.Drawing.Point(195, 38);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTitle.Size = new System.Drawing.Size(125, 39);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "אפשרויות";
            // 
            // BtnApply
            // 
            this.BtnApply.Enabled = false;
            this.BtnApply.Location = new System.Drawing.Point(223, 270);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 6;
            this.BtnApply.Text = "החל";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // CbxAutoOpen
            // 
            this.CbxAutoOpen.Location = new System.Drawing.Point(337, 109);
            this.CbxAutoOpen.Name = "CbxAutoOpen";
            this.CbxAutoOpen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbxAutoOpen.Size = new System.Drawing.Size(165, 24);
            this.CbxAutoOpen.TabIndex = 7;
            this.CbxAutoOpen.Text = "אל תדרוש סיסמא בפתיחה";
            this.CbxAutoOpen.UseVisualStyleBackColor = true;
            this.CbxAutoOpen.CheckedChanged += new System.EventHandler(this.CbxAutoOpen_CheckedChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(175, 130);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtPassword.Size = new System.Drawing.Size(222, 20);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "הסיסמא שלך";
            // 
            // CbxAbsoluteDelete
            // 
            this.CbxAbsoluteDelete.Location = new System.Drawing.Point(239, 174);
            this.CbxAbsoluteDelete.Name = "CbxAbsoluteDelete";
            this.CbxAbsoluteDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbxAbsoluteDelete.Size = new System.Drawing.Size(263, 24);
            this.CbxAbsoluteDelete.TabIndex = 10;
            this.CbxAbsoluteDelete.Text = "במחיקה - מחק את העובד ללא אפשרות שחזור";
            this.CbxAbsoluteDelete.UseVisualStyleBackColor = true;
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.Location = new System.Drawing.Point(96, 130);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.Size = new System.Drawing.Size(73, 20);
            this.BtnShowPassword.TabIndex = 11;
            this.BtnShowPassword.Text = "הצג סיסמא";
            this.BtnShowPassword.UseVisualStyleBackColor = true;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // BtnRestoreDeleted
            // 
            this.BtnRestoreDeleted.Location = new System.Drawing.Point(341, 204);
            this.BtnRestoreDeleted.Name = "BtnRestoreDeleted";
            this.BtnRestoreDeleted.Size = new System.Drawing.Size(130, 23);
            this.BtnRestoreDeleted.TabIndex = 12;
            this.BtnRestoreDeleted.Text = "שחזר עובדים מחוקים";
            this.BtnRestoreDeleted.UseVisualStyleBackColor = true;
            this.BtnRestoreDeleted.Click += new System.EventHandler(this.BtnRestoreDeleted_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 325);
            this.Controls.Add(this.BtnRestoreDeleted);
            this.Controls.Add(this.BtnShowPassword);
            this.Controls.Add(this.CbxAbsoluteDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.CbxAutoOpen);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "אפשרויות";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.CheckBox CbxAutoOpen;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbxAbsoluteDelete;
        private System.Windows.Forms.Button BtnShowPassword;
        private System.Windows.Forms.Button BtnRestoreDeleted;
    }
}