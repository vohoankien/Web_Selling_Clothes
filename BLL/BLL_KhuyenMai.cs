using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_KhuyenMai
    {
        DAL_KhuyenMai dl = new DAL_KhuyenMai();
        public BLL_KhuyenMai() { }
        public IQueryable getAllKhuyenMai()
        {
            return dl.getAllKhuyenMai();
        }

        public string GenerateMaKhuyenMai()
        {
            return dl.GenerateMaKhuyenMai();
        }

        public bool insertKhuyenMai(khuyenmai lsp)
        {
            return dl.insertKhuyenMai(lsp);
        }
        public bool deleteKhuyenMai(khuyenmai lsp)
        {
            return dl.deleteKhuyenMai(lsp);
        }

        public bool updateKhuyenMai(string ten,DateTime ngaybd ,DateTime ngaykt,int gia, khuyenmai lsp)
        {
            return dl.updateKhuyenMai(ten,ngaybd,ngaykt,gia, lsp);
        }

        public khuyenmai findKhuyenMai(string s)
        {
            return dl.findKhuyenMai(s);
        }
    }
}
