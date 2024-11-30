using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HoaDon
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_HoaDon() { }
        public string GenerateHoanDon()
        {
            var existingMaHoaDon = ql.hoadons.Select(k => k.MAHD).ToList();
            int newCodeNumber = 1;
            if (existingMaHoaDon.Count > 0)
            {
                var maxCode = existingMaHoaDon
                    .Select(m => int.Parse(m.Substring(2)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaHoaDon = "HD" + newCodeNumber.ToString("D3");

                return newMaHoaDon;
            }
            else
            {
                return "HD001";
            }
        }
        public bool insertHoaDon(hoadon nh)
        {
            try
            {
                ql.hoadons.InsertOnSubmit(nh);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteHoaDon(hoadon lsp)
        {
            try
            {
                ql.hoadons.DeleteOnSubmit(lsp);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }





        public bool updateHoaDon(string tenlsp, hoadon lsp)
        {
            try
            {
            //    lsp.TENHoaDon = tenlsp;
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
