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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this, "Are you sure? ", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
