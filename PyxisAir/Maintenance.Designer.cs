namespace PyxisAir
{
    partial class Maintenance
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.maintListBox = new System.Windows.Forms.ListBox();
            this.planeNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(201, 127);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(113, 40);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Display Log";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // maintListBox
            // 
            this.maintListBox.FormattingEnabled = true;
            this.maintListBox.Location = new System.Drawing.Point(339, 29);
            this.maintListBox.Name = "maintListBox";
            this.maintListBox.Size = new System.Drawing.Size(255, 394);
            this.maintListBox.TabIndex = 1;
            // 
            // planeNoTextBox
            // 
            this.planeNoTextBox.Location = new System.Drawing.Point(206, 202);
            this.planeNoTextBox.Name = "planeNoTextBox";
            this.planeNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.planeNoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a Plane Number";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(704, 12);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(82, 21);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Main Form";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(704, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 21);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
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
            this.mainFormToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // mainFormToolStripMenuItem
            // 
            this.mainFormToolStripMenuItem.Name = "mainFormToolStripMenuItem";
            this.mainFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainFormToolStripMenuItem.Text = "Main Form";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planeNoTextBox);
            this.Controls.Add(this.maintListBox);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Maintenance_FormClosing);
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox maintListBox;
        private System.Windows.Forms.TextBox planeNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}