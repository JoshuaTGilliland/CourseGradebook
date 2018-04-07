namespace CourseGradebook
{
    partial class MinimumGradeCalculator
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
            this.lblCurrentPercentage = new System.Windows.Forms.Label();
            this.lblCurrentTotalPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLowestFinalGradeDesired = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtPointsInNextAssignment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.btnDetailedReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentPercentage
            // 
            this.lblCurrentPercentage.AutoSize = true;
            this.lblCurrentPercentage.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentPercentage.Name = "lblCurrentPercentage";
            this.lblCurrentPercentage.Size = new System.Drawing.Size(128, 13);
            this.lblCurrentPercentage.TabIndex = 0;
            this.lblCurrentPercentage.Text = "Your current percentage: ";
            // 
            // lblCurrentTotalPoints
            // 
            this.lblCurrentTotalPoints.AutoSize = true;
            this.lblCurrentTotalPoints.Location = new System.Drawing.Point(12, 32);
            this.lblCurrentTotalPoints.Name = "lblCurrentTotalPoints";
            this.lblCurrentTotalPoints.Size = new System.Drawing.Size(125, 13);
            this.lblCurrentTotalPoints.TabIndex = 1;
            this.lblCurrentTotalPoints.Text = "Your current total points: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lowest final grade desired:";
            // 
            // txtLowestFinalGradeDesired
            // 
            this.txtLowestFinalGradeDesired.Location = new System.Drawing.Point(151, 53);
            this.txtLowestFinalGradeDesired.Name = "txtLowestFinalGradeDesired";
            this.txtLowestFinalGradeDesired.Size = new System.Drawing.Size(29, 20);
            this.txtLowestFinalGradeDesired.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "%";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 157);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtPointsInNextAssignment
            // 
            this.txtPointsInNextAssignment.Location = new System.Drawing.Point(151, 79);
            this.txtPointsInNextAssignment.Name = "txtPointsInNextAssignment";
            this.txtPointsInNextAssignment.Size = new System.Drawing.Size(29, 20);
            this.txtPointsInNextAssignment.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Points in Next Assignment:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 105);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(204, 46);
            this.txtAnswer.TabIndex = 9;
            this.txtAnswer.Text = "";
            // 
            // btnDetailedReport
            // 
            this.btnDetailedReport.Location = new System.Drawing.Point(121, 157);
            this.btnDetailedReport.Name = "btnDetailedReport";
            this.btnDetailedReport.Size = new System.Drawing.Size(95, 23);
            this.btnDetailedReport.TabIndex = 3;
            this.btnDetailedReport.Text = "Detailed Report";
            this.btnDetailedReport.UseVisualStyleBackColor = true;
            this.btnDetailedReport.Click += new System.EventHandler(this.btnDetailedReport_Click);
            // 
            // MinimumGradeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 192);
            this.Controls.Add(this.btnDetailedReport);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtPointsInNextAssignment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLowestFinalGradeDesired);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentTotalPoints);
            this.Controls.Add(this.lblCurrentPercentage);
            this.Name = "MinimumGradeCalculator";
            this.Text = "MinimumGradeCalculator";
            this.Load += new System.EventHandler(this.MinimumGradeCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPercentage;
        private System.Windows.Forms.Label lblCurrentTotalPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLowestFinalGradeDesired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPointsInNextAssignment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.Button btnDetailedReport;
    }
}