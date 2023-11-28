namespace practice_1
{
    partial class FrmApllication
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
            label3 = new Label();
            cmbDuration = new ComboBox();
            label2 = new Label();
            txtCohortYear = new TextBox();
            btnAddSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            gridStd = new DataGridView();
            groupBox2 = new GroupBox();
            btnRemoveStudent = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridStd).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbDuration);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCohortYear);
            groupBox1.Controls.Add(btnAddSave);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 32);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 7;
            label3.Text = "Course duration :";
            // 
            // cmbDuration
            // 
            cmbDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDuration.FormattingEnabled = true;
            cmbDuration.Items.AddRange(new object[] { "One year ", "Two years", "Three years" });
            cmbDuration.Location = new Point(591, 29);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(151, 28);
            cmbDuration.TabIndex = 6;
            cmbDuration.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 32);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Cohort Year:";
            // 
            // txtCohortYear
            // 
            txtCohortYear.Location = new Point(329, 29);
            txtCohortYear.Name = "txtCohortYear";
            txtCohortYear.Size = new Size(125, 27);
            txtCohortYear.TabIndex = 4;
            // 
            // btnAddSave
            // 
            btnAddSave.Location = new Point(648, 123);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(94, 29);
            btnAddSave.TabIndex = 3;
            btnAddSave.Text = "save";
            btnAddSave.UseVisualStyleBackColor = true;
            btnAddSave.Click += btnAddSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // gridStd
            // 
            gridStd.BackgroundColor = SystemColors.ButtonFace;
            gridStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStd.Location = new Point(0, 158);
            gridStd.Name = "gridStd";
            gridStd.RowHeadersWidth = 51;
            gridStd.RowTemplate.Height = 29;
            gridStd.Size = new Size(813, 245);
            gridStd.TabIndex = 1;
            gridStd.CellContentClick += gridStd_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRemoveStudent);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 401);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(752, 49);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new Point(648, 14);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(94, 29);
            btnRemoveStudent.TabIndex = 0;
            btnRemoveStudent.Text = "Remove";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // FrmApllication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 0, 105);
            ClientSize = new Size(752, 450);
            Controls.Add(groupBox2);
            Controls.Add(gridStd);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmApllication";
            Text = "application Form";
            Load += FrmApllication_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridStd).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtName;
        private Button btnAddSave;
        private Label label2;
        private TextBox txtCohortYear;
        private ComboBox cmbDuration;
        private Label label3;
        private DataGridView gridStd;
        private GroupBox groupBox2;
        private Button btnRemoveStudent;
    }
}