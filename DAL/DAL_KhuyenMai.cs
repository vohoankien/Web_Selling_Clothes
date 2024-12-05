using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_KhuyenMai
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_KhuyenMai() { }
        public string GenerateMaKhuyenMai()
        {
            var existingMaKhuyenMai = ql.khuyenmais.Select(k => k.MAKM).ToList();
            int newCodeNumber = 1;
            if (existingMaKhuyenMai.Count > 0)
            {
                var maxCode = existingMaKhuyenMai
                    .Select(m => int.Parse(m.Substring(3)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaKhuyenMai = "KM" + newCodeNumber.ToString("D3");

                return newMaKhuyenMai;
            }
            else
            {
                return "KM001";
            }
        }
        public IQueryable getAllKhuyenMai()
        {
            var query = from tk in ql.khuyenmais
                        select new
                        {
                            tk.MAKM,
                            tk.TENKM,
                            tk.NGAYBD,
                            tk.NGAYKT,
                            tk.PHANTRAMGIAM,
                        };
            return query;
        }

        public List<khuyenmai> getAllKhuyenMaiSP()
        {
            // Lấy dữ liệu kiểu ẩn danh từ cơ sở dữ liệu
            var query = from tk in ql.khuyenmais
                        select new
                        {
                            tk.MAKM,
                            tk.TENKM,
                            tk.NGAYBD,
                            tk.NGAYKT,
                            tk.PHANTRAMGIAM
                        };

            // Ánh xạ kết quả kiểu ẩn danh sang đối tượng khuyenmai
            var danhSachKhuyenMai = query.ToList().Select(km => new khuyenmai
            {
                MAKM = km.MAKM,
                TENKM = km.TENKM,
                NGAYBD = km.NGAYBD,
                NGAYKT = km.NGAYKT,
                PHANTRAMGIAM = km.PHANTRAMGIAM
            }).ToList();

            return danhSachKhuyenMai;
        }



        public bool insertKhuyenMai(khuyenmai nh)
        {
            try
            {
                ql.khuyenmais.InsertOnSubmit(nh);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public khuyenmai findKhuyenMai(string s)
        {
            var nq = (from n in ql.khuyenmais
                      where n.MAKM == s
                      select n).FirstOrDefault();
            return nq;
        }

        public bool deleteKhuyenMai(khuyenmai lsp)
        {
            try
            {
                ql.khuyenmais.DeleteOnSubmit(lsp);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool updateKhuyenMai(string tenlsp,DateTime ngaybd,DateTime ngaykt,int giam ,khuyenmai lsp)
        {
            try
            {
                lsp.TENKM = tenlsp;
                lsp.NGAYBD = ngaybd;
                lsp.NGAYKT = ngaykt;
                lsp.PHANTRAMGIAM = giam;
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
