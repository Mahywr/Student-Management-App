namespace practice_1
{
    partial class FrmModule
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
            BtnSaveModule = new Button();
            label2 = new Label();
            cmbDegree = new ComboBox();
            txtModule = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnRemoveModule = new Button();
            gridModule = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridModule).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(BtnSaveModule);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbDegree);
            groupBox1.Controls.Add(txtModule);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtnSaveModule
            // 
            BtnSaveModule.Location = new Point(684, 90);
            BtnSaveModule.Name = "BtnSaveModule";
            BtnSaveModule.Size = new Size(94, 29);
            BtnSaveModule.TabIndex = 13;
            BtnSaveModule.Text = "save";
            BtnSaveModule.UseVisualStyleBackColor = true;
            BtnSaveModule.Click += BtnSaveModule_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 23);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 14;
            label2.Text = "Program degree :";
            // 
            // cmbDegree
            // 
            cmbDegree.FormattingEnabled = true;
            cmbDegree.Location = new Point(376, 19);
            cmbDegree.Name = "cmbDegree";
            cmbDegree.Size = new Size(151, 28);
            cmbDegree.TabIndex = 13;
            // 
            // txtModule
            // 
            txtModule.Location = new Point(112, 20);
            txtModule.Name = "txtModule";
            txtModule.Size = new Size(125, 27);
            txtModule.TabIndex = 12;
            txtModule.TextChanged += TxtModule_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 11;
            label1.Text = "Module Title :";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(169, 0, 105);
            groupBox2.Controls.Add(BtnRemoveModule);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 53);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // BtnRemoveModule
            // 
            BtnRemoveModule.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRemoveModule.Location = new Point(684, 18);
            BtnRemoveModule.Name = "BtnRemoveModule";
            BtnRemoveModule.Size = new Size(94, 29);
            BtnRemoveModule.TabIndex = 3;
            BtnRemoveModule.Text = "Remove";
            BtnRemoveModule.UseVisualStyleBackColor = true;
            BtnRemoveModule.Click += BtnRemoveModule_Click;
            // 
            // gridModule
            // 
            gridModule.BackgroundColor = SystemColors.ButtonFace;
            gridModule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridModule.Location = new Point(0, 131);
            gridModule.Name = "gridModule";
            gridModule.RowHeadersWidth = 51;
            gridModule.RowTemplate.Height = 29;
            gridModule.Size = new Size(800, 260);
            gridModule.TabIndex = 2;
            // 
            // FrmModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridModule);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmModule";
            Text = "Modules";
            Load += FrmModule_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridModule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtModule;
        private Button BtnSaveModule;
        private Label label2;
        private ComboBox cmbDegree;
        private DataGridView gridModule;
        private Button BtnRemoveModule;
    }
}