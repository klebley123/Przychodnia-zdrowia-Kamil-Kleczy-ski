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
            infoLabel.Text = _basicInfo.GetInfo().info[0];
        }
    }
}
