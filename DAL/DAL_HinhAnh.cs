using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_HinhAnh
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_HinhAnh() { }

        public IQueryable getALLHinhAnh(string masp)
        {
            var size = from s in ql.hinhanhs
                       where s.MASP == masp
                       select s;
            return size;
        }
        public bool insertHinhAnh(hinhanh size)
        {
            try
            {
                ql.hinhanhs.InsertOnSubmit(size);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool deleteHinhAnhTheoSanPham(string masp)
        {
            try
            {
                var imagesToDelete = ql.hinhanhs.Where(ha => ha.MASP == masp);
                ql.hinhanhs.DeleteAllOnSubmit(imagesToDelete);
                ql.SubmitChanges();
                return true;    
            }
            catch { return false; }
        }

    }
}
