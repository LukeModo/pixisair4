//*************************************************************************************
//Written By: Luke Modory
//Date: 11/21/22
//This program takes a plane number entry by the user and returns its maintenance logs using DB2
//*************************************************************************************
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

namespace PyxisAir
{
    public partial class MaintenanceDB2 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;
        public MaintenanceDB2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtBoxVal = planeNoTextBox.Text;
            string connectionString = "DataSource=deathstar.gtc.edu";
            string SQL = "SELECT PLANENO,LOGNO,TASKID,MNTSTRDATE,MNTENDDATE,STATUS,MNTCOST FROM MAINTLOG WHERE PLANENO LIKE '" + txtBoxVal + "'"; ;

            try
            {
                dataGridView1.DataSource = bindingSource1;

                dataAdapter = new iDB2DataAdapter(SQL, connectionString);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(dataAdapter);
                table = new DataTable();

                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

            }
            catch (Exception ex)
            {
                planeNoTextBox.Text = ex.Message;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaintenanceDB2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this, "Are you sure? ", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaintenanceDB2_Load(object sender, EventArgs e)
        {

        }
    }
}
