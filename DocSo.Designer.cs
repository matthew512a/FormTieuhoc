namespace FormDangNhap
{
    partial class DocSo
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
            btnConvert = new Button();
            lblKetqua = new Label();
            label3 = new Label();
            txtNumber = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1014, 110);
            label1.TabIndex = 3;
            label1.Text = "ĐỌC SỐ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.ActiveCaption;
            btnConvert.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.Location = new Point(434, 343);
            btnConvert.Margin = new Padding(3, 2, 3, 2);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(146, 45);
            btnConvert.TabIndex = 34;
            btnConvert.Text = "Chuyển đổi";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblKetqua
            // 
            lblKetqua.BackColor = SystemColors.ActiveCaption;
            lblKetqua.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKetqua.Location = new Point(232, 243);
            lblKetqua.Name = "lblKetqua";
            lblKetqua.Size = new Size(684, 66);
            lblKetqua.TabIndex = 33;
            lblKetqua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 255);
            label3.Name = "label3";
            label3.Size = new Size(114, 37);
            label3.TabIndex = 32;
            label3.Text = "Kết quả:";
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber.Location = new Point(232, 187);
            txtNumber.Margin = new Padding(3, 4, 3, 4);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(685, 39);
            txtNumber.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 186);
            label2.Name = "label2";
            label2.Size = new Size(122, 37);
            label2.TabIndex = 36;
            label2.Text = "Nhập số:";
            // 
            // DocSo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 598);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(txtNumber);
            Controls.Add(btnConvert);
            Controls.Add(lblKetqua);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DocSo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConvert;
        private Label lblKetqua;
        private Label label3;
        private TextBox txtNumber;
        private Label label2;
    }
}