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
    public partial class PhepToanPhanSo : Form
    {
        public PhepToanPhanSo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Dau.Text = btnCong.Text;
            Phanso ps1, ps2;
            try
            {
                ps1 = new Phanso(int.Parse(Tu1.Text), int.Parse(Mau1.Text));
                ps2 = new Phanso(int.Parse(Tu2.Text), int.Parse(Mau2.Text));
                Phanso kq = ps1.Cong(ps2);
                textBox8.Text = kq.Tuso.ToString();
                textBox9.Text = kq.Mauso.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            Dau.Text = btnTru.Text;
            Phanso ps1, ps2;
            try
            {
                ps1 = new Phanso(int.Parse(Tu1.Text), int.Parse(Mau1.Text));
                ps2 = new Phanso(int.Parse(Tu2.Text), int.Parse(Mau2.Text));
                Phanso kq = ps1.Tru(ps2);
                textBox8.Text = kq.Tuso.ToString();
                textBox9.Text = kq.Mauso.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Dau.Text = btnNhan.Text;
            Phanso ps1, ps2;
            try
            {
                ps1 = new Phanso(int.Parse(Tu1.Text), int.Parse(Mau1.Text));
                ps2 = new Phanso(int.Parse(Tu2.Text), int.Parse(Mau2.Text));
                Phanso kq = ps1.Nhan(ps2);
                textBox8.Text = kq.Tuso.ToString();
                textBox9.Text = kq.Mauso.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Dau.Text = btnChia.Text;
            Phanso ps1, ps2;
            try
            {
                ps1 = new Phanso(int.Parse(Tu1.Text), int.Parse(Mau1.Text));
                ps2 = new Phanso(int.Parse(Tu2.Text), int.Parse(Mau2.Text));
                Phanso kq = ps1.Chia(ps2);
                textBox8.Text = kq.Tuso.ToString();
                textBox9.Text = kq.Mauso.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
