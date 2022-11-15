using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PyxisAir
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=V2StudentPOC;Initial Catalog=PixisAir;" +
                "Persist Security Info=True;User ID=Student;Password=ichooseGateway";
            SQL = "Select * FROM Sales.SalesTerritory";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            PlaneListBox.Items.Clear();
            dataSet = new DataSet();
            SQL = "SELECT PMake,PlaneModel FROM dbo.Airplane  ";
            try
            {
                connection.Open();
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    PlaneListBox.Items.Add("Make: " + dataRow[0] + "  Model: " + dataRow[1]);
                connection.Close();
            }
            catch (Exception ex)
            {
                PlaneListBox.Items.Add(ex.Message);
            }
        }

        private void btnMaint_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this, "Are you sure? ", "Quit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PlaneListBox.Items.Clear();
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaneListBox.Items.Clear();
        }
    }
}
