namespace areyesram
{
    partial class WizardForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panelStep = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(466, 42);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.btnCancel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(186, 8);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(68, 26);
            this.panel6.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(8, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 26);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.btnBack);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(254, 8);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(68, 26);
            this.panel5.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Location = new System.Drawing.Point(8, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 26);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(322, 8);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(68, 26);
            this.panel4.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(8, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 26);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btnFinish);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(390, 8);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(68, 26);
            this.panel3.TabIndex = 0;
            // 
            // btnFinish
            // 
            this.btnFinish.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFinish.Location = new System.Drawing.Point(8, 0);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(60, 26);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // panelStep
            // 
            this.panelStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStep.Location = new System.Drawing.Point(0, 0);
            this.panelStep.Name = "panelStep";
            this.panelStep.Size = new System.Drawing.Size(466, 202);
            this.panelStep.TabIndex = 2;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 244);
            this.ControlBox = false;
            this.Controls.Add(this.panelStep);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WizardForm";
            this.Text = "Wizard";
            this.Load += new System.EventHandler(this.WizardForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelStep;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFinish;
    }
}