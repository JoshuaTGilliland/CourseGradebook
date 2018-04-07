namespace HumanitiesGradebook
{
    partial class CourseGradebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseGradebook));
            this.chkDropLowest = new System.Windows.Forms.CheckBox();
            this.lblTotalGrade = new System.Windows.Forms.Label();
            this.lblGradePercentage = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstGrades = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenominator = new System.Windows.Forms.TextBox();
            this.txtNumerator = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMinGrade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPercentageOfCourse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkDropLowest
            // 
            this.chkDropLowest.AutoSize = true;
            this.chkDropLowest.Location = new System.Drawing.Point(16, 278);
            this.chkDropLowest.Name = "chkDropLowest";
            this.chkDropLowest.Size = new System.Drawing.Size(146, 17);
            this.chkDropLowest.TabIndex = 4;
            this.chkDropLowest.Text = "Drop The Lowest Grade?";
            this.chkDropLowest.UseVisualStyleBackColor = true;
            this.chkDropLowest.CheckedChanged += new System.EventHandler(this.chkDropLowest_CheckedChanged);
            // 
            // lblTotalGrade
            // 
            this.lblTotalGrade.AutoSize = true;
            this.lblTotalGrade.Location = new System.Drawing.Point(13, 325);
            this.lblTotalGrade.Name = "lblTotalGrade";
            this.lblTotalGrade.Size = new System.Drawing.Size(89, 13);
            this.lblTotalGrade.TabIndex = 18;
            this.lblTotalGrade.Text = "Your total points: ";
            // 
            // lblGradePercentage
            // 
            this.lblGradePercentage.AutoSize = true;
            this.lblGradePercentage.Location = new System.Drawing.Point(13, 307);
            this.lblGradePercentage.Name = "lblGradePercentage";
            this.lblGradePercentage.Size = new System.Drawing.Size(65, 13);
            this.lblGradePercentage.TabIndex = 17;
            this.lblGradePercentage.Text = "Your grade: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(163, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstGrades
            // 
            this.lstGrades.FormattingEnabled = true;
            this.lstGrades.Location = new System.Drawing.Point(13, 66);
            this.lstGrades.Name = "lstGrades";
            this.lstGrades.Size = new System.Drawing.Size(225, 199);
            this.lstGrades.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Grade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "/";
            // 
            // txtDenominator
            // 
            this.txtDenominator.Location = new System.Drawing.Point(130, 12);
            this.txtDenominator.Name = "txtDenominator";
            this.txtDenominator.Size = new System.Drawing.Size(26, 20);
            this.txtDenominator.TabIndex = 1;
            // 
            // txtNumerator
            // 
            this.txtNumerator.Location = new System.Drawing.Point(80, 12);
            this.txtNumerator.Name = "txtNumerator";
            this.txtNumerator.Size = new System.Drawing.Size(26, 20);
            this.txtNumerator.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(163, 274);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMinGrade
            // 
            this.btnMinGrade.Location = new System.Drawing.Point(13, 348);
            this.btnMinGrade.Name = "btnMinGrade";
            this.btnMinGrade.Size = new System.Drawing.Size(225, 23);
            this.btnMinGrade.TabIndex = 7;
            this.btnMinGrade.Text = "Minimum Grade For Next Assignment";
            this.btnMinGrade.UseVisualStyleBackColor = true;
            this.btnMinGrade.Click += new System.EventHandler(this.btnMinGrade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Percentage of Course:";
            // 
            // txtPercentageOfCourse
            // 
            this.txtPercentageOfCourse.Location = new System.Drawing.Point(130, 38);
            this.txtPercentageOfCourse.Name = "txtPercentageOfCourse";
            this.txtPercentageOfCourse.Size = new System.Drawing.Size(26, 20);
            this.txtPercentageOfCourse.TabIndex = 2;
            this.txtPercentageOfCourse.Text = "100";
            // 
            // CourseGradebook
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPercentageOfCourse);
            this.Controls.Add(this.btnMinGrade);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.chkDropLowest);
            this.Controls.Add(this.lblTotalGrade);
            this.Controls.Add(this.lblGradePercentage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstGrades);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDenominator);
            this.Controls.Add(this.txtNumerator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseGradebook";
            this.Text = "CourseGradebook";
            this.Load += new System.EventHandler(this.CourseGradebook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDropLowest;
        private System.Windows.Forms.Label lblTotalGrade;
        private System.Windows.Forms.Label lblGradePercentage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckedListBox lstGrades;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenominator;
        private System.Windows.Forms.TextBox txtNumerator;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMinGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPercentageOfCourse;
    }
}