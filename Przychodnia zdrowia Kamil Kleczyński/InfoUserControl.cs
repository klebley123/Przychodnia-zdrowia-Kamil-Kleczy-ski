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
    public partial class InfoUserControl : UserControl
    {
        private IBasicInfo _basicInfo;

        public InfoUserControl(IBasicInfo basicInfo)
        {
            InitializeComponent();
            _basicInfo = basicInfo;
            infoLabel.Text = _basicInfo.GetInfo().Item1[0];
        }
    }
}
