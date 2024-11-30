using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_SanPham
    {
        DAL_SanPham dl = new DAL_SanPham();
        public BLL_SanPham() { }


        public IQueryable getAllSanPham()
        {
            return dl.getAllSanPham();
        }

        public string GenerateMaSanPham()
        {
            return dl.GenerateMaSanPham();
        }

        public bool insertSanPham(sanpham lsp)
        {
            return dl.insertSanPham(lsp);
        }
        public bool deleteSanPham(sanpham lsp)
        {
            return dl.deleteSanPham(lsp);
        }

        public bool updateSanPham(sanpham temp, sanpham lsp)
        {
            return dl.updateSanPham(temp, lsp);
        }

        public sanpham findSanPham(string s)
        {
            return dl.findSanPham(s);
        }

        public double getGiaKhuyenMai(string masp)
        {
            return dl.getGiaKhuyenMai(masp);
        }

    }
}
