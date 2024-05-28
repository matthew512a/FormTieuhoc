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
    public partial class DocSo : Form
    {
        public DocSo()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out double number))
            {
                lblKetqua.Text = DocSoThanhChu.ConvertToWords(number);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
