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

                lstDisplay.DataSource = bindingSource;
                adapter = new iDB2DataAdapter(sql, conn);

                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(adapter);
                DataTable table = new DataTable();

                //dataset = new DataSet();
                adapter.Fill(table);
                bindingSource.DataSource = table;

                //listBox1.Items.Clear();
                //foreach (DataRow pRow in dataset.Tables[0].Rows)

                //txtAirport.Text = pRow[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                lstDisplay.Items.Add(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtPlaneNo.Text = "";
            lstDisplay.Items.Clear();
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
    }
}
