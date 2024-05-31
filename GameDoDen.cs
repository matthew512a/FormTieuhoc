using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class GameDoDen : Form
    {
        string path;
        public GameDoDen()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int so1, so2, so3;
            Random r = new Random();
            so1 = r.Next(1, 7);
            so2 = r.Next(1, 7);
            so3 = r.Next(1, 7);
            string file1 = Path.Combine(path, "die" + so1.ToString() + ".jpg");
            string file2 = Path.Combine(path, "die" + so2.ToString() + ".jpg");
            string file3 = Path.Combine(path, "die" + so3.ToString() + ".jpg");

            if (!File.Exists(file1) || !File.Exists(file2) || !File.Exists(file3))
            {
                MessageBox.Show("Một hoặc nhiều file ảnh không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị ảnh trên các PictureBox
            picSo1.Image = Image.FromFile(file1);
            picSo2.Image = Image.FromFile(file2);
            picSo3.Image = Image.FromFile(file3);
            int total = so1 + so2 + so3;

            // Hiển thị kết quả
            label2.Text = $"Kết quả = {total}";
        }

        private void GameDoDen_Load(object sender, EventArgs e)
        {
            path = Path.Combine(Application.StartupPath, "Images");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult rel = new DialogResult();
            rel = MessageBox.Show("Bạn có muốn thoát?","Thông báo", MessageBoxButtons.YesNo);
            if (rel == DialogResult.Yes) {
                this.Close(); 
            }
        }
    }
}
