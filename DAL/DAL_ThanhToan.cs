using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ThanhToan
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_ThanhToan() { }
        public string GenerateMaThanhToan()
        {
            var existingMaThanhToan = ql.thanhtoans.Select(k => k.MATHANHTOAN).ToList();
            int newCodeNumber = 1;
            if (existingMaThanhToan.Count > 0)
            {
                var maxCode = existingMaThanhToan
                    .Select(m => int.Parse(m.Substring(3)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaThanhToan = "TT" + newCodeNumber.ToString("D3");
                return newMaThanhToan;
            }
            else
            {
                return "TT001";
            }
        }


        public bool insertThanhToan(thanhtoan nh)
        {
            try
            {
                ql.thanhtoans.InsertOnSubmit(nh);
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
