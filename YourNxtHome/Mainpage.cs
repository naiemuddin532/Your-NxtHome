namespace YourNxtHome
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Signin sn = new Signin();
            sn.Show();
            this.Hide();
        }
        private void label_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.ForeColor = Color.BlueViolet;
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.ForeColor = Color.FromArgb(240, 248, 255);
            }
        }
        private void Mainpage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            a.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Guest g = new Guest();
            g.Show();
            this.Hide();
        }
    }
}
