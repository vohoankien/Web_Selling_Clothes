using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_PhanHoi
    {
        QuanLyQuanAoDataContext ql =new QuanLyQuanAoDataContext();
        public DAL_PhanHoi() { }
        public string GenerateMaPhanHoi()
        {
            var existingMaKho = ql.phanhois.Select(k => k.MAPHANHOI).ToList();
            int newCodeNumber = 1;
            if (existingMaKho.Count > 0)
            {
                var maxCode = existingMaKho
                    .Select(m => int.Parse(m.Substring(2)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaKho = "PH" + newCodeNumber.ToString("D3");

                return newMaKho;
            }
            else
            {
                return "PH001";
            }
        }


        public bool insertPhanHoi(phanhoi ph)
        {
            try
            {
                ql.phanhois.InsertOnSubmit(ph);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool updatePhanHoi(string noidung,phanhoi ph)
        {
            try
            {
                ph.NOIDUNG = noidung;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public phanhoi findPhanHoi(string MaDG)
        {
           var ph = (from p in ql.phanhois
                    where p.MADANHGIA.Equals(MaDG)
                    select p).FirstOrDefault();
            return ph;
        }

    }
}
