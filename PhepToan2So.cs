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
    public partial class PhepToan2So : Form
    {
        Random r = new Random();
        string[] toantu = { "+", "-", "x", "/" };
        int index = 0;
        public PhepToan2So()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            int so1, so2;
            do
            {
                so1 = r.Next(10); so2 = r.Next(10);
                index = r.Next(4);

            } while (index == 3 && so2 == 0);
            lblSo1.Text = so1.ToString();
            lblSo2.Text = so2.ToString();
            lblToanTu.Text = toantu[index];
            lblKq.Text = "";
            txtDoan.Text = "";

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            int Kq = 0;
            switch (index)
            {
                case 0:
                    Kq = int.Parse(lblSo1.Text) + int.Parse(lblSo2.Text); break;
                case 1:
                    Kq = int.Parse(lblSo1.Text) - int.Parse(lblSo2.Text); break;
                case 2:
                    Kq = int.Parse(lblSo1.Text) * int.Parse(lblSo2.Text); break;
                case 3:
                    Kq = int.Parse(lblSo1.Text) / int.Parse(lblSo2.Text); break;
            }
            try
            {
                int user = int.Parse(txtDoan.Text);
                if (user == Kq)
                {
                    lblKq.Text = "Chúc mừng bạn! Chính xác!!!";
                }
                else
                {
                    lblKq.Text = "Tiếc quá! Sai rồi!!! Kết quả đúng phải là " + Kq.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập kết quả dự đoán là số!", "Thông báo");
            }
        }

        private void btnDauTru_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text != "") return;
            txtDoan.Text = "-";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text == "") return;
            txtDoan.Text = txtDoan.Text.Substring(0, txtDoan.Text.Length - 1);
        }
    }
}
