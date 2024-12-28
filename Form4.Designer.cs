namespace WinFormsApp123
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            dataGridView1 = new DataGridView();
            item_name = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item_name, unit_price, quantity, total });
            dataGridView1.Location = new Point(336, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // item_name
            // 
            item_name.HeaderText = "Item name";
            item_name.Name = "item_name";
            // 
            // unit_price
            // 
            unit_price.HeaderText = "Unit Price";
            unit_price.Name = "unit_price";
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 75);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "Item Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 116);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 158);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(129, 158);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 7;
            label4.Text = "___________";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(43, 23);
            label5.Name = "label5";
            label5.Size = new Size(20, 21);
            label5.TabIndex = 8;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Items.AddRange(new object[] { "Sandwitch", "Rice", "Mango Juice", "Lemon Juice", "Burger", "Pizza", "Egg Hoppers", "Tea ", "Coffee", "Kottu" });
            listBox1.Location = new Point(654, 191);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(124, 224);
            listBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 290);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 11;
            button1.Text = "Add to cart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 191);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 12;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(129, 191);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 13;
            label7.Text = "___________";
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(221, 295);
            label8.Name = "label8";
            label8.Size = new Size(126, 21);
            label8.TabIndex = 14;
            label8.Text = "Grand Total :     ";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.Location = new Point(415, 296);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn total;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
    }
}