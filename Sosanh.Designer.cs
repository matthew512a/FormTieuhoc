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
            btnTiepTuc = new Button();
            btnXem = new Button();
            txtDoan = new TextBox();
            lblKq = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-72, 9);
            label1.Name = "label1";
            label1.Size = new Size(962, 79);
            label1.TabIndex = 2;
            label1.Text = "PHÉP SO SÁNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = SystemColors.ActiveCaption;
            btnTiepTuc.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTiepTuc.Location = new Point(716, 322);
            btnTiepTuc.Margin = new Padding(3, 2, 3, 2);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(146, 40);
            btnTiepTuc.TabIndex = 27;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.TextAlign = ContentAlignment.TopCenter;
            btnTiepTuc.UseVisualStyleBackColor = false;
            // 
            // btnXem
            // 
            btnXem.BackColor = SystemColors.ActiveCaption;
            btnXem.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXem.Location = new Point(716, 261);
            btnXem.Margin = new Padding(3, 2, 3, 2);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(146, 40);
            btnXem.TabIndex = 26;
            btnXem.Text = "Xem";
            btnXem.TextAlign = ContentAlignment.TopCenter;
            btnXem.UseVisualStyleBackColor = false;
            // 
            // txtDoan
            // 
            txtDoan.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDoan.Location = new Point(167, 266);
            txtDoan.Margin = new Padding(3, 2, 3, 2);
            txtDoan.Multiline = true;
            txtDoan.Name = "txtDoan";
            txtDoan.Size = new Size(534, 36);
            txtDoan.TabIndex = 25;
            // 
            // lblKq
            // 
            lblKq.BackColor = SystemColors.ActiveCaption;
            lblKq.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKq.Location = new Point(167, 320);
            lblKq.Name = "lblKq";
            lblKq.Size = new Size(534, 36);
            lblKq.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 322);
            label3.Name = "label3";
            label3.Size = new Size(114, 37);
            label3.TabIndex = 23;
            label3.Text = "Kết quả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 266);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 22;
            label2.Text = "Trả lời: ";
            // 
            // Sosanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 445);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnXem);
            Controls.Add(txtDoan);
            Controls.Add(lblKq);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sosanh";
            Text = "Sosanh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTiepTuc;
        private Button btnXem;
        private TextBox txtDoan;
        private Label lblKq;
        private Label label3;
        private Label label2;
    }
}