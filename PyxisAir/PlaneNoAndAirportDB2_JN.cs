using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//**************************************************************************************
// Assignment: Pixis Air Group Project: Team 4 Option 8 in DB2
// Date:       November 21, 2022
// Name:       Jessica Narlock
// Purpose:    This form will use DB2. The form will prompt the user to enter
//              a Plane Number, and once it is entered (if it is a valid number
//              in the AIRPLANE table), we will press the button and the 
//              listbox will display that Plane Number's Airport. There is also
//              a Clear Error and Return to Main Form button, and there is a menuStrip
//              that will allow the user to exit the program, close form and 
//              return to main form, and a Display tab that will allow the other
//              forms to be opened there as well.
//***************************************************************************************

namespace PyxisAir
{
    public partial class PlaneNoAndAirportDB2_JN : Form
    {
        private BindingSource bindingSource = new BindingSource();
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;

        public PlaneNoAndAirportDB2_JN()
        {
            InitializeComponent();
        }

        private void PlaneNoAndAirportDB2_JN_Load(object sender, EventArgs e)
        {

        }

        private void SeeAirportButton_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                sql = "SELECT APARCD FROM AIRPLANE WHERE PlaneNo = '" +
                    txtPlaneNo.Text + "' ";

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
            txtPlaneNo.Text = "";
            txtError.Text = "";
        }

        private void ReturnToMainButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
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
            this.Close();
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

        private void maintenanceSQLToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void planeNoAirportSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaneNoAndAirportSQL_JN planeNoAndAirportSQL = new PlaneNoAndAirportSQL_JN();
            planeNoAndAirportSQL.Show();
            this.Hide();
        }

        private void displayAllMaintenanceLogsSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsSQL_JN allMaintSQL = new AllMaintenanceLogsSQL_JN();
            allMaintSQL.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
