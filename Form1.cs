namespace practice_1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            FrmApllication form = new FrmApllication();
            form.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}