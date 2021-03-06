﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_Pop;
using System.Deployment.Application;

namespace Team5_Pop
{
    public partial class MainPoPForm : Form
    {
        public MainPoPForm()
        {
            InitializeComponent();
            CheckUpdate();
        }
        private void CheckUpdate()
        {
            UpdateCheckInfo info = null;

            if (!ApplicationDeployment.IsNetworkDeployed)
            {
                MessageBox.Show("not deployed using Clickonce");
            }
            else
            {
                ApplicationDeployment appDeploy = ApplicationDeployment.CurrentDeployment;
                info = appDeploy.CheckForDetailedUpdate();

                if (info.UpdateAvailable)
                {
                    bool doUpdate = true;

                    if (doUpdate)
                    {
                        appDeploy.Update();
                        MessageBox.Show("프로그램이 업그레이드 되어서 재시작 합니다.");
                        this.Close();
                        Application.Restart();
                    }
                }
            }
        }
        private void MainPoPForm_Load(object sender, EventArgs e)
        {
            CreateTabPages("메인 화면", new PoPMain(this));
            CreateTabPages("설비 관리", new ContorlForm(this));
            this.metroTabControl1.SelectedIndex = 0;
        }

        public void CreateTabPages(string text, Form OpenForm)
        {
            foreach (TabPage childForm in this.metroTabControl1.TabPages)
            {
                if (childForm.Text == text)
                {                                                                                                                                                                                                                                     
                    metroTabControl1.SelectedTab = childForm;
                    return;
                }
            }

            TabPage myTabPage = new TabPage();
            myTabPage.Text = text;
            myTabPage.ImageIndex = 1;
            metroTabControl1.Controls.Add(myTabPage);


            myTabPage.Focus();

            OpenForm.TopLevel = false;
            OpenForm.Parent = this;
            myTabPage.Controls.Add(OpenForm);
            //창이 열리면서 최대화

            OpenForm.Dock = DockStyle.Fill;
            OpenForm.FormBorderStyle = FormBorderStyle.None;
            OpenForm.Show();

            metroTabControl1.SelectedTab = myTabPage;
        }

        public void DeleteTabPages(Form OpenForm)
        {
            metroTabControl1.TabPages.RemoveAt(metroTabControl1.SelectedIndex);
            metroTabControl1.Controls.Remove(OpenForm);
            metroTabControl1.SelectedIndex = 0;
        }
    }
}
