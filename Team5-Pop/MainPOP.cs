﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_Pop
{
    public partial class MainPOP : Form
    {
        public MainPOP()
        {
            InitializeComponent();
        }

        private void MainPOP_Load(object sender, EventArgs e)
        {
            //창이 열려있으면 또 안열리게
            foreach (Form childForm in this.panelMain.Controls)
            {
                childForm.Close();
            }
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(WorkOrderRegister))
                {
                    //메모리 재할당 x 
                    childForm.Activate();
                    return;
                }
            }
            WorkOrderRegister frm = new WorkOrderRegister();
            frm.TopLevel = false;
            frm.Parent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(frm);
            //창이 열리면서 최대화
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //창이 열려있으면 또 안열리게
            foreach (Form childForm in this.panelMain.Controls)
            {
                childForm.Close();
            }
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(WorkOrderRegister))
                {
                    //메모리 재할당 x 
                    childForm.Activate();
                    return;
                }
            }
            WorkOrderRegister frm = new WorkOrderRegister();
            frm.TopLevel = false;
            frm.Parent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(frm);
            //창이 열리면서 최대화
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.panelMain.Controls)
            {
                childForm.Close();
            }
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(WorkOrderList))
                {
                    //메모리 재할당 x 
                    childForm.Activate();
                    return;
                }
            }
            WorkOrderList frm = new WorkOrderList();
            frm.TopLevel = false;
            frm.Parent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(frm);
            //창이 열리면서 최대화
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.panelMain.Controls)
            {
                childForm.Close();
            }
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(Monitor))
                {
                    //메모리 재할당 x 
                    childForm.Activate();
                    return;
                }
            }
            Monitor frm = new Monitor();
            frm.TopLevel = false;
            frm.Parent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(frm);
            //창이 열리면서 최대화
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.panelMain.Controls)
            {
                childForm.Close();
            }
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm.GetType() == typeof(WorkOrderRegister))
                {
                    //메모리 재할당 x 
                    childForm.Activate();
                    return;
                }
            }
            WorkOrderRegister frm = new WorkOrderRegister();
            frm.TopLevel = false;
            frm.Parent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(frm);
            //창이 열리면서 최대화
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}