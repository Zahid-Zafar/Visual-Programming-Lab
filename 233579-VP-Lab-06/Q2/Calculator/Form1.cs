using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        string curinp = "";
        double result = 0;
        string op = "";
        bool is_pend = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            curinp += button.Text;
            textBox1.Text = curinp;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            curinp = "";
            result = 0;
            is_pend= false;
            op = "";
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(is_pend)
            {
                calc();
            }

            Button button = (Button)sender;
            op=button.Text;
            result=double.Parse(curinp);
            curinp = "";
            is_pend = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (is_pend)
            {
                calc();
            }

            Button button = (Button)sender;
            op = button.Text;
            result = double.Parse(curinp);
            curinp = "";
            is_pend = true;
        }


        private void calc()
        {
            if(is_pend)
            {
                double inp=double.Parse(curinp);

                switch (op)
                {
                    case "+":
                        result += inp;
                        break;

                    case "-":
                        result -= inp;
                        break;

                }

                textBox1.Text=result.ToString();
                curinp = "";
                is_pend = false;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calc();
        }
    }
}
