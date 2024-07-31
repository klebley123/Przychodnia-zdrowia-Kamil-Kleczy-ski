using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

            for(int i = 0; i < PersonStore.People.Count; i++)
            {
                Person p = PersonStore.People[i];
                IBasicInfo ib = (IBasicInfo)p;
                UserControlPerson up = new UserControlPerson(ib, i, () => {
                    InfoUserControl ucp = new InfoUserControl(ib);
                    peoplePanel.Controls.Add(ucp);
                }, 
                    uc => {
                    if (PersonStore.GetCount() > 0)
                    {
                        PersonStore.People.Remove(p);
                        uc.Hide();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });
                peoplePanel.Controls.Add(up);
            }
        }


        private void SetEnabledButtons()
        {
            var patientCount = PersonStore.GetCount();
            var lastIndex = patientCount - 1;
            if (lastIndex <= 0)
            {
                BtnPrevious.Enabled = false;
                BtnNext.Enabled = false;
            }
            else
            {
                BtnPrevious.Enabled = true;
                BtnNext.Enabled = true;
            }

            if (_currentPatientsIndex == lastIndex)
            {
                BtnNext.Enabled = false;
            }

            if (_currentPatientsIndex == 0)
            {
                BtnPrevious.Enabled = false;
            }
        }

     
        private void UserControlXMLAndViewing_Load(object sender, EventArgs e)
        {
            LoadFirstPerson();
        }

        private void LoadFirstPerson()
        {
            var patient = PersonStore.GetInOrder().FirstOrDefault();
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

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _currentPatientsIndex--;
            var person = PersonStore.GetByIndex(_currentPatientsIndex);
            AddListBox(person);
            SetEnabledButtons();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _currentPatientsIndex++;
            var person = PersonStore.GetByIndex(_currentPatientsIndex);
            AddListBox(person);
            SetEnabledButtons();
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            var person = PersonStore.GetByIndex(_currentPatientsIndex);
            person.Photo = (Bitmap)pictureBox1.Image;
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = @"Zdjęcia";
            openFileDialog.Filter = @"Photo Files (*.jpg)|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = @"Export ludzi";
            saveFileDialog.FileName = "Persons.xml";
            saveFileDialog.Filter = @"XML Files (*.xml)|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;
                var persons = PersonStore.GetInOrder();
                var xs = new XmlSerializer(persons.GetType());
                TextWriter writer = new StreamWriter(path);
                xs.Serialize(writer, persons);
                writer.Close();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = @"Import ludzi";
            openFileDialog.Filter = @"XML Files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var xs = new XmlSerializer(typeof(Person));
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
                            var person = xs.Deserialize(reader);
                            if (person.GetType() == typeof(Patient))
                            {
                                PersonStore.People.Add((Patient)person);
                            }

                            if (person.GetType() == typeof(Worker))
                            {
                                PersonStore.People.Add((Worker)person);
                            }
                        }
                    }

                    LoadFirstPerson();
                }
            }
        }
    }
}