namespace Q9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 160;

            int rc = textBox1.MaxLength;
            label1.Text = rc.ToString() + " cahracters remaining";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int rc = textBox1.MaxLength - textBox1.Text.Length;

            label1.Text = rc.ToString() +" cahracters remaining";

            if(textBox1.Text.Length== 0 )
            {
                MessageBox.Show("You have reched the limit");
            }
        }
    }
}
