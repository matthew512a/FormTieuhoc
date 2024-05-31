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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            add_Click();
            list = new List<string>();
        }
        List<Button> buttons;
        List<string> list;
        private void enalbleButtons()
        {
            btnCong.Enabled = true;
            btnTru.Enabled = true;
            btnNhan.Enabled = true;
            btnChia.Enabled = true;
        }
        private void disableButtons()
        {
            btnCong.Enabled = false;
            btnTru.Enabled = false;
            btnNhan.Enabled = false;
            btnChia.Enabled = false;
        }
        private void Sum()
        {
            if (list.Contains("+"))
            {
                list.Remove("+");
                double s = Convert.ToDouble(list[0]) + Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }

        }
        private void Sub()
        {
            if (list.Contains("-"))
            {
                list.Remove("-");
                double s = Convert.ToDouble(list[0]) - Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void Mul()
        {
            if (list.Contains("x"))
            {
                list.Remove("x");
                double s = Convert.ToDouble(list[0]) * Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void Div()
        {
            if (list.Contains("/"))
            {
                list.Remove("/");
                double s = Convert.ToDouble(list[0]) / Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void add_Click()
        {
            buttons = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };
            foreach (var item in buttons)
            {
                item.Click += new EventHandler(button_Click);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            string textButton = (sender as Button).Text;
            textBox1.Text += textButton;//viết 2 số liền nhau sau khi nhấn nên để +=
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(btnCong.Text);
                textBox1.Text = "";// list giờ gồm số và + , dấu + sẽ ko đc hiển thị
                disableButtons();
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                Sum();
                Sub();
                Mul();
                Div();
                enalbleButtons();
                list.Clear();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(btnTru.Text);
                textBox1.Text = "";
                disableButtons();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(btnNhan.Text);
                textBox1.Text = "";
                disableButtons();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(btnChia.Text);
                textBox1.Text = "";
                disableButtons();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();   
            list.Clear();
            enalbleButtons();
        }
    }
}
