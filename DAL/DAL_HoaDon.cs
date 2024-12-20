﻿using System;
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

        public IQueryable getAllHoaDonKhachHang()
        {
            var hd = from h in ql.hoadons
                     join nd in ql.nguoidungs on h.MAND equals nd.MAND
                     select new
                     {
                         h.MAHD,
                         nd.TENND,
                         h.SOLUONG,
                         h.NGAYDATHANG,
                         h.TONGTIEN,
                         h.TINHTRANG
                     };
            return hd;
        }

        public IQueryable findHoaDonNguoiDung(string ten)
        {
            var query = (from h in ql.hoadons
                         join nd in ql.nguoidungs on h.MAND equals nd.MAND
                         where nd.TENND.Contains(ten)
                         select new
                         {
                             h.MAHD,
                            nd.TENND,
                             h.SOLUONG,
                             h.NGAYDATHANG,
                             h.TONGTIEN,
                             h.TINHTRANG
                         });
            return query;
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

        


        public bool updateHoaDon(DateTime ngay,int tinhtrang, hoadon lsp)
        {
            try
            {
                lsp.TINHTRANG = tinhtrang;
                lsp.NGAYDATHANG = ngay;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public hoadon findHoaDon(string s)
        {
            var nq = (from n in ql.hoadons
                      where n.MAHD == s
                      select n).FirstOrDefault();
            return nq;
        }


    }
}
