using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name.Focus();
            }
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                salary.Focus();
            }
        }

        private void salary_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                float t = float.Parse(salary.Text) * 5 / 100;
                tax.Text = t.ToString();
                float b = float.Parse(salary.Text) - t;
                balance.Text = b.ToString();
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ms = "รหัส :" + code.Text + "\n" + "ชื่อ : " + name.Text + "\n" + "เงินเดือน : " + salary.Text + "\n" + "ภาษี 5% : " + tax.Text + "\n" + "คงเหลือ: " + balance.Text + "";
            MessageBox.Show(ms, "เงินเดือน");
        }
    }
}
