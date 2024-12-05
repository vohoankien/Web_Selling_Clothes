using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class hoadon
    {
        string thang;
        long doanhthu;
        string tennguoidung;
        public long Doanhthu { get => doanhthu; set => doanhthu = value; }
        public string Thang { get => thang; set => thang = value; }
        public string Tennguoidung { get => tennguoidung; set => tennguoidung = value; }
    }
}
