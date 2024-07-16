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
        private Action _onClick;
        private Func<UserControl, bool> _onDeleteClick;


        public UserControlPerson(IBasicInfo info, int index, Action onClick, Func<UserControl, bool> onDeleteClick)
        {
            InitializeComponent();

            _info = info;
            _index = index;

            nameLabel.Text = info.GetInfo().Item1[0];
            surnameLabel.Text = info.GetInfo().Item1[1];
            _onDeleteClick = onDeleteClick;
            _onClick = onClick;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _onDeleteClick.Invoke(this);
        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserControlPerson_Click(object sender, EventArgs e)
        {
            _onClick.Invoke();
        }
    }
}
