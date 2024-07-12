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
    public partial class UserControlPerson : UserControl
    {
        private IBasicInfo _info;
        private int _index;

        public UserControlPerson(IBasicInfo info, int index)
        {
            InitializeComponent();

            _info = info;
            _index = index;

            nameLabel.Text = info.GetInfo().Item1[0];
            surnameLabel.Text = info.GetInfo().Item1[1];
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            PersonStore.Instance().People.RemoveAt(_index);
            this.Hide();
        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
