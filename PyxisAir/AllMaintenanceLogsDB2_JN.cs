using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//************************************************************************************
// Assignment: Pixis Air Group Project: Team 4 Option 2 in DB2
// Date:       November 21, 2022
// Name:       Jessica Narlock
// Purpose:    This form will use DB2. The form will have a dataGridView that will
//              display the Maintenance Log table when the See All Maintenance Logs
//              button is pressed. Once pressed, this button will use DB2 code to 
//              select all records and fields from MAINTLOG in FLIGHT2022 and print
//              this table. There is also a Clear Error and Return to Main Form
//              button, and there is a menuStrip that will allow the user to exit
//              the program, return to main form, and a Display tab that will allow
//              the other forms to be opened there as well.            
//*************************************************************************************

namespace PyxisAir
{
    public partial class AllMaintenanceLogsDB2_JN : Form
    {
        private BindingSource bindingSource = new BindingSource();
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;

        public AllMaintenanceLogsDB2_JN()
        {
            InitializeComponent();
        }

        private void AllMaintenanceLogsDB2_JN_Load(object sender, EventArgs e)
        {

        }

        private void SeeAllMaintLogsButton_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                sql = "SELECT * FROM MAINTLOG";

                dataGridView1.DataSource = bindingSource;
                adapter = new iDB2DataAdapter(sql, conn);

                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(adapter);
                DataTable table = new DataTable();

                adapter.Fill(table);
                bindingSource.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
        }

        private void ReturnToMainButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            //this.Hide();
            this.Close();
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeReturnToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            //this.Hide();
            this.Close();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planesSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void planesDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanesDB2 planesDB = new PlanesDB2();
            planesDB.Show();
            this.Hide();
        }

        private void maintenanceLogsSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance maint = new Maintenance();
            maint.Show();
            this.Hide();
        }

        private void maintenanceLogsDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceDB2 maint = new MaintenanceDB2();
            maint.Show();
            this.Hide();
        }

        private void planeNoAndAirportSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaneNoAndAirportSQL_JN planeNoAndAirportSQL = new PlaneNoAndAirportSQL_JN();
            planeNoAndAirportSQL.Show();
            this.Hide();
        }

        private void planeNoAndAirportDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaneNoAndAirportDB2_JN planeNoAndAirportDB2 = new PlaneNoAndAirportDB2_JN();
            planeNoAndAirportDB2.Show();
            this.Hide();
        }

        private void displayAllMaintenanceLogsSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsSQL_JN allMaintSQL = new AllMaintenanceLogsSQL_JN();
            allMaintSQL.Show();
            this.Hide();
        }
    }
}
