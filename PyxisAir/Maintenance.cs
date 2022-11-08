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
using System.Data.SqlClient;

namespace PyxisAir
{
    public partial class Maintenance : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=V2StudentPOC;Initial Catalog=PixisAir;" +
                "Persist Security Info=True;User ID=Student;Password=ichooseGateway";
            SQL = "Select * FROM Sales.SalesTerritory";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            maintListBox.Items.Clear();
            dataSet = new DataSet();
            string txtBoxVal = planeNoTextBox.Text;
            SQL = "SELECT PLANENO,LOGMO,TASKID,MNTSTRDATE,MNTENDDATE,STATUS,MNTCOST FROM dbo.MAINTLOG WHERE PLANENO LIKE '" + txtBoxVal + "'";
            try
            {
                connection.Open();
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    maintListBox.Items.Add("Plane Number: " + dataRow[0]);
                    maintListBox.Items.Add("Log: " + dataRow[1]);
                    maintListBox.Items.Add("Task ID: " + dataRow[2]);
                    maintListBox.Items.Add("Start Maintenance Date: " + dataRow[3]);
                    maintListBox.Items.Add("End Maintenance Date: " + dataRow[4]);
                    maintListBox.Items.Add("Status: " + dataRow[5]);
                    maintListBox.Items.Add("Cost: " + dataRow[6]);
                }
                
                connection.Close();
            }
            catch (Exception ex)
            {
                maintListBox.Items.Add(ex.Message);
            }
        }

        private void Maintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this, "Are you sure? ", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
