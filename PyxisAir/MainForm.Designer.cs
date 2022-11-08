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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMaint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlanes);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
    }
}