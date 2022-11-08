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
            SQL = "SELECT DATEMAINT,MAINTMILES FROM dbo.Airplane WHERE PLANENO = PlaneNoTextBox.getText()";
            try
            {
                connection.Open();
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    maintListBox.Items.Add("Maintenance Log: " + dataRow[0]);
                connection.Close();
            }
            catch (Exception ex)
            {
                maintListBox.Items.Add(ex.Message);
            }
        }
    }
}
