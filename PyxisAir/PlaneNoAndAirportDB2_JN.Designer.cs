namespace PyxisAir
{
    partial class PlaneNoAndAirportDB2_JN
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaneNo = new System.Windows.Forms.TextBox();
            this.SeeAirportButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeReturnToMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceLogsDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeNoAirportSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllMaintenanceLogsSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllMaintenanceLogsDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ReturnToMainButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtError = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter a Plane Number:";
            // 
            // txtPlaneNo
            // 
            this.txtPlaneNo.Location = new System.Drawing.Point(36, 144);
            this.txtPlaneNo.Name = "txtPlaneNo";
            this.txtPlaneNo.Size = new System.Drawing.Size(184, 20);
            this.txtPlaneNo.TabIndex = 2;
            // 
            // SeeAirportButton
            // 
            this.SeeAirportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeAirportButton.Location = new System.Drawing.Point(36, 250);
            this.SeeAirportButton.Name = "SeeAirportButton";
            this.SeeAirportButton.Size = new System.Drawing.Size(184, 45);
            this.SeeAirportButton.TabIndex = 3;
            this.SeeAirportButton.Text = "&See Airport for Plane";
            this.SeeAirportButton.UseVisualStyleBackColor = true;
            this.SeeAirportButton.Click += new System.EventHandler(this.SeeAirportButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitProgramToolStripMenuItem,
            this.closeReturnToMainFormToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // closeReturnToMainFormToolStripMenuItem
            // 
            this.closeReturnToMainFormToolStripMenuItem.Name = "closeReturnToMainFormToolStripMenuItem";
            this.closeReturnToMainFormToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.closeReturnToMainFormToolStripMenuItem.Text = "Close & Return to Main Form";
            this.closeReturnToMainFormToolStripMenuItem.Click += new System.EventHandler(this.closeReturnToMainFormToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planesSQLToolStripMenuItem,
            this.planesDB2ToolStripMenuItem,
            this.maintenanceSQLToolStripMenuItem,
            this.maintenanceLogsDB2ToolStripMenuItem,
            this.planeNoAirportSQLToolStripMenuItem,
            this.displayAllMaintenanceLogsSQLToolStripMenuItem,
            this.displayAllMaintenanceLogsDB2ToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // planesSQLToolStripMenuItem
            // 
            this.planesSQLToolStripMenuItem.Name = "planesSQLToolStripMenuItem";
            this.planesSQLToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.planesSQLToolStripMenuItem.Text = "Planes SQL";
            this.planesSQLToolStripMenuItem.Click += new System.EventHandler(this.planesSQLToolStripMenuItem_Click);
            // 
            // planesDB2ToolStripMenuItem
            // 
            this.planesDB2ToolStripMenuItem.Name = "planesDB2ToolStripMenuItem";
            this.planesDB2ToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.planesDB2ToolStripMenuItem.Text = "Planes DB2";
            this.planesDB2ToolStripMenuItem.Click += new System.EventHandler(this.planesDB2ToolStripMenuItem_Click);
            // 
            // maintenanceSQLToolStripMenuItem
            // 
            this.maintenanceSQLToolStripMenuItem.Name = "maintenanceSQLToolStripMenuItem";
            this.maintenanceSQLToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.maintenanceSQLToolStripMenuItem.Text = "Maintenance Logs SQL";
            this.maintenanceSQLToolStripMenuItem.Click += new System.EventHandler(this.maintenanceSQLToolStripMenuItem_Click);
            // 
            // maintenanceLogsDB2ToolStripMenuItem
            // 
            this.maintenanceLogsDB2ToolStripMenuItem.Name = "maintenanceLogsDB2ToolStripMenuItem";
            this.maintenanceLogsDB2ToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.maintenanceLogsDB2ToolStripMenuItem.Text = "Maintenance Logs DB2";
            this.maintenanceLogsDB2ToolStripMenuItem.Click += new System.EventHandler(this.maintenanceLogsDB2ToolStripMenuItem_Click);
            // 
            // planeNoAirportSQLToolStripMenuItem
            // 
            this.planeNoAirportSQLToolStripMenuItem.Name = "planeNoAirportSQLToolStripMenuItem";
            this.planeNoAirportSQLToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.planeNoAirportSQLToolStripMenuItem.Text = "Plane No And Airport SQL";
            this.planeNoAirportSQLToolStripMenuItem.Click += new System.EventHandler(this.planeNoAirportSQLToolStripMenuItem_Click);
            // 
            // displayAllMaintenanceLogsSQLToolStripMenuItem
            // 
            this.displayAllMaintenanceLogsSQLToolStripMenuItem.Name = "displayAllMaintenanceLogsSQLToolStripMenuItem";
            this.displayAllMaintenanceLogsSQLToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.displayAllMaintenanceLogsSQLToolStripMenuItem.Text = "Display All Maintenance Logs SQL";
            this.displayAllMaintenanceLogsSQLToolStripMenuItem.Click += new System.EventHandler(this.displayAllMaintenanceLogsSQLToolStripMenuItem_Click);
            // 
            // displayAllMaintenanceLogsDB2ToolStripMenuItem
            // 
            this.displayAllMaintenanceLogsDB2ToolStripMenuItem.Name = "displayAllMaintenanceLogsDB2ToolStripMenuItem";
            this.displayAllMaintenanceLogsDB2ToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.displayAllMaintenanceLogsDB2ToolStripMenuItem.Text = "Display All Maintenance Logs DB2";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(604, 236);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(173, 45);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ReturnToMainButton
            // 
            this.ReturnToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToMainButton.Location = new System.Drawing.Point(604, 348);
            this.ReturnToMainButton.Name = "ReturnToMainButton";
            this.ReturnToMainButton.Size = new System.Drawing.Size(173, 45);
            this.ReturnToMainButton.TabIndex = 6;
            this.ReturnToMainButton.Text = "Return to Main Form";
            this.ReturnToMainButton.UseVisualStyleBackColor = true;
            this.ReturnToMainButton.Click += new System.EventHandler(this.ReturnToMainButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(317, 350);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(13, 418);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(764, 20);
            this.txtError.TabIndex = 8;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(604, 292);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(173, 45);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "&Exit Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlaneNoAndAirportDB2_JN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReturnToMainButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SeeAirportButton);
            this.Controls.Add(this.txtPlaneNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlaneNoAndAirportDB2_JN";
            this.Text = "PlaneNoAndAirportDB2_JN";
            this.Load += new System.EventHandler(this.PlaneNoAndAirportDB2_JN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaneNo;
        private System.Windows.Forms.Button SeeAirportButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeReturnToMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ReturnToMainButton;
        private System.Windows.Forms.ToolStripMenuItem planesSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceLogsDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeNoAirportSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllMaintenanceLogsSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllMaintenanceLogsDB2ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Button ExitButton;
    }
}