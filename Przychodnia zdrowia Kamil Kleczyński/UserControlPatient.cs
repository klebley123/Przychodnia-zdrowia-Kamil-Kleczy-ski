using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlPatient : UserControl
    {
        private readonly PatientStore _patientStore = new PatientStore(new List<Patient>());

        public UserControlPatient()
        {
            InitializeComponent();
        }

        private void UserControlPatient_Load(object sender, EventArgs e)
        {
            var patient = _patientStore.GetAll().FirstOrDefault();
            var defaultPatient = patient != null ? patient.GetInfo() : _patientStore.GetInfoDefaultPatient();
            foreach (var item in defaultPatient)
            {
                lstPatient.Items.Add(item);
            }
        }
    }
}