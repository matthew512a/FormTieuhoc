namespace FormDangNhap
{
    partial class Calculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            btnXoa = new Button();
            btnBang = new Button();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, -6);
            label1.Name = "label1";
            label1.Size = new Size(1014, 110);
            label1.TabIndex = 2;
            label1.Text = "MÁY TÍNH BỎ TÚI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(200, 179);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(614, 35);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.Location = new Point(275, 251);
            button1.Name = "button1";
            button1.Size = new Size(114, 46);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button2.Location = new Point(385, 251);
            button2.Name = "button2";
            button2.Size = new Size(114, 46);
            button2.TabIndex = 5;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button3.Location = new Point(495, 251);
            button3.Name = "button3";
            button3.Size = new Size(114, 46);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button4.Location = new Point(275, 288);
            button4.Name = "button4";
            button4.Size = new Size(114, 46);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button5.Location = new Point(385, 288);
            button5.Name = "button5";
            button5.Size = new Size(114, 46);
            button5.TabIndex = 8;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button6.Location = new Point(495, 288);
            button6.Name = "button6";
            button6.Size = new Size(114, 46);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button7.Location = new Point(275, 327);
            button7.Name = "button7";
            button7.Size = new Size(114, 46);
            button7.TabIndex = 10;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button8.Location = new Point(385, 327);
            button8.Name = "button8";
            button8.Size = new Size(114, 46);
            button8.TabIndex = 11;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button9.Location = new Point(495, 327);
            button9.Name = "button9";
            button9.Size = new Size(114, 46);
            button9.TabIndex = 12;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button10.Location = new Point(385, 370);
            button10.Name = "button10";
            button10.Size = new Size(114, 46);
            button10.TabIndex = 13;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnXoa.Location = new Point(275, 370);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 46);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "C";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnBang
            // 
            btnBang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnBang.Location = new Point(495, 370);
            btnBang.Name = "btnBang";
            btnBang.Size = new Size(114, 46);
            btnBang.TabIndex = 15;
            btnBang.Text = "=";
            btnBang.UseVisualStyleBackColor = true;
            btnBang.Click += btnBang_Click;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCong.Location = new Point(616, 251);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(114, 46);
            btnCong.TabIndex = 16;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnTru.Location = new Point(616, 288);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(114, 46);
            btnTru.TabIndex = 17;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnNhan.Location = new Point(616, 327);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(114, 46);
            btnNhan.TabIndex = 18;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnChia.Location = new Point(616, 370);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(114, 46);
            btnChia.TabIndex = 19;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 598);
            ControlBox = false;
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(btnBang);
            Controls.Add(btnXoa);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btnXoa;
        private Button btnBang;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
    }
}