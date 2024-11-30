using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhanHieu
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_NhanHieu() { }
        public string GenerateMaNhanHieu()
        {
            var existingMaNhanHieu = ql.nhanhieus.Select(k => k.MANH).ToList();
            int newCodeNumber = 1;
            if (existingMaNhanHieu.Count > 0)
            {
                var maxCode = existingMaNhanHieu
                    .Select(m => int.Parse(m.Substring(3)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaNhanHieu = "NHA" + newCodeNumber.ToString("D3");

                return newMaNhanHieu;
            }
            else
            {
                return "NHA001";
            }
        }
        public IQueryable getAllNhanHieu()
        {
            var query = from tk in ql.nhanhieus
                        select new
                        {
                            tk.MANH,
                            tk.TENNH,
                            tk.QUOCGIA
                        };
            return query;
        }


        public bool insertNhanHieu(nhanhieu nh)
        {
            try
            {
                ql.nhanhieus.InsertOnSubmit(nh);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public nhanhieu findNhanHieu(string s)
        {
            var nq = (from n in ql.nhanhieus
                      where n.MANH == s
                      select n).FirstOrDefault();
            return nq;
        }

        public bool deleteNhanHieu(nhanhieu lsp)
        {
            try
            {
                ql.nhanhieus.DeleteOnSubmit(lsp);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool updateNhanHieu(string tenlsp,string qg ,nhanhieu lsp)
        {
            try
            {
                lsp.TENNH = tenlsp;
                lsp.QUOCGIA = qg;
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
