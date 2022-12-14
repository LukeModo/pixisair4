namespace PyxisAir
{
    partial class MainForm
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
            this.btnPlanes = new System.Windows.Forms.Button();
            this.PlaneNoAirportSQLButton = new System.Windows.Forms.Button();
            this.btnMaint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlanesDB2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDB2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceDB2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planeNoAndAirportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeNoAndAirportDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMaintenanceLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMaintenanceLogsDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaneNoAirportDB2Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AllMaintLogsDB2Button = new System.Windows.Forms.Button();
            this.btnWorkJL = new System.Windows.Forms.Button();
            this.btnWorkDB2JL = new System.Windows.Forms.Button();
            this.btnZipcodesDB2JL = new System.Windows.Forms.Button();
            this.btnZipcodesJL = new System.Windows.Forms.Button();
            this.workOrderAndDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrderAndDescriptionDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipcodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipcodesDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlanes
            // 
            this.btnPlanes.Location = new System.Drawing.Point(78, 65);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(118, 52);
            this.btnPlanes.TabIndex = 0;
            this.btnPlanes.Text = "Planes (LM)";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // PlaneNoAirportSQLButton
            // 
            this.PlaneNoAirportSQLButton.Location = new System.Drawing.Point(347, 65);
            this.PlaneNoAirportSQLButton.Name = "PlaneNoAirportSQLButton";
            this.PlaneNoAirportSQLButton.Size = new System.Drawing.Size(118, 52);
            this.PlaneNoAirportSQLButton.TabIndex = 1;
            this.PlaneNoAirportSQLButton.Text = "Plane Number and Airport SQL (JN)";
            this.PlaneNoAirportSQLButton.UseVisualStyleBackColor = true;
            this.PlaneNoAirportSQLButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMaint
            // 
            this.btnMaint.Location = new System.Drawing.Point(214, 65);
            this.btnMaint.Name = "btnMaint";
            this.btnMaint.Size = new System.Drawing.Size(118, 52);
            this.btnMaint.TabIndex = 2;
            this.btnMaint.Text = "Maintenance Logs (LM)";
            this.btnMaint.UseVisualStyleBackColor = true;
            this.btnMaint.Click += new System.EventHandler(this.btnMaint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(711, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "This is the Main form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "You can access all other forms from here";
            // 
            // btnPlanesDB2
            // 
            this.btnPlanesDB2.Location = new System.Drawing.Point(78, 124);
            this.btnPlanesDB2.Name = "btnPlanesDB2";
            this.btnPlanesDB2.Size = new System.Drawing.Size(118, 52);
            this.btnPlanesDB2.TabIndex = 6;
            this.btnPlanesDB2.Text = "Planes DB2 (LM)";
            this.btnPlanesDB2.UseVisualStyleBackColor = true;
            this.btnPlanesDB2.Click += new System.EventHandler(this.btnPlanesDB2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Maintenance DB2 (LM)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem1
            // 
            this.displayToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planesToolStripMenuItem1,
            this.planesDB2ToolStripMenuItem1,
            this.maintenanceToolStripMenuItem1,
            this.maintenanceDB2ToolStripMenuItem1,
            this.planeNoAndAirportToolStripMenuItem,
            this.planeNoAndAirportDB2ToolStripMenuItem,
            this.allMaintenanceLogsToolStripMenuItem,
            this.allMaintenanceLogsDB2ToolStripMenuItem,
            this.workOrderAndDescriptionToolStripMenuItem,
            this.workOrderAndDescriptionDB2ToolStripMenuItem,
            this.zipcodesToolStripMenuItem,
            this.zipcodesDB2ToolStripMenuItem});
            this.displayToolStripMenuItem1.Name = "displayToolStripMenuItem1";
            this.displayToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem1.Text = "Display";
            // 
            // planesToolStripMenuItem1
            // 
            this.planesToolStripMenuItem1.Name = "planesToolStripMenuItem1";
            this.planesToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.planesToolStripMenuItem1.Text = "Planes";
            this.planesToolStripMenuItem1.Click += new System.EventHandler(this.planesToolStripMenuItem1_Click);
            // 
            // planesDB2ToolStripMenuItem1
            // 
            this.planesDB2ToolStripMenuItem1.Name = "planesDB2ToolStripMenuItem1";
            this.planesDB2ToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.planesDB2ToolStripMenuItem1.Text = "PlanesDB2";
            this.planesDB2ToolStripMenuItem1.Click += new System.EventHandler(this.planesDB2ToolStripMenuItem1_Click);
            // 
            // maintenanceToolStripMenuItem1
            // 
            this.maintenanceToolStripMenuItem1.Name = "maintenanceToolStripMenuItem1";
            this.maintenanceToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.maintenanceToolStripMenuItem1.Text = "Maintenance";
            this.maintenanceToolStripMenuItem1.Click += new System.EventHandler(this.maintenanceToolStripMenuItem1_Click);
            // 
            // maintenanceDB2ToolStripMenuItem1
            // 
            this.maintenanceDB2ToolStripMenuItem1.Name = "maintenanceDB2ToolStripMenuItem1";
            this.maintenanceDB2ToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.maintenanceDB2ToolStripMenuItem1.Text = "Maintenance DB2";
            this.maintenanceDB2ToolStripMenuItem1.Click += new System.EventHandler(this.maintenanceDB2ToolStripMenuItem1_Click);
            // 
            // planeNoAndAirportToolStripMenuItem
            // 
            this.planeNoAndAirportToolStripMenuItem.Name = "planeNoAndAirportToolStripMenuItem";
            this.planeNoAndAirportToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.planeNoAndAirportToolStripMenuItem.Text = "Plane No and Airport";
            this.planeNoAndAirportToolStripMenuItem.Click += new System.EventHandler(this.planeNoAndAirportToolStripMenuItem_Click);
            // 
            // planeNoAndAirportDB2ToolStripMenuItem
            // 
            this.planeNoAndAirportDB2ToolStripMenuItem.Name = "planeNoAndAirportDB2ToolStripMenuItem";
            this.planeNoAndAirportDB2ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.planeNoAndAirportDB2ToolStripMenuItem.Text = "Plane No and Airport DB2";
            this.planeNoAndAirportDB2ToolStripMenuItem.Click += new System.EventHandler(this.planeNoAndAirportDB2ToolStripMenuItem_Click);
            // 
            // allMaintenanceLogsToolStripMenuItem
            // 
            this.allMaintenanceLogsToolStripMenuItem.Name = "allMaintenanceLogsToolStripMenuItem";
            this.allMaintenanceLogsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.allMaintenanceLogsToolStripMenuItem.Text = "All Maintenance Logs";
            this.allMaintenanceLogsToolStripMenuItem.Click += new System.EventHandler(this.allMaintenanceLogsToolStripMenuItem_Click);
            // 
            // allMaintenanceLogsDB2ToolStripMenuItem
            // 
            this.allMaintenanceLogsDB2ToolStripMenuItem.Name = "allMaintenanceLogsDB2ToolStripMenuItem";
            this.allMaintenanceLogsDB2ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.allMaintenanceLogsDB2ToolStripMenuItem.Text = "All Maintenance Logs DB2";
            this.allMaintenanceLogsDB2ToolStripMenuItem.Click += new System.EventHandler(this.allMaintenanceLogsDB2ToolStripMenuItem_Click);
            // 
            // PlaneNoAirportDB2Button
            // 
            this.PlaneNoAirportDB2Button.Location = new System.Drawing.Point(347, 124);
            this.PlaneNoAirportDB2Button.Name = "PlaneNoAirportDB2Button";
            this.PlaneNoAirportDB2Button.Size = new System.Drawing.Size(118, 52);
            this.PlaneNoAirportDB2Button.TabIndex = 9;
            this.PlaneNoAirportDB2Button.Text = "Plane Number and Airport DB2 (JN)";
            this.PlaneNoAirportDB2Button.UseVisualStyleBackColor = true;
            this.PlaneNoAirportDB2Button.Click += new System.EventHandler(this.PlaneNoAirportDB2Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Display All Maintenance Logs SQL (JN)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AllMaintLogsDB2Button
            // 
            this.AllMaintLogsDB2Button.Location = new System.Drawing.Point(483, 124);
            this.AllMaintLogsDB2Button.Name = "AllMaintLogsDB2Button";
            this.AllMaintLogsDB2Button.Size = new System.Drawing.Size(118, 52);
            this.AllMaintLogsDB2Button.TabIndex = 11;
            this.AllMaintLogsDB2Button.Text = "Display All Maintenance Logs DB2 (JN)";
            this.AllMaintLogsDB2Button.UseVisualStyleBackColor = true;
            this.AllMaintLogsDB2Button.Click += new System.EventHandler(this.AllMaintLogsDB2Button_Click);
            // 
            // btnWorkJL
            // 
            this.btnWorkJL.Location = new System.Drawing.Point(78, 214);
            this.btnWorkJL.Name = "btnWorkJL";
            this.btnWorkJL.Size = new System.Drawing.Size(118, 53);
            this.btnWorkJL.TabIndex = 12;
            this.btnWorkJL.Text = "Work Order and Description (JL)";
            this.btnWorkJL.UseVisualStyleBackColor = true;
            this.btnWorkJL.Click += new System.EventHandler(this.btnWorkJL_Click);
            // 
            // btnWorkDB2JL
            // 
            this.btnWorkDB2JL.Location = new System.Drawing.Point(78, 273);
            this.btnWorkDB2JL.Name = "btnWorkDB2JL";
            this.btnWorkDB2JL.Size = new System.Drawing.Size(118, 53);
            this.btnWorkDB2JL.TabIndex = 13;
            this.btnWorkDB2JL.Text = "Work Order and Description DB2 (JL)";
            this.btnWorkDB2JL.UseVisualStyleBackColor = true;
            this.btnWorkDB2JL.Click += new System.EventHandler(this.btnWorkDB2JL_Click);
            // 
            // btnZipcodesDB2JL
            // 
            this.btnZipcodesDB2JL.Location = new System.Drawing.Point(214, 273);
            this.btnZipcodesDB2JL.Name = "btnZipcodesDB2JL";
            this.btnZipcodesDB2JL.Size = new System.Drawing.Size(118, 53);
            this.btnZipcodesDB2JL.TabIndex = 15;
            this.btnZipcodesDB2JL.Text = "Zipcodes DB2 (JL)";
            this.btnZipcodesDB2JL.UseVisualStyleBackColor = true;
            this.btnZipcodesDB2JL.Click += new System.EventHandler(this.btnZipcodesDB2JL_Click);
            // 
            // btnZipcodesJL
            // 
            this.btnZipcodesJL.Location = new System.Drawing.Point(214, 214);
            this.btnZipcodesJL.Name = "btnZipcodesJL";
            this.btnZipcodesJL.Size = new System.Drawing.Size(118, 53);
            this.btnZipcodesJL.TabIndex = 14;
            this.btnZipcodesJL.Text = "Zipcodes (JL)";
            this.btnZipcodesJL.UseVisualStyleBackColor = true;
            this.btnZipcodesJL.Click += new System.EventHandler(this.btnZipcodesJL_Click);
            // 
            // workOrderAndDescriptionToolStripMenuItem
            // 
            this.workOrderAndDescriptionToolStripMenuItem.Name = "workOrderAndDescriptionToolStripMenuItem";
            this.workOrderAndDescriptionToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.workOrderAndDescriptionToolStripMenuItem.Text = "Work Order and Description";
            // 
            // workOrderAndDescriptionDB2ToolStripMenuItem
            // 
            this.workOrderAndDescriptionDB2ToolStripMenuItem.Name = "workOrderAndDescriptionDB2ToolStripMenuItem";
            this.workOrderAndDescriptionDB2ToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.workOrderAndDescriptionDB2ToolStripMenuItem.Text = "Work Order and Description DB2";
            // 
            // zipcodesToolStripMenuItem
            // 
            this.zipcodesToolStripMenuItem.Name = "zipcodesToolStripMenuItem";
            this.zipcodesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.zipcodesToolStripMenuItem.Text = "Zipcodes";
            // 
            // zipcodesDB2ToolStripMenuItem
            // 
            this.zipcodesDB2ToolStripMenuItem.Name = "zipcodesDB2ToolStripMenuItem";
            this.zipcodesDB2ToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.zipcodesDB2ToolStripMenuItem.Text = "Zipcodes DB2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZipcodesDB2JL);
            this.Controls.Add(this.btnZipcodesJL);
            this.Controls.Add(this.btnWorkDB2JL);
            this.Controls.Add(this.btnWorkJL);
            this.Controls.Add(this.AllMaintLogsDB2Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PlaneNoAirportDB2Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPlanesDB2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMaint);
            this.Controls.Add(this.PlaneNoAirportSQLButton);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button PlaneNoAirportSQLButton;
        private System.Windows.Forms.Button btnMaint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlanesDB2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button PlaneNoAirportDB2Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AllMaintLogsDB2Button;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planesDB2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceDB2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planeNoAndAirportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeNoAndAirportDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allMaintenanceLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allMaintenanceLogsDB2ToolStripMenuItem;
        private System.Windows.Forms.Button btnWorkJL;
        private System.Windows.Forms.Button btnWorkDB2JL;
        private System.Windows.Forms.Button btnZipcodesDB2JL;
        private System.Windows.Forms.Button btnZipcodesJL;
        private System.Windows.Forms.ToolStripMenuItem workOrderAndDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workOrderAndDescriptionDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipcodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipcodesDB2ToolStripMenuItem;
    }
}