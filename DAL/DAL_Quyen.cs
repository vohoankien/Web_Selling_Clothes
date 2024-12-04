using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Quyen
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_Quyen() { }

        public List<nhomquyen> getAllQuyen()
        {
            return ql.nhomquyens.Select(k => k).ToList<nhomquyen>();
        }

        public List<nhomquyen> getQuyenNhanVien()
        {
            return ql.nhomquyens.Where(k => k.TENQUYEN != "Khách Hàng").ToList();
        }


        public bool insertQuyen(nhomquyen quyen)
        {
            try
            {
                ql.nhomquyens.InsertOnSubmit(quyen);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public nhomquyen findQuyen(string s )
        {
            var nq = (from n in ql.nhomquyens
                     where n.TENQUYEN == s
                     select n).FirstOrDefault();
            return nq;
        }

        public nhomquyen findMaQuyen(string s)
        {
            var nq = (from n in ql.nhomquyens
                      where n.MAQUYEN == s
                      select n).FirstOrDefault();
            return nq;
        }
        public bool deleteQuyen(nhomquyen quyen)
        {
            try
            {
                ql.nhomquyens.DeleteOnSubmit(quyen);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool updateQuyen(string tenq,nhomquyen nhomquyen)
        {
            try
            {
               nhomquyen.TENQUYEN = tenq;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string GenerateMaQuyen()
        {
            var existingMaQuyen = ql.nhomquyens.Select(k => k.MAQUYEN).ToList();

            int newCodeNumber = 1;


            if (existingMaQuyen.Count > 0)
            {
                var maxCode = existingMaQuyen
                    .Select(m => int.Parse(m.Substring(2))) // Lấy phần số sau "MQ"
                    .Max(); // Tìm số lớn nhất
                newCodeNumber = maxCode + 1; // Tăng lên 1
                                             // Định dạng mã quyền mới
                string newMaQuyen = "MQ" + newCodeNumber.ToString("D3"); // Định dạng thành MQ001, MQ002, ...

                return newMaQuyen;
            }
            else
            {
                return "MQ001";
            }    
        }

    }
}
