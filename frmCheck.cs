using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BeenTogether
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        DataTable dt;

        private void btnAllow_Click(object sender, EventArgs e)
        {
            
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //  This Form is Creating Table
        //  Fill in the Datatype to student Table (Column)
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------

            DataSet ds = new DataSet();
            dt = new DataTable();

            dt.Columns.Add(new DataColumn("Person1"));
            dt.Columns.Add(new DataColumn("Person2"));
            dt.Columns.Add(new DataColumn("ChangeTitle"));
            dt.Columns.Add(new DataColumn("ChangeBottomText"));
            dt.Columns.Add(new DataColumn("StartDate"));
            dt.Columns.Add(new DataColumn("Photo1"));
            dt.Columns.Add(new DataColumn("Photo2"));
            dt.Columns.Add(new DataColumn("Photo3"));

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------
            //  Data of fillRows function()
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------
            fillRows("Person1", "Person2", "ChangeTitle", "ChangeBottomText", "StartDate", "Photo1", "Photo2", "Photo3");

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Create DataSet, Setting Table.
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "Setting";
            ds.WriteXml("Setting.Xml");
            ds.WriteXmlSchema("Setting.xsd");

            frmSetting set = new frmSetting();
            set.Show();
            this.Close();

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //  FillRows function Add Row to Table
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void fillRows(string P1, string P2, string Ct, string Cbt, string DT, string Pto1, string Pto2, string Pbk)
        {
            DataRow dr;
            dr = dt.NewRow();

            dr["Person1"] = P1;
            dr["Person2"] = P2;
            dr["ChangeTitle"] = Ct;
            dr["ChangeBottomText"] = Cbt;
            dr["StartDate"] = DT;
            dr["Photo1"] = Pto1;
            dr["Photo2"] = Pto2;
            dr["Photo3"] = Pbk;
            dt.Rows.Add(dr);
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCheck_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmCheck_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
