using System;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var uc = new UserControlHome();
            var up = new UserControlPatient();
            var uw = new UserControlWorker();

            uc.Dock = DockStyle.Fill;
            up.Dock = DockStyle.Fill;
            uw.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(uc);
            panelContainer.Controls.Add(up);
            panelContainer.Controls.Add(uw);

            menuHome.Enabled = false;
            menuPatient.Enabled = true;
            menuWorker.Enabled = true;
        }

        private void homeMenu_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = false;
            menuPatient.Enabled = true;
            menuWorker.Enabled = true;
            panelContainer.Controls["UserControlHome"].BringToFront();
        }

        private void patientMenu_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = true;
            menuPatient.Enabled = false;
            menuWorker.Enabled = true;
            panelContainer.Controls["UserControlPatient"].BringToFront();
        }

        private void worekrMenu_Click(object sender, EventArgs e)
        {
            menuHome.Enabled = true;
            menuPatient.Enabled = true;
            menuWorker.Enabled = false;
            panelContainer.Controls["UserControlWorker"].BringToFront();
        }
    }
}