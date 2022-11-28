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

namespace PixisAirJobs
{
    public partial class JobType : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        
        public JobType()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=V2STUDENTPOC;Initial Catalog=PixisAir;" +
                "User ID=Student;Password=ichooseGateway";
            SQL = "Select * From dbo.JobType";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet = new DataSet();

            SQL = "SELECT JTID, JTCD, JTTINYNM, JTNM,JTDESC FROM dbo.JobType";
            try
            {
                connection.Open();  
                dataAdapter.SelectCommand.CommandText= SQL;
                dataAdapter.Fill(dataSet);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add("Job Type" + dataRow[0] + dataRow[1] + dataRow[2] + dataRow[3] + dataRow[4]);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                
        }
    }
}
