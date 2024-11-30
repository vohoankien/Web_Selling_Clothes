using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Kho
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_Kho() { }
        public string GenerateMaKho()
        {
            var existingMaKho = ql.khos.Select(k => k.MAKHO).ToList();
            int newCodeNumber = 1;
            if (existingMaKho.Count > 0)
            {
                var maxCode = existingMaKho
                    .Select(m => int.Parse(m.Substring(3)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaKho = "KHO" + newCodeNumber.ToString("D3");

                return newMaKho;
            }
            else
            {
                return "KHO001";
            }
        }
        public IQueryable getAllKho()
        {
            var query = from tk in ql.khos
                        select new
                        {
                            tk.MAKHO,
                            tk.TENKHO,
                        };
            return query;
        }


        public bool insertKho(kho nh)
        {
            try
            {
                ql.khos.InsertOnSubmit(nh);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteKho(kho lsp)
        {
            try
            {
                ql.khos.DeleteOnSubmit(lsp);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
   

      


        public bool updateKho(string tenlsp, kho lsp)
        {
            try
            {
                lsp.TENKHO = tenlsp;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public kho findKho(string s)
        {
            var nq = (from n in ql.khos
                      where n.MAKHO == s
                      select n).FirstOrDefault();
            return nq;
        }
    }
}
