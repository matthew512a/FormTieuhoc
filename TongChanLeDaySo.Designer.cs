namespace FormDangNhap
{
    partial class TongChanLeDaySo
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
            Label label6;
            groupBox1 = new GroupBox();
            txta = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtTongLe = new TextBox();
            txtTongChan = new TextBox();
            txtTong = new TextBox();
            txtDaySo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNhap = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.BackColor = Color.LightCoral;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(1, 9);
            label6.Name = "label6";
            label6.Size = new Size(780, 64);
            label6.TabIndex = 11;
            label6.Text = "TÍNH TỔNG CHẴN, TỔNG LẺ CÁC DÃY SỐ NGUYÊN CHO TRƯỚC";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txta);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 99);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập số";
            // 
            // txta
            // 
            txta.Location = new Point(124, 48);
            txta.Name = "txta";
            txta.Size = new Size(463, 34);
            txta.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 51);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongLe);
            groupBox2.Controls.Add(txtTongChan);
            groupBox2.Controls.Add(txtTong);
            groupBox2.Controls.Add(txtDaySo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(22, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(651, 274);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(201, 202);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(386, 34);
            txtTongLe.TabIndex = 9;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(201, 159);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(386, 34);
            txtTongChan.TabIndex = 8;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(201, 106);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(386, 34);
            txtTong.TabIndex = 7;
            // 
            // txtDaySo
            // 
            txtDaySo.Location = new Point(201, 61);
            txtDaySo.Name = "txtDaySo";
            txtDaySo.Size = new Size(386, 34);
            txtDaySo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 202);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 4;
            label5.Text = "Tổng lẻ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 154);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 3;
            label4.Text = "Tổng chẵn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 109);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 2;
            label3.Text = "Tổng dãy số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 1;
            label2.Text = "Dãy số vừa nhập";
            label2.Click += label2_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = SystemColors.ActiveCaption;
            btnNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhap.Location = new Point(310, 188);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(108, 39);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // TongChanLeDaySo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 574);
            Controls.Add(label6);
            Controls.Add(btnNhap);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TongChanLeDaySo";
            Text = "TongChanLeDaySo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txta;
        private TextBox txtTongLe;
        private TextBox txtTongChan;
        private TextBox txtTong;
        private TextBox txtDaySo;
        private Button btnNhap;
        private Label label6;
    }
}