using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlPatient : UserControl
    {
        private readonly PatientStore _patientStore = new PatientStore();
        private readonly DiseaseStore _diseaseStoreStore = new DiseaseStore(false);
        private int _currentPatientsIndex;

        public UserControlPatient()
        {
            InitializeComponent();
        }

        private void UserControlPatient_Load(object sender, EventArgs e)
        {
            LoadDiseases();
            LoadFirstPatient();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentPatientsIndex--;
            var patient = _patientStore.GetByIndex(_currentPatientsIndex);
            AddListBox(patient);
            SetEnableButtons();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPatientsIndex++;
            var patient = _patientStore.GetByIndex(_currentPatientsIndex);
            AddListBox(patient);
            SetEnableButtons();
        }

        protected virtual void btnLoad_Click(object sender, EventArgs e)
        {
            ClearForm();
            var patient = _patientStore.GetByIndex(_currentPatientsIndex);
            txtPesel.Text = patient.Pesel;
            txtIdNumber.Text = patient.IdNumber;
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtAddress.Text = patient.Address;
            txtEmail.Text = patient.Email;
            txtPhoneNumber.Text = patient.PhoneNumber;
            chkInsurance.Checked = patient.Insurance;
            txtMedicalRecordNumber.Text = patient.MedicalRecordNumber;
            txtPrimaryDoctor.Text = patient.PrimaryDoctor;
            txtWeight.Text = patient.Weight.ToString();
            txtHeight.Text = patient.Height.ToString();
            cmbBloodGroup.Text = patient.BloodGroup;
            var ids = new List<int>();
            foreach (var id in patient.DiseaseId)
            {
                var name = _diseaseStoreStore.GetById(id);
                foreach (var item in chkDisease.Items)
                {
                    if ((string)item == name)
                        ids.Add(chkDisease.Items.IndexOf(name));
                }

                foreach (var idx in ids)
                {
                    chkDisease.SetItemChecked(idx, true);
                }
            }

            txtPesel.Enabled = false;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //do przeniesienia do pacjent
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

                _patientStore.Add(patient);
                //if (!string.IsNullOrEmpty(message))
                //{
                //    MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                _currentPatientsIndex = _patientStore.GetCount() - 1;
                AddListBox(patient);
                ClearForm();
                SetEnableButtons();
            }
            catch (Exception exeception)
            {
                MessageBox.Show(exeception.Message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error );
                //throw;
            }
            //var weight = _patientStore.IsValidWeight(txtWeight.Text);
            //if (weight == 0)
            //{
            //    MessageBox.Show(@"Niepoprawna waga.", @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //var height = _patientStore.IsValidHeight(txtHeight.Text);
            //if (height == 0)
            //{
            //    MessageBox.Show(@"Niepoprawny wzrost.", @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //var diseaseId = GetDiseases();
            //var patient = new Patient(txtPesel.Text, txtIdNumber.Text, txtFirstName.Text, txtLastName.Text,
            //    txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, chkInsurance.Checked, txtMedicalRecordNumber.Text,
            //    txtPrimaryDoctor.Text, weight, height, cmbBloodGroup.Text, diseaseId);

            //var message = _patientStore.Add(patient);
            //if (!string.IsNullOrEmpty(message))
            //{
            //    MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //_currentPatientsIndex = _patientStore.GetCount() - 1;
            //AddListBox(patient);
            //ClearForm();
            //SetEnableButtons();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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

                _patientStore.Update(patient);
                //if (!string.IsNullOrEmpty(message))
                //{
                //    MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                AddListBox(patient);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"upss.. coś poszło nie tak", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            //var weight = _patientStore.IsValidWeight(txtWeight.Text);
            //if (weight == 0)
            //{
            //    MessageBox.Show(@"Niepoprawna waga.", @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //var height = _patientStore.IsValidHeight(txtHeight.Text);
            //if (height == 0)
            //{
            //    MessageBox.Show(@"Niepoprawny wzrost.", @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //var diseaseId = GetDiseases();

            //var patient = new Patient(txtPesel.Text, txtIdNumber.Text, txtFirstName.Text, txtLastName.Text,
            //    txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, chkInsurance.Checked, txtMedicalRecordNumber.Text,
            //    txtPrimaryDoctor.Text, weight, height, cmbBloodGroup.Text, diseaseId);

            // var message = _patientStore.Update(patient);
            ////if (!string.IsNullOrEmpty(message))
            ////{
            ////    MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    return;
            ////}

            //AddListBox(patient);
            //ClearForm();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        //private void btnImportXML_Click(object sender, EventArgs e)
        //{
        //    var openFileDialog = new OpenFileDialog();
        //    openFileDialog.Title = @"Import pacjentów";
        //    openFileDialog.Filter = @"XML Files (*.xml)|*.xml";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        var xs = new XmlSerializer(typeof(Patient));
        //        using (var stream = new StreamReader(openFileDialog.FileName))
        //        {
        //            var xmlDoc = new XmlDocument();
        //            xmlDoc.Load(stream);
        //            var xmlPatientList = xmlDoc.GetElementsByTagName("Patient");
        //            if (xmlPatientList.Count == 0) return;

        //            var patients = new List<Patient>();
        //            foreach (XmlNode xmlItem in xmlPatientList)
        //            {
        //                using (XmlReader reader = new XmlNodeReader(xmlItem))
        //                {
        //                    patients.Add((Patient)xs.Deserialize(reader));
        //                }
        //            }

        //            _patientStore.UpdateList(patients);
        //            LoadFirstPatient();
        //        }
        //    }
        //}

        //private void btnExportXML_Click(object sender, EventArgs e)
        //{
        //    var saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Title = @"Export pacjentów";
        //    saveFileDialog.FileName = "Patients.xml";
        //    saveFileDialog.Filter = @"XML Files (*.xml)|*.xml";

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        var path = saveFileDialog.FileName;
        //        var patients = _patientStore.GetAll();
        //        var xs = new XmlSerializer(patients.GetType());
        //        TextWriter writer = new StreamWriter(path);
        //        xs.Serialize(writer, patients);
        //        writer.Close();
        //    }
        //}

        private void LoadDiseases()
        {
            foreach (var item in _diseaseStoreStore.Diseases)
            {
                chkDisease.Items.Add(item.Name);
            }
        }

        private void LoadFirstPatient()
        {
            var patient = _patientStore.GetAll().FirstOrDefault();
            AddListBox(patient);
            SetEnableButtons();
        }

        private void AddListBox(Patient patient)
        {
            if (patient == null) return;

            lstPatient.Items.Clear();
            var info = patient.GetInfo();
            foreach (var item in info.Item1)
            {
                lstPatient.Items.Add(item);
            }

            pictureBox1.Image = info.Item2;
        }

        private void SetEnableButtons()
        {
            var patientCount = _patientStore.GetCount();
            var lastIndex = patientCount - 1;
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

            if (_currentPatientsIndex == lastIndex)
            {
                btnNext.Enabled = false;
            }

            if (_currentPatientsIndex == 0)
            {
                btnPrev.Enabled = false;
            }

            if (patientCount > 0)
            {
                btnLoad.Enabled = true;
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
            for (var i = 0; i < chkDisease.Items.Count; i++)
            {
                chkDisease.SetItemChecked(i, false);
            }

            txtPesel.Enabled = true;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }

        private void btnFillValue_Click(object sender, EventArgs e)
        {
            txtPesel.Text = "01241946373";
            txtFirstName.Text = "Jon";
            txtLastName.Text = "Kawalski";
            txtAddress.Text = "Marcowa 12";
            txtEmail.Text = "hop@hope.pl";
            txtPhoneNumber.Text = "997";
            txtIdNumber.Text = "OOO997887";
            txtMedicalRecordNumber.Text = "12";
            txtPrimaryDoctor.Text = "Władysław";
            txtWeight.Text = "150";
            txtHeight.Text = "175";
            cmbBloodGroup.Text = "0 RH+";
        }
    }
}