using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public partial class UserControlWorker : UserControl
    {
        private readonly WorkerStore _workerStore = new WorkerStore(new List<Worker>());

        public UserControlWorker()
        {
            InitializeComponent();
        }

        private void UserControlWorker_Load(object sender, EventArgs e)
        {
            var worker = _workerStore.GetAll().FirstOrDefault();
            var defaultWorker = worker != null ? worker.GetInfo() : _workerStore.GetInfoDefaultWorker();
            foreach (var item in defaultWorker)
            {
                lstWorker.Items.Add(item);
            }
        }
    }
}