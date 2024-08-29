using System;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class Form1 : Form
    {
        private UserControlHome _uc;
        private UserControlPatient _up;
        private UserControlWorker _uw;
        private UserControlXMLAndViewing _uxml;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _uc = new UserControlHome();
            _up = new UserControlPatient();
            _uw = new UserControlWorker();
            _uxml = new UserControlXMLAndViewing();

            _uc.Dock = DockStyle.Fill;
            _up.Dock = DockStyle.Fill;
            _uw.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(_uc);
            panelContainer.Controls.Add(_up);
            panelContainer.Controls.Add(_uw);

            menuHome.Enabled = false;
            menuPatient.Enabled = true;
            menuWorker.Enabled = true;
            menuPodglad.Enabled = true;
        }

        private void HomeMenu_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = false;
            menuPatient.Enabled = true;
            menuWorker.Enabled = true;
            menuPodglad.Enabled = true;
            panelContainer.Controls.Add(new UserControlHome());
        }

        private void PatientMenu_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = true;
            menuPatient.Enabled = false;
            menuWorker.Enabled = true;
            menuPodglad.Enabled = true;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UserControlPatient());
            //up.BringToFront();
        }

        private void WorekrMenu_Click(object sender, EventArgs e)
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