
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
            this.SuspendLayout();
            // 
            // lstPatient
            // 
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.Location = new System.Drawing.Point(3, 3);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(317, 225);
            this.lstPatient.TabIndex = 0;
            // 
            // UserControlPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstPatient);
            this.Name = "UserControlPatient";
            this.Size = new System.Drawing.Size(701, 349);
            this.Load += new System.EventHandler(this.UserControlPatient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPatient;
    }
}
