using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_DanhGia
    {
        QuanLyQuanAoDataContext ql =new QuanLyQuanAoDataContext();
        public DAL_DanhGia() { }
        public IQueryable getAllDanhGia()
        {
            var query = from dg in ql.danhgias
                        join nd in ql.nguoidungs on dg.MAND equals nd.MAND
                        join cthd in ql.chitiethoadons on dg.MACTHD equals cthd.MACTHD
                        join sp in ql.sanphams on cthd.MASP equals sp.MASP
                        select new
                        {
                            nd.TENND,
                            dg.NOIDUNG,
                            dg.SOSAO,
                            dg.TINHTRANG,
                            dg.MADANHGIA,
                            sp.TENSANPHAM
                        };
            return query;

        }

        public bool updateDanhGia(int tinhtrang, danhgia ph)
        {
            try
            {
                ph.TINHTRANG = tinhtrang;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public danhgia findDanhGia(string MaDG)
        {
            var ph = (from p in ql.danhgias
                      where p.MADANHGIA.Equals(MaDG)
                      select p).FirstOrDefault();
            return ph;
        }
    }
}
