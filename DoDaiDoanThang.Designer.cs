namespace FormDangNhap
{
    partial class DoDaiDoanThang
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
            label2 = new Label();
            label3 = new Label();
            btnBaDoanThang = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-5, 0);
            label1.Name = "label1";
            label1.Size = new Size(911, 76);
            label1.TabIndex = 0;
            label1.Text = "Bé điền kết quả vào ô dưới đây";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(259, 35);
            label2.TabIndex = 1;
            label2.Text = "1 - Tính độ dài đường gấp khúc";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 341);
            label3.Name = "label3";
            label3.Size = new Size(251, 35);
            label3.TabIndex = 2;
            label3.Text = "2 - Tính Chu vi và Diện tích";
            // 
            // btnBaDoanThang
            // 
            btnBaDoanThang.Location = new Point(753, 183);
            btnBaDoanThang.Name = "btnBaDoanThang";
            btnBaDoanThang.Size = new Size(94, 29);
            btnBaDoanThang.TabIndex = 3;
            btnBaDoanThang.Text = "Đổi đề bài";
            btnBaDoanThang.UseVisualStyleBackColor = true;
            btnBaDoanThang.Click += btnBaDoanThang_Click;
            // 
            // DoDaiDoanThang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(905, 578);
            Controls.Add(btnBaDoanThang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoDaiDoanThang";
            Text = "Độ Dài Đoạn thẳng";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBaDoanThang;
    }
}