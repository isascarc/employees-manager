namespace ManagerEmployees
{
    partial class FrmOptionsExport
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
            this.BtnSelectPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbx1 = new System.Windows.Forms.CheckBox();
            this.RbtAll = new System.Windows.Forms.RadioButton();
            this.RbtThis = new System.Windows.Forms.RadioButton();
            this.RbtSelectEmployee = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ChlEmployees = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CbxSaveInArchive = new System.Windows.Forms.CheckBox();
            this.CbxSendInMail = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(118, 420);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 10;
            this.BtnOK.Text = "אישור";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(27, 420);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "ביטול";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSelectPath
            // 
            this.BtnSelectPath.Location = new System.Drawing.Point(27, 274);
            this.BtnSelectPath.Name = "BtnSelectPath";
            this.BtnSelectPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSelectPath.Size = new System.Drawing.Size(29, 23);
            this.BtnSelectPath.TabIndex = 6;
            this.BtnSelectPath.Text = "...";
            this.BtnSelectPath.UseVisualStyleBackColor = true;
            this.BtnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(482, 279);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(111, 11);
            this.label5.TabIndex = 13;
            this.label5.Text = "שמור ב:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Cbx1
            // 
            this.Cbx1.Location = new System.Drawing.Point(457, 335);
            this.Cbx1.Name = "Cbx1";
            this.Cbx1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cbx1.Size = new System.Drawing.Size(133, 17);
            this.Cbx1.TabIndex = 7;
            this.Cbx1.Text = "פתח קובץ בסיום";
            this.Cbx1.UseVisualStyleBackColor = true;
            // 
            // RbtAll
            // 
            this.RbtAll.AutoSize = true;
            this.RbtAll.Location = new System.Drawing.Point(547, 72);
            this.RbtAll.Name = "RbtAll";
            this.RbtAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RbtAll.Size = new System.Drawing.Size(46, 17);
            this.RbtAll.TabIndex = 0;
            this.RbtAll.Text = "הכל";
            this.RbtAll.UseVisualStyleBackColor = true;
            this.RbtAll.CheckedChanged += new System.EventHandler(this.RbtSelectEmployee_CheckedChanged);
            // 
            // RbtThis
            // 
            this.RbtThis.AutoSize = true;
            this.RbtThis.Checked = true;
            this.RbtThis.Location = new System.Drawing.Point(508, 97);
            this.RbtThis.Name = "RbtThis";
            this.RbtThis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RbtThis.Size = new System.Drawing.Size(85, 17);
            this.RbtThis.TabIndex = 1;
            this.RbtThis.TabStop = true;
            this.RbtThis.Text = "נוכחי בלבד";
            this.RbtThis.UseVisualStyleBackColor = true;
            this.RbtThis.CheckedChanged += new System.EventHandler(this.RbtSelectEmployee_CheckedChanged);
            // 
            // RbtSelectEmployee
            // 
            this.RbtSelectEmployee.AutoSize = true;
            this.RbtSelectEmployee.Location = new System.Drawing.Point(511, 122);
            this.RbtSelectEmployee.Name = "RbtSelectEmployee";
            this.RbtSelectEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RbtSelectEmployee.Size = new System.Drawing.Size(82, 17);
            this.RbtSelectEmployee.TabIndex = 2;
            this.RbtSelectEmployee.Text = "לפי בחירה:";
            this.RbtSelectEmployee.UseVisualStyleBackColor = true;
            this.RbtSelectEmployee.CheckedChanged += new System.EventHandler(this.RbtSelectEmployee_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(482, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "העובדים ליצוא";
            // 
            // ChlEmployees
            // 
            this.ChlEmployees.CheckOnClick = true;
            this.ChlEmployees.ColumnWidth = 150;
            this.ChlEmployees.Enabled = false;
            this.ChlEmployees.FormattingEnabled = true;
            this.ChlEmployees.HorizontalScrollbar = true;
            this.ChlEmployees.Location = new System.Drawing.Point(335, 49);
            this.ChlEmployees.Name = "ChlEmployees";
            this.ChlEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChlEmployees.Size = new System.Drawing.Size(150, 154);
            this.ChlEmployees.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(482, 244);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "שם הקובץ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(62, 274);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtPath.Size = new System.Drawing.Size(423, 20);
            this.TxtPath.TabIndex = 5;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(27, 244);
            this.TxtName.Name = "TxtName";
            this.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtName.Size = new System.Drawing.Size(458, 20);
            this.TxtName.TabIndex = 4;
            // 
            // CbxSaveInArchive
            // 
            this.CbxSaveInArchive.Location = new System.Drawing.Point(457, 358);
            this.CbxSaveInArchive.Name = "CbxSaveInArchive";
            this.CbxSaveInArchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbxSaveInArchive.Size = new System.Drawing.Size(133, 17);
            this.CbxSaveInArchive.TabIndex = 8;
            this.CbxSaveInArchive.Text = "שמור כארכיון";
            this.CbxSaveInArchive.UseVisualStyleBackColor = true;
            // 
            // CbxSendInMail
            // 
            this.CbxSendInMail.Location = new System.Drawing.Point(457, 381);
            this.CbxSendInMail.Name = "CbxSendInMail";
            this.CbxSendInMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbxSendInMail.Size = new System.Drawing.Size(133, 17);
            this.CbxSendInMail.TabIndex = 9;
            this.CbxSendInMail.Text = "צרף להודעת מייל";
            this.CbxSendInMail.UseVisualStyleBackColor = true;
            // 
            // FrmOptionsExport
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 455);
            this.Controls.Add(this.CbxSendInMail);
            this.Controls.Add(this.CbxSaveInArchive);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChlEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbtSelectEmployee);
            this.Controls.Add(this.RbtThis);
            this.Controls.Add(this.RbtAll);
            this.Controls.Add(this.Cbx1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSelectPath);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOptionsExport";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF יצוא לקובץ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOptionsExportToPdf_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSelectPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Cbx1;
        private System.Windows.Forms.RadioButton RbtAll;
        private System.Windows.Forms.RadioButton RbtThis;
        private System.Windows.Forms.RadioButton RbtSelectEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.CheckBox CbxSaveInArchive;
        private System.Windows.Forms.CheckBox CbxSendInMail;
        public System.Windows.Forms.CheckedListBox ChlEmployees;
    }
}