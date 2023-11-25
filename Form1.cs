namespace practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            FrmApllication form = new FrmApllication();
            form.Show();


        }
    }
}