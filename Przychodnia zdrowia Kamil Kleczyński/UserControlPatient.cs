using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlPatient : UserControl
    {
        private readonly PatientStore _patientStore = new PatientStore(new List<Patient>());
        private int _index = 0;

        public UserControlPatient()
        {
            InitializeComponent();
        }

        private void UserControlPatient_Load(object sender, EventArgs e)
        {
            var patient = _patientStore.GetAll().FirstOrDefault();
            AddListBox(patient);
            SetPrevNextButtons();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var weight = _patientStore.IsValidWeight(txtWeight.Text);
            if (weight == 0)
            {
                MessageBox.Show(@"Niepoprawna waga.", @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var height = _patientStore.IsValidHeight(txtHeight.Text);
            if (height == 0)
            {
                MessageBox.Show(@"Niepoprawny wzrost.", @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var diseaseId = new List<int> { 2, 3 };
            var patient = new Patient(txtPesel.Text, txtIdNumber.Text, txtFirstName.Text, txtLastName.Text,
                txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, chkInsurance.Checked, txtMedicalRecordNumber.Text,
                txtPrimaryDoctor.Text, weight, height, cmbBloodGroup.Text, diseaseId);

            var message = _patientStore.Add(patient);
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddListBox(patient);
            SetPrevNextButtons();
        }

        private void AddListBox(Patient patient)
        {
            if (patient == null) return;

            lstPatient.Items.Clear();
            foreach (var item in patient.GetInfo())
            {
                lstPatient.Items.Add(item);
            }
        }

        private void SetPrevNextButtons()
        {
            var lastIndex = _patientStore.GetCount() - 1;
            if (lastIndex <= 0)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }

            _index = lastIndex;
        }
    }
}