namespace practice_1
{
    partial class FrmProgram
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
            groupBox1 = new GroupBox();
            btnSaveProgram = new Button();
            txtCohortYear = new TextBox();
            label2 = new Label();
            txtProgramTitle = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cmbDuration = new ComboBox();
            groupBox2 = new GroupBox();
            GridProgram = new DataGridView();
            btnRemoveProgram = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridProgram).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnSaveProgram);
            groupBox1.Controls.Add(txtCohortYear);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtProgramTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbDuration);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnSaveProgram
            // 
            btnSaveProgram.Location = new Point(704, 79);
            btnSaveProgram.Name = "btnSaveProgram";
            btnSaveProgram.Size = new Size(94, 29);
            btnSaveProgram.TabIndex = 14;
            btnSaveProgram.Text = "save";
            btnSaveProgram.UseVisualStyleBackColor = true;
            btnSaveProgram.Click += btnSaveProgram_Click;
            // 
            // txtCohortYear
            // 
            txtCohortYear.Location = new Point(347, 16);
            txtCohortYear.Name = "txtCohortYear";
            txtCohortYear.Size = new Size(125, 26);
            txtCohortYear.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 19);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 12;
            label2.Text = "Cohort Year :";
            // 
            // txtProgramTitle
            // 
            txtProgramTitle.Location = new Point(109, 16);
            txtProgramTitle.Name = "txtProgramTitle";
            txtProgramTitle.Size = new Size(125, 26);
            txtProgramTitle.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 18);
            label1.TabIndex = 10;
            label1.Text = "Degree Title :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 19);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 9;
            label3.Text = "Course duration :";
            // 
            // cmbDuration
            // 
            cmbDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDuration.FormattingEnabled = true;
            cmbDuration.Items.AddRange(new object[] { "One year ", "Two years", "Three years" });
            cmbDuration.Location = new Point(647, 16);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(151, 26);
            cmbDuration.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(169, 0, 105);
            groupBox2.Controls.Add(btnRemoveProgram);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 414);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(820, 51);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // GridProgram
            // 
            GridProgram.BackgroundColor = SystemColors.ButtonFace;
            GridProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProgram.Location = new Point(0, 135);
            GridProgram.Name = "GridProgram";
            GridProgram.RowHeadersWidth = 51;
            GridProgram.RowTemplate.Height = 29;
            GridProgram.Size = new Size(820, 273);
            GridProgram.TabIndex = 2;
            // 
            // btnRemoveProgram
            // 
            btnRemoveProgram.Location = new Point(704, 16);
            btnRemoveProgram.Name = "btnRemoveProgram";
            btnRemoveProgram.Size = new Size(94, 29);
            btnRemoveProgram.TabIndex = 3;
            btnRemoveProgram.Text = "Remove";
            btnRemoveProgram.UseVisualStyleBackColor = true;
            btnRemoveProgram.Click += btnRemoveProgram_Click;
            // 
            // FrmProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 465);
            Controls.Add(GridProgram);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmProgram";
            Text = "Program Degree";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridProgram).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox cmbDuration;
        private Label label1;
        private TextBox txtProgramTitle;
        private TextBox txtCohortYear;
        private Label label2;
        private Button btnSaveProgram;
        private DataGridView GridProgram;
        private Button btnRemoveProgram;
    }
}