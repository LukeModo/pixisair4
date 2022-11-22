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

namespace PyxisAir
{
    public partial class AllMaintenanceLogsSQL_JN : Form
    {
        //declare class level variables
        private BindingSource bindingSource = new BindingSource();
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public AllMaintenanceLogsSQL_JN()
        {
            InitializeComponent();
        }

        private void AllMaintenanceLogsSQL_JN_Load(object sender, EventArgs e)
        {
            //Set connection string in the load, since we will use it for all of the buttons
            connectionString = "Data Source=V2STUDENTPOC;Initial Catalog=PixisAir;" +
                "User ID=Student;Password=ichooseGateway";

            //set SQL statement (we will replace this in each button)
            SQL = "Select * FROM dbo.MaintLog";

            //set and instantiate connection, dataAdapter, and dataSet
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void SeeMaintLogsButton_Click(object sender, EventArgs e)
        {
            //reset dataSet
            dataSet = new DataSet();

            //set SQL statement for this button
            //We need PlaneNo and APARCD from dbo.Airplane
            //Where PersonType = input text in textbox only
            SQL = "SELECT * FROM dbo.MaintLog ";

            //use try/catch block for error handling
            try
            {
                connection.Open(); //open connection

                dataGridView1.DataSource = bindingSource;
                dataAdapter = new SqlDataAdapter(SQL, connection);

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();

                dataAdapter.Fill(table);
                bindingSource.DataSource = table;

                connection.Close(); //close connection
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
    }
}
