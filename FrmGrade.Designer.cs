namespace practice_1
{
    partial class FrmGrade
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
            label1 = new Label();
            BtnSearch = new Button();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            gridStudents = new DataGridView();
            gridAddGrade = new DataGridView();
            BtnAddGrade = new Button();
            btnSaveGrade = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridAddGrade).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Student :";
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(229, 26);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(62, 27);
            BtnSearch.TabIndex = 1;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.AccessibleDescription = "";
            txtSearch.Location = new Point(79, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Name or ID";
            txtSearch.Size = new Size(144, 27);
            txtSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(169, 0, 105);
            groupBox2.Controls.Add(btnSaveGrade);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 484);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 35);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // gridStudents
            // 
            gridStudents.BackgroundColor = SystemColors.ButtonFace;
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudents.Location = new Point(0, 91);
            gridStudents.Name = "gridStudents";
            gridStudents.RowHeadersWidth = 51;
            gridStudents.RowTemplate.Height = 29;
            gridStudents.Size = new Size(800, 153);
            gridStudents.TabIndex = 2;
            // 
            // gridAddGrade
            // 
            gridAddGrade.BackgroundColor = SystemColors.ButtonFace;
            gridAddGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAddGrade.Location = new Point(6, 285);
            gridAddGrade.Name = "gridAddGrade";
            gridAddGrade.RowHeadersWidth = 51;
            gridAddGrade.RowTemplate.Height = 29;
            gridAddGrade.Size = new Size(800, 198);
            gridAddGrade.TabIndex = 3;
            // 
            // BtnAddGrade
            // 
            BtnAddGrade.Location = new Point(694, 250);
            BtnAddGrade.Name = "BtnAddGrade";
            BtnAddGrade.Size = new Size(94, 29);
            BtnAddGrade.TabIndex = 4;
            BtnAddGrade.Text = "Choose";
            BtnAddGrade.UseVisualStyleBackColor = true;
            BtnAddGrade.Click += BtnAddGrade_Click;
            // 
            // btnSaveGrade
            // 
            btnSaveGrade.Location = new Point(694, 0);
            btnSaveGrade.Name = "btnSaveGrade";
            btnSaveGrade.Size = new Size(94, 29);
            btnSaveGrade.TabIndex = 5;
            btnSaveGrade.Text = "Save";
            btnSaveGrade.UseVisualStyleBackColor = true;
            // 
            // FrmGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(BtnAddGrade);
            Controls.Add(gridAddGrade);
            Controls.Add(gridStudents);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmGrade";
            Text = "Grades";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridAddGrade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnSearch;
        private TextBox txtSearch;
        private DataGridView gridStudents;
        private Label label1;
        private DataGridView gridAddGrade;
        private Button BtnAddGrade;
        private Button btnSaveGrade;
    }
}