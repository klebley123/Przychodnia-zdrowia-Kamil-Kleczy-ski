﻿namespace Przychodnia_zdrowia_Kamil_Kleczynski
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPodglad = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnImportXML = new System.Windows.Forms.Button();
            this.btnExportXml = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.menuPatient,
            this.menuWorker,
            this.menuPodglad});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuHome.Image = ((System.Drawing.Image)(resources.GetObject("menuHome.Image")));
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(28, 20);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.homeMenu_Click);
            // 
            // menuPatient
            // 
            this.menuPatient.Name = "menuPatient";
            this.menuPatient.Size = new System.Drawing.Size(63, 20);
            this.menuPatient.Text = "Pacjenci";
            this.menuPatient.Click += new System.EventHandler(this.patientMenu_Click);
            // 
            // menuWorker
            // 
            this.menuWorker.Name = "menuWorker";
            this.menuWorker.Size = new System.Drawing.Size(80, 20);
            this.menuWorker.Text = "Pracownicy";
            this.menuWorker.Click += new System.EventHandler(this.worekrMenu_Click);
            // 
            // menuPodglad
            // 
            this.menuPodglad.Name = "menuPodglad";
            this.menuPodglad.Size = new System.Drawing.Size(63, 20);
            this.menuPodglad.Text = "Podglad";
            this.menuPodglad.Click += new System.EventHandler(this.MenuPodglad_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 27);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1010, 390);
            this.panelContainer.TabIndex = 0;
            // 
            // btnImportXML
            // 
            this.btnImportXML.Location = new System.Drawing.Point(834, 285);
            this.btnImportXML.Name = "btnImportXML";
            this.btnImportXML.Size = new System.Drawing.Size(79, 23);
            this.btnImportXML.TabIndex = 16;
            this.btnImportXML.Text = "Import XML";
            this.btnImportXML.UseVisualStyleBackColor = true;
            // 
            // btnExportXml
            // 
            this.btnExportXml.Location = new System.Drawing.Point(919, 285);
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(79, 23);
            this.btnExportXml.TabIndex = 15;
            this.btnExportXml.Text = "Eksport XML";
            this.btnExportXml.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 424);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przychodnia Kamil Kleczyński";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPatient;
        private System.Windows.Forms.ToolStripMenuItem menuWorker;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.Button btnImportXML;
        private System.Windows.Forms.Button btnExportXml;
        private System.Windows.Forms.ToolStripMenuItem menuPodglad;
    }
}

