namespace Przychodnia_zdrowia_Kamil_Kleczyński
{
    partial class Form1
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
            this.lvPatient = new System.Windows.Forms.ListView();
            this.lvWorker = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvPatient
            // 
            this.lvPatient.HideSelection = false;
            this.lvPatient.Location = new System.Drawing.Point(12, 24);
            this.lvPatient.Name = "lvPatient";
            this.lvPatient.Size = new System.Drawing.Size(776, 252);
            this.lvPatient.TabIndex = 0;
            this.lvPatient.UseCompatibleStateImageBehavior = false;
            // 
            // lvWorker
            // 
            this.lvWorker.HideSelection = false;
            this.lvWorker.Location = new System.Drawing.Point(12, 282);
            this.lvWorker.Name = "lvWorker";
            this.lvWorker.Size = new System.Drawing.Size(776, 252);
            this.lvWorker.TabIndex = 1;
            this.lvWorker.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.lvWorker);
            this.Controls.Add(this.lvPatient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPatient;
        private System.Windows.Forms.ListView lvWorker;
    }
}

