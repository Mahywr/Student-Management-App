namespace practice_1
{
    partial class FrmAssessment
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
            cmbModule = new ComboBox();
            TxtAssessment = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnSaveAssessment = new Button();
            groupBox2 = new GroupBox();
            BtnRemoveAssessment = new Button();
            GridAssessment = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridAssessment).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(cmbModule);
            groupBox1.Controls.Add(TxtAssessment);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnSaveAssessment);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cmbModule
            // 
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(363, 20);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(151, 28);
            cmbModule.TabIndex = 15;
            // 
            // TxtAssessment
            // 
            TxtAssessment.Location = new Point(143, 20);
            TxtAssessment.Name = "TxtAssessment";
            TxtAssessment.Size = new Size(125, 27);
            TxtAssessment.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 13;
            label2.Text = "Module :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 12;
            label1.Text = "Assessment Title :";
            label1.Click += label1_Click;
            // 
            // BtnSaveAssessment
            // 
            BtnSaveAssessment.Location = new Point(694, 90);
            BtnSaveAssessment.Name = "BtnSaveAssessment";
            BtnSaveAssessment.Size = new Size(94, 29);
            BtnSaveAssessment.TabIndex = 0;
            BtnSaveAssessment.Text = "Save";
            BtnSaveAssessment.UseVisualStyleBackColor = true;
            BtnSaveAssessment.Click += BtnSaveAssessment_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(169, 0, 105);
            groupBox2.Controls.Add(BtnRemoveAssessment);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 395);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 55);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // BtnRemoveAssessment
            // 
            BtnRemoveAssessment.Location = new Point(694, 20);
            BtnRemoveAssessment.Name = "BtnRemoveAssessment";
            BtnRemoveAssessment.Size = new Size(94, 29);
            BtnRemoveAssessment.TabIndex = 1;
            BtnRemoveAssessment.Text = "Remove";
            BtnRemoveAssessment.UseVisualStyleBackColor = true;
            BtnRemoveAssessment.Click += BtnRemoveAssessment_Click;
            // 
            // GridAssessment
            // 
            GridAssessment.BackgroundColor = SystemColors.ButtonFace;
            GridAssessment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridAssessment.GridColor = SystemColors.ActiveBorder;
            GridAssessment.Location = new Point(0, 131);
            GridAssessment.Name = "GridAssessment";
            GridAssessment.RowHeadersWidth = 51;
            GridAssessment.RowTemplate.Height = 29;
            GridAssessment.Size = new Size(800, 258);
            GridAssessment.TabIndex = 2;
            // 
            // FrmAssessment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridAssessment);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmAssessment";
            Text = "FrmAssessment";
            Load += FrmAssessment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridAssessment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnSaveAssessment;
        private Button BtnRemoveAssessment;
        private Label label1;
        private Label label2;
        private ComboBox cmbModule;
        private TextBox TxtAssessment;
        private DataGridView GridAssessment;
    }
}