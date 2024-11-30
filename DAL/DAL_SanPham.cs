using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_SanPham
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext(); 
        public DAL_SanPham () { }

        public string GenerateMaSanPham()
        {
            var existingMaSanPham = ql.sanphams.Select(k => k.MASP).ToList();
            int newCodeNumber = 1;
            if (existingMaSanPham.Count > 0)
            {
                var maxCode = existingMaSanPham
                    .Select(m => int.Parse(m.Substring(3)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaSanPham = "SP" + newCodeNumber.ToString("D4");

                return newMaSanPham;
            }
            else
            {
                return "SP0001";
            }
        }
        public IQueryable getAllSanPham()
        {
            var query = from tk in ql.sanphams
                        select new
                        {
                            tk.MASP,
                            tk.TENSANPHAM,
                            tk.CHATLIEU,
                            tk.GIA,
                            tk.MALOAI,
                            tk.MANH,
                            tk.GIAGIAM,
                            tk.HINHANH,
                            tk.MAKM
                        };
            return query;
        }


        public bool insertSanPham(sanpham nh)
        {
            try
            {
                ql.sanphams.InsertOnSubmit(nh);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public sanpham findSanPham(string s)
        {
            var nq = (from n in ql.sanphams
                      where n.MASP == s
                      select n).FirstOrDefault();
            return nq;
        }

        public bool deleteSanPham(sanpham lsp)
        {
            try
            {
                ql.sanphams.DeleteOnSubmit(lsp);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool updateSanPham(sanpham  temp, sanpham lsp)
        {
            try
            {
                lsp.TENSANPHAM = temp.TENSANPHAM;
                lsp.GIA = temp.GIA;
                lsp.HINHANH = temp.HINHANH;
                lsp.MAKM = temp.MAKM;
                lsp.MANH = lsp.MANH;
                lsp.MALOAI = temp.MALOAI;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public double getGiaKhuyenMai(string masp)
        {
            var giakm = ql.TinhGiamGia(masp);
            return giakm ?? 0;

        }

    }
}
