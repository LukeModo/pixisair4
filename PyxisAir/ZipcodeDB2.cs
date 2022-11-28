using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;


namespace PyxisAir
{
    public partial class ZipcodeDB2 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public ZipcodeDB2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                sql = "SELECT * FROM ZIPCODE";
                dataGridView1.DataSource = bindingSource;
                adapter = new iDB2DataAdapter(sql, conn);

                dataset = new DataSet();
                adapter.Fill(dataset);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(adapter);
                //dataset = new DataSet();
                DataTable table = new DataTable();
                adapter.Fill(table);
                bindingSource.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                textBox1.Text= ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeAndReturnToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void workOrderAndDescSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkOrderAndDescSQL workOrder = new WorkOrderAndDescSQL();
            workOrder.Show();
            this.Hide();
        }

        private void workOrderAndDescDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkOrderAndDescDB2 workOrderDB2 = new WorkOrderAndDescDB2();
            workOrderDB2.Show();
            this.Hide();
        }

        private void zipcodeSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZipcodeSQL zipcode = new ZipcodeSQL();
            zipcode.Show();
            this.Hide();
        }

        private void ZipcodeDB2_Load(object sender, EventArgs e)
        {

        }
    }
}
