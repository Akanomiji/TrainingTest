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
    public partial class mathtest : Form
    {
        string[] question = { "24 + 45 = ?", "31 + 38 = ?", " 29 + 40 = ?", "15 + 54 = ?", "12 + 57 = ?" };
        string[] choice1 = { "65", "45", "70", "69", "68" };
        string[] choice2 = { "55", "62", "69", "72", "67" };
        string[] choice3 = { "68", "69", "65", "62", "61" };
        string[] choice4 = { "69", "71", "68", "65", "69" };
        string[] answer = { "69", "69", "69", "69", "69" };
        int i = 0;

        public mathtest()
        {
            InitializeComponent();
            /*
            label1.Text = question[i];
            radioButton1.Text = choice1[i];
            radioButton2.Text = choice2[i];
            radioButton3.Text = choice3[i];
            radioButton4.Text = choice4[i];
            */
            showQuestion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answerTrue = "";
            if (radioButton1.Checked == true) { answerTrue = choice1[i]; }
            else if (radioButton2.Checked == true) { answerTrue = choice2[i]; }
            else if (radioButton3.Checked == true) { answerTrue = choice3[i]; }
            else if (radioButton4.Checked == true) { answerTrue = choice4[i]; }

            if (answerTrue == answer[i])
            {
                i++;

                if (i == question.Length)
                {
                    MessageBox.Show("คำตอบถูกทั้งหมด");
                    i = 0;
                }
                label1.Text = question[i];
                radioButton1.Text = choice1[i];
                radioButton2.Text = choice2[i];
                radioButton3.Text = choice3[i];
                radioButton4.Text = choice4[i];
            }
            else 
            { 
                MessageBox.Show("คำตอบผิด"); 
            }
            
        }

        private void showQuestion() 
        {
            label1.Text = question[i];
            radioButton1.Text = choice1[i];
            radioButton2.Text = choice2[i];
            radioButton3.Text = choice3[i];
            radioButton4.Text = choice4[i];
        }




















        private void button2_Click(object sender, EventArgs e)
        {
            /*
            label1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            button1.Enabled = true;
            */
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            button1.Visible = true;
            button2.Enabled = false;
            button2.Visible = false;
            if (i == 0) { }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                button1.Visible = true;
                button2.Enabled = false;
                button2.Visible = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
