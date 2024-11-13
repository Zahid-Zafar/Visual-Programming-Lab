namespace Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=int.Parse(textBox1.Text);

            int fact = 1;

            for(int i = 1;i <= n;i++)
            {
                fact *= i;
            }

            string s=Convert.ToString(fact);

            textBox2.Text = s;
        }
    }
}
