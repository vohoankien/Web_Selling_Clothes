using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class BLL_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dl = new DAL_ChiTietHoaDon();
        public string GenerateMaChiTietHoaDon()
        {
            return dl.GenerateChiTietHoanDon();
        }

        public DataTable getAllChiTietHoaDon(string mahd)
        {
            return dl.getAllCTHD(mahd);
        }

        public bool insertChiTietHoaDon(chitiethoadon lsp)
        {
            return dl.insertChiTietHoaDon(lsp);
        }
        public bool deleteChiTietHoaDon(chitiethoadon lsp)
        {
            return dl.deleteChiTietHoaDon(lsp);
        }
        public async Task<bool> updateSoLuongChiTietHoaDon(int ten, chitiethoadon lsp)
        {
            return await dl.updateSoLuongChiTietHoaDon(ten, lsp);
        }

        public async Task<bool> UpdateSizeChiTietHoaDonAsync(string ten, chitiethoadon lsp)
        {
            return await dl.UpdateSizeChiTietHoaDonAsync(ten, lsp);
        }
        public chitiethoadon findCTHD(string s)
        {
            return dl.findCTHD(s);
        }
    }
}
