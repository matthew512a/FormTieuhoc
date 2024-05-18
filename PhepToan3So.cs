using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{

    public partial class PhepToan3So : Form
    {
        Random r = new Random();
        string[] toantu1 = { "+", "-", "x", "/" };
        string[] toantu2 = { "+", "-", "x", "/" };
        int index1 = 0, index2 = 0;

        public PhepToan3So()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            int so1, so2, so3;
            do
            {
                so1 = r.Next(10); so2 = r.Next(10); so3 = r.Next(10);
                index1 = r.Next(4);
                index2 = r.Next(4);

            } while ((index1 == 3 && so2 == 0) || (index2 == 3 && so3 == 0));
            lblSo1.Text = so1.ToString();
            lblSo2.Text = so2.ToString();
            lblSo3.Text = so3.ToString();
            lblToanTu1.Text = toantu1[index1];
            lblToanTu2.Text = toantu2[index2];
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
            if ((index1 == 0 || index1 == 1) && (index2 == 2 || index2 == 3))
            {
                int Kq_23 = 0;
                int Kq = 0;
                switch (index2)
                {
                    case 2:
                        Kq_23 = int.Parse(lblSo2.Text) * int.Parse(lblSo3.Text); break;
                    case 3:
                        Kq_23 = int.Parse(lblSo2.Text) / int.Parse(lblSo3.Text); break;
                }

                switch (index1)
                {
                    case 0:
                        Kq = int.Parse(lblSo1.Text) + Kq_23; break;
                    case 1:
                        Kq = int.Parse(lblSo1.Text) - Kq_23; break;
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
            else
            {
                int Kq_12 = 0;
                int Kq = 0;
                switch (index1)
                {
                    case 0:
                        Kq_12 = int.Parse(lblSo1.Text) + int.Parse(lblSo2.Text); break;
                    case 1:
                        Kq_12 = int.Parse(lblSo1.Text) - int.Parse(lblSo2.Text); break;
                    case 2:
                        Kq_12 = int.Parse(lblSo1.Text) * int.Parse(lblSo2.Text); break;
                    case 3:
                        Kq_12 = int.Parse(lblSo1.Text) / int.Parse(lblSo2.Text); break;
                }

                switch (index2)
                {
                    case 0:
                        Kq = Kq_12 + int.Parse(lblSo3.Text); break;
                    case 1:
                        Kq = Kq_12 - int.Parse(lblSo3.Text); break;
                    case 2:
                        Kq = Kq_12 * int.Parse(lblSo3.Text); break;
                    case 3:
                        Kq = Kq_12 / int.Parse(lblSo3.Text); break;
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
