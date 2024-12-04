using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
   
    public class DAL_ThongTinAdmin
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_ThongTinAdmin() { }

        public bool insertAdmin(thongtinadmin quyen)
        {
            try
            {
                ql.thongtinadmins.InsertOnSubmit(quyen);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable getAllAdmin()
        {
            var query = from tt in ql.thongtinadmins
                        join tk in ql.taikhoanusers on tt.MAUSER equals tk.MAUSER
                        join q in ql.nhomquyens on tk.MAQUYEN equals q.MAQUYEN
                        select new
                        {
                            tk.MAUSER,
                            tk.TENTK,
                            tt.TENNV,
                            tt.EMAIL,
                            tt.DIACHI,
                            tt.SODIENTHOAI,
                            q.MAQUYEN,
                        };

            return query;
        }

        public thongtinadmin findAdmin(string s)
        {
            var nq = (from n in ql.thongtinadmins
                      where n.MAUSER == s
                      select n).FirstOrDefault();
            return nq;
        }


        public bool deleteThongTinAdmin(thongtinadmin quyen)
        {
            try
            {
                ql.thongtinadmins.DeleteOnSubmit(quyen);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool updateTTAdmin(thongtinadmin temp, thongtinadmin nhomquyen)
        {
            try
            {

                nhomquyen.TENNV = temp.TENNV;
                nhomquyen.EMAIL = temp.EMAIL;
                nhomquyen.DIACHI = temp.DIACHI;
                nhomquyen.SODIENTHOAI = temp.SODIENTHOAI;
               
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
