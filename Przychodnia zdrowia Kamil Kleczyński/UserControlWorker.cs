using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlWorker : UserControl
    {
        private readonly WorkerStore _workerStore = new WorkerStore();
        private int _currentWorkersIndex;

        public UserControlWorker()
        {
            InitializeComponent();
        }

        private void UserControlWorker_Load(object sender, EventArgs e)
        {
            var worker = _workerStore.GetAll().FirstOrDefault();
            AddListBox(worker);
            SetEnableButtons();
        }

        //private void buttonSave_Click(object sender, EventArgs e)
        //{
        //    //var dateOfHire = GetDatePickerDateOfHire(dateTimePickerDateOfHire.CustomFormat);
        //    var salary = _workerStore.IsValidSalary(textBoxSalary.Text);
        //    if (salary == 0 && salary > 30001)
        //    {
        //        MessageBox.Show(@"Niepoprawne wynagrodzenie.", @"Błąd zapisu", MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //        return;
        //    }

        //    var worker = new Worker(textBoxPesel.Text, textBoxIdNum.Text, textBoxFirstName.Text,
        //        textBoxLastName.Text,
        //        textBoxAddress.Text, textBoxEMail.Text, textBoxTelNum.Text, checkBoxInsuirance.Checked,
        //        textBoxPosition.Text,
        //        textBoxWorkerId.Text, dateTimePickerDateOfHire.Value.Date, salary);

        //    var message = _workerStore.Add(worker);

        //    if (!string.IsNullOrEmpty(message))
        //    {
        //        MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    _currentWorkersIndex = _workerStore.GetCount() - 1;
        //    AddListBox(worker);
        //    ClearForm();
        //    SetEnableButtons();
        //}

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //var dateOfHire = GetDatePickerDateOfHire(dateTimePickerDateOfHire.CustomFormat);
            try
            {
                var salary = _workerStore.IsValidSalary(textBoxSalary.Text);
                if (salary == 0 && salary > 30001)
                {
                    MessageBox.Show(@"Niepoprawne wynagrodzenie.", @"Błąd zapisu", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var worker = new Worker(textBoxPesel.Text, textBoxIdNum.Text, textBoxFirstName.Text,
                    textBoxLastName.Text,
                    textBoxAddress.Text, textBoxEMail.Text, textBoxTelNum.Text, checkBoxInsuirance.Checked,
                    cmbPosition.Text,
                    textBoxWorkerId.Text, dateTimePickerDateOfHire.Value.Date, salary);

                _workerStore.Add(worker);
                _currentWorkersIndex = _workerStore.GetCount() - 1;
                AddListBox(worker);
                ClearForm();
                SetEnableButtons();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        //private DateTimePicker GetDatePickerDateOfHire(string dateOfHire)
        //{
        //    return dateTimePickerDateOfHire;
        //}

        private void AddListBox(Worker worker)
        {
            if (worker == null) return;

            listWorker.Items.Clear();
            var info = worker.GetInfo();
            foreach (var item in info.Item1)
            {
                listWorker.Items.Add(item);
            }
            pictureBox1.Image = info.Item2;
        }

        private void SetEnableButtons()
        {
            var patientCount = _workerStore.GetCount();
            var lastIndex = patientCount - 1;
            if (lastIndex <= 0)
            {
                buttonPrevious.Enabled = false;
                buttonNext.Enabled = false;
            }
            else
            {
                buttonPrevious.Enabled = true;
                buttonNext.Enabled = true;
            }

            if (_currentWorkersIndex == lastIndex)
            {
                buttonNext.Enabled = false;
            }

            if (_currentWorkersIndex == 0)
            {
                buttonPrevious.Enabled = false;
            }

            if (patientCount > 0)
            {
                btnLoad.Enabled = true;
            }
        }

        private void ClearForm()
        {
            textBoxPesel.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxAddress.Clear();
            textBoxEMail.Clear();
            textBoxTelNum.Clear();
            textBoxIdNum.Clear();
            cmbPosition.SelectedItem = null;
            dateTimePickerDateOfHire.Value = DateTime.Now;
            textBoxWorkerId.Clear();
            textBoxSalary.Clear();

            checkBoxInsuirance.Checked = false;


            textBoxPesel.Enabled = true;
            buttonUpdate.Visible = false;
            buttonSave.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            ClearForm();
            var worker = _workerStore.GetByIndex(_currentWorkersIndex);
            textBoxPesel.Text = worker.Pesel;
            textBoxIdNum.Text = worker.IdNumber;
            textBoxFirstName.Text = worker.FirstName;
            textBoxLastName.Text = worker.LastName;
            textBoxAddress.Text = worker.Address;
            textBoxEMail.Text = worker.Email;
            textBoxTelNum.Text = worker.PhoneNumber;
            checkBoxInsuirance.Checked = worker.Insurance;
            cmbPosition.Text = worker.Position;
            textBoxWorkerId.Text = worker.WorkerId;
            dateTimePickerDateOfHire.Value = worker.DateOfHire;
            textBoxSalary.Text = worker.Salary.ToString();

            textBoxPesel.Enabled = false;
            buttonSave.Visible = false;
            buttonUpdate.Visible = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var salary = _workerStore.IsValidSalary(textBoxSalary.Text);
                if (salary == 0 && salary > 30001)
                {
                    MessageBox.Show(@"Niepoprawne wynagrodzenie.", @"Błąd zapisu", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var worker = new Worker(textBoxPesel.Text, textBoxIdNum.Text, textBoxFirstName.Text, textBoxLastName.Text,
                    textBoxAddress.Text, textBoxEMail.Text, textBoxTelNum.Text, checkBoxInsuirance.Checked,
                    cmbPosition.Text,
                    textBoxWorkerId.Text, dateTimePickerDateOfHire.Value.Date, salary);

                _workerStore.Update(worker);
                //if (!string.IsNullOrEmpty(message))
                //{
                //    MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                AddListBox(worker);
                ClearForm();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, @"upss... Coś poszło nie tak..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //var salary = _workerStore.IsValidSalary(textBoxSalary.Text);
            //if (salary == 0 && salary > 30001)
            //{
            //    MessageBox.Show(@"Niepoprawne wynagrodzenie.", @"Błąd zapisu", MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}

            //var worker = new Worker(textBoxPesel.Text, textBoxIdNum.Text, textBoxFirstName.Text, textBoxLastName.Text,
            //    textBoxAddress.Text, textBoxEMail.Text, textBoxTelNum.Text, checkBoxInsuirance.Checked,
            //    textBoxPosition.Text,
            //    textBoxWorkerId.Text, dateTimePickerDateOfHire.Value.Date, salary);

            //var message = _workerStore.Update(worker);
            //if (!string.IsNullOrEmpty(message))
            //{
            //    MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //AddListBox(worker);
            //ClearForm();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            _currentWorkersIndex--;
            var worker = _workerStore.GetByIndex(_currentWorkersIndex);
            AddListBox(worker);
            SetEnableButtons();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _currentWorkersIndex++;
            var worker = _workerStore.GetByIndex(_currentWorkersIndex);
            AddListBox(worker);
            SetEnableButtons();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void buttonFullValue_Click(object sender, EventArgs e)
        {
            textBoxPesel.Text = "01240332535";
            textBoxFirstName.Text = "Władysław";
            textBoxLastName.Text = "Kawalski";
            textBoxAddress.Text = "Marcowa 12";
            textBoxEMail.Text = "oko@poko.pl";
            textBoxTelNum.Text = "112";
            textBoxIdNum.Text = "PEPE3345";
            cmbPosition.Text = "Lekarz";
            dateTimePickerDateOfHire.Text = DateTime.Now.ToString();
            textBoxWorkerId.Text = "2256";
            textBoxSalary.Text = "123";
        }
    }
}