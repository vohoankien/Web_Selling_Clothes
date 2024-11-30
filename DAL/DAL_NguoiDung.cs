using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NguoiDung
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_NguoiDung() { }
        public string GenerateMaQuyen()
        {
            var existingMaQuyen = ql.taikhoanusers.Select(k => k.MAUSER).ToList();
            int newCodeNumber = 1;
            if (existingMaQuyen.Count > 0)
            {
                var maxCode = existingMaQuyen
                    .Select(m => int.Parse(m.Substring(2))) // Lấy phần số sau "MQ"
                    .Max(); // Tìm số lớn nhất
                newCodeNumber = maxCode + 1; // Tăng lên 1
                                             // Định dạng mã quyền mới
                string newMaQuyen = "ND" + newCodeNumber.ToString("D3"); // Định dạng thành MQ001, MQ002, ...

                return newMaQuyen;
            }
            else
            {
                return "ND001";
            }
        }

        public IQueryable getAllNguoiDung()
        {
            var query = from tk in ql.nguoidungs
                        select new
                        {
                            tk.MAND,
                            tk.TENND,
                            tk.EMAIL,
                            tk.DIACHI,
                            tk.SODIENTHOAI,
                            tk.MAUSER
                        };

            return query;
        }
        public bool insertNguoiDung(nguoidung quyen)
        {
            try
            {
                ql.nguoidungs.InsertOnSubmit(quyen);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public nguoidung findNguoiDung(string s)
        {
            var nq = (from n in ql.nguoidungs
                      where n.MAND == s
                      select n).FirstOrDefault();
            return nq;
        }


        public bool deleteNguoiDung(nguoidung quyen)
        {
            try
            {
                ql.nguoidungs.DeleteOnSubmit(quyen);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool updateNguoiDung(nguoidung temp, nguoidung nhomquyen)
        {
            try
            {
                nhomquyen.TENND = temp.TENND;
                nhomquyen.EMAIL =temp.EMAIL;    
                nhomquyen.DIACHI =temp.DIACHI;
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
