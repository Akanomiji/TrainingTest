namespace TrainingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //setAmount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox6.Visible = true;
            textBox7.Visible = false;
        }

        private void itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemName.Focus();

            }
        }

        private void itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                price.Focus();
            }
        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setAmount();
                qty.Focus();
            }
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setAmount();
            }
        }

        private void setAmount()
        {
            try
            {
                int amt = int.Parse(price.Text) * int.Parse(qty.Text);
                //amount.Text = amt.ToString();
                amount.Text = amt + "";
                amount.Visible = true;
            }
            catch (Exception)
            {
                qty.Text = "";
                amount.Text = "";
                //amount.Clear();
                MessageBox.Show("ใส่จำนวนผิด");
            }

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            string ms = "รหัส :" + itemCode.Text + "\n" + "ชื่อ : " + itemName.Text + "\n" + "ราคา: " + price.Text + "\n" + "จำนวน : " + qty.Text + "\n" + "เป็นเงิน: " + amount.Text + "";
            MessageBox.Show(ms, "ข้อมูลสินค้า");
        }

        private void itemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
