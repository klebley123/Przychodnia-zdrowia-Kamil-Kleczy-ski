
namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    partial class UserControlWorker
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
            this.groupBoxWorkerData = new System.Windows.Forms.GroupBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelWorkerId = new System.Windows.Forms.Label();
            this.textBoxWorkerId = new System.Windows.Forms.TextBox();
            this.labelDateOfHire = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfHire = new System.Windows.Forms.DateTimePicker();
            this.labelPosition = new System.Windows.Forms.Label();
            this.groupBoxWorkerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWorkerData
            // 
            this.groupBoxWorkerData.Controls.Add(this.cmbPosition);
            this.groupBoxWorkerData.Controls.Add(this.labelSalary);
            this.groupBoxWorkerData.Controls.Add(this.textBoxSalary);
            this.groupBoxWorkerData.Controls.Add(this.labelWorkerId);
            this.groupBoxWorkerData.Controls.Add(this.textBoxWorkerId);
            this.groupBoxWorkerData.Controls.Add(this.labelDateOfHire);
            this.groupBoxWorkerData.Controls.Add(this.dateTimePickerDateOfHire);
            this.groupBoxWorkerData.Controls.Add(this.labelPosition);
            this.groupBoxWorkerData.Location = new System.Drawing.Point(676, 18);
            this.groupBoxWorkerData.Name = "groupBoxWorkerData";
            this.groupBoxWorkerData.Size = new System.Drawing.Size(306, 124);
            this.groupBoxWorkerData.TabIndex = 3;
            this.groupBoxWorkerData.TabStop = false;
            this.groupBoxWorkerData.Text = "Zatrudnienie";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Lekarz",
            "Recepcjonistka",
            "Sprzątaczka"});
            this.cmbPosition.Location = new System.Drawing.Point(102, 18);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(198, 21);
            this.cmbPosition.TabIndex = 8;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(15, 96);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(81, 13);
            this.labelSalary.TabIndex = 7;
            this.labelSalary.Text = "Wynagrodzenie";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(102, 96);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(198, 20);
            this.textBoxSalary.TabIndex = 6;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalary_KeyPress);
            // 
            // labelWorkerId
            // 
            this.labelWorkerId.AutoSize = true;
            this.labelWorkerId.Location = new System.Drawing.Point(19, 70);
            this.labelWorkerId.Name = "labelWorkerId";
            this.labelWorkerId.Size = new System.Drawing.Size(77, 13);
            this.labelWorkerId.TabIndex = 5;
            this.labelWorkerId.Text = "Nr. pozwolenia";
            // 
            // textBoxWorkerId
            // 
            this.textBoxWorkerId.Location = new System.Drawing.Point(102, 70);
            this.textBoxWorkerId.Name = "textBoxWorkerId";
            this.textBoxWorkerId.Size = new System.Drawing.Size(198, 20);
            this.textBoxWorkerId.TabIndex = 4;
            // 
            // labelDateOfHire
            // 
            this.labelDateOfHire.AutoSize = true;
            this.labelDateOfHire.Location = new System.Drawing.Point(6, 45);
            this.labelDateOfHire.Name = "labelDateOfHire";
            this.labelDateOfHire.Size = new System.Drawing.Size(90, 13);
            this.labelDateOfHire.TabIndex = 3;
            this.labelDateOfHire.Text = "Data zatrudnienia";
            // 
            // dateTimePickerDateOfHire
            // 
            this.dateTimePickerDateOfHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfHire.Location = new System.Drawing.Point(102, 45);
            this.dateTimePickerDateOfHire.Name = "dateTimePickerDateOfHire";
            this.dateTimePickerDateOfHire.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateOfHire.TabIndex = 2;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(23, 22);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(62, 13);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "Stanowisko";
            // 
            // UserControlWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxWorkerData);
            this.Name = "UserControlWorker";
            this.Size = new System.Drawing.Size(995, 390);
            this.Load += new System.EventHandler(this.UserControlWorker_Load);
            this.Controls.SetChildIndex(this.groupBoxWorkerData, 0);
            this.groupBoxWorkerData.ResumeLayout(false);
            this.groupBoxWorkerData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxWorkerData;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfHire;
        private System.Windows.Forms.Label labelDateOfHire;
        private System.Windows.Forms.Label labelWorkerId;
        private System.Windows.Forms.TextBox textBoxWorkerId;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ComboBox cmbPosition;
    }
}
