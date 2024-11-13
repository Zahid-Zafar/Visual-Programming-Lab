namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = int.Parse(textBox1.Text);
            double c = (t - 32) / 1.8;
            string s = Convert.ToString(c);
            textBox2.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
