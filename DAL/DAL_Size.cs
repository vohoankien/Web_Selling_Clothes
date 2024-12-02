using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Size
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext(); 
        public DAL_Size() { }

        public IQueryable getALLSize(string masp)
        {
            var size = from s in ql.sizes
                       where s.MASP == masp
                       select s;
            return size;
        }

        public string getSizeFirst(string maspham)
        {
            var masp = (from sp in ql.sizes
                       where sp.MASP == maspham
                        select sp.SIZESP ).First();
            return  masp;
        }
    }
}
