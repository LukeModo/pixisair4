namespace PyxisAir
{
    partial class PlaneNoAndAirportSQL_JN
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeReturnToMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceLogsSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceLogsDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SeeAirportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaneNo = new System.Windows.Forms.TextBox();
            this.ReturnToMainButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.planeNoAirportDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllMaintenanceLogsSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllMaintenanceLogsDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.closeReturnToMainFormToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exitToolStripMenuItem.Text = "Exit Program";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.planesToolStripMenuItem,
            this.planesDB2ToolStripMenuItem,
            this.maintenanceLogsSQLToolStripMenuItem,
            this.maintenanceLogsDB2ToolStripMenuItem,
            this.planeNoAirportDB2ToolStripMenuItem,
            this.displayAllMaintenanceLogsSQLToolStripMenuItem,
            this.displayAllMaintenanceLogsDB2ToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.planesToolStripMenuItem.Text = "Planes SQL";
            this.planesToolStripMenuItem.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
            // 
            // planesDB2ToolStripMenuItem
            // 
            this.planesDB2ToolStripMenuItem.Name = "planesDB2ToolStripMenuItem";
            this.planesDB2ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.planesDB2ToolStripMenuItem.Text = "Planes DB2";
            this.planesDB2ToolStripMenuItem.Click += new System.EventHandler(this.planesDB2ToolStripMenuItem_Click);
            // 
            // maintenanceLogsSQLToolStripMenuItem
            // 
            this.maintenanceLogsSQLToolStripMenuItem.Name = "maintenanceLogsSQLToolStripMenuItem";
            this.maintenanceLogsSQLToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.maintenanceLogsSQLToolStripMenuItem.Text = "Maintenance Logs SQL";
            this.maintenanceLogsSQLToolStripMenuItem.Click += new System.EventHandler(this.maintenanceLogsSQLToolStripMenuItem_Click);
            // 
            // maintenanceLogsDB2ToolStripMenuItem
            // 
            this.maintenanceLogsDB2ToolStripMenuItem.Name = "maintenanceLogsDB2ToolStripMenuItem";
            this.maintenanceLogsDB2ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.maintenanceLogsDB2ToolStripMenuItem.Text = "Maintenance Logs DB2";
            this.maintenanceLogsDB2ToolStripMenuItem.Click += new System.EventHandler(this.maintenanceLogsDB2ToolStripMenuItem_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(253, 56);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(306, 355);
            this.lstDisplay.TabIndex = 1;
            // 
            // SeeAirportButton
            // 
            this.SeeAirportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeAirportButton.Location = new System.Drawing.Point(34, 227);
            this.SeeAirportButton.Name = "SeeAirportButton";
            this.SeeAirportButton.Size = new System.Drawing.Size(184, 39);
            this.SeeAirportButton.TabIndex = 2;
            this.SeeAirportButton.Text = "&See Airport for Plane";
            this.SeeAirportButton.UseVisualStyleBackColor = true;
            this.SeeAirportButton.Click += new System.EventHandler(this.SeeAirportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter a Plane Number:";
            // 
            // txtPlaneNo
            // 
            this.txtPlaneNo.Location = new System.Drawing.Point(34, 173);
            this.txtPlaneNo.Name = "txtPlaneNo";
            this.txtPlaneNo.Size = new System.Drawing.Size(184, 20);
            this.txtPlaneNo.TabIndex = 4;
            // 
            // ReturnToMainButton
            // 
            this.ReturnToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToMainButton.Location = new System.Drawing.Point(613, 368);
            this.ReturnToMainButton.Name = "ReturnToMainButton";
            this.ReturnToMainButton.Size = new System.Drawing.Size(141, 43);
            this.ReturnToMainButton.TabIndex = 5;
            this.ReturnToMainButton.Text = "&Return to Main Form\r\n";
            this.ReturnToMainButton.UseVisualStyleBackColor = true;
            this.ReturnToMainButton.Click += new System.EventHandler(this.ReturnToMainButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(613, 309);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(141, 39);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // planeNoAirportDB2ToolStripMenuItem
            // 
            this.planeNoAirportDB2ToolStripMenuItem.Name = "planeNoAirportDB2ToolStripMenuItem";
            this.planeNoAirportDB2ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.planeNoAirportDB2ToolStripMenuItem.Text = "Plane No. And Airport DB2";
            this.planeNoAirportDB2ToolStripMenuItem.Click += new System.EventHandler(this.planeNoAirportDB2ToolStripMenuItem_Click);
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
            // PlaneNoAndAirportSQL_JN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ReturnToMainButton);
            this.Controls.Add(this.txtPlaneNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeeAirportButton);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlaneNoAndAirportSQL_JN";
            this.Text = "PlaneNoAndAirportSQL_JN";
            this.Load += new System.EventHandler(this.PlaneNoAndAirportSQL_JN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button SeeAirportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaneNo;
        private System.Windows.Forms.Button ReturnToMainButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ToolStripMenuItem closeReturnToMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceLogsSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceLogsDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeNoAirportDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllMaintenanceLogsSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllMaintenanceLogsDB2ToolStripMenuItem;
    }
}