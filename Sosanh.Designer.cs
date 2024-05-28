namespace FormDangNhap
{
    partial class Sosanh
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
            btnTaosongaunhien = new Button();
            btnKiemTra = new Button();
            lblKetqua = new Label();
            label3 = new Label();
            label2 = new Label();
            rdoLon = new RadioButton();
            rdoNho = new RadioButton();
            rdoBang = new RadioButton();
            lblSo1 = new Label();
            lblSo2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1035, 105);
            label1.TabIndex = 2;
            label1.Text = "PHÉP SO SÁNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTaosongaunhien
            // 
            btnTaosongaunhien.BackColor = SystemColors.ActiveCaption;
            btnTaosongaunhien.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaosongaunhien.Location = new Point(818, 477);
            btnTaosongaunhien.Name = "btnTaosongaunhien";
            btnTaosongaunhien.Size = new Size(167, 53);
            btnTaosongaunhien.TabIndex = 27;
            btnTaosongaunhien.Text = "Tiếp tục";
            btnTaosongaunhien.TextAlign = ContentAlignment.TopCenter;
            btnTaosongaunhien.UseVisualStyleBackColor = false;
            btnTaosongaunhien.Click += btnTaosongaunhien_Click;
            // 
            // btnKiemTra
            // 
            btnKiemTra.BackColor = SystemColors.ActiveCaption;
            btnKiemTra.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKiemTra.Location = new Point(818, 404);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(167, 53);
            btnKiemTra.TabIndex = 26;
            btnKiemTra.Text = "Xem";
            btnKiemTra.TextAlign = ContentAlignment.TopCenter;
            btnKiemTra.UseVisualStyleBackColor = false;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // lblKetqua
            // 
            lblKetqua.BackColor = SystemColors.ActiveCaption;
            lblKetqua.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKetqua.Location = new Point(183, 481);
            lblKetqua.Name = "lblKetqua";
            lblKetqua.Size = new Size(610, 48);
            lblKetqua.TabIndex = 24;
            lblKetqua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 481);
            label3.Name = "label3";
            label3.Size = new Size(151, 46);
            label3.TabIndex = 23;
            label3.Text = "Kết quả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 404);
            label2.Name = "label2";
            label2.Size = new Size(132, 46);
            label2.TabIndex = 22;
            label2.Text = "Trả lời: ";
            // 
            // rdoLon
            // 
            rdoLon.AutoSize = true;
            rdoLon.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoLon.Location = new Point(299, 391);
            rdoLon.Margin = new Padding(3, 4, 3, 4);
            rdoLon.Name = "rdoLon";
            rdoLon.Size = new Size(80, 66);
            rdoLon.TabIndex = 28;
            rdoLon.TabStop = true;
            rdoLon.Text = ">";
            rdoLon.UseVisualStyleBackColor = true;
            // 
            // rdoNho
            // 
            rdoNho.AutoSize = true;
            rdoNho.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoNho.Location = new Point(466, 391);
            rdoNho.Margin = new Padding(3, 4, 3, 4);
            rdoNho.Name = "rdoNho";
            rdoNho.Size = new Size(80, 66);
            rdoNho.TabIndex = 29;
            rdoNho.TabStop = true;
            rdoNho.Text = "<";
            rdoNho.UseVisualStyleBackColor = true;
            // 
            // rdoBang
            // 
            rdoBang.AutoSize = true;
            rdoBang.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoBang.Location = new Point(622, 391);
            rdoBang.Margin = new Padding(3, 4, 3, 4);
            rdoBang.Name = "rdoBang";
            rdoBang.Size = new Size(80, 66);
            rdoBang.TabIndex = 30;
            rdoBang.TabStop = true;
            rdoBang.Text = "=";
            rdoBang.UseVisualStyleBackColor = true;
            // 
            // lblSo1
            // 
            lblSo1.BackColor = Color.FromArgb(255, 224, 192);
            lblSo1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo1.ForeColor = Color.Black;
            lblSo1.Location = new Point(221, 161);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(187, 189);
            lblSo1.TabIndex = 33;
            lblSo1.TextAlign = ContentAlignment.MiddleCenter;
            lblSo1.Click += lblSo1_Click;
            // 
            // lblSo2
            // 
            lblSo2.BackColor = Color.FromArgb(255, 224, 192);
            lblSo2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSo2.ForeColor = Color.Black;
            lblSo2.Location = new Point(611, 161);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(182, 189);
            lblSo2.TabIndex = 34;
            lblSo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sosanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 624);
            ControlBox = false;
            Controls.Add(lblSo2);
            Controls.Add(lblSo1);
            Controls.Add(rdoBang);
            Controls.Add(rdoNho);
            Controls.Add(rdoLon);
            Controls.Add(btnTaosongaunhien);
            Controls.Add(btnKiemTra);
            Controls.Add(lblKetqua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Sosanh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTaosongaunhien;
        private Button btnKiemTra;
        private Label lblKetqua;
        private Label label3;
        private Label label2;
        private RadioButton rdoLon;
        private RadioButton rdoNho;
        private RadioButton rdoBang;
        private Label lblSo1;
        private Label lblSo2;
    }
}