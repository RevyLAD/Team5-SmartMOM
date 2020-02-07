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

namespace Team5_SmartMOM.BaseForm
{
    public partial class Loading_Form : Form
    {
        public Action Worker { get; set; }
        public Loading_Form(Action worker)
        {
            InitializeComponent();

            Worker = worker;
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {
            
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
