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

       

        public string getSizeFirst(string maspham)
        {
            var masp = (from sp in ql.sizes
                       where sp.MASP == maspham
                        select sp.SIZESP ).First();
            return  masp;
        }
        public IQueryable getALLSize(string masp)
        {
            var size = from s in ql.sizes
                       where s.MASP == masp
                       select s;
            return size;
        }
        public bool insertSize(size size)
        {
            try
            {
                ql.sizes.InsertOnSubmit(size);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }


    }
}
