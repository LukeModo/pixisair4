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
            this.button2 = new System.Windows.Forms.Button();
            this.btnMaint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlanesDB2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlanes
            // 
            this.btnPlanes.Location = new System.Drawing.Point(78, 65);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(118, 52);
            this.btnPlanes.TabIndex = 0;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMaint
            // 
            this.btnMaint.Location = new System.Drawing.Point(214, 65);
            this.btnMaint.Name = "btnMaint";
            this.btnMaint.Size = new System.Drawing.Size(118, 52);
            this.btnMaint.TabIndex = 2;
            this.btnMaint.Text = "Maintenance Logs";
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
            this.btnPlanesDB2.Text = "Planes DB2";
            this.btnPlanesDB2.UseVisualStyleBackColor = true;
            this.btnPlanesDB2.Click += new System.EventHandler(this.btnPlanesDB2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Maintenance DB2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planesToolStripMenuItem,
            this.planesDB2ToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.maintenanceDB2ToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planesToolStripMenuItem.Text = "Planes";
            this.planesToolStripMenuItem.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
            // 
            // planesDB2ToolStripMenuItem
            // 
            this.planesDB2ToolStripMenuItem.Name = "planesDB2ToolStripMenuItem";
            this.planesDB2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planesDB2ToolStripMenuItem.Text = "PlanesDB2";
            this.planesDB2ToolStripMenuItem.Click += new System.EventHandler(this.planesDB2ToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // maintenanceDB2ToolStripMenuItem
            // 
            this.maintenanceDB2ToolStripMenuItem.Name = "maintenanceDB2ToolStripMenuItem";
            this.maintenanceDB2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maintenanceDB2ToolStripMenuItem.Text = "Maintenance DB2";
            this.maintenanceDB2ToolStripMenuItem.Click += new System.EventHandler(this.maintenanceDB2ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPlanesDB2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMaint);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMaint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlanesDB2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}