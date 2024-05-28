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
    public partial class Sosanh : Form
    {
        private double so1;
        private double so2;
        public Sosanh()
        {
            InitializeComponent();
        }
        private void GenerateRandomNumbers()
        {
            Random rand = new Random();
            so1 = Math.Round(rand.NextDouble() * 100, 2);
            so2 = Math.Round(rand.NextDouble() * 100, 2);
            lblSo1.Text = "Số 1: " + so1.ToString();
            lblSo2.Text = "Số 2: " + so2.ToString();
        }
        private void btnTaosongaunhien_Click(object sender, EventArgs e)
        {
            GenerateRandomNumbers();
            lblKetqua.Text = "";
            rdoLon.Checked = false;
            rdoNho.Checked = false;
            rdoBang.Checked = false;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string ketQua = "";
            if (rdoLon.Checked)
            {
                ketQua = (so1 > so2) ? "Đúng" : "Sai";
            }
            else if (rdoNho.Checked)
            {
                ketQua = (so1 < so2) ? "Đúng" : "Sai";
            }
            else if (rdoBang.Checked)
            {
                ketQua = (so1 == so2) ? "Đúng" : "Sai";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn so sánh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblKetqua.Text = ketQua;
        }

        private void lblSo1_Click(object sender, EventArgs e)
        {

        }
    }
}

