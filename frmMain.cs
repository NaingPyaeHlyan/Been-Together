using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace BeenTogether
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void pictureBoxGirl_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxGirl.Width +1, pictureBoxGirl.Height +1);
            Region rg = new Region(gp);
            pictureBoxGirl.Region = rg;
        }

        private void pictureBoxBoy_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxGirl.Width + 1, pictureBoxGirl.Height + 1);
            Region rg = new Region(gp);
            pictureBoxGirl.Region = rg;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (lblBt.Text =="")
            {
                frmCheck fcheck = new frmCheck();
                fcheck.ShowDialog();
                this.Hide();
            }
            else
            {
                frmSetting set = new frmSetting();
                set.Show();
                this.Hide();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("Setting.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream read = new FileStream("Setting.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information info = (Information)xs.Deserialize(read);

                lblP1.Text = info.DataP1;
                lblP2.Text = info.DataP2;
                lblCT.Text = info.DataCt;
                lblBt.Text = info.DataCbt;
              //  lblDT.Text = string.Format(info.DataDt.ToString(),"dd-MM-yyyy");

            //    lblDT.Text = info.DataDt;
                pictureBoxBoy.ImageLocation = info.DataPto1;
                pictureBoxGirl.ImageLocation = info.DataPto2;
                pictureBoxBK.ImageLocation = info.DataPto3;

       //--------------------------------------------------------------------------------------------------------------------------------------------------------------
                // Change Ellipse Photo
       //--------------------------------------------------------------------------------------------------------------------------------------------------------------
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, pictureBoxGirl.Width + 0, pictureBoxGirl.Height + 0);
                Region rg = new Region(gp);
                pictureBoxGirl.Region = rg;


                System.Drawing.Drawing2D.GraphicsPath dg = new System.Drawing.Drawing2D.GraphicsPath();
                dg.AddEllipse(0, 0, pictureBoxBoy.Width + 0, pictureBoxBoy.Height + 0);
                Region reg = new Region(gp);
                pictureBoxBoy.Region = reg;

       //--------------------------------------------------------------------------------------------------------------------------------------------------------------
                // Show Calculate Year, Month, Days.
       //--------------------------------------------------------------------------------------------------------------------------------------------------------------
                DateTime dateOfStart;
                DateTime.TryParse(info.DataDt, out dateOfStart);
                DateTime currentDate = DateTime.Now;
                TimeSpan difference = currentDate.Subtract(dateOfStart);
                DateTime date = DateTime.MinValue + difference;

                int InYear = date.Year - 1;
                int InMonth = date.Month - 1;
                int InDay = date.Day - 1;

                lblYear.Text = (InYear).ToString();
                lblMonth.Text = (InMonth).ToString();
                lblDay.Text = (InDay).ToString();


       //--------------------------------------------------------------------------------------------------------------------------------------------------------------
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
