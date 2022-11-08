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
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlanes
            // 
            this.btnPlanes.Location = new System.Drawing.Point(65, 34);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(118, 52);
            this.btnPlanes.TabIndex = 0;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMaint
            // 
            this.btnMaint.Location = new System.Drawing.Point(65, 108);
            this.btnMaint.Name = "btnMaint";
            this.btnMaint.Size = new System.Drawing.Size(118, 52);
            this.btnMaint.TabIndex = 2;
            this.btnMaint.Text = "Maintenance Logs";
            this.btnMaint.UseVisualStyleBackColor = true;
            this.btnMaint.Click += new System.EventHandler(this.btnMaint_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMaint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlanes);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMaint;
        private System.Windows.Forms.Button button4;
    }
}