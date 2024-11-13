namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);

            int result = n1 + n2;
            string s = Convert.ToString(result);
            textBox3.Text = s;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);

            int result = n1 - n2;
            string s = Convert.ToString(result);
            textBox3.Text = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);

            int result = n1 * n2;
            string s = Convert.ToString(result);
            textBox3.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);

            if(n2==0)
            {
                MessageBox.Show("Cannot divide by zero");
            }

            int result = n1 /n2;
            string s = Convert.ToString(result);
            textBox3.Text = s;
        }
    }
}