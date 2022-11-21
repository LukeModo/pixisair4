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
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SeeAirportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaneNo = new System.Windows.Forms.TextBox();
            this.ReturnToMainButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
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
            this.SeeAirportButton.Location = new System.Drawing.Point(59, 227);
            this.SeeAirportButton.Name = "SeeAirportButton";
            this.SeeAirportButton.Size = new System.Drawing.Size(159, 39);
            this.SeeAirportButton.TabIndex = 2;
            this.SeeAirportButton.Text = "See Airport for Plane";
            this.SeeAirportButton.UseVisualStyleBackColor = true;
            this.SeeAirportButton.Click += new System.EventHandler(this.SeeAirportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter a Plane Number:";
            // 
            // txtPlaneNo
            // 
            this.txtPlaneNo.Location = new System.Drawing.Point(59, 173);
            this.txtPlaneNo.Name = "txtPlaneNo";
            this.txtPlaneNo.Size = new System.Drawing.Size(146, 20);
            this.txtPlaneNo.TabIndex = 4;
            // 
            // ReturnToMainButton
            // 
            this.ReturnToMainButton.Location = new System.Drawing.Point(634, 274);
            this.ReturnToMainButton.Name = "ReturnToMainButton";
            this.ReturnToMainButton.Size = new System.Drawing.Size(98, 43);
            this.ReturnToMainButton.TabIndex = 5;
            this.ReturnToMainButton.Text = "Return to Main Form\r\n";
            this.ReturnToMainButton.UseVisualStyleBackColor = true;
            this.ReturnToMainButton.Click += new System.EventHandler(this.ReturnToMainButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(634, 227);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(98, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PlaneNoAndAirportSQL_JN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}