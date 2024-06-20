using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlPatient : UserControl
    {
        private readonly PatientStore _patientStore = new PatientStore(new List<Patient>());
        private readonly DiseaseStore _diseaseStoreStore = new DiseaseStore(false);
        private int _index = 0;

        public UserControlPatient()
        {
            InitializeComponent();
        }

        private void UserControlPatient_Load(object sender, EventArgs e)
        {
            LoadDiseases();
            var patient = _patientStore.GetAll().FirstOrDefault();
            AddListBox(patient);
            SetPrevNextButtons();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _index--;
            var patient = _patientStore.GetByIndex(_index);
            AddListBox(patient);
            SetPrevNextButtons();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _index++;
            var patient = _patientStore.GetByIndex(_index);
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

            var diseaseId = GetDiseases();
            var patient = new Patient(txtPesel.Text, txtIdNumber.Text, txtFirstName.Text, txtLastName.Text,
                txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, chkInsurance.Checked, txtMedicalRecordNumber.Text,
                txtPrimaryDoctor.Text, weight, height, cmbBloodGroup.Text, diseaseId);

            var message = _patientStore.Add(patient);
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _index = _patientStore.GetCount() - 1;
            AddListBox(patient);
            ClearForm();
            SetPrevNextButtons();
        }

        private void LoadDiseases()
        {
            foreach (var item in _diseaseStoreStore.Diseases)
            {
                chkDisease.Items.Add(item.Name);
            }
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

            if (_index == lastIndex)
            {
                btnNext.Enabled = false;
            }

            if (_index == 0)
            {
                btnPrev.Enabled = false;
            }
        }

        private List<int> GetDiseases()
        {
            var result = new List<int>();
            foreach (var item in chkDisease.CheckedItems)
            {
                var id = _diseaseStoreStore.Diseases.Find(x => x.Name == (string)item).Id;
                result.Add(id);
            }

            return result;
        }

        private void ClearForm()
        {
            txtPesel.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtIdNumber.Clear();
            chkInsurance.Checked = false;

            txtMedicalRecordNumber.Clear();
            txtPrimaryDoctor.Clear();
            txtWeight.Clear();
            txtHeight.Clear();
            cmbBloodGroup.SelectedIndex = -1;
            cmbBloodGroup.SelectedText = string.Empty;
            chkDisease.ClearSelected();
        }
    }
}