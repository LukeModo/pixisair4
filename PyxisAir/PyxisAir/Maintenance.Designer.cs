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
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(125, 65);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(140, 68);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // maintListBox
            // 
            this.maintListBox.FormattingEnabled = true;
            this.maintListBox.Location = new System.Drawing.Point(417, 28);
            this.maintListBox.Name = "maintListBox";
            this.maintListBox.Size = new System.Drawing.Size(325, 368);
            this.maintListBox.TabIndex = 1;
            // 
            // planeNoTextBox
            // 
            this.planeNoTextBox.Location = new System.Drawing.Point(64, 252);
            this.planeNoTextBox.Name = "planeNoTextBox";
            this.planeNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.planeNoTextBox.TabIndex = 2;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.planeNoTextBox);
            this.Controls.Add(this.maintListBox);
            this.Controls.Add(this.btnInsert);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox maintListBox;
        private System.Windows.Forms.TextBox planeNoTextBox;
    }
}