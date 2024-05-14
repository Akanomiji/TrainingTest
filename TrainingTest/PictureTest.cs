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
    public partial class PictureTest : Form
    {
        string[] imageList = { "1.png", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg" };
        int i = 0;
        public PictureTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\1.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\2.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\3.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\4.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\5.jpg");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\6.jpg");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\7.jpg");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\8.jpg");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\9.jpg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\10.jpg");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            i = i - 1;
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\" + imageList[i]);
            button12.Enabled = true;
            if (i == 0) 
            { 
                button11.Enabled = false; 
            }
            


            /*
            if (imageList.Length >= 0) 
            {
                i--;
                pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\" + imageList[i]);
            }
            */




            /*
            for (int i = 0; i <= imageList.Length; i--)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\" + imageList[0]);
            }
            */
        }

        private void button12_Click(object sender, EventArgs e)
        {
            i = i + 1;
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\" + imageList[i]);
            button11.Enabled = true;
            if (i == imageList.Length -1) 
            {
                button12.Enabled = false; 
            }
            
            /*
            if (imageList.Length >= 0)
            {

                i++;
                pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\" + imageList[i]);
            }
            */

            /*
            for (int i = 0; i <= imageList.Length; i++)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile("D:\\Pic\\" + imageList[0]);
            }
            */
        }
    }
}
