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
    public partial class TongChanLeDaySo : Form
    {
        public TongChanLeDaySo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int Tong = 0, TongChan = 0, Tongle = 0;
        private void btnNhap_Click(object sender, EventArgs e)
        {
            //cach2();
            cach1();
        }
        // Cách 1: Không dùng mảng
        public void cach2()
        {
            int a;
            if (string.IsNullOrEmpty(txta.Text))
                MessageBox.Show("Chưa nhập số", "Thông báo");
            else if (!int.TryParse(txta.Text, out a))
                MessageBox.Show("số bạn nhập không phải số tự nhiên", "Thông báo");
            else
            {
                txtDaySo.Text += txta.Text + " ";
                Tong += a;
                if (a % 2 == 0)
                    TongChan += a;
                else 
                    Tongle += a;
            }
            txtTong.Text = Tong.ToString();
            txtTongChan.Text = TongChan.ToString();
            txtTongLe.Text = Tongle.ToString();
            txta.Clear();
            txta.Focus();
        }
        // Cách 1: Dùng mảng
        public void cach1()
        {
            txtDaySo.Clear(); txtTong.Clear(); txtTongChan.Clear(); txtTongLe.Clear();
                if(string.IsNullOrEmpty(txta.Text))
                    MessageBox.Show("Chưa nhập dãy số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    int a;
                    bool flag = true; // Tạo cờ để kiểm tra dãy nhập vào có phải là dãy số
                    string[] arr = txta.Text.Split(' '); // Tách các phần tử bởi khoảng trắng ' '
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!int.TryParse(arr[i], out a)) { flag = false; break; } //Kiểm tra số nguyên trong mảng ! gán cờ sai ; thoát vòng lặp
                        else
                        {
                        Tong += a;
                        if (a % 2 == 0) { TongChan += a; }
                        else { Tongle += a; }

                        }    
                    }
                    if(flag)
                    {
                        txtDaySo.Text = txta.Text;
                        txtTong.Text = Tong.ToString();
                        txtTongChan.Text = TongChan.ToString();
                        txtTongLe.Text = Tongle.ToString();
                    }
                    else 
                    {
                        MessageBox.Show("Dãy số không đúng", "Thông báo");
                    }
                    
                }
                Tong = 0;
                TongChan = 0;
                Tongle = 0;

        }
    }
}
