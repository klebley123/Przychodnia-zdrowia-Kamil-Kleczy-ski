namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    partial class UserControlPerson
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFullValue = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.groupBoxPersonData = new System.Windows.Forms.GroupBox();
            this.checkBoxInsuirance = new System.Windows.Forms.CheckBox();
            this.labelIdNum = new System.Windows.Forms.Label();
            this.labelTelNum = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxIdNum = new System.Windows.Forms.TextBox();
            this.textBoxTelNum = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.labelPesel = new System.Windows.Forms.Label();
            this.listPerson = new System.Windows.Forms.ListBox();
            this.buttonLoadPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.groupBoxPersonData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFullValue
            // 
            this.buttonFullValue.Location = new System.Drawing.Point(424, 271);
            this.buttonFullValue.Name = "buttonFullValue";
            this.buttonFullValue.Size = new System.Drawing.Size(183, 23);
            this.buttonFullValue.TabIndex = 52;
            this.buttonFullValue.Text = "Uzupełnij";
            this.buttonFullValue.UseVisualStyleBackColor = true;
            this.buttonFullValue.Click += new System.EventHandler(this.ButtonFullValue_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(20, 3);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(100, 102);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 51;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(357, 241);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 50;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(438, 241);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 47;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(519, 241);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 49;
            this.buttonUpdate.Text = "Aktualizuj";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(600, 241);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 48;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(242, 343);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 46;
            this.buttonNext.Text = "Następny";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(38, 343);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 45;
            this.buttonPrevious.Text = "Poprzedni";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // groupBoxPersonData
            // 
            this.groupBoxPersonData.Controls.Add(this.checkBoxInsuirance);
            this.groupBoxPersonData.Controls.Add(this.labelIdNum);
            this.groupBoxPersonData.Controls.Add(this.labelTelNum);
            this.groupBoxPersonData.Controls.Add(this.labelEMail);
            this.groupBoxPersonData.Controls.Add(this.labelAddress);
            this.groupBoxPersonData.Controls.Add(this.labelLastName);
            this.groupBoxPersonData.Controls.Add(this.labelFirstName);
            this.groupBoxPersonData.Controls.Add(this.textBoxIdNum);
            this.groupBoxPersonData.Controls.Add(this.textBoxTelNum);
            this.groupBoxPersonData.Controls.Add(this.textBoxEMail);
            this.groupBoxPersonData.Controls.Add(this.textBoxAddress);
            this.groupBoxPersonData.Controls.Add(this.textBoxLastName);
            this.groupBoxPersonData.Controls.Add(this.textBoxFirstName);
            this.groupBoxPersonData.Controls.Add(this.textBoxPesel);
            this.groupBoxPersonData.Controls.Add(this.labelPesel);
            this.groupBoxPersonData.Location = new System.Drawing.Point(357, 3);
            this.groupBoxPersonData.Name = "groupBoxPersonData";
            this.groupBoxPersonData.Size = new System.Drawing.Size(313, 232);
            this.groupBoxPersonData.TabIndex = 44;
            this.groupBoxPersonData.TabStop = false;
            this.groupBoxPersonData.Text = "Dane osobowe";
            // 
            // checkBoxInsuirance
            // 
            this.checkBoxInsuirance.AutoSize = true;
            this.checkBoxInsuirance.Location = new System.Drawing.Point(96, 203);
            this.checkBoxInsuirance.Name = "checkBoxInsuirance";
            this.checkBoxInsuirance.Size = new System.Drawing.Size(93, 17);
            this.checkBoxInsuirance.TabIndex = 19;
            this.checkBoxInsuirance.Text = "Ubezpieczony";
            this.checkBoxInsuirance.UseVisualStyleBackColor = true;
            // 
            // labelIdNum
            // 
            this.labelIdNum.AutoSize = true;
            this.labelIdNum.Location = new System.Drawing.Point(11, 177);
            this.labelIdNum.Name = "labelIdNum";
            this.labelIdNum.Size = new System.Drawing.Size(79, 13);
            this.labelIdNum.TabIndex = 14;
            this.labelIdNum.Text = "Numer dowodu";
            // 
            // labelTelNum
            // 
            this.labelTelNum.AutoSize = true;
            this.labelTelNum.Location = new System.Drawing.Point(11, 151);
            this.labelTelNum.Name = "labelTelNum";
            this.labelTelNum.Size = new System.Drawing.Size(79, 13);
            this.labelTelNum.TabIndex = 13;
            this.labelTelNum.Text = "Numer telefonu";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(58, 126);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(32, 13);
            this.labelEMail.TabIndex = 12;
            this.labelEMail.Text = "Email";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(56, 97);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(34, 13);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Adres";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(37, 71);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(53, 13);
            this.labelLastName.TabIndex = 10;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(64, 45);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(26, 13);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "Imię";
            // 
            // textBoxIdNum
            // 
            this.textBoxIdNum.Location = new System.Drawing.Point(96, 177);
            this.textBoxIdNum.Name = "textBoxIdNum";
            this.textBoxIdNum.Size = new System.Drawing.Size(211, 20);
            this.textBoxIdNum.TabIndex = 7;
            // 
            // textBoxTelNum
            // 
            this.textBoxTelNum.Location = new System.Drawing.Point(96, 151);
            this.textBoxTelNum.Name = "textBoxTelNum";
            this.textBoxTelNum.Size = new System.Drawing.Size(211, 20);
            this.textBoxTelNum.TabIndex = 6;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(96, 123);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(211, 20);
            this.textBoxEMail.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(96, 97);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(211, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(96, 71);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(211, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(96, 45);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(211, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(96, 19);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(211, 20);
            this.textBoxPesel.TabIndex = 1;
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(49, 22);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(41, 13);
            this.labelPesel.TabIndex = 0;
            this.labelPesel.Text = "PESEL";
            // 
            // listPerson
            // 
            this.listPerson.FormattingEnabled = true;
            this.listPerson.Location = new System.Drawing.Point(20, 112);
            this.listPerson.Name = "listPerson";
            this.listPerson.Size = new System.Drawing.Size(317, 225);
            this.listPerson.TabIndex = 43;
            // 
            // buttonLoadPhoto
            // 
            this.buttonLoadPhoto.Location = new System.Drawing.Point(126, 83);
            this.buttonLoadPhoto.Name = "buttonLoadPhoto";
            this.buttonLoadPhoto.Size = new System.Drawing.Size(101, 23);
            this.buttonLoadPhoto.TabIndex = 53;
            this.buttonLoadPhoto.Text = "Przypisz zdjęcie";
            this.buttonLoadPhoto.UseVisualStyleBackColor = true;
            this.buttonLoadPhoto.Click += new System.EventHandler(this.buttonLoadPhoto_Click);
            // 
            // UserControlPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLoadPhoto);
            this.Controls.Add(this.buttonFullValue);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.groupBoxPersonData);
            this.Controls.Add(this.listPerson);
            this.Name = "UserControlPerson";
            this.Size = new System.Drawing.Size(690, 374);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.groupBoxPersonData.ResumeLayout(false);
            this.groupBoxPersonData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFullValue;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.GroupBox groupBoxPersonData;
        private System.Windows.Forms.CheckBox checkBoxInsuirance;
        private System.Windows.Forms.Label labelIdNum;
        private System.Windows.Forms.Label labelTelNum;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxIdNum;
        private System.Windows.Forms.TextBox textBoxTelNum;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.ListBox listPerson;
        private System.Windows.Forms.Button buttonLoadPhoto;
    }
}
