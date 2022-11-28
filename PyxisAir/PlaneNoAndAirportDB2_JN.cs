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
        //declare class level variables
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
                //Instantiate connection string
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                //set SQL statement
                sql = "SELECT APARCD FROM AIRPLANE WHERE PlaneNo = '" +
                    txtPlaneNo.Text + "' ";

                //bind dataGridView1's data source to bindingSource
                dataGridView1.DataSource = bindingSource;
                adapter = new iDB2DataAdapter(sql, conn);

                //Use adapter to set up the commandBuilder, and create data table
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(adapter);
                DataTable table = new DataTable(); 

                //Fill the adapter with table, and set bindingSource's 
                //Data Source to table.
                adapter.Fill(table);
                bindingSource.DataSource = table;

                //close connection
                conn.Close();
            }
            catch (Exception ex)
            {
                //Error messages will display in the txtError textbox at the
                // bottom of the form.
                txtError.Text = ex.Message;
            }
        }

        //Clear textboxes
        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtPlaneNo.Text = "";
            txtError.Text = "";
        }

        //Return to Main Form button
        private void ReturnToMainButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        //Exit Program Button from menustrip
        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Return to Main Form button from menustrip
        private void closeReturnToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        //Open PlaneNoAndAirportSQL form
        private void planeNoAirportSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaneNoAndAirportSQL_JN planeNoAndAirportSQL = new PlaneNoAndAirportSQL_JN();
            planeNoAndAirportSQL.Show();
            this.Hide();
        }

        //Open AllMaintenanceLogsSQL form
        private void displayAllMaintenanceLogsSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsSQL_JN allMaintSQL = new AllMaintenanceLogsSQL_JN();
            allMaintSQL.Show();
            this.Hide();
        }

        //Exit Button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPlaneNo_TextChanged(object sender, EventArgs e)
        {

        }

        //Return to Main Form in display menu
        private void closeAndReturnToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        //Open AllMaintenanceLogsSQL form
        private void displayAllMaintenanceLogsDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsDB2_JN allMaintDB2 = new AllMaintenanceLogsDB2_JN();
            allMaintDB2.Show();
            this.Hide();
        }
    }
}
