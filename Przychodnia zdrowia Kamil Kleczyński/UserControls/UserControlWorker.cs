using System;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlWorker : UserControlPerson
    {
        private int _currentWorkersIndex;

        public UserControlWorker()
        {
            InitializeComponent();
            _fullValueButtonClicked += ButtonFullValue_Click;
            _saveButtonClicked += ButtonSave_Click;
            _cancelButtonClicked += ClearForm;
            _loadButtonClicked += ButtonLoad_Click;
            _updateButtonClicked += ButtonUpdate_Click;
        }

        private void UserControlWorker_Load(object sender, EventArgs e)
        {
            var worker = WorkerStore.GetAllInOrder().FirstOrDefault();
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var dateOfHire = GetDatePickerDateOfHire(dateTimePickerDateOfHire.CustomFormat);
            try
            {
                //var salary = WorkerStore.IsValidSalary(textBoxSalary.Text);
                //if (salary == 0 && salary > 30001)
                //{
                //    MessageBox.Show(@"Niepoprawne wynagrodzenie.", @"Błąd zapisu", MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //    return;
                //}

                var worker = new Worker(
                    Pesel,
                    IdNum,
                    FirstName,
                    LastName,
                    Address,
                    Email,
                    TelNum,
                    Insured,
                    cmbPosition.Text,
                    textBoxWorkerId.Text,
                    dateTimePickerDateOfHire.Value.Date,
                    Decimal.Parse(textBoxSalary.Text));

                WorkerStore.Add(worker);
                _currentWorkersIndex = WorkerStore.GetCount() - 1;
                ClearForm(sender,e);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private DateTimePicker GetDatePickerDateOfHire(string dateOfHire)
        {
            return dateTimePickerDateOfHire;
        }

        private void ClearForm(object sender, EventArgs e)
        {
            cmbPosition.SelectedItem = null;
            dateTimePickerDateOfHire.Value = DateTime.Now;
            textBoxWorkerId.Clear();
            textBoxSalary.Clear();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            ClearForm(sender, e);
            var worker = WorkerStore.GetByIndex(_currentWorkersIndex);
            cmbPosition.Text = worker.Position;
            textBoxWorkerId.Text = worker.WorkerId;
            dateTimePickerDateOfHire.Value = worker.DateOfHire;
            textBoxSalary.Text = worker.Salary.ToString();

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //var salary = _workerStore.IsValidSalary(textBoxSalary.Text);
                //if (salary == 0 && salary > 30001)
                //{
                //    MessageBox.Show(@"Niepoprawne wynagrodzenie.", @"Błąd zapisu", MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //    return;
                //}

                //var worker = new Worker(textBoxPesel.Text, textBoxIdNum.Text, textBoxFirstName.Text, textBoxLastName.Text,
                //    textBoxAddress.Text, textBoxEMail.Text, textBoxTelNum.Text, checkBoxInsuirance.Checked,
                //    cmbPosition.Text,
                //    textBoxWorkerId.Text, dateTimePickerDateOfHire.Value.Date, salary);

                //_workerStore.Update(worker);
                //if (!string.IsNullOrEmpty(message))
                //{
                //    MessageBox.Show(message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                //AddListBox(worker);
                ClearForm(sender, e);
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
            try
            {
                var pesel = Pesel;
                var idNumber = IdNum;
                var firstName = FirstName;
                var lastName = LastName;
                var address = Address;
                var email = Email;
                var phoneNumber = TelNum;
                var insurance = Insured;

                var workerToUpdate = WorkerStore.GetByPesel(pesel);
                if (decimal.TryParse(textBoxSalary.Text, out var salary))
                {
                    workerToUpdate.Update(idNumber, firstName, lastName, address, email, phoneNumber, insurance, 
                        cmbPosition.Text, textBoxWorkerId.Text, dateTimePickerDateOfHire.Value.Date, salary);
                }
                else
                {
                    workerToUpdate.Update(idNumber, firstName, lastName, address, email, phoneNumber, insurance, 
                        cmbPosition.Text, textBoxWorkerId.Text, dateTimePickerDateOfHire.Value.Date, workerToUpdate.Salary);
                }
                
                WorkerStore.Update(workerToUpdate);
                ClearForm(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonFullValue_Click(object sender, EventArgs e)
        {
            cmbPosition.Text = "Lekarz";
            dateTimePickerDateOfHire.Text = DateTime.Now.ToString();
            textBoxWorkerId.Text = "2256";
            textBoxSalary.Text = "123";
        }
    }
}