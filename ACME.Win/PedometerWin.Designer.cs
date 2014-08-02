namespace ACME.Win
{
    partial class PedometerWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStepGoalToday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfStepsToday = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step Goal For Today";
            // 
            // txtStepGoalToday
            // 
            this.txtStepGoalToday.Location = new System.Drawing.Point(150, 27);
            this.txtStepGoalToday.Name = "txtStepGoalToday";
            this.txtStepGoalToday.Size = new System.Drawing.Size(186, 20);
            this.txtStepGoalToday.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Steps Today";
            // 
            // txtNumberOfStepsToday
            // 
            this.txtNumberOfStepsToday.Location = new System.Drawing.Point(150, 59);
            this.txtNumberOfStepsToday.Name = "txtNumberOfStepsToday";
            this.txtNumberOfStepsToday.Size = new System.Drawing.Size(186, 20);
            this.txtNumberOfStepsToday.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(343, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 60);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(22, 117);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 5;
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 216);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumberOfStepsToday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStepGoalToday);
            this.Controls.Add(this.label1);
            this.Name = "PedometerWin";
            this.Text = "PedometerWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStepGoalToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfStepsToday;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label ResultLabel;
    }
}