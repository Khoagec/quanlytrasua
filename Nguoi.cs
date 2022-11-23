using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyCuaHang
{
    public class Nguoi
    {
        private string name;
        private string sdt;
        private string diachi;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public Nguoi()
        {
        }
        public Nguoi(string name, string sdt, string diachi)
        {
            this.name = name;
            this.sdt = sdt;
            this.diachi = diachi;
        }
    }
}
