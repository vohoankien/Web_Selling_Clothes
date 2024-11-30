using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_LoaiSanPham
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_LoaiSanPham() { }
        public string GenerateMaLoaiSP()
        {
            var existingMaQuyen = ql.loaisanphams.Select(k => k.MALOAI).ToList();
            int newCodeNumber = 1;
            if (existingMaQuyen.Count > 0)
            {
                var maxCode = existingMaQuyen
                    .Select(m => int.Parse(m.Substring(2)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaQuyen = "ML" + newCodeNumber.ToString("D3");

                return newMaQuyen;
            }
            else
            {
                return "ML001";
            }
        }
        public IQueryable getAllLoaiSanPham()
        {
            var query = from tk in ql.loaisanphams
                        select new
                        {
                            tk.MALOAI,
                            tk.TENLOAI
                        };
            return query;
        }


        public bool insertLoaiSanPham(loaisanpham lsp)
        {
            try
            {
                ql.loaisanphams.InsertOnSubmit(lsp);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public loaisanpham findLoaiSanPham(string s)
        {
            var nq = (from n in ql.loaisanphams
                      where n.MALOAI == s
                      select n).FirstOrDefault();
            return nq;
        }

        public bool deleteLoaiSanPham(loaisanpham lsp)
        {
            try
            {
                ql.loaisanphams.DeleteOnSubmit(lsp);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool updateLoaiSanPham(string tenlsp, loaisanpham lsp)
        {
            try
            {
                lsp.TENLOAI = tenlsp;
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
