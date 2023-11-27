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
            label3 = new Label();
            cmbDuration = new ComboBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbDuration);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 22);
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
            cmbDuration.Location = new Point(648, 19);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(151, 26);
            cmbDuration.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(169, 0, 105);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 414);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(820, 51);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
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
            // FrmProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 465);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmProgram";
            Text = "Program Degree";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox cmbDuration;
        private Label label1;
    }
}