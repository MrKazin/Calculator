using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form2 : UserControl
    {
        float a, b;
        int counter;
        bool simbol = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button2_Click(object sender, EventArgs e) //,,,,
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button8_Click(object sender, EventArgs e) //----
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            counter = 2;
            label1.Text = a.ToString() + "-";
            simbol = true;
        }

        private void button4_Click(object sender, EventArgs e) //++++
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            counter = 1;
            label1.Text = a.ToString() + "+";
            simbol = true;
        }

        private void button17_Click(object sender, EventArgs e) // CeCeCe
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e) //****
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            counter = 3;
            label1.Text = a.ToString() + "*";
            simbol = true;
        }

        private void button16_Click(object sender, EventArgs e) //////
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            counter = 4;
            label1.Text = a.ToString() + "/";
            simbol = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        public void calculate()
        {
            switch (counter)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }


        public void setText(string str)
        {
            textBox1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (simbol.Equals(true))
            {
                textBox1.Text = "-" + textBox1.Text;
                simbol = false;
            }
            else if (simbol.Equals(false))
            {
                textBox1.Text = textBox1.Text.Replace("-","");
                simbol = true;
            }
        }

        public string getText()
        {
            return textBox1.Text;
        }
    }
}
