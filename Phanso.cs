using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    internal class Phanso
    {
        int tuso, mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(int t, int m)
        {
            tuso = t;
            mauso = m == 0 ? 1 : m;
        }
        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set { mauso = value; }
        }
        private void Toigian()
        {
            int uc = Lopdungchung.USCLN(tuso, mauso);
            if (uc > 0)
            {
                tuso /= uc;
                mauso /= uc;
            }
        }
        public Phanso Cong(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.mauso + mauso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Tru(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.mauso - mauso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Nhan(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Chia(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.mauso;
            kq.mauso = mauso * p.tuso;
            kq.Toigian();
            return kq;
        }

    }
}
