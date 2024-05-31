namespace FormDangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guna2TextBox2.PasswordChar = '*';
        }
        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            guna2TextBox1.IconLeft = Properties.Resources.user_green;
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            guna2TextBox1.IconLeft = Properties.Resources.user_black;
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            guna2TextBox2.IconLeft = Properties.Resources.lock_green;
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            guna2TextBox2.IconLeft = Properties.Resources.Lock_black;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
                MessageBox.Show("Chưa nhập tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (guna2TextBox1.Text.Equals("admin") && guna2TextBox2.Text.Equals("123456"))
            {
                MessageBox.Show("Đăng nhập thành công! ", "Thông báo");
                this.Hide(); // ẩn form đăng nhập
                FrmMain fm = new FrmMain();
                fm.ShowDialog();
                fm = null;
                this.Show();
            }
            else
                MessageBox.Show("Đang nhập thất bại! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

    }
}
