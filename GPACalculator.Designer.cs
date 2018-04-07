namespace CourseGradebook
{
    partial class GPACalculator
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
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.barClass1 = new System.Windows.Forms.TrackBar();
            this.lblTotalGPA = new System.Windows.Forms.Label();
            this.lblClass1 = new System.Windows.Forms.Label();
            this.lblClass2 = new System.Windows.Forms.Label();
            this.barClass2 = new System.Windows.Forms.TrackBar();
            this.lblClass3 = new System.Windows.Forms.Label();
            this.barClass3 = new System.Windows.Forms.TrackBar();
            this.lblClass4 = new System.Windows.Forms.Label();
            this.barClass4 = new System.Windows.Forms.TrackBar();
            this.lblClass8 = new System.Windows.Forms.Label();
            this.barClass8 = new System.Windows.Forms.TrackBar();
            this.lblClass7 = new System.Windows.Forms.Label();
            this.barClass7 = new System.Windows.Forms.TrackBar();
            this.lblClass6 = new System.Windows.Forms.Label();
            this.barClass6 = new System.Windows.Forms.TrackBar();
            this.lblClass5 = new System.Windows.Forms.Label();
            this.barClass5 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrades1 = new System.Windows.Forms.Label();
            this.lblGrades2 = new System.Windows.Forms.Label();
            this.lblGrades3 = new System.Windows.Forms.Label();
            this.lblGrades4 = new System.Windows.Forms.Label();
            this.lblGrades5 = new System.Windows.Forms.Label();
            this.lblGrades6 = new System.Windows.Forms.Label();
            this.lblGrades7 = new System.Windows.Forms.Label();
            this.lblGrades8 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.DomainUpDown();
            this.btnDeleteClass1 = new System.Windows.Forms.Button();
            this.btnDeleteClass2 = new System.Windows.Forms.Button();
            this.btnDeleteClass3 = new System.Windows.Forms.Button();
            this.btnDeleteClass4 = new System.Windows.Forms.Button();
            this.btnDeleteClass5 = new System.Windows.Forms.Button();
            this.btnDeleteClass6 = new System.Windows.Forms.Button();
            this.btnDeleteClass7 = new System.Windows.Forms.Button();
            this.btnDeleteClass8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barClass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course: ";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(64, 9);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(144, 20);
            this.txtCourseName.TabIndex = 1;
            // 
            // txtCreditHours
            // 
            this.txtCreditHours.Location = new System.Drawing.Point(286, 9);
            this.txtCreditHours.Name = "txtCreditHours";
            this.txtCreditHours.Size = new System.Drawing.Size(43, 20);
            this.txtCreditHours.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cred/Hr:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(237, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Course";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // barClass1
            // 
            this.barClass1.Location = new System.Drawing.Point(15, 125);
            this.barClass1.Maximum = 11;
            this.barClass1.Name = "barClass1";
            this.barClass1.Size = new System.Drawing.Size(421, 45);
            this.barClass1.TabIndex = 7;
            this.barClass1.Visible = false;
            this.barClass1.Scroll += new System.EventHandler(this.barClass1_Scroll);
            // 
            // lblTotalGPA
            // 
            this.lblTotalGPA.AutoSize = true;
            this.lblTotalGPA.Location = new System.Drawing.Point(12, 49);
            this.lblTotalGPA.Name = "lblTotalGPA";
            this.lblTotalGPA.Size = new System.Drawing.Size(60, 13);
            this.lblTotalGPA.TabIndex = 8;
            this.lblTotalGPA.Text = "Your GPA: ";
            // 
            // lblClass1
            // 
            this.lblClass1.AutoSize = true;
            this.lblClass1.Location = new System.Drawing.Point(12, 99);
            this.lblClass1.Name = "lblClass1";
            this.lblClass1.Size = new System.Drawing.Size(38, 13);
            this.lblClass1.TabIndex = 9;
            this.lblClass1.Text = "Class: ";
            this.lblClass1.Visible = false;
            this.lblClass1.Click += new System.EventHandler(this.lblClass1_Click);
            // 
            // lblClass2
            // 
            this.lblClass2.AutoSize = true;
            this.lblClass2.Location = new System.Drawing.Point(12, 191);
            this.lblClass2.Name = "lblClass2";
            this.lblClass2.Size = new System.Drawing.Size(38, 13);
            this.lblClass2.TabIndex = 11;
            this.lblClass2.Text = "Class: ";
            this.lblClass2.Visible = false;
            this.lblClass2.Click += new System.EventHandler(this.lblClass2_Click);
            // 
            // barClass2
            // 
            this.barClass2.Location = new System.Drawing.Point(15, 212);
            this.barClass2.Maximum = 11;
            this.barClass2.Name = "barClass2";
            this.barClass2.Size = new System.Drawing.Size(421, 45);
            this.barClass2.TabIndex = 10;
            this.barClass2.Visible = false;
            this.barClass2.Scroll += new System.EventHandler(this.barClass2_Scroll);
            // 
            // lblClass3
            // 
            this.lblClass3.AutoSize = true;
            this.lblClass3.Location = new System.Drawing.Point(12, 269);
            this.lblClass3.Name = "lblClass3";
            this.lblClass3.Size = new System.Drawing.Size(38, 13);
            this.lblClass3.TabIndex = 13;
            this.lblClass3.Text = "Class: ";
            this.lblClass3.Visible = false;
            this.lblClass3.Click += new System.EventHandler(this.lblClass3_Click);
            // 
            // barClass3
            // 
            this.barClass3.Location = new System.Drawing.Point(15, 295);
            this.barClass3.Maximum = 11;
            this.barClass3.Name = "barClass3";
            this.barClass3.Size = new System.Drawing.Size(421, 45);
            this.barClass3.TabIndex = 12;
            this.barClass3.Visible = false;
            this.barClass3.Scroll += new System.EventHandler(this.barClass3_Scroll);
            // 
            // lblClass4
            // 
            this.lblClass4.AutoSize = true;
            this.lblClass4.Location = new System.Drawing.Point(12, 360);
            this.lblClass4.Name = "lblClass4";
            this.lblClass4.Size = new System.Drawing.Size(38, 13);
            this.lblClass4.TabIndex = 15;
            this.lblClass4.Text = "Class: ";
            this.lblClass4.Visible = false;
            this.lblClass4.Click += new System.EventHandler(this.lblClass4_Click);
            // 
            // barClass4
            // 
            this.barClass4.Location = new System.Drawing.Point(15, 381);
            this.barClass4.Maximum = 11;
            this.barClass4.Name = "barClass4";
            this.barClass4.Size = new System.Drawing.Size(421, 45);
            this.barClass4.TabIndex = 14;
            this.barClass4.Visible = false;
            this.barClass4.Scroll += new System.EventHandler(this.barClass4_Scroll);
            // 
            // lblClass8
            // 
            this.lblClass8.AutoSize = true;
            this.lblClass8.Location = new System.Drawing.Point(12, 702);
            this.lblClass8.Name = "lblClass8";
            this.lblClass8.Size = new System.Drawing.Size(38, 13);
            this.lblClass8.TabIndex = 23;
            this.lblClass8.Text = "Class: ";
            this.lblClass8.Visible = false;
            this.lblClass8.Click += new System.EventHandler(this.lblClass8_Click);
            // 
            // barClass8
            // 
            this.barClass8.Location = new System.Drawing.Point(15, 718);
            this.barClass8.Maximum = 11;
            this.barClass8.Name = "barClass8";
            this.barClass8.Size = new System.Drawing.Size(421, 45);
            this.barClass8.TabIndex = 22;
            this.barClass8.Visible = false;
            this.barClass8.Scroll += new System.EventHandler(this.barClass8_Scroll);
            // 
            // lblClass7
            // 
            this.lblClass7.AutoSize = true;
            this.lblClass7.Location = new System.Drawing.Point(12, 615);
            this.lblClass7.Name = "lblClass7";
            this.lblClass7.Size = new System.Drawing.Size(38, 13);
            this.lblClass7.TabIndex = 21;
            this.lblClass7.Text = "Class: ";
            this.lblClass7.Visible = false;
            this.lblClass7.Click += new System.EventHandler(this.lblClass7_Click);
            // 
            // barClass7
            // 
            this.barClass7.Location = new System.Drawing.Point(15, 631);
            this.barClass7.Maximum = 11;
            this.barClass7.Name = "barClass7";
            this.barClass7.Size = new System.Drawing.Size(421, 45);
            this.barClass7.TabIndex = 20;
            this.barClass7.Visible = false;
            this.barClass7.Scroll += new System.EventHandler(this.barClass7_Scroll);
            // 
            // lblClass6
            // 
            this.lblClass6.AutoSize = true;
            this.lblClass6.Location = new System.Drawing.Point(12, 532);
            this.lblClass6.Name = "lblClass6";
            this.lblClass6.Size = new System.Drawing.Size(38, 13);
            this.lblClass6.TabIndex = 19;
            this.lblClass6.Text = "Class: ";
            this.lblClass6.Visible = false;
            this.lblClass6.Click += new System.EventHandler(this.lblClass6_Click);
            // 
            // barClass6
            // 
            this.barClass6.Location = new System.Drawing.Point(15, 548);
            this.barClass6.Maximum = 11;
            this.barClass6.Name = "barClass6";
            this.barClass6.Size = new System.Drawing.Size(421, 45);
            this.barClass6.TabIndex = 18;
            this.barClass6.Visible = false;
            this.barClass6.Scroll += new System.EventHandler(this.barClass6_Scroll);
            // 
            // lblClass5
            // 
            this.lblClass5.AutoSize = true;
            this.lblClass5.Location = new System.Drawing.Point(12, 445);
            this.lblClass5.Name = "lblClass5";
            this.lblClass5.Size = new System.Drawing.Size(38, 13);
            this.lblClass5.TabIndex = 17;
            this.lblClass5.Text = "Class: ";
            this.lblClass5.Visible = false;
            this.lblClass5.Click += new System.EventHandler(this.lblClass5_Click);
            // 
            // barClass5
            // 
            this.barClass5.Location = new System.Drawing.Point(15, 461);
            this.barClass5.Maximum = 11;
            this.barClass5.Name = "barClass5";
            this.barClass5.Size = new System.Drawing.Size(421, 45);
            this.barClass5.TabIndex = 16;
            this.barClass5.Visible = false;
            this.barClass5.Scroll += new System.EventHandler(this.barClass5_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Grade:";
            // 
            // lblGrades1
            // 
            this.lblGrades1.AutoSize = true;
            this.lblGrades1.Location = new System.Drawing.Point(23, 157);
            this.lblGrades1.Name = "lblGrades1";
            this.lblGrades1.Size = new System.Drawing.Size(408, 13);
            this.lblGrades1.TabIndex = 26;
            this.lblGrades1.Text = "F          D-        D        D+        C-         C         C+        B-        " +
    " B         B+        A-         A";
            this.lblGrades1.Visible = false;
            // 
            // lblGrades2
            // 
            this.lblGrades2.AutoSize = true;
            this.lblGrades2.Location = new System.Drawing.Point(23, 244);
            this.lblGrades2.Name = "lblGrades2";
            this.lblGrades2.Size = new System.Drawing.Size(408, 13);
            this.lblGrades2.TabIndex = 27;
            this.lblGrades2.Text = "F          D-        D        D+        C-         C         C+        B-        " +
    " B         B+        A-         A";
            this.lblGrades2.Visible = false;
            // 
            // lblGrades3
            // 
            this.lblGrades3.AutoSize = true;
            this.lblGrades3.Location = new System.Drawing.Point(23, 327);
            this.lblGrades3.Name = "lblGrades3";
            this.lblGrades3.Size = new System.Drawing.Size(408, 13);
            this.lblGrades3.TabIndex = 28;
            this.lblGrades3.Text = "F          D-        D        D+        C-         C         C+        B-        " +
    " B         B+        A-         A";
            this.lblGrades3.Visible = false;
            // 
            // lblGrades4
            // 
            this.lblGrades4.AutoSize = true;
            this.lblGrades4.Location = new System.Drawing.Point(23, 413);
            this.lblGrades4.Name = "lblGrades4";
            this.lblGrades4.Size = new System.Drawing.Size(408, 13);
            this.lblGrades4.TabIndex = 29;
            this.lblGrades4.Text = "F          D-        D        D+        C-         C         C+        B-        " +
    " B         B+        A-         A";
            this.lblGrades4.Visible = false;
            // 
            // lblGrades5
            // 
            this.lblGrades5.AutoSize = true;
            this.lblGrades5.Location = new System.Drawing.Point(23, 493);
            this.lblGrades5.Name = "lblGrades5";
            this.lblGrades5.Size = new System.Drawing.Size(408, 13);
            this.lblGrades5.TabIndex = 30;
            this.lblGrades5.Text = "F          D-        D        D+        C-         C         C+        B-        " +
    " B         B+        A-         A";
            this.lblGrades5.Visible = false;
            // 
            // lblGrades6
            // 
            this.lblGrades6.AutoSize = true;
            this.lblGrades6.Location = new System.Drawing.Point(23, 580);
            this.lblGrades6.Name = "lblGrades6";
            this.lblGrades6.Size = new System.Drawing.Size(408, 13);
            this.lblGrades6.TabIndex = 31;
            this.lblGrades6.Text = "F          D-        D        D+        C-         C         C+        B-        " +
    " B         B+        A-         A";
            this.lblGrades6.Visible = false;
            // 
            // lblGrades7
            // 
            this.lblGrades7.AutoSize = true;
            this.lblGrades7.Location = new System.Drawing.Point(23, 663);
            this.lblGrades7.Name = "lblGrades7";
            this.lblGrades7.Size = new System.Drawing.Size(408, 13);
            this.lblGrades7.TabIndex = 32;
            this.lblGrades7.Text = "F          D-        D        D+        C-         C         C+        B-        " +
    " B         B+        A-         A";
            this.lblGrades7.Visible = false;
            // 
            // lblGrades8
            // 
            this.lblGrades8.AutoSize = true;
            this.lblGrades8.Location = new System.Drawing.Point(23, 750);
            this.lblGrades8.Name = "lblGrades8";
            this.lblGrades8.Size = new System.Drawing.Size(408, 13);
            this.lblGrades8.TabIndex = 33;
            this.lblGrades8.Text = "F          D-        D        D+        C-         C         C+        B-        " +
    " B         B+        A-         A";
            this.lblGrades8.Visible = false;
            // 
            // txtGrade
            // 
            this.txtGrade.Items.Add("A");
            this.txtGrade.Items.Add("A-");
            this.txtGrade.Items.Add("B+");
            this.txtGrade.Items.Add("B");
            this.txtGrade.Items.Add("B-");
            this.txtGrade.Items.Add("C+");
            this.txtGrade.Items.Add("C");
            this.txtGrade.Items.Add("C-");
            this.txtGrade.Items.Add("D+");
            this.txtGrade.Items.Add("D");
            this.txtGrade.Items.Add("D-");
            this.txtGrade.Items.Add("F");
            this.txtGrade.Location = new System.Drawing.Point(393, 10);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(47, 20);
            this.txtGrade.TabIndex = 35;
            // 
            // btnDeleteClass1
            // 
            this.btnDeleteClass1.Location = new System.Drawing.Point(403, 99);
            this.btnDeleteClass1.Name = "btnDeleteClass1";
            this.btnDeleteClass1.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteClass1.TabIndex = 36;
            this.btnDeleteClass1.Text = "X";
            this.btnDeleteClass1.UseVisualStyleBackColor = true;
            this.btnDeleteClass1.Visible = false;
            this.btnDeleteClass1.Click += new System.EventHandler(this.btnDeleteClass1_Click);
            // 
            // btnDeleteClass2
            // 
            this.btnDeleteClass2.Location = new System.Drawing.Point(403, 186);
            this.btnDeleteClass2.Name = "btnDeleteClass2";
            this.btnDeleteClass2.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteClass2.TabIndex = 37;
            this.btnDeleteClass2.Text = "X";
            this.btnDeleteClass2.UseVisualStyleBackColor = true;
            this.btnDeleteClass2.Visible = false;
            this.btnDeleteClass2.Click += new System.EventHandler(this.btnDeleteClass2_Click);
            // 
            // btnDeleteClass3
            // 
            this.btnDeleteClass3.Location = new System.Drawing.Point(403, 269);
            this.btnDeleteClass3.Name = "btnDeleteClass3";
            this.btnDeleteClass3.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteClass3.TabIndex = 38;
            this.btnDeleteClass3.Text = "X";
            this.btnDeleteClass3.UseVisualStyleBackColor = true;
            this.btnDeleteClass3.Visible = false;
            this.btnDeleteClass3.Click += new System.EventHandler(this.btnDeleteClass3_Click);
            // 
            // btnDeleteClass4
            // 
            this.btnDeleteClass4.Location = new System.Drawing.Point(403, 352);
            this.btnDeleteClass4.Name = "btnDeleteClass4";
            this.btnDeleteClass4.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteClass4.TabIndex = 39;
            this.btnDeleteClass4.Text = "X";
            this.btnDeleteClass4.UseVisualStyleBackColor = true;
            this.btnDeleteClass4.Visible = false;
            this.btnDeleteClass4.Click += new System.EventHandler(this.btnDeleteClass4_Click);
            // 
            // btnDeleteClass5
            // 
            this.btnDeleteClass5.Location = new System.Drawing.Point(403, 435);
            this.btnDeleteClass5.Name = "btnDeleteClass5";
            this.btnDeleteClass5.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteClass5.TabIndex = 40;
            this.btnDeleteClass5.Text = "X";
            this.btnDeleteClass5.UseVisualStyleBackColor = true;
            this.btnDeleteClass5.Visible = false;
            this.btnDeleteClass5.Click += new System.EventHandler(this.btnDeleteClass5_Click);
            // 
            // btnDeleteClass6
            // 
            this.btnDeleteClass6.Location = new System.Drawing.Point(403, 519);
            this.btnDeleteClass6.Name = "btnDeleteClass6";
            this.btnDeleteClass6.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteClass6.TabIndex = 41;
            this.btnDeleteClass6.Text = "X";
            this.btnDeleteClass6.UseVisualStyleBackColor = true;
            this.btnDeleteClass6.Visible = false;
            this.btnDeleteClass6.Click += new System.EventHandler(this.btnDeleteClass6_Click);
            // 
            // btnDeleteClass7
            // 
            this.btnDeleteClass7.Location = new System.Drawing.Point(403, 605);
            this.btnDeleteClass7.Name = "btnDeleteClass7";
            this.btnDeleteClass7.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteClass7.TabIndex = 42;
            this.btnDeleteClass7.Text = "X";
            this.btnDeleteClass7.UseVisualStyleBackColor = true;
            this.btnDeleteClass7.Visible = false;
            this.btnDeleteClass7.Click += new System.EventHandler(this.btnDeleteClass7_Click);
            // 
            // btnDeleteClass8
            // 
            this.btnDeleteClass8.Location = new System.Drawing.Point(403, 692);
            this.btnDeleteClass8.Name = "btnDeleteClass8";
            this.btnDeleteClass8.Size = new System.Drawing.Size(28, 23);
            this.btnDeleteClass8.TabIndex = 43;
            this.btnDeleteClass8.Text = "X";
            this.btnDeleteClass8.UseVisualStyleBackColor = true;
            this.btnDeleteClass8.Visible = false;
            this.btnDeleteClass8.Click += new System.EventHandler(this.btnDeleteClass8_Click);
            // 
            // GPACalculator
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 777);
            this.Controls.Add(this.btnDeleteClass8);
            this.Controls.Add(this.btnDeleteClass7);
            this.Controls.Add(this.btnDeleteClass6);
            this.Controls.Add(this.btnDeleteClass5);
            this.Controls.Add(this.btnDeleteClass4);
            this.Controls.Add(this.btnDeleteClass3);
            this.Controls.Add(this.btnDeleteClass2);
            this.Controls.Add(this.btnDeleteClass1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrades8);
            this.Controls.Add(this.lblGrades7);
            this.Controls.Add(this.lblGrades6);
            this.Controls.Add(this.lblGrades5);
            this.Controls.Add(this.lblGrades4);
            this.Controls.Add(this.lblGrades3);
            this.Controls.Add(this.lblGrades2);
            this.Controls.Add(this.lblGrades1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblClass8);
            this.Controls.Add(this.barClass8);
            this.Controls.Add(this.lblClass7);
            this.Controls.Add(this.barClass7);
            this.Controls.Add(this.lblClass6);
            this.Controls.Add(this.barClass6);
            this.Controls.Add(this.lblClass5);
            this.Controls.Add(this.barClass5);
            this.Controls.Add(this.lblClass4);
            this.Controls.Add(this.barClass4);
            this.Controls.Add(this.lblClass3);
            this.Controls.Add(this.barClass3);
            this.Controls.Add(this.lblClass2);
            this.Controls.Add(this.barClass2);
            this.Controls.Add(this.lblClass1);
            this.Controls.Add(this.lblTotalGPA);
            this.Controls.Add(this.barClass1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCreditHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label1);
            this.Name = "GPACalculator";
            this.Text = "GPACalculator";
            this.Load += new System.EventHandler(this.GPACalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barClass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barClass5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCreditHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TrackBar barClass1;
        private System.Windows.Forms.Label lblTotalGPA;
        private System.Windows.Forms.Label lblClass1;
        private System.Windows.Forms.Label lblClass2;
        private System.Windows.Forms.TrackBar barClass2;
        private System.Windows.Forms.Label lblClass3;
        private System.Windows.Forms.TrackBar barClass3;
        private System.Windows.Forms.Label lblClass4;
        private System.Windows.Forms.TrackBar barClass4;
        private System.Windows.Forms.Label lblClass8;
        private System.Windows.Forms.TrackBar barClass8;
        private System.Windows.Forms.Label lblClass7;
        private System.Windows.Forms.TrackBar barClass7;
        private System.Windows.Forms.Label lblClass6;
        private System.Windows.Forms.TrackBar barClass6;
        private System.Windows.Forms.Label lblClass5;
        private System.Windows.Forms.TrackBar barClass5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrades1;
        private System.Windows.Forms.Label lblGrades2;
        private System.Windows.Forms.Label lblGrades3;
        private System.Windows.Forms.Label lblGrades4;
        private System.Windows.Forms.Label lblGrades5;
        private System.Windows.Forms.Label lblGrades6;
        private System.Windows.Forms.Label lblGrades7;
        private System.Windows.Forms.Label lblGrades8;
        private System.Windows.Forms.DomainUpDown txtGrade;
        private System.Windows.Forms.Button btnDeleteClass1;
        private System.Windows.Forms.Button btnDeleteClass2;
        private System.Windows.Forms.Button btnDeleteClass3;
        private System.Windows.Forms.Button btnDeleteClass4;
        private System.Windows.Forms.Button btnDeleteClass5;
        private System.Windows.Forms.Button btnDeleteClass6;
        private System.Windows.Forms.Button btnDeleteClass7;
        private System.Windows.Forms.Button btnDeleteClass8;
    }
}