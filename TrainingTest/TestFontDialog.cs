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
    public partial class TestFontDialog : Form
    {
        public TestFontDialog()
        {
            InitializeComponent();
        }

        private void bFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            /*
            label1.Font = fontDialog1.Font;
            label2.Font = fontDialog1.Font;
            label3.Font = fontDialog1.Font;
            label4.Font = fontDialog1.Font;
            label5.Font = fontDialog1.Font;
            label6.Font = fontDialog1.Font;
            label7.Font = fontDialog1.Font;
            label8.Font = fontDialog1.Font;
            label9.Font = fontDialog1.Font;
            label10.Font = fontDialog1.Font;
            ShowData.Font = fontDialog1.Font;
            */
            //this.Controls[0].Font = fontDialog1.Font;

            for (int i=0; i < groupBox1.Controls.Count; i++)
            {
                groupBox1.Controls[i].Font = fontDialog1.Font;
            }
            //MessageBox.Show(this.Controls.Count + "");
        }

        
    }
}
