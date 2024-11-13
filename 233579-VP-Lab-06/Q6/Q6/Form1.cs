using System;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Q6
{
    public partial class Form1 : Form
    {
        decimal sec = 10;

        NumericUpDown n = new NumericUpDown();
        
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval= 200;
            timer.Tick += Timer_Tick;

        }

        

        public void button1_Click(object sender, EventArgs e)
        {
            //decimal sec = 0;

            //NumericUpDown n=new NumericUpDown();

            sec=n.Value;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
            {
                sec--; // Decrement the countdown time
                label3.Text = sec + " Seconds"; // Update the label
            }
            else
            {
                timer.Stop(); // Stop the timer when countdown reaches zero
                label3.Text = "Time Over!";
                MessageBox.Show("Time Over!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
