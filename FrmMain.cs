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

        private void BtnProgram_Click(object sender, EventArgs e)
        {
            FrmProgram form = new FrmProgram();
            form.Show();
        }

        private void BtnModules_Click(object sender, EventArgs e)
        {
            FrmModule frmModules = new FrmModule();
            frmModules.Show();
        }

        private void BtnAssessment_Click(object sender, EventArgs e)
        {
            FrmAssessment form = new FrmAssessment();
            form.Show();
        }

        private void BtnAddGrades_Click(object sender, EventArgs e)
        {
            FrmGrade form = new FrmGrade();
            form.Show();
        }

        private void BtnResults_Click(object sender, EventArgs e)
        {
            frmResult form = new frmResult();
            form.Show();
        }
    }
}