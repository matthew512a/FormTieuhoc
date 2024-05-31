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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void Loadform(object Form)
        {
            if (panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(f);
            this.panel4.Tag = f;
            f.Show();
        }

        private void BtnShowPhepToan2So_Click(object sender, EventArgs e)
        {
            Loadform(new PhepToan2So());
        }

        private void btnShowPhepToan3So_Click(object sender, EventArgs e)
        {
            Loadform(new PhepToan3So());
        }

        private void btnShowPhepToanPhanSo_Click(object sender, EventArgs e)
        {
            Loadform(new PhepToanPhanSo());
        }

        private void btnShowChuviDientic_Click(object sender, EventArgs e)
        {
            Loadform(new TinhChuviDientich());
        }

        private void btnShowTongChanLeDaySo_Click(object sender, EventArgs e)
        {
            Loadform(new TongChanLeDaySo());
        }

        private void btnShowDocSoThanhChu_Click(object sender, EventArgs e)
        {
            Loadform(new DocSo());
        }

        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            Loadform(new Sosanh());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Loadform(new GameDoDen());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loadform(new GiaiPT());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loadform(new Calculator());
        }
    }
}
