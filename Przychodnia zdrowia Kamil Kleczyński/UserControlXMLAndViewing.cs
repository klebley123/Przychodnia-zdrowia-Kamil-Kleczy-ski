using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlXMLAndViewing : UserControl
    {
        private int _currentPatientsIndex;

        public UserControlXMLAndViewing()
        {
            InitializeComponent();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            _currentPatientsIndex--;
            var person = PersonStore.Instance().GetByIndex(_currentPatientsIndex);
            AddListBox(person);
            SetEnabledButtons();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _currentPatientsIndex++;
            var person = PersonStore.Instance().GetByIndex(_currentPatientsIndex);
            AddListBox(person);
            SetEnabledButtons();
        }

        private void SetEnabledButtons()
        {
            var patientCount = PersonStore.Instance().GetCount();
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

            if (_currentPatientsIndex == lastIndex)
            {
                buttonNext.Enabled = false;
            }

            if (_currentPatientsIndex == 0)
            {
                buttonPrevious.Enabled = false;
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            SetEnabledButtons();
        }

        private void UserControlXMLAndViewing_Load(object sender, EventArgs e)
        {
            LoadFirstPerson();
        }

        private void LoadFirstPerson()
        {
            var patient = PersonStore.Instance().GetAll().FirstOrDefault();
            AddListBox(patient);
            SetEnabledButtons();
        }

        private void AddListBox(Person person)
        {
            if (person == null) return;

            listPersons.Items.Clear();
            var info = person.GetInfo();
            foreach (var item in info.Item1)
            {
                listPersons.Items.Add(item);
            }

            pictureBox1.Image = person.Photo;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = @"Import ludzi";
            openFileDialog.Filter = @"XML Files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var xs = new XmlSerializer(typeof(Patient));
                using (var stream = new StreamReader(openFileDialog.FileName))
                {
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(stream);
                    var xmlPatientList = xmlDoc.GetElementsByTagName("Person");
                    if (xmlPatientList.Count == 0) return;

                    foreach (XmlNode xmlItem in xmlPatientList)
                    {
                        using (XmlReader reader = new XmlNodeReader(xmlItem))
                        {
                            //var person = PersonStore.Instance().People.Add(patient);
                            //persons.Add((Person)xs.Deserialize(reader));
                        }
                    }

                    //PersonStore.Instance().UpdateList(persons);
                    LoadFirstPerson();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = @"Export ludzi";
            saveFileDialog.FileName = "Persons.xml";
            saveFileDialog.Filter = @"XML Files (*.xml)|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;
                var persons = PersonStore.Instance().GetAll();
                var xs = new XmlSerializer(persons.GetType());
                TextWriter writer = new StreamWriter(path);
                xs.Serialize(writer, persons);
                writer.Close();
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = @"Zdjęcia";
            openFileDialog.Filter = @"Photo Files (*.jpg)|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var person = PersonStore.Instance().GetByIndex(_currentPatientsIndex);
            person.Photo = (Bitmap)pictureBox1.Image;
        }
    }
}