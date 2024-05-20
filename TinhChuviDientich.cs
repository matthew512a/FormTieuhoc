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
    public partial class TinhChuviDientich : Form
    {
        double a, b, c, cv, dt;
        public TinhChuviDientich()
        {
            InitializeComponent();
        }

        private void TinhChuviDientich_Load(object sender, EventArgs e)
        {
            this.lbCanh1.Visible = false;
            this.lbCanh2.Visible = false;
            this.lbCanh3.Visible = false;
            this.txtCanh1.Visible = false;
            this.txtCanh2.Visible = false;
            this.txtCanh3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double r;
                r = double.Parse(this.txtCanh1.Text);
                cv = Math.Round(2 * r * Math.PI, 4);
                dt = Math.Round(r * r * Math.PI, 4);
            }
            if (radioButton4.Checked == true)
            {
                double a;
                a = double.Parse(this.txtCanh1.Text);
                cv = 4 * a;
                dt = a * a;
            }
            if (radioButton2.Checked == true)
            {
                double a, b;
                a = double.Parse(this.txtCanh1.Text);
                b = double.Parse(this.txtCanh2.Text);
                cv = (a + b) * 2;
                dt = a * b;
            }
            if (radioButton3.Checked == true)
            {
                double a, b, c, p;
                a = double.Parse(this.txtCanh1.Text);
                b = double.Parse(this.txtCanh2.Text);
                c = double.Parse(this.txtCanh3.Text);
                if (a + b < c || a + c < b || b + c < a)
                {
                    MessageBox.Show("Ba cạnh này không tạo thành một tam giác hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
           
                a = double.Parse(this.txtCanh1.Text);
                b = double.Parse(this.txtCanh2.Text);
                c = double.Parse(this.txtCanh3.Text);
                cv = a + b + c;
                p = cv / 2;
                dt = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 4);
            }

            this.Chuvi.Text = cv.ToString();
            this.Dientich.Text = dt.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.lbCanh1.Visible = true;
            this.txtCanh1.Visible = true;
            this.lbCanh1.Text = "Bán kính";
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            this.lbCanh1.Visible = true;
            this.txtCanh1.Visible = true;
            this.lbCanh1.Text = "Cạnh";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.lbCanh1.Visible = true;
            this.txtCanh1.Visible = true;
            this.lbCanh1.Text = "Chiều dài";
            this.lbCanh2.Visible = true;
            this.txtCanh2.Visible = true;
            this.lbCanh2.Text = "Chiều rộng";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.lbCanh1.Visible = true;
            this.txtCanh1.Visible = true;
            this.lbCanh1.Text = "Cạnh 1";
            this.lbCanh2.Visible = true;
            this.txtCanh2.Visible = true;
            this.lbCanh2.Text = "Cạnh 2";
            this.lbCanh3.Visible = true;
            this.txtCanh3.Visible = true;

        }

        private void txtCanh1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu chấm thập phân
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtCanh2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu chấm thập phân
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtCanh3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu chấm thập phân
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
