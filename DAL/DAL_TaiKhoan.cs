using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BCrypt.Net;
using System.Runtime.InteropServices;
namespace DAL
{
    public class DAL_TaiKhoan
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_TaiKhoan() { }

        public IQueryable getAllTaiKhoan()
        {
            var query = from tk in ql.taikhoanusers
                        join nd in ql.nguoidungs on tk.MAUSER equals nd.MAUSER
                      
                        select new
                        {
                            tk.MAUSER,
                            tk.TENTK,
                            nd.TENND,
                            nd.EMAIL,
                            nd.DIACHI,
                            nd.SODIENTHOAI,
                        };
            return query;
        }


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
                string newMaQuyen = "TK" + newCodeNumber.ToString("D3"); // Định dạng thành MQ001, MQ002, ...

                return newMaQuyen;
            }
            else
            {
                return "TK001";
            }
        }

        public string hashPassword( string pass)
        {
            return BCrypt.Net.BCrypt.HashPassword(pass);
        }

        public bool verifyPassword(string inputPassword, string hashedPassword)
        {
            try
            {
                bool kq = BCrypt.Net.BCrypt.Verify(inputPassword, hashedPassword);
                return kq;
            }
            catch (Exception ex)
            {
                return false;
            }
       
        }

        public bool insertTaiKhoan(taikhoanuser quyen)
        {
            try
            {
                ql.taikhoanusers.InsertOnSubmit(quyen);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public taikhoanuser findTaiKhoanTheoTen(string s)
        {
            var nq = (from n in ql.taikhoanusers
                      where n.TENTK == s
                      select n).FirstOrDefault();
            return nq;
        }
        public taikhoanuser findTaiKhoanTheoTenvaEmail(string s)
        {
            var result = (from n in ql.taikhoanusers
                          join nv in ql.thongtinadmins
                          on n.MAUSER equals nv.MAUSER
                          select new
                          {
                              n.TENTK,
                              n.MAUSER,
                              n.MAQUYEN,
                              n.MATKHAU,
                             Email =  nv.EMAIL,
                          }).FirstOrDefault();

            if (result != null)
            {
                return new taikhoanuser
                {
                    TENTK = result.TENTK,
                    MAQUYEN = result.MAQUYEN,
                    MATKHAU = result.MATKHAU,
                    MAUSER = result.MAUSER,
                    Email = result.Email
                };
            }

            return null;
        }


        public taikhoanuser findTaiKhoan(string s)
        {
            var nq = (from n in ql.taikhoanusers
                      where n.MAUSER == s
                      select n).FirstOrDefault();
            return nq;
        }


        public bool deleteTaiKhoan(taikhoanuser quyen)
        {
            try
            {
                ql.taikhoanusers.DeleteOnSubmit(quyen);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updateTaiKhoan(taikhoanuser temp, taikhoanuser nhomquyen)
        {
            try
            {
                nhomquyen.TENTK = temp.TENTK;
                nhomquyen.MAQUYEN = temp.MAQUYEN;
                nhomquyen.MATKHAU = temp.MATKHAU;   
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }


    }
}
