﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PyxisProject4_LeAir
{
    public partial class WorkOrderAndDescSQL : Form
    {

        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        public WorkOrderAndDescSQL()
        {
            InitializeComponent();
        }

      
        private void WorkOrderAndDescSQL_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=V2STUDENTPOC;Initial Catalog=PixisAir;" +
                "User ID=Student;Password=ichooseGateway";

            SQL = "SELECT * FROM dbo.Tasks";

            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataSet = new DataSet();

            SQL = "SELECT TASKID,TASKDESC FROM dbo.Tasks WHERE TASKID='"+
            textBox1.Text + "' ";
            try
            {
                connection.Open(); //open connection
                dataAdapter.SelectCommand.CommandText = SQL; //set command text to SQL
                dataAdapter.Fill(dataSet); //fill dataAdapter with dataSet

                //use foreach loop to write out the relevant data to the listbox
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add(dataRow[0] + ", " + dataRow[1]);
                connection.Close(); //close connection
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeAndReturnToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
