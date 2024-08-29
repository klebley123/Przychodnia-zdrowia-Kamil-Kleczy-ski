
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
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(724, 13);
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
            // UserControlPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "UserControlPatient";
            this.Size = new System.Drawing.Size(1080, 390);
            this.Load += new System.EventHandler(this.UserControlPatient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Label labelDisease;
        private System.Windows.Forms.CheckedListBox chkDisease;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
