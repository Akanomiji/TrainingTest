namespace TrainingTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemCode = new TextBox();
            itemName = new TextBox();
            price = new TextBox();
            qty = new TextBox();
            amount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label10 = new Label();
            ShowData = new Button();
            SuspendLayout();
            // 
            // itemCode
            // 
            itemCode.Font = new Font("Segoe UI", 9.75F);
            itemCode.Location = new Point(57, 70);
            itemCode.Name = "itemCode";
            itemCode.Size = new Size(100, 25);
            itemCode.TabIndex = 0;
            itemCode.TextChanged += textBox1_TextChanged;
            itemCode.KeyDown += itemCode_KeyDown;
            itemCode.KeyPress += itemCode_KeyPress;
            // 
            // itemName
            // 
            itemName.Font = new Font("Segoe UI", 9.75F);
            itemName.Location = new Point(221, 70);
            itemName.Name = "itemName";
            itemName.Size = new Size(264, 25);
            itemName.TabIndex = 1;
            itemName.KeyDown += itemName_KeyDown;
            // 
            // price
            // 
            price.Font = new Font("Segoe UI", 9.75F);
            price.Location = new Point(57, 177);
            price.Name = "price";
            price.Size = new Size(100, 25);
            price.TabIndex = 2;
            price.Text = "0";
            price.KeyDown += price_KeyDown;
            // 
            // qty
            // 
            qty.Font = new Font("Segoe UI", 9.75F);
            qty.Location = new Point(256, 177);
            qty.Name = "qty";
            qty.Size = new Size(100, 25);
            qty.TabIndex = 3;
            qty.Text = "0";
            qty.KeyDown += qty_KeyDown;
            // 
            // amount
            // 
            amount.Enabled = false;
            amount.Font = new Font("Segoe UI", 9.75F);
            amount.Location = new Point(432, 177);
            amount.Name = "amount";
            amount.Size = new Size(100, 25);
            amount.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(57, 43);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 5;
            label1.Text = "รหัส";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(221, 43);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 6;
            label2.Text = "ชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(57, 150);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 7;
            label3.Text = "ราคา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(256, 150);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 8;
            label4.Text = "จำนวน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(432, 150);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 9;
            label5.Text = "เป็นเงิน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(163, 181);
            label6.Name = "label6";
            label6.Size = new Size(35, 21);
            label6.TabIndex = 10;
            label6.Text = "บาท";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(362, 181);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 11;
            label7.Text = "ชิ้น";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(538, 181);
            label8.Name = "label8";
            label8.Size = new Size(35, 21);
            label8.TabIndex = 12;
            label8.Text = "บาท";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(57, 239);
            label9.Name = "label9";
            label9.Size = new Size(42, 21);
            label9.TabIndex = 13;
            label9.Text = "แสดง";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9.75F);
            textBox6.Location = new Point(57, 263);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(335, 25);
            textBox6.TabIndex = 14;
            textBox6.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9.75F);
            textBox7.Location = new Point(57, 346);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(335, 25);
            textBox7.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(57, 322);
            label10.Name = "label10";
            label10.Size = new Size(38, 21);
            label10.TabIndex = 15;
            label10.Text = "ซ่อน";
            // 
            // ShowData
            // 
            ShowData.BackColor = SystemColors.HighlightText;
            ShowData.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowData.ForeColor = SystemColors.ActiveCaptionText;
            ShowData.Location = new Point(629, 43);
            ShowData.Name = "ShowData";
            ShowData.Size = new Size(165, 159);
            ShowData.TabIndex = 17;
            ShowData.Text = "ShowData";
            ShowData.UseVisualStyleBackColor = false;
            ShowData.Click += ShowData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(911, 435);
            Controls.Add(ShowData);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(amount);
            Controls.Add(qty);
            Controls.Add(price);
            Controls.Add(itemName);
            Controls.Add(itemCode);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox itemCode;
        private TextBox itemName;
        private TextBox price;
        private TextBox qty;
        private TextBox amount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label10;
        private Button ShowData;
    }
}
