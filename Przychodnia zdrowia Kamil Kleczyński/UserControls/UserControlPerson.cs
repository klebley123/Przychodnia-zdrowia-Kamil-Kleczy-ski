using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlPerson : UserControl
    {
        private int _currentPersonIndex;
        protected event EventHandler _fullValueButtonClicked;
        protected event EventHandler _saveButtonClicked;
        protected event EventHandler _cancelButtonClicked;
        protected event EventHandler _loadButtonClicked;
        protected event EventHandler _updateButtonClicked;
        protected event EventHandler _photoButtonClicked;

        public UserControlPerson()
        {
            InitializeComponent();
            LoadFirstPerson();
            SetEnableButtons();
        }

        public ListBox.ObjectCollection ListItems { get => listPerson.Items; }

        public Bitmap Photo { get; set; }
        public string Pesel { get => textBoxPesel.Text; private set => textBoxPesel.Text = value; }
        public string FirstName { get => textBoxFirstName.Text; private set => textBoxFirstName.Text = value; }
        public string LastName { get => textBoxLastName.Text; private set => textBoxLastName.Text = value; }
        public string Address { get => textBoxAddress.Text; private set => textBoxAddress.Text = value; }
        public string Email { get => textBoxEMail.Text; private set => textBoxEMail.Text = value; }
        public string TelNum { get => textBoxTelNum.Text; private set => textBoxTelNum.Text = value; }
        public string IdNum { get => textBoxIdNum.Text; private set => textBoxIdNum.Text = value; }
        public bool Insured { get => checkBoxInsuirance.Checked; private set => checkBoxInsuirance.Checked = value; }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            _currentPersonIndex--;
            LoadPerson(_currentPersonIndex);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            _currentPersonIndex++;
            LoadPerson(_currentPersonIndex);
        }

        private void LoadFirstPerson()
        {
            var person = PersonStore.GetAllInOrder().FirstOrDefault();
            if (person is null)
            {
                return;
            }
            AddListBox(person);
            SetEnableButtons();
        }

        public void AddListBox(Person patient)
        {
            if (patient == null) return;

            ListItems.Clear();
            var info = patient.GetInfo();
            foreach (var item in info.info)
            {
                ListItems.Add(item);
            }

            pictureBoxPhoto.Image = patient.Photo;
            SetEnableButtons();
        }

        private void LoadPerson(int index)
        {
            var person = PersonStore.GetByIndex(index);
            if (person == null) return;

            ListItems.Clear();
            AddListBox(person);
            pictureBoxPhoto.Image = person.Photo;
            

            SetEnableButtons();
        }

        private void SetEnableButtons()
        {
            var peopleCount = PersonStore.GetCount();
            var lastIndex = peopleCount - 1;
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

            if (_currentPersonIndex == lastIndex)
            {
                buttonNext.Enabled = false;
            }

            if (_currentPersonIndex == 0)
            {
                buttonPrevious.Enabled = false;
            }

            if (peopleCount > 0)
            {
                btnLoad.Enabled = true;
            }
        }

        public void ClearForm()
        {
            Pesel = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Address = string.Empty;
            Email = string.Empty;
            TelNum = string.Empty;
            IdNum = string.Empty;
            Insured = false;
            _cancelButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonFullValue_Click(object sender, EventArgs e)
        {
            Pesel = "01241946373";
            FirstName = "Jon";
            LastName = "Kawalski";
            Address = "Marcowa 12";
            Email = "hop@hope.pl";
            TelNum = "997";
            IdNum = "OOO997887";
            _fullValueButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _saveButtonClicked?.Invoke(this, EventArgs.Empty);
            if(PersonStore.GetCount() == 1)
            {
                LoadFirstPerson();
            }
            ClearForm();
            SetEnableButtons();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var person = PersonStore.GetByIndex(_currentPersonIndex);
            Pesel = person.Pesel;
            IdNum = person.IdNumber;
            FirstName = person.FirstName;
            LastName = person.LastName;
            Address = person.Address;
            Email = person.Email;
            TelNum = person.PhoneNumber;
            Insured = person.Insurance;
            Photo = (Bitmap)person.Photo;
            _loadButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            _updateButtonClicked?.Invoke(this, EventArgs.Empty);
            var person = PersonStore.GetByIndex(_currentPersonIndex);
            AddListBox(person);
            ClearForm();
        }

        private void buttonLoadPhoto_Click(object sender, EventArgs e)
        {
            try 
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Title = @"Zdjęcia";
                openFileDialog.Filter = @"Photo Files (*.jpg)|*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Photo = new Bitmap(Image.FromFile(openFileDialog.FileName));
                    pictureBoxPhoto.Image = Photo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Wystąpił błąd możliwe, że zdjęcie jest uszkodzone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
