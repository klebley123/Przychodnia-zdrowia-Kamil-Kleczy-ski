using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class Form1 : Form
    {
        UserControlHome uc;
        UserControlPatient up;
        UserControlWorker uw;
        UserControlXMLAndViewing uxml;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc = new UserControlHome();
            up = new UserControlPatient();
            uw = new UserControlWorker();
            uxml = new UserControlXMLAndViewing();

            uc.Dock = DockStyle.Fill;
            up.Dock = DockStyle.Fill;
            uw.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(uc);
            panelContainer.Controls.Add(up);
            panelContainer.Controls.Add(uw);

            menuHome.Enabled = false;
            menuPatient.Enabled = true;
            menuWorker.Enabled = true;
            menuPodglad.Enabled = true;
        }

        private void homeMenu_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = false;
            menuPatient.Enabled = true;
            menuWorker.Enabled = true;
            menuPodglad.Enabled = true;
            panelContainer.Controls.Add(new UserControlHome());
        }

        private void patientMenu_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = true;
            menuPatient.Enabled = false;
            menuWorker.Enabled = true;
            menuPodglad.Enabled = true;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UserControlPatient());
            //up.BringToFront();
        }

        private void worekrMenu_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = true;
            menuPatient.Enabled = true;
            menuWorker.Enabled = false;
            menuPodglad.Enabled = true;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UserControlWorker());
        }

        private void MenuPodglad_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = true;
            menuPatient.Enabled = true;
            menuWorker.Enabled = true;
            menuPodglad.Enabled = false;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UserControlXMLAndViewing());
        }
    }
}