namespace practice_1
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            maingpBox = new GroupBox();
            groupBox1 = new GroupBox();
            BtnResults = new Button();
            BtnAddGrades = new Button();
            label2 = new Label();
            label1 = new Label();
            BtnAssessment = new Button();
            BtnModules = new Button();
            BtnProgram = new Button();
            btnAdduser = new Button();
            maingpBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // maingpBox
            // 
            maingpBox.BackColor = Color.FromArgb(169, 0, 105);
            maingpBox.Controls.Add(groupBox1);
            maingpBox.Dock = DockStyle.Fill;
            maingpBox.Location = new Point(0, 0);
            maingpBox.Name = "maingpBox";
            maingpBox.Size = new Size(800, 405);
            maingpBox.TabIndex = 0;
            maingpBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(57, 75, 88);
            groupBox1.Controls.Add(BtnResults);
            groupBox1.Controls.Add(BtnAddGrades);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnAssessment);
            groupBox1.Controls.Add(BtnModules);
            groupBox1.Controls.Add(BtnProgram);
            groupBox1.Controls.Add(btnAdduser);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(3, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(118, 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // BtnResults
            // 
            BtnResults.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnResults.Location = new Point(9, 253);
            BtnResults.Name = "BtnResults";
            BtnResults.Size = new Size(98, 29);
            BtnResults.TabIndex = 8;
            BtnResults.Text = "Results";
            BtnResults.UseVisualStyleBackColor = true;
            // 
            // BtnAddGrades
            // 
            BtnAddGrades.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddGrades.Location = new Point(9, 218);
            BtnAddGrades.Name = "BtnAddGrades";
            BtnAddGrades.Size = new Size(98, 29);
            BtnAddGrades.TabIndex = 7;
            BtnAddGrades.Text = "Add grades";
            BtnAddGrades.UseVisualStyleBackColor = true;
            BtnAddGrades.Click += BtnAddGrades_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(24, 195);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Grading :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 5;
            label1.Text = "Add :";
            // 
            // BtnAssessment
            // 
            BtnAssessment.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAssessment.Location = new Point(9, 151);
            BtnAssessment.Name = "BtnAssessment";
            BtnAssessment.Size = new Size(98, 29);
            BtnAssessment.TabIndex = 4;
            BtnAssessment.Text = "Assesment";
            BtnAssessment.UseVisualStyleBackColor = true;
            BtnAssessment.Click += BtnAssessment_Click;
            // 
            // BtnModules
            // 
            BtnModules.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnModules.Location = new Point(9, 116);
            BtnModules.Name = "BtnModules";
            BtnModules.Size = new Size(98, 29);
            BtnModules.TabIndex = 3;
            BtnModules.Text = "Module";
            BtnModules.UseVisualStyleBackColor = true;
            BtnModules.Click += BtnModules_Click;
            // 
            // BtnProgram
            // 
            BtnProgram.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnProgram.Location = new Point(9, 81);
            BtnProgram.Name = "BtnProgram";
            BtnProgram.Size = new Size(98, 29);
            BtnProgram.TabIndex = 2;
            BtnProgram.Text = "Program";
            BtnProgram.UseVisualStyleBackColor = true;
            BtnProgram.Click += BtnProgram_Click;
            // 
            // btnAdduser
            // 
            btnAdduser.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdduser.Location = new Point(9, 46);
            btnAdduser.Name = "btnAdduser";
            btnAdduser.Size = new Size(98, 29);
            btnAdduser.TabIndex = 2;
            btnAdduser.Text = "Student";
            btnAdduser.UseVisualStyleBackColor = true;
            btnAdduser.Click += btnAdduser_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(maingpBox);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmMain";
            Text = "Student Management App";
            Load += Form1_Load;
            maingpBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox maingpBox;
        private GroupBox groupBox1;
        private Button btnAdduser;
        private Button BtnProgram;
        private Label label1;
        private Button BtnAssessment;
        private Button BtnModules;
        private Label label2;
        private Button BtnResults;
        private Button BtnAddGrades;
    }
}