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
    public partial class ZipcodeSQL : Form
    {

        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public ZipcodeSQL()
        {
            InitializeComponent();
        }

        private void ZipcodeSQL_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=V2STUDENTPOC;Initial Catalog=PixisAir;" +
                "User ID=Student;Password=ichooseGateway";

            

            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();

        }


        private void button1_Click(object sender, EventArgs e)
        {
                                          
            
            dataSet = new DataSet();

            SQL = "SELECT * FROM dbo.ZIPPF";

            try
            {
                connection.Open(); //open connection
                dataAdapter.SelectCommand.CommandText = SQL; //set command text to SQL
                dataAdapter.Fill(dataSet); //fill dataAdapter with dataSet

                //use foreach loop to write out the relevant data to the listbox
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2]);
                connection.Close(); //close connection
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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

        private void zipcodeDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZipcodeDB2 zipcodeDB2 = new ZipcodeDB2();
            zipcodeDB2.Show();
            this.Hide();
        }
    }
}
