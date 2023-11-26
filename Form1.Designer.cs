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
            groupBox1.Controls.Add(btnAdduser);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(3, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnAdduser
            // 
            btnAdduser.Location = new Point(27, 25);
            btnAdduser.Name = "btnAdduser";
            btnAdduser.Size = new Size(94, 29);
            btnAdduser.TabIndex = 2;
            btnAdduser.Text = "Add user";
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox maingpBox;
        private GroupBox groupBox1;
        private Button btnAdduser;
    }
}