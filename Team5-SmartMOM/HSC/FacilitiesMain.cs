using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM
{
    public partial class FacilitiesMain : Form
    {
        public FacilitiesMain()
        {
            InitializeComponent();
        }
        Facilities fac;
        FacilitiesDetail fcr;
        private void FacilitiesMain_Load(object sender, EventArgs e)
        {
            fac = new Facilities();
            fac.TopLevel = false;
            fac.Dock = DockStyle.Fill;
            fac.FormBorderStyle = FormBorderStyle.None;
            fac.Show();


            fac.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);

            fcr = new FacilitiesDetail();
            fcr.TopLevel = false;
            fcr.Dock = DockStyle.Fill;
            fcr.FormBorderStyle = FormBorderStyle.None;
            fcr.Show();

            splitContainer1.Panel1.Controls.Add(fac);
            splitContainer1.Panel2.Controls.Add(fcr);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fcr.dataGridView1.DataSource = FindFacDetail(fac.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private List<FacilitieDetailVO> FindFacDetail(string Code)
        {
            HSC_Service service = new HSC_Service();
            
            return service.FindFacDetail(Code); ;
        }
    }
}

