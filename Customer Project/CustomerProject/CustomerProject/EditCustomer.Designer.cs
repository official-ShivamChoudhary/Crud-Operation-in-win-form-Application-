namespace CustomerProject
{
    partial class EditCustomer
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
            textcontactnumber = new TextBox();
            textcustomeraddress = new TextBox();
            textcustomername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textId = new TextBox();
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
            groupBox1.Controls.Add(textcontactnumber);
            groupBox1.Controls.Add(textcustomeraddress);
            groupBox1.Controls.Add(textcustomername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(234, 23);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 7;
            label6.Text = "Customer Update Form";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(393, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textcontactnumber
            // 
            textcontactnumber.Location = new Point(320, 190);
            textcontactnumber.Name = "textcontactnumber";
            textcontactnumber.Size = new Size(230, 27);
            textcontactnumber.TabIndex = 5;
            textcontactnumber.KeyPress += textcontactnumber_KeyPress;
            // 
            // textcustomeraddress
            // 
            textcustomeraddress.Location = new Point(320, 134);
            textcustomeraddress.Name = "textcustomeraddress";
            textcustomeraddress.Size = new Size(230, 27);
            textcustomeraddress.TabIndex = 4;
            // 
            // textcustomername
            // 
            textcustomername.Location = new Point(320, 76);
            textcustomername.Name = "textcustomername";
            textcustomername.Size = new Size(230, 27);
            textcustomername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 197);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 137);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Address :  ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 79);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name : ";
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(454, 34);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 128, 0);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textId);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(14, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(604, 103);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(325, 36);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textId
            // 
            textId.Location = new Point(124, 36);
            textId.Name = "textId";
            textId.Size = new Size(182, 27);
            textId.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 38);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 0;
            label5.Text = "CustomerId :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(639, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(567, 263);
            dataGridView1.TabIndex = 2;
          
            // 
            // button4
            // 
            button4.BackColor = Color.Cyan;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(968, 435);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Prev";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(1112, 433);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // EditCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1218, 485);
            ControlBox = false;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EditCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCustomer";
            Load += EditCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textcontactnumber;
        private TextBox textcustomeraddress;
        private TextBox textcustomername;
        private Label label4;
        private TextBox textcustomerId;
        private GroupBox groupBox2;
        private TextBox textId;
        private Label label5;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Label label6;
    }
}