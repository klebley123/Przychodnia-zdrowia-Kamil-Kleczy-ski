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
        private readonly PatientStore _patientStore = new PatientStore(new List<Patient>());
        private readonly DiseaseStore _diseaseStoreStore = new DiseaseStore(false);
        private int _currentPatientsIndex;

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

        private void btnImportXML_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = @"Import pacjentów";
            openFileDialog.Filter = @"XML Files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var xs = new XmlSerializer(typeof(Patient));
                using (var stream = new StreamReader(openFileDialog.FileName))
                {
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(stream);
                    var xmlPatientList = xmlDoc.GetElementsByTagName("Patient");
                    if (xmlPatientList.Count == 0) return;

                    var patients = new List<Patient>();
                    foreach (XmlNode xmlItem in xmlPatientList)
                    {
                        using (XmlReader reader = new XmlNodeReader(xmlItem))
                        {
                            patients.Add((Patient)xs.Deserialize(reader));
                        }
                    }

                    _patientStore.UpdateList(patients);
                    //LoadFirstPatient();
                }
            }
        }
    }
}