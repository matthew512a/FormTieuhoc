namespace FormDangNhap
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            btnGame = new Button();
            button2 = new Button();
            button1 = new Button();
            btnSoSanh = new Button();
            btnShowDocSoThanhChu = new Button();
            btnShowTongChanLeDaySo = new Button();
            btnShowChuviDientic = new Button();
            btnShowPhepToanPhanSo = new Button();
            btnShowPhepToan3So = new Button();
            BtnShowPhepToan2So = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnGame);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSoSanh);
            panel1.Controls.Add(btnShowDocSoThanhChu);
            panel1.Controls.Add(btnShowTongChanLeDaySo);
            panel1.Controls.Add(btnShowChuviDientic);
            panel1.Controls.Add(btnShowPhepToanPhanSo);
            panel1.Controls.Add(btnShowPhepToan3So);
            panel1.Controls.Add(BtnShowPhepToan2So);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 665);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(64, 0, 0);
            button4.Image = Properties.Resources.calculator;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 471);
            button4.Name = "button4";
            button4.Size = new Size(248, 45);
            button4.TabIndex = 14;
            button4.Text = "               Máy tính bỏ túi";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(64, 0, 0);
            button3.Image = Properties.Resources.X;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 426);
            button3.Name = "button3";
            button3.Size = new Size(248, 45);
            button3.TabIndex = 13;
            button3.Text = "               Tìm x";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnGame
            // 
            btnGame.AutoSize = true;
            btnGame.Cursor = Cursors.Hand;
            btnGame.Dock = DockStyle.Top;
            btnGame.FlatAppearance.BorderSize = 0;
            btnGame.FlatStyle = FlatStyle.Flat;
            btnGame.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGame.ForeColor = Color.FromArgb(64, 0, 0);
            btnGame.Image = Properties.Resources.console;
            btnGame.ImageAlign = ContentAlignment.MiddleLeft;
            btnGame.Location = new Point(0, 370);
            btnGame.Name = "btnGame";
            btnGame.Size = new Size(248, 56);
            btnGame.TabIndex = 12;
            btnGame.Text = "               Game xúc xắc";
            btnGame.TextAlign = ContentAlignment.MiddleLeft;
            btnGame.UseVisualStyleBackColor = true;
            btnGame.Click += btnGame_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 575);
            button2.Name = "button2";
            button2.Size = new Size(248, 45);
            button2.TabIndex = 11;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 620);
            button1.Name = "button1";
            button1.Size = new Size(248, 45);
            button1.TabIndex = 10;
            button1.Text = "          QUAY LẠI";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSoSanh
            // 
            btnSoSanh.Cursor = Cursors.Hand;
            btnSoSanh.Dock = DockStyle.Top;
            btnSoSanh.FlatAppearance.BorderSize = 0;
            btnSoSanh.FlatStyle = FlatStyle.Flat;
            btnSoSanh.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSoSanh.ForeColor = Color.FromArgb(64, 0, 0);
            btnSoSanh.Image = Properties.Resources.icons8_average_math_48;
            btnSoSanh.ImageAlign = ContentAlignment.MiddleLeft;
            btnSoSanh.Location = new Point(0, 325);
            btnSoSanh.Name = "btnSoSanh";
            btnSoSanh.Size = new Size(248, 45);
            btnSoSanh.TabIndex = 9;
            btnSoSanh.Text = "               Phép so sánh";
            btnSoSanh.TextAlign = ContentAlignment.MiddleLeft;
            btnSoSanh.UseVisualStyleBackColor = true;
            btnSoSanh.Click += btnSoSanh_Click;
            // 
            // btnShowDocSoThanhChu
            // 
            btnShowDocSoThanhChu.Cursor = Cursors.Hand;
            btnShowDocSoThanhChu.Dock = DockStyle.Top;
            btnShowDocSoThanhChu.FlatAppearance.BorderSize = 0;
            btnShowDocSoThanhChu.FlatStyle = FlatStyle.Flat;
            btnShowDocSoThanhChu.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowDocSoThanhChu.ForeColor = Color.FromArgb(64, 0, 0);
            btnShowDocSoThanhChu.Image = Properties.Resources.icons8_cloud_lightning_481;
            btnShowDocSoThanhChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowDocSoThanhChu.Location = new Point(0, 280);
            btnShowDocSoThanhChu.Name = "btnShowDocSoThanhChu";
            btnShowDocSoThanhChu.Size = new Size(248, 45);
            btnShowDocSoThanhChu.TabIndex = 8;
            btnShowDocSoThanhChu.Text = "               Đọc số thành chữ";
            btnShowDocSoThanhChu.TextAlign = ContentAlignment.MiddleLeft;
            btnShowDocSoThanhChu.UseVisualStyleBackColor = true;
            btnShowDocSoThanhChu.Click += btnShowDocSoThanhChu_Click;
            // 
            // btnShowTongChanLeDaySo
            // 
            btnShowTongChanLeDaySo.Cursor = Cursors.Hand;
            btnShowTongChanLeDaySo.Dock = DockStyle.Top;
            btnShowTongChanLeDaySo.FlatAppearance.BorderSize = 0;
            btnShowTongChanLeDaySo.FlatStyle = FlatStyle.Flat;
            btnShowTongChanLeDaySo.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowTongChanLeDaySo.ForeColor = Color.FromArgb(64, 0, 0);
            btnShowTongChanLeDaySo.Image = (Image)resources.GetObject("btnShowTongChanLeDaySo.Image");
            btnShowTongChanLeDaySo.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowTongChanLeDaySo.Location = new Point(0, 235);
            btnShowTongChanLeDaySo.Name = "btnShowTongChanLeDaySo";
            btnShowTongChanLeDaySo.Size = new Size(248, 45);
            btnShowTongChanLeDaySo.TabIndex = 7;
            btnShowTongChanLeDaySo.Text = "               Tổng chẵn lẻ dãy số";
            btnShowTongChanLeDaySo.TextAlign = ContentAlignment.MiddleLeft;
            btnShowTongChanLeDaySo.UseVisualStyleBackColor = true;
            btnShowTongChanLeDaySo.Click += btnShowTongChanLeDaySo_Click;
            // 
            // btnShowChuviDientic
            // 
            btnShowChuviDientic.Cursor = Cursors.Hand;
            btnShowChuviDientic.Dock = DockStyle.Top;
            btnShowChuviDientic.FlatAppearance.BorderSize = 0;
            btnShowChuviDientic.FlatStyle = FlatStyle.Flat;
            btnShowChuviDientic.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowChuviDientic.ForeColor = Color.FromArgb(64, 0, 0);
            btnShowChuviDientic.Image = Properties.Resources.icons8_135_degrees_482;
            btnShowChuviDientic.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowChuviDientic.Location = new Point(0, 190);
            btnShowChuviDientic.Name = "btnShowChuviDientic";
            btnShowChuviDientic.Size = new Size(248, 45);
            btnShowChuviDientic.TabIndex = 6;
            btnShowChuviDientic.Text = "               Chu vi, Diện tích";
            btnShowChuviDientic.TextAlign = ContentAlignment.MiddleLeft;
            btnShowChuviDientic.UseVisualStyleBackColor = true;
            btnShowChuviDientic.Click += btnShowChuviDientic_Click;
            // 
            // btnShowPhepToanPhanSo
            // 
            btnShowPhepToanPhanSo.Cursor = Cursors.Hand;
            btnShowPhepToanPhanSo.Dock = DockStyle.Top;
            btnShowPhepToanPhanSo.FlatAppearance.BorderSize = 0;
            btnShowPhepToanPhanSo.FlatStyle = FlatStyle.Flat;
            btnShowPhepToanPhanSo.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPhepToanPhanSo.ForeColor = Color.FromArgb(64, 0, 0);
            btnShowPhepToanPhanSo.Image = Properties.Resources.icons8_mathway_48;
            btnShowPhepToanPhanSo.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowPhepToanPhanSo.Location = new Point(0, 145);
            btnShowPhepToanPhanSo.Name = "btnShowPhepToanPhanSo";
            btnShowPhepToanPhanSo.Size = new Size(248, 45);
            btnShowPhepToanPhanSo.TabIndex = 5;
            btnShowPhepToanPhanSo.Text = "               Phép toán Phân số";
            btnShowPhepToanPhanSo.TextAlign = ContentAlignment.MiddleLeft;
            btnShowPhepToanPhanSo.UseVisualStyleBackColor = true;
            btnShowPhepToanPhanSo.Click += btnShowPhepToanPhanSo_Click;
            // 
            // btnShowPhepToan3So
            // 
            btnShowPhepToan3So.Cursor = Cursors.Hand;
            btnShowPhepToan3So.Dock = DockStyle.Top;
            btnShowPhepToan3So.FlatAppearance.BorderSize = 0;
            btnShowPhepToan3So.FlatStyle = FlatStyle.Flat;
            btnShowPhepToan3So.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPhepToan3So.ForeColor = Color.FromArgb(64, 0, 0);
            btnShowPhepToan3So.Image = Properties.Resources.icons8_windsock_48;
            btnShowPhepToan3So.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowPhepToan3So.Location = new Point(0, 100);
            btnShowPhepToan3So.Name = "btnShowPhepToan3So";
            btnShowPhepToan3So.Size = new Size(248, 45);
            btnShowPhepToan3So.TabIndex = 4;
            btnShowPhepToan3So.Text = "               Phép toán 3 số";
            btnShowPhepToan3So.TextAlign = ContentAlignment.MiddleLeft;
            btnShowPhepToan3So.UseVisualStyleBackColor = true;
            btnShowPhepToan3So.Click += btnShowPhepToan3So_Click;
            // 
            // BtnShowPhepToan2So
            // 
            BtnShowPhepToan2So.Cursor = Cursors.Hand;
            BtnShowPhepToan2So.Dock = DockStyle.Top;
            BtnShowPhepToan2So.FlatAppearance.BorderSize = 0;
            BtnShowPhepToan2So.FlatStyle = FlatStyle.Flat;
            BtnShowPhepToan2So.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnShowPhepToan2So.ForeColor = Color.FromArgb(64, 0, 0);
            BtnShowPhepToan2So.Image = (Image)resources.GetObject("BtnShowPhepToan2So.Image");
            BtnShowPhepToan2So.ImageAlign = ContentAlignment.MiddleLeft;
            BtnShowPhepToan2So.Location = new Point(0, 55);
            BtnShowPhepToan2So.Name = "BtnShowPhepToan2So";
            BtnShowPhepToan2So.Size = new Size(248, 45);
            BtnShowPhepToan2So.TabIndex = 3;
            BtnShowPhepToan2So.Text = "               Phép toán 2 số";
            BtnShowPhepToan2So.TextAlign = ContentAlignment.MiddleLeft;
            BtnShowPhepToan2So.UseVisualStyleBackColor = true;
            BtnShowPhepToan2So.Click += BtnShowPhepToan2So_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 55);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(59, 28);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 13;
            label2.Text = "Người dùng: admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(59, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 12;
            label1.Text = "NHÓM 5";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.icons8_stationery_50;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 53);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(248, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1025, 55);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(130, 9);
            label3.Name = "label3";
            label3.Size = new Size(615, 30);
            label3.TabIndex = 1;
            label3.Text = "CHƯƠNG TRÌNH GIẢI MỘT SỐ DẠNG BÀI TOÁN TIỂU HỌC";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.icons8_menu_50;
            pictureBox2.Location = new Point(9, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 45);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(254, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(1014, 600);
            panel4.TabIndex = 4;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 665);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Panel panel2;
        private Button BtnShowPhepToan2So;
        private Panel panel3;
        private Panel panel4;
        private Button btnSoSanh;
        private Button btnShowDocSoThanhChu;
        private Button btnShowTongChanLeDaySo;
        private Button btnShowChuviDientic;
        private Button btnShowPhepToanPhanSo;
        private Button btnShowPhepToan3So;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Button btnGame;
        private Button button3;
        private Button button4;
    }
}