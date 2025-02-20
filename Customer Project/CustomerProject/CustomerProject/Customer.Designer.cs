namespace CustomerProject
{
    partial class Customer
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
            button1 = new Button();
            label4 = new Label();
            textcontactnumber = new TextBox();
            textcustomeraddress = new TextBox();
            textcustomername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 0, 0);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textcontactnumber);
            groupBox1.Controls.Add(textcustomeraddress);
            groupBox1.Controls.Add(textcustomername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.SplitButton;
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(452, 332);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(239, 35);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 6;
            label4.Text = "Customer Form";
            // 
            // textcontactnumber
            // 
            textcontactnumber.Location = new Point(385, 233);
            textcontactnumber.Name = "textcontactnumber";
            textcontactnumber.Size = new Size(212, 27);
            textcontactnumber.TabIndex = 5;
            textcontactnumber.KeyPress += textcontactnumber_KeyPress;
            // 
            // textcustomeraddress
            // 
            textcustomeraddress.Location = new Point(385, 169);
            textcustomeraddress.Name = "textcustomeraddress";
            textcustomeraddress.Size = new Size(212, 27);
            textcustomeraddress.TabIndex = 4;
            // 
            // textcustomername
            // 
            textcustomername.Location = new Point(384, 102);
            textcustomername.Name = "textcustomername";
            textcustomername.Size = new Size(212, 27);
            textcustomername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(53, 240);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(53, 172);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(53, 105);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(331, 26);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(199, 26);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(53, 26);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(665, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(570, 321);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.OrangeRed;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(12, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 77);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 128);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(967, 501);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "Prev";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Fuchsia;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(1141, 501);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 4;
            button6.Text = "Next";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1252, 584);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += Customer_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox textcontactnumber;
        private TextBox textcustomeraddress;
        private TextBox textcustomername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button4;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
    }
}