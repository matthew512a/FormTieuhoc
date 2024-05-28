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
    public partial class DoDaiDoanThang : Form
    {
        public DoDaiDoanThang()
        {
            InitializeComponent();
        }

        private void btnBaDoanThang_Click(object sender, EventArgs e)
        {
            // Vẽ các điểm A, B, C, D
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);

            //g.DrawEllipse(pen, new Rectangle(100, 100, 30, 30)); // Điểm A
            //g.DrawEllipse(pen, new Rectangle(200, 150, 30, 30)); // Điểm B
            //g.DrawEllipse(pen, new Rectangle(250, 100, 30, 30)); // Điểm C
            //g.DrawEllipse(pen, new Rectangle(200, 50, 30, 30)); // Điểm D

            // Nối các điểm bằng ba đoạn thẳng
            g.DrawLine(pen, new Point(130, 100), new Point(200, 150)); // AB
            g.DrawLine(pen, new Point(250, 100), new Point(200, 50)); // CD
            g.DrawLine(pen, new Point(200, 150), new Point(250, 100)); // BC
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
