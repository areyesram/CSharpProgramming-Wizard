﻿namespace areyesram.Steps
{
    partial class Step2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "When were you born?";
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDOB.Location = new System.Drawing.Point(57, 83);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(200, 37);
            this.dateTimeDOB.TabIndex = 2;
            // 
            // Step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimeDOB);
            this.Controls.Add(this.label1);
            this.Name = "Step2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
    }
}
