namespace ManagerEmployees
{
    partial class FrmSendMail
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtBodyMessage = new System.Windows.Forms.TextBox();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtSendTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddFiles = new System.Windows.Forms.Button();
            this.LstFiles = new System.Windows.Forms.ListBox();
            this.LblWarning = new System.Windows.Forms.Label();
            this.LblConnected = new System.Windows.Forms.Label();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(31, 418);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "ביטול";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(122, 418);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "שלח";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtBodyMessage
            // 
            this.TxtBodyMessage.Location = new System.Drawing.Point(31, 94);
            this.TxtBodyMessage.Multiline = true;
            this.TxtBodyMessage.Name = "TxtBodyMessage";
            this.TxtBodyMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBodyMessage.Size = new System.Drawing.Size(449, 162);
            this.TxtBodyMessage.TabIndex = 2;
            // 
            // TxtSubject
            // 
            this.TxtSubject.Location = new System.Drawing.Point(31, 68);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtSubject.Size = new System.Drawing.Size(449, 20);
            this.TxtSubject.TabIndex = 1;
            // 
            // TxtSendTo
            // 
            this.TxtSendTo.Location = new System.Drawing.Point(31, 42);
            this.TxtSendTo.Name = "TxtSendTo";
            this.TxtSendTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtSendTo.Size = new System.Drawing.Size(449, 20);
            this.TxtSendTo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(486, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "שלח אל:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(486, 67);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "כותרת:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(486, 93);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "תוכן ההודעה:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(486, 283);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "קבצים מצורפים:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAddFiles
            // 
            this.BtnAddFiles.Location = new System.Drawing.Point(31, 283);
            this.BtnAddFiles.Name = "BtnAddFiles";
            this.BtnAddFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddFiles.Size = new System.Drawing.Size(25, 23);
            this.BtnAddFiles.TabIndex = 4;
            this.BtnAddFiles.Text = "...";
            this.BtnAddFiles.UseVisualStyleBackColor = true;
            this.BtnAddFiles.Click += new System.EventHandler(this.BtnAddFiles_Click);
            // 
            // LstFiles
            // 
            this.LstFiles.FormattingEnabled = true;
            this.LstFiles.Location = new System.Drawing.Point(62, 283);
            this.LstFiles.Name = "LstFiles";
            this.LstFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstFiles.Size = new System.Drawing.Size(418, 82);
            this.LstFiles.TabIndex = 23;
            this.LstFiles.TabStop = false;
            // 
            // LblWarning
            // 
            this.LblWarning.ForeColor = System.Drawing.Color.Red;
            this.LblWarning.Location = new System.Drawing.Point(31, 372);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblWarning.Size = new System.Drawing.Size(449, 29);
            this.LblWarning.TabIndex = 24;
            this.LblWarning.Text = "נראה שאינך מחובר לאינטרנט.\r\nאם המכשיר שלך אינו מאפשר שליחת \'פינג\', אל תתיחס להודע" +
    "ה זו.";
            // 
            // LblConnected
            // 
            this.LblConnected.ForeColor = System.Drawing.Color.Lime;
            this.LblConnected.Location = new System.Drawing.Point(31, 372);
            this.LblConnected.Name = "LblConnected";
            this.LblConnected.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblConnected.Size = new System.Drawing.Size(449, 29);
            this.LblConnected.TabIndex = 25;
            this.LblConnected.Text = "נראה שאתה מחובר לאינטרנט.";
            this.LblConnected.Visible = false;
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnClearAll.Location = new System.Drawing.Point(31, 312);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnClearAll.Size = new System.Drawing.Size(25, 23);
            this.BtnClearAll.TabIndex = 26;
            this.BtnClearAll.Text = "X";
            this.BtnClearAll.UseVisualStyleBackColor = true;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // FrmSendMail
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 465);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.LblConnected);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.LstFiles);
            this.Controls.Add(this.BtnAddFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSendTo);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.TxtBodyMessage);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "שליחת מייל";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAddFiles;
        public System.Windows.Forms.TextBox TxtBodyMessage;
        public System.Windows.Forms.TextBox TxtSubject;
        public System.Windows.Forms.TextBox TxtSendTo;
        private System.Windows.Forms.ListBox LstFiles;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.Label LblConnected;
        private System.Windows.Forms.Button BtnClearAll;

    }
}