namespace Q7
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick; 
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
