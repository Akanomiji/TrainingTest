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
    public partial class test_font___colors_dialog : Form
    {
        public test_font___colors_dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color; // สีตัวหนังสือ
            //label1.BackColor = colorDialog1.Color; // สีพื้นหลังตัวหนังสือ
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }
    }
}
