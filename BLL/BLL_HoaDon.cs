using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_HoaDon
    {
        DAL_HoaDon dl =new DAL_HoaDon();
        public BLL_HoaDon() { }
        public string GenerateMaHoaDon()
        {
            return dl.GenerateHoanDon();
        }
        public hoadon findHoaDon(string s)
        {
            return dl.findHoaDon(s);
        }

        public bool insertHoaDon(hoadon lsp)
        {
            return dl.insertHoaDon(lsp);
        }
        public bool updateHoaDon(DateTime ngay, int tt, hoadon lsp)
        {
            return dl.updateHoaDon(ngay, tt, lsp);
        }

        public bool deleteHoaDon(hoadon lsp)
        {
            return dl.deleteHoaDon(lsp);
        }

      

      
        public IQueryable getAllHoaDonKhachHang()
        {
            return dl.getAllHoaDonKhachHang();
        }

        public IQueryable findHoaDonKhachHang(string ten)
        {
            return dl.findHoaDonNguoiDung(ten);
        }
    }

}
