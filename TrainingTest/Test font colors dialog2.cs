using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TrainingTest
{
    public partial class Test_font_colors_dialog2 : Form
    {
        public Test_font_colors_dialog2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].Font = fontDialog1.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.ForeColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }

        private void bBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
        }

        private void bFile_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //openFileDialog1.Filter = "picture file(*.png;*.jpg)";
            //openFileDialog1.FilterIndex = 1;
            //pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.Filter = "picture file(*.png;*.jpg)";);
        }
    }
}
