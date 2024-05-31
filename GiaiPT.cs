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
    public partial class GiaiPT : Form
    {
        public GiaiPT()
        {
            InitializeComponent();
        }

        private void PT1_CheckedChanged(object sender, EventArgs e)
        {
            if (PT1.Checked)
            {
                this.textBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.textBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!PT1.Checked && !radioButton2.Checked) MessageBox.Show("Bạn hãy chọn 1 phương trình để giải", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!double.TryParse(this.textBox1.Text, out a) || a == 0) MessageBox.Show("a phải là số và a khác 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!double.TryParse(this.textBox2.Text, out b)) MessageBox.Show("b phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (PT1.Checked)
            {
                this.textBox4.Text = "Phương trình có nghiệm \t x = " + Math.Round(-b / a, 2).ToString();
            }
            else
            {
                double c;
                if (!double.TryParse(this.textBox3.Text, out c) || a == 0) MessageBox.Show("c phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                double del = b * b - 4 * a * c;
                if (del == 0) this.textBox4.Text = "Phương trình có 1 nghiệm kép \t x1 = x2 = " + Math.Round(-b / (2 * a), 2);
                else if (del < 0) this.textBox4.Text = "Phương trình vô nghiệm \t";
                else
                {
                    double x1 = Math.Round((-b - Math.Sqrt(del)) / (2 * a), 2);
                    double x2 = Math.Round((-b + Math.Sqrt(del)) / (2 * a), 2);
                    this.textBox4.Text = "Phương trình có 2 nghiệm phân biệt \t x1 = " + x1 + "\t" + "x2 = " + x2 + "\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PT1.Checked = false;
            radioButton2.Checked = false;
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
