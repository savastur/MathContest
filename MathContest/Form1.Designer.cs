namespace MathContest
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
            this.studentInformatoinBox = new System.Windows.Forms.GroupBox();
            this.ageBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.signSelctionbox = new System.Windows.Forms.GroupBox();
            this.divideButton = new System.Windows.Forms.RadioButton();
            this.multiplyButton = new System.Windows.Forms.RadioButton();
            this.subtractButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.problemBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNumberlabel = new System.Windows.Forms.Label();
            this.secondNumbertext = new System.Windows.Forms.TextBox();
            this.firstNumbertext = new System.Windows.Forms.TextBox();
            this.buttonBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.summeryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.studentInformatoinBox.SuspendLayout();
            this.signSelctionbox.SuspendLayout();
            this.problemBox.SuspendLayout();
            this.buttonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentInformatoinBox
            // 
            this.studentInformatoinBox.AccessibleName = "StudentInfoBox";
            this.studentInformatoinBox.Controls.Add(this.ageBox);
            this.studentInformatoinBox.Controls.Add(this.label3);
            this.studentInformatoinBox.Controls.Add(this.label2);
            this.studentInformatoinBox.Controls.Add(this.label1);
            this.studentInformatoinBox.Controls.Add(this.gradeBox);
            this.studentInformatoinBox.Controls.Add(this.nameBox);
            this.studentInformatoinBox.Location = new System.Drawing.Point(12, 12);
            this.studentInformatoinBox.Name = "studentInformatoinBox";
            this.studentInformatoinBox.Size = new System.Drawing.Size(304, 109);
            this.studentInformatoinBox.TabIndex = 0;
            this.studentInformatoinBox.TabStop = false;
            this.studentInformatoinBox.Text = "Student Information";
            // 
            // ageBox
            // 
            this.ageBox.AccessibleName = "AgeBox";
            this.ageBox.FormattingEnabled = true;
            this.ageBox.Items.AddRange(new object[] {
            "",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.ageBox.Location = new System.Drawing.Point(141, 38);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(46, 24);
            this.ageBox.TabIndex = 6;
            this.ageBox.SelectedIndexChanged += new System.EventHandler(this.ageBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // gradeBox
            // 
            this.gradeBox.AccessibleName = "GradeBox";
            this.gradeBox.Location = new System.Drawing.Point(218, 40);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(44, 22);
            this.gradeBox.TabIndex = 2;
            this.gradeBox.TextChanged += new System.EventHandler(this.gradeBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.AccessibleName = "NameBox";
            this.nameBox.Location = new System.Drawing.Point(6, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // signSelctionbox
            // 
            this.signSelctionbox.AccessibleName = "SignSelectionBox";
            this.signSelctionbox.Controls.Add(this.divideButton);
            this.signSelctionbox.Controls.Add(this.multiplyButton);
            this.signSelctionbox.Controls.Add(this.subtractButton);
            this.signSelctionbox.Controls.Add(this.addButton);
            this.signSelctionbox.Location = new System.Drawing.Point(11, 127);
            this.signSelctionbox.Name = "signSelctionbox";
            this.signSelctionbox.Size = new System.Drawing.Size(200, 175);
            this.signSelctionbox.TabIndex = 1;
            this.signSelctionbox.TabStop = false;
            this.signSelctionbox.Text = "Math Problem Type";
            // 
            // divideButton
            // 
            this.divideButton.AccessibleName = "DivideButton";
            this.divideButton.AutoSize = true;
            this.divideButton.Location = new System.Drawing.Point(52, 119);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(76, 20);
            this.divideButton.TabIndex = 3;
            this.divideButton.TabStop = true;
            this.divideButton.Text = "Division";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.AccessibleName = "MultiplyButton";
            this.multiplyButton.AutoSize = true;
            this.multiplyButton.Location = new System.Drawing.Point(52, 93);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(102, 20);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.TabStop = true;
            this.multiplyButton.Text = "Multipication";
            this.multiplyButton.UseVisualStyleBackColor = true;
            // 
            // subtractButton
            // 
            this.subtractButton.AccessibleName = "SubtractButton";
            this.subtractButton.AutoSize = true;
            this.subtractButton.Location = new System.Drawing.Point(52, 67);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(88, 20);
            this.subtractButton.TabIndex = 1;
            this.subtractButton.TabStop = true;
            this.subtractButton.Text = "Subtration";
            this.subtractButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.AccessibleName = "AddButton";
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(52, 43);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 20);
            this.addButton.TabIndex = 0;
            this.addButton.TabStop = true;
            this.addButton.Text = "Addition";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // problemBox
            // 
            this.problemBox.AccessibleName = "ProblemBox";
            this.problemBox.Controls.Add(this.label4);
            this.problemBox.Controls.Add(this.studentAnswer);
            this.problemBox.Controls.Add(this.label5);
            this.problemBox.Controls.Add(this.firstNumberlabel);
            this.problemBox.Controls.Add(this.secondNumbertext);
            this.problemBox.Controls.Add(this.firstNumbertext);
            this.problemBox.Location = new System.Drawing.Point(217, 127);
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(200, 175);
            this.problemBox.TabIndex = 2;
            this.problemBox.TabStop = false;
            this.problemBox.Text = "Math Problem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Answer";
            // 
            // studentAnswer
            // 
            this.studentAnswer.AccessibleName = "StudentAnswer";
            this.studentAnswer.Location = new System.Drawing.Point(43, 147);
            this.studentAnswer.Name = "studentAnswer";
            this.studentAnswer.Size = new System.Drawing.Size(100, 22);
            this.studentAnswer.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Second Number";
            // 
            // firstNumberlabel
            // 
            this.firstNumberlabel.AutoSize = true;
            this.firstNumberlabel.Location = new System.Drawing.Point(38, 26);
            this.firstNumberlabel.Name = "firstNumberlabel";
            this.firstNumberlabel.Size = new System.Drawing.Size(83, 16);
            this.firstNumberlabel.TabIndex = 2;
            this.firstNumberlabel.Text = "First Number";
            // 
            // secondNumbertext
            // 
            this.secondNumbertext.Location = new System.Drawing.Point(41, 90);
            this.secondNumbertext.Name = "secondNumbertext";
            this.secondNumbertext.ReadOnly = true;
            this.secondNumbertext.Size = new System.Drawing.Size(100, 22);
            this.secondNumbertext.TabIndex = 1;
            // 
            // firstNumbertext
            // 
            this.firstNumbertext.Location = new System.Drawing.Point(43, 45);
            this.firstNumbertext.Name = "firstNumbertext";
            this.firstNumbertext.ReadOnly = true;
            this.firstNumbertext.Size = new System.Drawing.Size(100, 22);
            this.firstNumbertext.TabIndex = 0;
            // 
            // buttonBox
            // 
            this.buttonBox.AccessibleName = "ButtonBox";
            this.buttonBox.Controls.Add(this.exitButton);
            this.buttonBox.Controls.Add(this.summeryButton);
            this.buttonBox.Controls.Add(this.clearButton);
            this.buttonBox.Controls.Add(this.submitButton);
            this.buttonBox.Location = new System.Drawing.Point(452, 33);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(336, 360);
            this.buttonBox.TabIndex = 3;
            this.buttonBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.AccessibleName = "ExitButton";
            this.exitButton.Location = new System.Drawing.Point(131, 171);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // summeryButton
            // 
            this.summeryButton.AccessibleName = "SummeryButton";
            this.summeryButton.Location = new System.Drawing.Point(131, 113);
            this.summeryButton.Name = "summeryButton";
            this.summeryButton.Size = new System.Drawing.Size(75, 23);
            this.summeryButton.TabIndex = 2;
            this.summeryButton.Text = "Summery";
            this.summeryButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.AccessibleName = "ClearButton";
            this.clearButton.Location = new System.Drawing.Point(131, 65);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.AccessibleName = "SubmitButton";
            this.submitButton.Location = new System.Drawing.Point(131, 18);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.problemBox);
            this.Controls.Add(this.signSelctionbox);
            this.Controls.Add(this.studentInformatoinBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.studentInformatoinBox.ResumeLayout(false);
            this.studentInformatoinBox.PerformLayout();
            this.signSelctionbox.ResumeLayout(false);
            this.signSelctionbox.PerformLayout();
            this.problemBox.ResumeLayout(false);
            this.problemBox.PerformLayout();
            this.buttonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox studentInformatoinBox;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox signSelctionbox;
        private System.Windows.Forms.RadioButton divideButton;
        private System.Windows.Forms.RadioButton multiplyButton;
        private System.Windows.Forms.RadioButton subtractButton;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.GroupBox problemBox;
        private System.Windows.Forms.TextBox secondNumbertext;
        private System.Windows.Forms.TextBox firstNumbertext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label firstNumberlabel;
        private System.Windows.Forms.GroupBox buttonBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button summeryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentAnswer;
        private System.Windows.Forms.ComboBox ageBox;
    }
}

