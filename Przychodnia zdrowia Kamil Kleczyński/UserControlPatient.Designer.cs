
namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    partial class UserControlPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelIdNumber = new System.Windows.Forms.Label();
            this.labelTelNum = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPesel = new System.Windows.Forms.Label();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDisease = new System.Windows.Forms.Label();
            this.chkDisease = new System.Windows.Forms.CheckedListBox();
            this.labelBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtPrimaryDoctor = new System.Windows.Forms.TextBox();
            this.labelPrimaryDoctor = new System.Windows.Forms.Label();
            this.txtMedicalRecordNumber = new System.Windows.Forms.TextBox();
            this.labelMedicalRecordNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFillValue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.Location = new System.Drawing.Point(20, 114);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(317, 225);
            this.lstPatient.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(64, 356);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Poprzedni";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(190, 356);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Następny";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelIdNumber);
            this.groupBox1.Controls.Add(this.labelTelNum);
            this.groupBox1.Controls.Add(this.labelEMail);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelPesel);
            this.groupBox1.Controls.Add(this.chkInsurance);
            this.groupBox1.Controls.Add(this.txtIdNumber);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtPesel);
            this.groupBox1.Location = new System.Drawing.Point(354, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 232);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane osobowe";
            // 
            // labelIdNumber
            // 
            this.labelIdNumber.AutoSize = true;
            this.labelIdNumber.Location = new System.Drawing.Point(6, 185);
            this.labelIdNumber.Name = "labelIdNumber";
            this.labelIdNumber.Size = new System.Drawing.Size(79, 13);
            this.labelIdNumber.TabIndex = 25;
            this.labelIdNumber.Text = "Numer dowodu";
            // 
            // labelTelNum
            // 
            this.labelTelNum.AutoSize = true;
            this.labelTelNum.Location = new System.Drawing.Point(6, 156);
            this.labelTelNum.Name = "labelTelNum";
            this.labelTelNum.Size = new System.Drawing.Size(79, 13);
            this.labelTelNum.TabIndex = 24;
            this.labelTelNum.Text = "Numer telefonu";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(53, 130);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(32, 13);
            this.labelEMail.TabIndex = 23;
            this.labelEMail.Text = "Email";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(51, 104);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(34, 13);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "Adres";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(32, 78);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(53, 13);
            this.labelLastName.TabIndex = 21;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Imię";
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(44, 26);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(41, 13);
            this.labelPesel.TabIndex = 19;
            this.labelPesel.Text = "PESEL";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(91, 208);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(93, 17);
            this.chkInsurance.TabIndex = 18;
            this.chkInsurance.Text = "Ubezpieczony";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(91, 178);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(211, 20);
            this.txtIdNumber.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(91, 149);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(211, 20);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 97);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(91, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(211, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(91, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(211, 20);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(91, 19);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(211, 20);
            this.txtPesel.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDisease);
            this.groupBox2.Controls.Add(this.chkDisease);
            this.groupBox2.Controls.Add(this.labelBloodGroup);
            this.groupBox2.Controls.Add(this.cmbBloodGroup);
            this.groupBox2.Controls.Add(this.labelHeight);
            this.groupBox2.Controls.Add(this.labelWeight);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.txtWeight);
            this.groupBox2.Controls.Add(this.txtPrimaryDoctor);
            this.groupBox2.Controls.Add(this.labelPrimaryDoctor);
            this.groupBox2.Controls.Add(this.txtMedicalRecordNumber);
            this.groupBox2.Controls.Add(this.labelMedicalRecordNumber);
            this.groupBox2.Location = new System.Drawing.Point(690, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 272);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane medyczne";
            // 
            // labelDisease
            // 
            this.labelDisease.AutoSize = true;
            this.labelDisease.Location = new System.Drawing.Point(42, 156);
            this.labelDisease.Name = "labelDisease";
            this.labelDisease.Size = new System.Drawing.Size(46, 13);
            this.labelDisease.TabIndex = 36;
            this.labelDisease.Text = "Choroby";
            // 
            // chkDisease
            // 
            this.chkDisease.FormattingEnabled = true;
            this.chkDisease.Location = new System.Drawing.Point(94, 157);
            this.chkDisease.Name = "chkDisease";
            this.chkDisease.Size = new System.Drawing.Size(211, 109);
            this.chkDisease.TabIndex = 35;
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.Location = new System.Drawing.Point(30, 138);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(58, 13);
            this.labelBloodGroup.TabIndex = 34;
            this.labelBloodGroup.Text = "Grupa krwi";
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "0 RH+",
            "0 RH-",
            "A RH+",
            "A RH-",
            "B RH+",
            "B RH-",
            "AB RH+",
            "AB RH-"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(94, 130);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(211, 21);
            this.cmbBloodGroup.TabIndex = 33;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(52, 108);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(40, 13);
            this.labelHeight.TabIndex = 32;
            this.labelHeight.Text = "Wzrost";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(52, 82);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(36, 13);
            this.labelWeight.TabIndex = 31;
            this.labelWeight.Text = "Waga";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(94, 101);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(211, 20);
            this.txtHeight.TabIndex = 30;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(94, 75);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(211, 20);
            this.txtWeight.TabIndex = 29;
            // 
            // txtPrimaryDoctor
            // 
            this.txtPrimaryDoctor.Location = new System.Drawing.Point(94, 49);
            this.txtPrimaryDoctor.Name = "txtPrimaryDoctor";
            this.txtPrimaryDoctor.Size = new System.Drawing.Size(211, 20);
            this.txtPrimaryDoctor.TabIndex = 28;
            // 
            // labelPrimaryDoctor
            // 
            this.labelPrimaryDoctor.AutoSize = true;
            this.labelPrimaryDoctor.Location = new System.Drawing.Point(49, 56);
            this.labelPrimaryDoctor.Name = "labelPrimaryDoctor";
            this.labelPrimaryDoctor.Size = new System.Drawing.Size(39, 13);
            this.labelPrimaryDoctor.TabIndex = 27;
            this.labelPrimaryDoctor.Text = "Lekarz";
            // 
            // txtMedicalRecordNumber
            // 
            this.txtMedicalRecordNumber.Location = new System.Drawing.Point(94, 23);
            this.txtMedicalRecordNumber.Name = "txtMedicalRecordNumber";
            this.txtMedicalRecordNumber.Size = new System.Drawing.Size(211, 20);
            this.txtMedicalRecordNumber.TabIndex = 26;
            // 
            // labelMedicalRecordNumber
            // 
            this.labelMedicalRecordNumber.AutoSize = true;
            this.labelMedicalRecordNumber.Location = new System.Drawing.Point(6, 26);
            this.labelMedicalRecordNumber.Name = "labelMedicalRecordNumber";
            this.labelMedicalRecordNumber.Size = new System.Drawing.Size(82, 13);
            this.labelMedicalRecordNumber.TabIndex = 25;
            this.labelMedicalRecordNumber.Text = "Numer kartoteki";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(463, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(544, 262);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 37;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(463, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Aktualizuj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(382, 262);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 39;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnFillValue
            // 
            this.btnFillValue.Location = new System.Drawing.Point(416, 292);
            this.btnFillValue.Name = "btnFillValue";
            this.btnFillValue.Size = new System.Drawing.Size(169, 23);
            this.btnFillValue.TabIndex = 41;
            this.btnFillValue.Text = "Uzupełnij";
            this.btnFillValue.UseVisualStyleBackColor = true;
            this.btnFillValue.Click += new System.EventHandler(this.btnFillValue_Click);
            // 
            // UserControlPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFillValue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lstPatient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UserControlPatient";
            this.Size = new System.Drawing.Size(1013, 390);
            this.Load += new System.EventHandler(this.UserControlPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelIdNumber;
        private System.Windows.Forms.Label labelTelNum;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMedicalRecordNumber;
        private System.Windows.Forms.Label labelMedicalRecordNumber;
        private System.Windows.Forms.TextBox txtPrimaryDoctor;
        private System.Windows.Forms.Label labelPrimaryDoctor;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label labelBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelDisease;
        private System.Windows.Forms.CheckedListBox chkDisease;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnUpdate;
        protected System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFillValue;
    }
}
