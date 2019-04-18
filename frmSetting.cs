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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        string PtoPath, PtoDestinP1, PtoDestinP2, PtoDestinBk, PtoNameP1, PtoNameP2, PtoNameBk;

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Call class Information
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPerson1.Text != "" & txtPerson2.Text != "" & txtChangeTitle.Text != "" & txtChangeBottomText.Text != "")
                {
                    Information info = new Information();
                    info.DataP1 = txtPerson1.Text;
                    info.DataP2 = txtPerson2.Text;
                    info.DataCt = txtChangeTitle.Text;
                    info.DataCbt = txtChangeBottomText.Text;

             /*       DateTime date = Convert.ToDateTime(dateTimePicker1);
                    info.DataDt = date.ToString("dd-MM-yyyy");
                    */
                    info.DataDt = dateTimePicker1.Text;
                    PhotoTask();
                    info.DataPto1 = PtoNameP1;
                    info.DataPto2 = PtoNameP2;
                    info.DataPto3 = PtoNameBk;

                    SaveXml.SaveData(info, "Setting.xml");

                    MessageBox.Show("Success");

                    txtPerson1.Text = "";
                    txtPerson2.Text = "";
                    txtChangeTitle.Text = "";
                    txtChangeBottomText.Text = "";

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Fill data Success", "Setting-BeenTogether", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPerson1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPerson1.Focus();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Task of Photo (PhotoTask())Function
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        string FileDir;

        void PhotoTask()
        {
            PtoPath = pictureBoxP1.ImageLocation;
            PtoNameP1 = txtPerson1.Text + "-" + (PtoPath.Substring(PtoPath.LastIndexOf('\\') + 1));
            PtoDestinP1 = FileDir + PtoNameP1;
            pictureBoxP1.Image.Save(PtoDestinP1);

            PtoPath = pictureBoxP2.ImageLocation;
            PtoNameP2 = txtPerson2.Text + "-" + (PtoPath.Substring(PtoPath.LastIndexOf('\\') + 1));
            PtoDestinP2 = FileDir + PtoNameP2;
            pictureBoxP2.Image.Save(PtoDestinP2);

            PtoPath = pictureBoxBk.ImageLocation;
            PtoNameBk = txtPerson2.Text + "-" + (PtoPath.Substring(PtoPath.LastIndexOf('\\') + 1));
            PtoDestinBk = FileDir + PtoNameBk;
            pictureBoxBk.Image.Save(PtoDestinBk);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Show photo from windwos picture
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void pictureBoxP1_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxP1.Width + 1, pictureBoxP1.Height + 1);
            Region rg = new Region(gp);
            pictureBoxP1.Region = rg;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = FileDir;
            ofd.Filter = "bmp,jpeg,png|*.bmp;*.jpg;*.png|all files|*.*";

            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBoxP1.ImageLocation = ofd.FileName;
            }
        
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Show photo from windwos picture
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void pictureBoxP2_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxP2.Width + 1, pictureBoxP2.Height + 1);
            Region rg = new Region(gp);
            pictureBoxP2.Region = rg;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = FileDir;
            ofd.Filter = "bmp,jpeg,png|*.bmp;*.jpg;*.png|all files|*.*";

            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBoxP2.ImageLocation = ofd.FileName;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Show photo from windwos picture
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void pictureBoxBk_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = FileDir;
            ofd.Filter = "bmp,jpeg,png|*.bmp;*.jpg;*.png|all files|*.*";

            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBoxBk.ImageLocation = ofd.FileName;
            }
        }

        private void frmSetting_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
