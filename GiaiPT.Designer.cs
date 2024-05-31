namespace FormDangNhap
{
    partial class GiaiPT
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            PT1 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-5, -4);
            label1.Name = "label1";
            label1.Size = new Size(1014, 110);
            label1.TabIndex = 1;
            label1.Text = "GIẢI PHƯƠNG TRÌNH - TÌM X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(PT1);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(176, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 141);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn chức năng";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(49, 80);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(266, 34);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Giải phương trình bậc 2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // PT1
            // 
            PT1.AutoSize = true;
            PT1.Location = new Point(49, 38);
            PT1.Name = "PT1";
            PT1.Size = new Size(496, 34);
            PT1.TabIndex = 0;
            PT1.TabStop = true;
            PT1.Text = "Giải phương trình bậc nhất -Tìm x biết ax+b=0";
            PT1.UseVisualStyleBackColor = true;
            PT1.CheckedChanged += PT1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(176, 303);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 3;
            label2.Text = "Nhập a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(176, 343);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Nhập b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(176, 380);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 5;
            label4.Text = "Nhập c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(176, 430);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 6;
            label5.Text = "Kết quả";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 343);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(300, 380);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(300, 435);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(314, 117);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(672, 297);
            button1.Name = "button1";
            button1.Size = new Size(236, 50);
            button1.TabIndex = 11;
            button1.Text = "Giải phương trình";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(672, 351);
            button2.Name = "button2";
            button2.Size = new Size(236, 50);
            button2.TabIndex = 12;
            button2.Text = "Làm lại";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(672, 415);
            button3.Name = "button3";
            button3.Size = new Size(236, 50);
            button3.TabIndex = 13;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // GiaiPT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 598);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GiaiPT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton PT1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}