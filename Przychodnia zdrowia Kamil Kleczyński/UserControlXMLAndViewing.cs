using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlXMLAndViewing : UserControl
    {
        public UserControlXMLAndViewing()
        {
            InitializeComponent();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void SetEnabledButtons()
        {
            buttonPrevious.Enabled = false;
            buttonNext.Enabled = false;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            SetEnabledButtons();
        }

        private void AddListBox(PersonStore personStore)
        {
            //PersonStore.Instance().People.Where(x => x is Worker)
                //.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).Select(x => (Worker)x).ToList();
            listPersons.Items.Clear();
            foreach (var items in PersonStore.Instance)
            {

            }
        }
    }
}
