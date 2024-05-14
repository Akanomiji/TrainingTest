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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }
        string d="";
        string desserts = "";
        string food = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            { d += radioButton1.Text; }
            if (radioButton2.Checked == true) { d += radioButton2.Text; }
            if (radioButton3.Checked == true) { d += radioButton3.Text; }
            MessageBox.Show(d);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //string desserts = "";
            if (checkBox1.Checked == true) { desserts += checkBox1.Text +"\n"; }
            
            if (checkBox2.Checked == true) { desserts += checkBox2.Text + "\n"; }
            if (checkBox3.Checked == true) { desserts += checkBox3.Text + "\n"; }
            if (checkBox4.Checked == true) { desserts += checkBox4.Text + "\n"; }
            if (checkBox5.Checked == true) { desserts += checkBox5.Text + "\n"; }
            MessageBox.Show(desserts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            food = (string)comboBox1.SelectedItem;
            //string food = (string)comboBox1.SelectedItem;
            MessageBox.Show(food);
        }

        /*
        private void drink(string=drinks) {
            string drinks;
            if (radioButton1.Checked == true)
            { radioButton1.Text += drink; }
            if (radioButton2.Checked == true) { radioButton2.Text += drink; }
            if (radioButton3.Checked == true) { radioButton3.Text += drink; }
            
            if (radioButton1.Checked == true)
            { MessageBox.Show(radioButton1.Text); }
            else if (radioButton2.Checked == true) { MessageBox.Show(radioButton2.Text); }
            else if (radioButton3.Checked == true) { MessageBox.Show(radioButton3.Text); }
            
        }
        */

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(d+"\n"+desserts+"\n"+food+"");
            

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
    }
}
