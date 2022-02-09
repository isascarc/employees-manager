namespace ManagerEmployees
{
    partial class FrmAddEmployee
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
            this.BtnSelectImage = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.CbxStatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.DtpEnterToWork = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtDuty = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtFamily = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtIN = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtTelephone = new System.Windows.Forms.TextBox();
            this.lbl_name_full = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.NudChilds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudChilds)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSelectImage
            // 
            this.BtnSelectImage.Location = new System.Drawing.Point(546, 265);
            this.BtnSelectImage.Name = "BtnSelectImage";
            this.BtnSelectImage.Size = new System.Drawing.Size(146, 23);
            this.BtnSelectImage.TabIndex = 291;
            this.BtnSelectImage.Text = "בחר תמונה";
            this.BtnSelectImage.UseVisualStyleBackColor = true;
            this.BtnSelectImage.Click += new System.EventHandler(this.BtnSelectImage_Click);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Image = global::ManagerEmployees.Properties.Resources.Employee;
            this.pic1.Location = new System.Drawing.Point(546, 102);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(146, 158);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 290;
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(88, 167);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 289;
            this.label8.Text = "+";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(44, 466);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 274;
            this.BtnCancel.Text = "ביטול";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(134, 466);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 273;
            this.BtnCreate.Text = "צור";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // CbxStatus
            // 
            this.CbxStatus.BackColor = System.Drawing.Color.MintCream;
            this.CbxStatus.DisplayMember = "0";
            this.CbxStatus.FormattingEnabled = true;
            this.CbxStatus.Items.AddRange(new object[] {
            "רווק",
            "נשוי",
            "גרוש",
            "אלמן"});
            this.CbxStatus.Location = new System.Drawing.Point(99, 164);
            this.CbxStatus.Name = "CbxStatus";
            this.CbxStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbxStatus.Size = new System.Drawing.Size(51, 21);
            this.CbxStatus.TabIndex = 266;
            this.CbxStatus.Text = "רווק";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 455);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(114, 21);
            this.button1.TabIndex = 272;
            this.button1.Text = "צור חוזה אוטומטי";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 428);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(114, 21);
            this.button3.TabIndex = 271;
            this.button3.Text = "צרף חוזה...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label18.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(43, 303);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(652, 18);
            this.label18.TabIndex = 288;
            this.label18.Text = "פרטי העסקה";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(40, 76);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(652, 18);
            this.label17.TabIndex = 287;
            this.label17.Text = "פרטים אישיים";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpStart
            // 
            this.DtpStart.CalendarMonthBackground = System.Drawing.Color.MintCream;
            this.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpStart.Location = new System.Drawing.Point(285, 193);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpStart.RightToLeftLayout = true;
            this.DtpStart.Size = new System.Drawing.Size(120, 20);
            this.DtpStart.TabIndex = 262;
            // 
            // DtpEnterToWork
            // 
            this.DtpEnterToWork.CalendarMonthBackground = System.Drawing.Color.MintCream;
            this.DtpEnterToWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEnterToWork.Location = new System.Drawing.Point(442, 332);
            this.DtpEnterToWork.Name = "DtpEnterToWork";
            this.DtpEnterToWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpEnterToWork.RightToLeftLayout = true;
            this.DtpEnterToWork.Size = new System.Drawing.Size(120, 20);
            this.DtpEnterToWork.TabIndex = 269;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(578, 332);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(117, 20);
            this.label14.TabIndex = 286;
            this.label14.Text = "תאריך כניסה לעבודה";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(442, 198);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 285;
            this.label13.Text = "תאריך לידה";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtDuty
            // 
            this.TxtDuty.BackColor = System.Drawing.Color.MintCream;
            this.TxtDuty.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtDuty.Location = new System.Drawing.Point(442, 364);
            this.TxtDuty.Name = "TxtDuty";
            this.TxtDuty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDuty.Size = new System.Drawing.Size(120, 20);
            this.TxtDuty.TabIndex = 270;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.MintCream;
            this.TxtMail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtMail.Location = new System.Drawing.Point(43, 194);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtMail.Size = new System.Drawing.Size(109, 20);
            this.TxtMail.TabIndex = 268;
            // 
            // TxtFamily
            // 
            this.TxtFamily.BackColor = System.Drawing.Color.MintCream;
            this.TxtFamily.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtFamily.Location = new System.Drawing.Point(285, 132);
            this.TxtFamily.Name = "TxtFamily";
            this.TxtFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtFamily.Size = new System.Drawing.Size(120, 20);
            this.TxtFamily.TabIndex = 260;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.MintCream;
            this.TxtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtName.Location = new System.Drawing.Point(285, 102);
            this.TxtName.Name = "TxtName";
            this.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtName.Size = new System.Drawing.Size(120, 20);
            this.TxtName.TabIndex = 259;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(578, 362);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(117, 20);
            this.Label10.TabIndex = 284;
            this.Label10.Text = "תפקיד בחברה";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(155, 194);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(88, 20);
            this.Label9.TabIndex = 283;
            this.Label9.Text = "כתובת דוא\"ל";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(163, 167);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(80, 13);
            this.Label3.TabIndex = 282;
            this.Label3.Text = "מצב אישי";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(442, 134);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(80, 13);
            this.Label2.TabIndex = 281;
            this.Label2.Text = "שם משפחה";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(442, 104);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(80, 13);
            this.Label1.TabIndex = 280;
            this.Label1.Text = "שם פרטי";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(442, 226);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(80, 13);
            this.Label5.TabIndex = 275;
            this.Label5.Text = "עיר";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(163, 137);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(80, 13);
            this.Label7.TabIndex = 276;
            this.Label7.Text = "מספר טלפון";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(163, 104);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(80, 13);
            this.Label6.TabIndex = 277;
            this.Label6.Text = "כתובת";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(442, 165);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(80, 13);
            this.Label4.TabIndex = 278;
            this.Label4.Text = "מספר זהות";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtIN
            // 
            this.TxtIN.BackColor = System.Drawing.Color.MintCream;
            this.TxtIN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtIN.Location = new System.Drawing.Point(285, 162);
            this.TxtIN.Name = "TxtIN";
            this.TxtIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtIN.Size = new System.Drawing.Size(120, 20);
            this.TxtIN.TabIndex = 261;
            // 
            // TxtCity
            // 
            this.TxtCity.BackColor = System.Drawing.Color.MintCream;
            this.TxtCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCity.Location = new System.Drawing.Point(285, 223);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCity.Size = new System.Drawing.Size(120, 20);
            this.TxtCity.TabIndex = 263;
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.Color.MintCream;
            this.TxtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAddress.Location = new System.Drawing.Point(43, 104);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtAddress.Size = new System.Drawing.Size(109, 20);
            this.TxtAddress.TabIndex = 264;
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.BackColor = System.Drawing.Color.MintCream;
            this.TxtTelephone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtTelephone.Location = new System.Drawing.Point(43, 134);
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTelephone.Size = new System.Drawing.Size(109, 20);
            this.TxtTelephone.TabIndex = 265;
            // 
            // lbl_name_full
            // 
            this.lbl_name_full.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_name_full.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_name_full.Location = new System.Drawing.Point(40, 35);
            this.lbl_name_full.Name = "lbl_name_full";
            this.lbl_name_full.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_name_full.Size = new System.Drawing.Size(649, 26);
            this.lbl_name_full.TabIndex = 279;
            this.lbl_name_full.Text = "נא מלא את הפרטים הבאים";
            this.lbl_name_full.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(578, 393);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 293;
            this.label11.Text = "משכורת חודשית";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtSalary
            // 
            this.TxtSalary.BackColor = System.Drawing.Color.MintCream;
            this.TxtSalary.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtSalary.Location = new System.Drawing.Point(442, 392);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtSalary.Size = new System.Drawing.Size(120, 20);
            this.TxtSalary.TabIndex = 294;
            // 
            // NudChilds
            // 
            this.NudChilds.Location = new System.Drawing.Point(44, 164);
            this.NudChilds.Name = "NudChilds";
            this.NudChilds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NudChilds.Size = new System.Drawing.Size(41, 20);
            this.NudChilds.TabIndex = 295;
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 516);
            this.Controls.Add(this.NudChilds);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnSelectImage);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.CbxStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DtpStart);
            this.Controls.Add(this.DtpEnterToWork);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtDuty);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtFamily);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TxtIN);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtTelephone);
            this.Controls.Add(this.lbl_name_full);
            this.Name = "FrmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת עובד";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudChilds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectImage;
        internal System.Windows.Forms.PictureBox pic1;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ComboBox CbxStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.DateTimePicker DtpEnterToWork;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDuty;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtFamily;
        private System.Windows.Forms.TextBox TxtName;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox TxtIN;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtTelephone;
        internal System.Windows.Forms.Label lbl_name_full;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.NumericUpDown NudChilds;


    }
}