using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class CircleProgressBar : Form
    {
        public Action Worker { get; set; }
        public CircleProgressBar(Action worker)
        {
            InitializeComponent();

            Worker = worker;
        }

        private void frmWaitForm_Load(object sender, EventArgs e)
        {

            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
