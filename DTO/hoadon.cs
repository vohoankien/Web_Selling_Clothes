using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class hoadon
    {
        string ngay;
        long doanhthu;
        public long Doanhthu { get => doanhthu; set => doanhthu = value; }
        public string Ngay { get => ngay; set => ngay = value; }
    }
}
