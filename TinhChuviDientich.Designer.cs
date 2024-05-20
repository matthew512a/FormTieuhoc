namespace FormDangNhap
{
    partial class TinhChuviDientich
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
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            txtCanh1 = new TextBox();
            Dientich = new TextBox();
            Chuvi = new TextBox();
            txtCanh3 = new TextBox();
            txtCanh2 = new TextBox();
            button1 = new Button();
            lbCanh1 = new Label();
            lbCanh2 = new Label();
            lbCanh3 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-57, 9);
            label1.Name = "label1";
            label1.Size = new Size(962, 79);
            label1.TabIndex = 1;
            label1.Text = "TÍNH CHU VI DIỆN TÍCH CÁC HÌNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(68, 175);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 34);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "Tròn";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(68, 295);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(119, 34);
            radioButton3.TabIndex = 4;
            radioButton3.Text = "Tam Giác";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(68, 215);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(96, 34);
            radioButton4.TabIndex = 5;
            radioButton4.Text = "Vuông";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += radioButton4_Click;
            // 
            // txtCanh1
            // 
            txtCanh1.Location = new Point(648, 175);
            txtCanh1.Name = "txtCanh1";
            txtCanh1.Size = new Size(107, 23);
            txtCanh1.TabIndex = 6;
            txtCanh1.KeyPress += txtCanh1_KeyPress;
            // 
            // Dientich
            // 
            Dientich.Location = new Point(619, 406);
            Dientich.Name = "Dientich";
            Dientich.Size = new Size(107, 23);
            Dientich.TabIndex = 8;
            // 
            // Chuvi
            // 
            Chuvi.Location = new Point(619, 373);
            Chuvi.Name = "Chuvi";
            Chuvi.Size = new Size(107, 23);
            Chuvi.TabIndex = 9;
            // 
            // txtCanh3
            // 
            txtCanh3.Location = new Point(648, 264);
            txtCanh3.Name = "txtCanh3";
            txtCanh3.Size = new Size(107, 23);
            txtCanh3.TabIndex = 10;
            txtCanh3.KeyPress += txtCanh3_KeyPress;
            // 
            // txtCanh2
            // 
            txtCanh2.Location = new Point(648, 222);
            txtCanh2.Name = "txtCanh2";
            txtCanh2.Size = new Size(107, 23);
            txtCanh2.TabIndex = 11;
            txtCanh2.KeyPress += txtCanh2_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(312, 222);
            button1.Name = "button1";
            button1.Size = new Size(121, 107);
            button1.TabIndex = 12;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbCanh1
            // 
            lbCanh1.AutoSize = true;
            lbCanh1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCanh1.Location = new Point(521, 168);
            lbCanh1.Name = "lbCanh1";
            lbCanh1.Size = new Size(78, 30);
            lbCanh1.TabIndex = 15;
            lbCanh1.Text = "Cạnh 1";
            // 
            // lbCanh2
            // 
            lbCanh2.AutoSize = true;
            lbCanh2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCanh2.Location = new Point(521, 215);
            lbCanh2.Name = "lbCanh2";
            lbCanh2.Size = new Size(78, 30);
            lbCanh2.TabIndex = 16;
            lbCanh2.Text = "Cạnh 2";
            // 
            // lbCanh3
            // 
            lbCanh3.AutoSize = true;
            lbCanh3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCanh3.Location = new Point(521, 257);
            lbCanh3.Name = "lbCanh3";
            lbCanh3.Size = new Size(78, 30);
            lbCanh3.TabIndex = 17;
            lbCanh3.Text = "Cạnh 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(521, 369);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 18;
            label5.Text = "Chu vi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(521, 399);
            label6.Name = "label6";
            label6.Size = new Size(96, 30);
            label6.TabIndex = 19;
            label6.Text = "Diện tích";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(68, 255);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(126, 34);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Chữ Nhật";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // TinhChuviDientich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 548);
            Controls.Add(radioButton2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbCanh3);
            Controls.Add(lbCanh2);
            Controls.Add(lbCanh1);
            Controls.Add(button1);
            Controls.Add(txtCanh2);
            Controls.Add(txtCanh3);
            Controls.Add(Chuvi);
            Controls.Add(Dientich);
            Controls.Add(txtCanh1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "TinhChuviDientich";
            Text = "TinhChuviDientich";
            Load += TinhChuviDientich_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox txtCanh1;
        private TextBox Dientich;
        private TextBox Chuvi;
        private TextBox txtCanh3;
        private TextBox txtCanh2;
        private Button button1;
        private Label lbCanh1;
        private Label lbCanh2;
        private Label lbCanh3;
        private Label label5;
        private Label label6;
        private RadioButton radioButton2;
    }
}