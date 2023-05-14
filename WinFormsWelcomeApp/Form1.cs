namespace WinFormsWelcomeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //this.BackColor = Color.Green;

            TabPage tabPage3 = new TabPage();
            tabPage3.Text = "New Tab Page";
            tabControl1.TabPages.Add(tabPage3);

            tabPage3.Controls.Add(new Button());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm(this);
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}