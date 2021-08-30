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
    public partial class Form1 : Form
    {
        
        public int tryit;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void form21_Load(object sender, EventArgs e)
        {

        }

        private void form31_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)  //left
        {
            form31.LeftCorner();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)  //middle
        {
            form31.Middle();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)  //right
        {
            form31.RightCorner();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)  //font
        {
            form31.setFont(fontDialog1);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)  // color
        {
            form31.setColor(colorDialog1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)  // to the calculator
        {
            if(form31.getText().Length > 0)
            {
                if (form31.richTextBox1.SelectedText.Length > 0)
                {
                    if(Int32.TryParse(form31.richTextBox1.SelectedText, out tryit))
                    {
                        form21.setText(form31.richTextBox1.SelectedText);
                    }
                    else
                    {
                        MessageBox.Show("It's not a number");
                    }
                }
                else
                {
                    if (Int32.TryParse(form31.richTextBox1.Text, out tryit))
                    {
                        form21.setText(form31.richTextBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("It's not a number");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no text in Editor");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(form21.getText().Length > 0)
            {
                form31.setText(form21.textBox1.Text);
            }
            else
            {
                MessageBox.Show("There is no text in Calculator");
            }
        }
    }
}
