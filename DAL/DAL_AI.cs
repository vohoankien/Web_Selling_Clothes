using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_AI
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_AI() { } 

        public List<DanhGiaSanPham> getDanhGia()
        {

            var kq =( from k in ql.danhgias
                     select new DanhGiaSanPham
                     {
                         NoiDung = k.NOIDUNG,
                         SoSao = (int)k.SOSAO
                     }).ToList();
            return kq;
        }

    }
}
