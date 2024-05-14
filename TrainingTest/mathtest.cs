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

        /*
        string[] choice1 = { "65", "45", "70", "69", "68" };
        string[] choice2 = { "55", "62", "69", "72", "67" };
        string[] choice3 = { "68", "69", "65", "62", "61" };
        string[] choice4 = { "69", "71", "68", "65", "69" };
        
        */

        string[] answer = { "69", "69", "69", "69", "69" };
        string[,] choice =
            {
            { "65", "55", "68", "69"},
                           { "45","62","69","71"},
                           { "70","69","65","68"},
                           { "69","72","62", "65" },
                           { "68","67","61","69"}
             };
        int i = 0;
        int score = 0;

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
            correctAns();
            /*
            string answerTrue = "";
            if (radioButton1.Checked) { answerTrue = choice1[i]; }
            else if (radioButton2.Checked) { answerTrue = choice2[i]; }
            else if (radioButton3.Checked) { answerTrue = choice3[i]; }
            else if (radioButton4.Checked) { answerTrue = choice4[i]; }

            if (answerTrue == answer[i])
            {
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
            i++;
        */
            if (i < question.Length - 1) { i++; showQuestion(); }
            else { button1.Enabled = false; }
            label4.Text = score.ToString(score + " คะแนน");


        }

        private void showQuestion()
        {
            label1.Text = question[i];
            radioButton1.Text = choice[i, 0];
            radioButton2.Text = choice[i, 1];
            radioButton3.Text = choice[i, 2];
            radioButton4.Text = choice[i, 3];
            label4.Text = score.ToString(score + " คะแนน");
        }

        private void correctAns()
        {
            string ans = "";

            if (radioButton1.Checked)
            {
                ans = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                ans = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                ans = radioButton3.Text;
            }
            else
            {
                ans = radioButton4.Text;
            }
            if (ans == answer[i])
            {
                MessageBox.Show("คำตอบถูกต้อง");
                score++;
            }

            else
            {
                MessageBox.Show("คำตอบผิด");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจนะที่จะปิด", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes) { this.Close(); }
            //ปุ่มกดออก 
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

        private void mathtest_Load(object sender, EventArgs e)
        {

        }
    }
}
