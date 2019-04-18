using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BeenTogether
{
    public partial class frmLoaing : Form
    {
        public frmLoaing()
        {
            InitializeComponent();
        }

        private void frmLoaing_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                lblLoader.Text = "Loading " + i + "%...";
                lblLoader.Refresh();
                Thread.Sleep(5);

                if (i == 100)
                {
                    lblLoader.Text = "Start....";


                    timer1.Stop();

                    frmMain fmain = new frmMain();
                    this.Hide();
                    fmain.Show();

                }
            }

        }
    }
}
