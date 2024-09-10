using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlPatient : UserControlPerson
    {
        private int _currentPatientsIndex;
        private readonly DiseaseStore _diseaseStore = new DiseaseStore(false);


        public UserControlPatient()
        {
            InitializeComponent();
            _fullValueButtonClicked += UCPerson_FullValueButtonClicked;
            _saveButtonClicked += BtnSave_Click;
            _cancelButtonClicked += ClearForm;
            _loadButtonClicked += BtnLoad_Click;
            _updateButtonClicked += BtnUpdate_Click;
            //_photoButtonClicked += ButtonLoadPhoto_Click;
        }

        private void UserControlPatient_Load(object sender, EventArgs e)
        {
            LoadDiseases();
        }

        private void UCPerson_FullValueButtonClicked(object sender, EventArgs e)
        {
            txtMedicalRecordNumber.Text = "12";
            txtPrimaryDoctor.Text = "Władysław";
            txtWeight.Text = "150";
            txtHeight.Text = "175";
            cmbBloodGroup.Text = "0 RH+";
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            ClearForm(sender, e);

            var patient = PatientStore.GetByIndex(_currentPatientsIndex);

            txtMedicalRecordNumber.Text = patient.MedicalRecordNumber;
            txtPrimaryDoctor.Text = patient.PrimaryDoctor;
            txtWeight.Text = patient.Weight.ToString();
            txtHeight.Text = patient.Height.ToString();
            cmbBloodGroup.Text = patient.BloodGroup;
            LoadDiseases(patient.DiseaseId);
        }

        private void LoadDiseases(List<int> diseaseIds)
        {
            for (var i = 0; i < chkDisease.Items.Count; i++)
            {
                chkDisease.SetItemChecked(i, false);
            }

            foreach (var id in diseaseIds)
            {
                if (id >= 0 && id < chkDisease.Items.Count)
                {
                    chkDisease.SetItemChecked(id, true);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var weight = ValidateWeight(txtWeight.Text);
                var height = ValidateHeight(txtHeight.Text);

                var pesel = Pesel;
                var idNumber = IdNum;
                var firstName = FirstName;
                var lastName = LastName;
                var address = Address;
                var email = Email;
                var phoneNumber = TelNum;
                var insurance = Insured;
                var photo = Photo;

                var patient = new Patient(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance, photo,
                                          txtMedicalRecordNumber.Text, txtPrimaryDoctor.Text, weight, height, cmbBloodGroup.Text, GetDiseases());

                //var message = PatientStore.Add(patient);
                //if (!string.IsNullOrEmpty(message))
                //{
                //    MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                PatientStore.Add(patient);
                _currentPatientsIndex = PatientStore.GetCount() + 1;
                ClearForm(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var weight = ValidateWeight(txtWeight.Text);
                var height = ValidateHeight(txtHeight.Text);

                var pesel = Pesel;
                var idNumber = IdNum;
                var firstName = FirstName;
                var lastName = LastName;
                var address = Address;
                var email = Email;
                var phoneNumber = TelNum;
                var insurance = Insured;
                var photo = Photo;
                
                var patientToUpdate = PatientStore.GetByPesel(pesel);
                patientToUpdate.Update(idNumber, firstName, lastName, address, email, phoneNumber, insurance, photo,  txtMedicalRecordNumber.Text,
                    txtPrimaryDoctor.Text, weight, height, cmbBloodGroup.Text, GetDiseases());

                PatientStore.Update(patientToUpdate);
                ClearForm(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private int ValidateWeight(string weightText)
        {
            if (!int.TryParse(weightText, out int weight) || weight <= 0)
            {
                throw new ArgumentException("Niepoprawna waga.");
            }
            return weight;
        }

        private int ValidateHeight(string heightText)
        {
            if (!int.TryParse(heightText, out int height) || height <= 0)
            {
                throw new ArgumentException("Niepoprawny wzrost.");
            }
            return height;
        }

        private void ClearForm(object sender, EventArgs e)
        {
           
            txtMedicalRecordNumber.Clear();
            txtPrimaryDoctor.Clear();
            txtWeight.Clear();
            txtHeight.Clear();
            cmbBloodGroup.SelectedIndex = -1;
            for (var i = 0; i < chkDisease.Items.Count; i++)
            {
                chkDisease.SetItemChecked(i, false);
            }
        }

        private void LoadDiseases()
        {
            chkDisease.Items.Clear();
            foreach (var disease in _diseaseStore.Diseases)
            {
                chkDisease.Items.Add(disease.Name);
            }
        }

        private List<int> GetDiseases()
        {
            var result = new List<int>();
            foreach (var item in chkDisease.CheckedItems)
            {
                var id = _diseaseStore.Diseases.Find(x => x.Name == (string)item).Id;
                result.Add(id);
            }

            return result;
        }
    }
}
