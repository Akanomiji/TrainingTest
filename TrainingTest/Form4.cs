using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingTest
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "+";
            textBox1.Clear();
        }



        private void bMinus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "-";
            textBox1.Clear();
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "*";
            textBox1.Clear();
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "/";
            textBox1.Clear();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            /*
            double add = double.Parse(label1.Text) + double.Parse(textBox1.Text);
            textBox1.Text = add.ToString();
            */
            double answer = 0;


            switch (label2.Text)
            {
                case "+":
                    answer = double.Parse(label1.Text) + double.Parse(textBox1.Text);
                    break;
                case "-":
                    answer = double.Parse(label1.Text) - double.Parse(textBox1.Text);
                    break;
                case "*":
                    answer = double.Parse(label1.Text) * double.Parse(textBox1.Text);
                    break;
                case "/":
                    answer = double.Parse(label1.Text) / double.Parse(textBox1.Text);
                    break;
                default: break;

            }
            textBox1.Text = answer.ToString();

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = " ";
            label2.Text = " ";
        }

        private void bClearEntry_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*
            string st = "123456789";
            MessageBox.Show(st.Length + "");
            st = st.Remove(st.Length - 1);
            MessageBox.Show(st);
            */
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
    }
}
