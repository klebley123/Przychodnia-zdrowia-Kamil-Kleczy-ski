namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    partial class UserControlXMLAndViewing
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
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.listPersons = new System.Windows.Forms.ListBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAssign = new System.Windows.Forms.Button();
            this.peoplePanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(31, 252);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 0;
            this.BtnPrevious.Text = "Poprzedni";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(241, 252);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Następny";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // listPersons
            // 
            this.listPersons.FormattingEnabled = true;
            this.listPersons.Location = new System.Drawing.Point(16, 14);
            this.listPersons.Name = "listPersons";
            this.listPersons.Size = new System.Drawing.Size(317, 225);
            this.listPersons.TabIndex = 2;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(656, 252);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 3;
            this.BtnLoad.Text = "Wczytaj";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(737, 252);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Zapisz";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnPhoto
            // 
            this.BtnPhoto.Location = new System.Drawing.Point(517, 252);
            this.BtnPhoto.Name = "BtnPhoto";
            this.BtnPhoto.Size = new System.Drawing.Size(75, 23);
            this.BtnPhoto.TabIndex = 43;
            this.BtnPhoto.Text = "Zdjęcie";
            this.BtnPhoto.UseVisualStyleBackColor = true;
            this.BtnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(342, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAssign
            // 
            this.BtnAssign.Location = new System.Drawing.Point(420, 252);
            this.BtnAssign.Name = "BtnAssign";
            this.BtnAssign.Size = new System.Drawing.Size(75, 23);
            this.BtnAssign.TabIndex = 44;
            this.BtnAssign.Text = "Przypisz";
            this.BtnAssign.UseVisualStyleBackColor = true;
            this.BtnAssign.Click += new System.EventHandler(this.BtnAssign_Click);
            // 
            // peoplePanel
            // 
            this.peoplePanel.Location = new System.Drawing.Point(608, 14);
            this.peoplePanel.Name = "peoplePanel";
            this.peoplePanel.Size = new System.Drawing.Size(399, 232);
            this.peoplePanel.TabIndex = 45;
            // 
            // UserControlXMLAndViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peoplePanel);
            this.Controls.Add(this.BtnAssign);
            this.Controls.Add(this.BtnPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.listPersons);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Name = "UserControlXMLAndViewing";
            this.Size = new System.Drawing.Size(1010, 320);
            this.Load += new System.EventHandler(this.UserControlXMLAndViewing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.ListBox listPersons;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAssign;
        private System.Windows.Forms.FlowLayoutPanel peoplePanel;
    }
}
