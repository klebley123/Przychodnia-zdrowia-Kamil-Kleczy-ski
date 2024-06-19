using Przychodnia_zdrowia_Kamil_Kleczynski;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Przychodnia_zdrowia_Kamil_Kleczyński
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvPatient.Items.Clear();
            lvWorker.Items.Clear();

            var patient = new Patient();
            var infoPatient = patient.GetInfo();
            foreach (var item in infoPatient)
            {
                lvPatient.Items.Add(item);
            }

            var worker = new Worker();
            var infoWorker = worker.GetInfo();
            foreach (var item in infoWorker)
            {
                lvWorker.Items.Add(item);
            }
        }
    }
}
