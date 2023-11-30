namespace practice_1
{
    partial class frmResult
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
            GridResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridResult).BeginInit();
            SuspendLayout();
            // 
            // GridResult
            // 
            GridResult.BackgroundColor = SystemColors.ButtonHighlight;
            GridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridResult.Dock = DockStyle.Fill;
            GridResult.Location = new Point(0, 0);
            GridResult.Name = "GridResult";
            GridResult.RowHeadersWidth = 51;
            GridResult.RowTemplate.Height = 29;
            GridResult.Size = new Size(800, 450);
            GridResult.TabIndex = 0;
            GridResult.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridResult);
            Name = "frmResult";
            Text = "Results";
            Load += frmResults_Load;
            ((System.ComponentModel.ISupportInitialize)GridResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridResult;
    }
}