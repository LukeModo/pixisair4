namespace PyxisAir
{
    partial class ZipcodeDB2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrderAndDescSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrderAndDescDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipcodeSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.closeAndReturnToMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "List All Zipcodes in Table ZIPCODE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 385);
            this.dataGridView1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workOrderAndDescSQLToolStripMenuItem,
            this.workOrderAndDescDB2ToolStripMenuItem,
            this.zipcodeSQLToolStripMenuItem,
            this.closeAndReturnToMainFormToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // workOrderAndDescSQLToolStripMenuItem
            // 
            this.workOrderAndDescSQLToolStripMenuItem.Name = "workOrderAndDescSQLToolStripMenuItem";
            this.workOrderAndDescSQLToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.workOrderAndDescSQLToolStripMenuItem.Text = "WorkOrderAndDescSQL";
            this.workOrderAndDescSQLToolStripMenuItem.Click += new System.EventHandler(this.workOrderAndDescSQLToolStripMenuItem_Click);
            // 
            // workOrderAndDescDB2ToolStripMenuItem
            // 
            this.workOrderAndDescDB2ToolStripMenuItem.Name = "workOrderAndDescDB2ToolStripMenuItem";
            this.workOrderAndDescDB2ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.workOrderAndDescDB2ToolStripMenuItem.Text = "WorkOrderAndDescDB2";
            this.workOrderAndDescDB2ToolStripMenuItem.Click += new System.EventHandler(this.workOrderAndDescDB2ToolStripMenuItem_Click);
            // 
            // zipcodeSQLToolStripMenuItem
            // 
            this.zipcodeSQLToolStripMenuItem.Name = "zipcodeSQLToolStripMenuItem";
            this.zipcodeSQLToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.zipcodeSQLToolStripMenuItem.Text = "ZipcodeSQL";
            this.zipcodeSQLToolStripMenuItem.Click += new System.EventHandler(this.zipcodeSQLToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(748, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(52, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(52, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 25);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Textbox";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // closeAndReturnToMainFormToolStripMenuItem
            // 
            this.closeAndReturnToMainFormToolStripMenuItem.Name = "closeAndReturnToMainFormToolStripMenuItem";
            this.closeAndReturnToMainFormToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.closeAndReturnToMainFormToolStripMenuItem.Text = "Close and Return to Main Form";
            this.closeAndReturnToMainFormToolStripMenuItem.Click += new System.EventHandler(this.closeAndReturnToMainFormToolStripMenuItem_Click);
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.Location = new System.Drawing.Point(52, 268);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(134, 36);
            this.btnReturnToMain.TabIndex = 18;
            this.btnReturnToMain.Text = "Return to Main Form";
            this.btnReturnToMain.UseVisualStyleBackColor = true;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // ZipcodeDB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZipcodeDB2";
            this.Text = "ZipcodeDB2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workOrderAndDescSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workOrderAndDescDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipcodeSQLToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem closeAndReturnToMainFormToolStripMenuItem;
        private System.Windows.Forms.Button btnReturnToMain;
    }
}