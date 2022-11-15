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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PyxisAir
{
    public partial class PlanesDB2 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;
        public PlanesDB2()
        {
            InitializeComponent();
        }
        private void btnPlanes_Click(object sender, EventArgs e)
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string SQL = "SELECT PLANENO,PMake,PlaneModel FROM Airplane  ";
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
                textBox1.Text = ex.Message;
            }
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

        private void PlanesDB2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this, "Are you sure? ", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanesDB2_FormClosing_1(object sender, FormClosingEventArgs e)
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
    }
}

