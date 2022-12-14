using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//*********************************************************************************
// Assignment: Pixis Air Group Project: Team 4 Option 8 in SQL
// Date:       November 21, 2022
// Name:       Jessica Narlock
// Purpose:    This form will use SQL. The form will prompt the user to enter
//              a Plane Number, and once it is entered (if it is a valid number
//              in the dbo.Airplane table), we will press the button and the 
//              listbox will display that Plane Number's Airport. There is also
//              a Clear and Return to Main Form button, and there is a menuStrip
//              that will allow the user to exit the program, close form and 
//              return to main form, and a Display tab that will allow the other
//              forms to be opened there as well.
//**********************************************************************************

namespace PyxisAir
{
    public partial class PlaneNoAndAirportSQL_JN : Form
    {
        //declare class level variables
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public PlaneNoAndAirportSQL_JN()
        {
            InitializeComponent();
        }

        private void PlaneNoAndAirportSQL_JN_Load(object sender, EventArgs e)
        {
            //Set connection string in the load, since we will use it for all of the buttons
            connectionString = "Data Source=V2STUDENTPOC;Initial Catalog=PixisAir;" +
                "User ID=Student;Password=ichooseGateway";

            //set SQL statement (we will replace this in each button)
            SQL = "Select * FROM dbo.Airplane";

            //set and instantiate connection, dataAdapter, and dataSet
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void SeeAirportButton_Click(object sender, EventArgs e)
        {
            //reset dataSet
            dataSet = new DataSet();

            //set SQL statement for this button
            //We need PlaneNo and APARCD from dbo.Airplane
            //Where PlaneNo = input text in textbox only
            SQL = "SELECT PlaneNo,APARCD FROM dbo.Airplane WHERE PlaneNo='" +
                    txtPlaneNo.Text + "' ";

            //use try/catch block for error handling
            try
            {
                connection.Open(); //open connection
                dataAdapter.SelectCommand.CommandText = SQL; //set command text to SQL
                dataAdapter.Fill(dataSet); //fill dataAdapter with dataSet

                //use foreach loop to write out the relevant data to the listbox
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    lstDisplay.Items.Add("Plane Number: " + dataRow[0] +
                        "   |   Airport: " + dataRow[1]);
                }

                connection.Close(); //close connection
            }
            catch (Exception ex)
            {
                //Errors will display in the listbox
                lstDisplay.Items.Add(ex.Message);
            }
        }

        //Clear button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtPlaneNo.Text = "";
            lstDisplay.Items.Clear();
        }

        //Return to Main Form Button
        private void ReturnToMainButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        //Exit Program button from file menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Return to Main Form from file menu
        private void closeReturnToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        //Open PlaneNoAndAirportDB2 form
        private void planeNoAirportDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaneNoAndAirportDB2_JN planeNoAndAirportDB2 = new PlaneNoAndAirportDB2_JN();
            planeNoAndAirportDB2.Show();
            this.Hide();
        }

        //Open AllMaintenanceLogsSQL_JN form
        private void displayAllMaintenanceLogsSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsSQL_JN allMaintSQL = new AllMaintenanceLogsSQL_JN();
            allMaintSQL.Show();
            this.Hide();
        }

        //Exit Button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Return to Main Form from display menu
        private void closeAndReturnToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        //Open AllMaintenanceLogsDB2_JN form
        private void displayAllMaintenanceLogsDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsDB2_JN allMaintDB2 = new AllMaintenanceLogsDB2_JN();
            allMaintDB2.Show();
            this.Hide();
        }
    }
}
