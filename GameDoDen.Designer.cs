namespace FormDangNhap
{
    partial class GameDoDen
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
            btnPlay = new Button();
            btnClose = new Button();
            picSo1 = new PictureBox();
            picSo2 = new PictureBox();
            picSo3 = new PictureBox();
            lblResult = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picSo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSo3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(1014, 110);
            label1.TabIndex = 1;
            label1.Text = "TUNG XÚC XẮC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(298, 375);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(177, 76);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Chơi";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(540, 375);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(159, 76);
            btnClose.TabIndex = 3;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // picSo1
            // 
            picSo1.Location = new Point(192, 142);
            picSo1.Name = "picSo1";
            picSo1.Size = new Size(174, 127);
            picSo1.SizeMode = PictureBoxSizeMode.Zoom;
            picSo1.TabIndex = 4;
            picSo1.TabStop = false;
            // 
            // picSo2
            // 
            picSo2.Location = new Point(415, 142);
            picSo2.Name = "picSo2";
            picSo2.Size = new Size(174, 127);
            picSo2.SizeMode = PictureBoxSizeMode.Zoom;
            picSo2.TabIndex = 5;
            picSo2.TabStop = false;
            // 
            // picSo3
            // 
            picSo3.Location = new Point(646, 142);
            picSo3.Name = "picSo3";
            picSo3.Size = new Size(174, 127);
            picSo3.SizeMode = PictureBoxSizeMode.Zoom;
            picSo3.TabIndex = 6;
            picSo3.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.RosyBrown;
            lblResult.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = SystemColors.ControlText;
            lblResult.Location = new Point(499, 283);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 65);
            lblResult.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(355, 294);
            label2.Name = "label2";
            label2.Size = new Size(0, 65);
            label2.TabIndex = 8;
            // 
            // GameDoDen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 598);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(picSo3);
            Controls.Add(picSo2);
            Controls.Add(picSo1);
            Controls.Add(btnClose);
            Controls.Add(btnPlay);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameDoDen";
            Load += GameDoDen_Load;
            ((System.ComponentModel.ISupportInitialize)picSo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSo3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnPlay;
        private Button btnClose;
        private PictureBox picSo1;
        private PictureBox picSo2;
        private PictureBox picSo3;
        private Label lblResult;
        private Label label2;
    }
}