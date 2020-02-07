using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class BaseGridForm : Form
    {
        public BaseGridForm()
        {
            InitializeComponent();
        }

        private void BaseGridForm_Load(object sender, EventArgs e)
        {
            //AddHeaderCheckBox();
            //GridViewCustom();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.EnableHeadersVisualStyles = false;
           

        }
        private void GridViewCustom()
        {

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(200, 210, 250);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
