using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyxisAir
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMaint_Click(object sender, EventArgs e)
        {
            Maintenance maint = new Maintenance();
            maint.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlaneNoAndAirportSQL_JN planeNoAndAirportSQL = new PlaneNoAndAirportSQL_JN();
            planeNoAndAirportSQL.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this, "Are you sure? ", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnPlanesDB2_Click(object sender, EventArgs e)
        {
            PlanesDB2 planesDB = new PlanesDB2();
            planesDB.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenanceDB2 maint = new MaintenanceDB2();
            maint.Show();
            this.Hide();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlaneNoAirportDB2Button_Click(object sender, EventArgs e)
        {
            PlaneNoAndAirportDB2_JN planeNoAndAirportDB2 = new PlaneNoAndAirportDB2_JN();
            planeNoAndAirportDB2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AllMaintenanceLogsSQL_JN allMaintSQL = new AllMaintenanceLogsSQL_JN();
            allMaintSQL.Show();
            this.Hide();
        }

        private void AllMaintLogsDB2Button_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsDB2_JN allMaintDB2 = new AllMaintenanceLogsDB2_JN();
            allMaintDB2.Show();
            this.Hide();
        }

        private void planesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void planesDB2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PlanesDB2 planesDB = new PlanesDB2();
            planesDB.Show();
            this.Hide();
        }

        private void maintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Maintenance maint = new Maintenance();
            maint.Show();
            this.Hide();
        }

        private void maintenanceDB2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MaintenanceDB2 maint = new MaintenanceDB2();
            maint.Show();
            this.Hide();
        }

        private void planeNoAndAirportToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void allMaintenanceLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsSQL_JN allMaintSQL = new AllMaintenanceLogsSQL_JN();
            allMaintSQL.Show();
            this.Hide();
        }

        private void allMaintenanceLogsDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMaintenanceLogsDB2_JN allMaintDB2 = new AllMaintenanceLogsDB2_JN();
            allMaintDB2.Show();
            this.Hide();
        }
    }
}
