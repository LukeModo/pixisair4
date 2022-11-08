namespace PyxisAir
{
    partial class Form1
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
            this.PlaneListBox = new System.Windows.Forms.ListBox();
            this.btnMaint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlanes
            // 
            this.btnPlanes.Location = new System.Drawing.Point(54, 174);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(129, 62);
            this.btnPlanes.TabIndex = 0;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // PlaneListBox
            // 
            this.PlaneListBox.FormattingEnabled = true;
            this.PlaneListBox.Location = new System.Drawing.Point(250, 2);
            this.PlaneListBox.Name = "PlaneListBox";
            this.PlaneListBox.Size = new System.Drawing.Size(280, 446);
            this.PlaneListBox.TabIndex = 1;
            // 
            // btnMaint
            // 
            this.btnMaint.Location = new System.Drawing.Point(702, 12);
            this.btnMaint.Name = "btnMaint";
            this.btnMaint.Size = new System.Drawing.Size(86, 21);
            this.btnMaint.TabIndex = 2;
            this.btnMaint.Text = "Main Form";
            this.btnMaint.UseVisualStyleBackColor = true;
            this.btnMaint.Click += new System.EventHandler(this.btnMaint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(702, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 21);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMaint);
            this.Controls.Add(this.PlaneListBox);
            this.Controls.Add(this.btnPlanes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.ListBox PlaneListBox;
        private System.Windows.Forms.Button btnMaint;
        private System.Windows.Forms.Button btnExit;
    }
}

