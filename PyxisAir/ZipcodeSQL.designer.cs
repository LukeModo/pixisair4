namespace PyxisAir
{
    partial class ZipcodeSQL
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrderAndDescSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrderAndDescDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipcodeDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAndReturnToMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(292, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 394);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "List All Zipcodes in Table ZIPCODE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(69, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 25);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(69, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 25);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
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
            this.zipcodeDB2ToolStripMenuItem,
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
            // zipcodeDB2ToolStripMenuItem
            // 
            this.zipcodeDB2ToolStripMenuItem.Name = "zipcodeDB2ToolStripMenuItem";
            this.zipcodeDB2ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.zipcodeDB2ToolStripMenuItem.Text = "ZipcodeDB2";
            this.zipcodeDB2ToolStripMenuItem.Click += new System.EventHandler(this.zipcodeDB2ToolStripMenuItem_Click);
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
            this.btnReturnToMain.Location = new System.Drawing.Point(68, 264);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(134, 36);
            this.btnReturnToMain.TabIndex = 18;
            this.btnReturnToMain.Text = "Return to Main Form";
            this.btnReturnToMain.UseVisualStyleBackColor = true;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // ZipcodeSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZipcodeSQL";
            this.Text = "ZipcodeSQL - LeAir";
            this.Load += new System.EventHandler(this.ZipcodeSQL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workOrderAndDescSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workOrderAndDescDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipcodeDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAndReturnToMainFormToolStripMenuItem;
        private System.Windows.Forms.Button btnReturnToMain;
    }
}