namespace CustomerProject
{
    partial class DeleteCustomer
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            button1 = new Button();
            textnumber = new TextBox();
            textaddress = new TextBox();
            textname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            button3 = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 0, 0);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textnumber);
            groupBox1.Controls.Add(textaddress);
            groupBox1.Controls.Add(textname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 353);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(262, 32);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 8;
            label6.Text = "Delete Customer Form ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(428, 296);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textnumber
            // 
            textnumber.Location = new Point(337, 233);
            textnumber.Name = "textnumber";
            textnumber.Size = new Size(252, 27);
            textnumber.TabIndex = 5;
            textnumber.KeyPress += textnumber_KeyPress;
            // 
            // textaddress
            // 
            textaddress.Location = new Point(337, 173);
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(252, 27);
            textaddress.TabIndex = 4;
            // 
            // textname
            // 
            textname.Location = new Point(337, 110);
            textname.Name = "textname";
            textname.Size = new Size(252, 27);
            textname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 240);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 176);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 113);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name :";
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(491, 47);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 128, 0);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(16, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(642, 104);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(321, 43);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 46);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 0;
            label5.Text = "CustomerId :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(676, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(571, 286);
            dataGridView1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(967, 516);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Prev";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 255, 128);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(1153, 516);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // DeleteCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1258, 573);
            ControlBox = false;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DeleteCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteCustomer";
            Load += DeleteCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox textnumber;
        private TextBox textaddress;
        private TextBox textname;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textId;
        private Label label4;
        private GroupBox groupBox2;
        private Label label5;
        private Button button3;
      
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label6;
        private Button button4;
        private Button button5;
    }
}