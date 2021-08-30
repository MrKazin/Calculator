using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form3 : UserControl
    {
        public string openfilename;
        public string savefilename;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openfilename = openFileDialog1.FileName;
            }
            richTextBox1.LoadFile(openfilename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savefilename = openFileDialog1.FileName;
            }
            richTextBox1.SaveFile(savefilename);
        }

        public void setText(string str)
        {
            richTextBox1.Text = str;
        }

        public string getText()
        {
            return richTextBox1.Text;
        }

        public void LeftCorner()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        public void Middle()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void RightCorner()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        public void setFont(FontDialog f)
        {
            if(richTextBox1.Text.Length > 0)
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (richTextBox1.SelectedText.Length > 0)
                    {
                        this.richTextBox1.SelectionFont = f.Font;
                    }
                    else
                    {
                        this.richTextBox1.Font = f.Font;
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no text in RichtextBox");
            }
        }

        public void setColor(ColorDialog c)
        {
            if(richTextBox1.Text.Length > 0)
            {
                if (c.ShowDialog() == DialogResult.OK)
                {
                    if (richTextBox1.SelectedText.Length > 0)
                    {
                        this.richTextBox1.SelectionColor = c.Color;
                    }
                    else
                    {
                        this.richTextBox1.ForeColor = c.Color;
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no text in RichtextBox");
            }
        }

    }
}
