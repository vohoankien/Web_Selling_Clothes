using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_LoaiSanPham
    {
        DAL_LoaiSanPham dl = new DAL_LoaiSanPham();
        public BLL_LoaiSanPham() { }

        public IQueryable getAllLoaiSanPham()
        {
            return dl.getAllLoaiSanPham();
        }

        public string createAutoMaLoaiSP()
        {
            return dl.GenerateMaLoaiSP();
        }

        public bool insertLoaiSanPham(loaisanpham lsp)
        {
            return dl.insertLoaiSanPham(lsp);
        }
        public bool deleteLoaiSanPham(loaisanpham lsp)
        {
            return dl.deleteLoaiSanPham(lsp);
        }

        public bool updateLoaiSanPham(string ten, loaisanpham lsp)
        {
            return dl.updateLoaiSanPham(ten, lsp);
        }

        public loaisanpham findLoaiSanPham(string s)
        {
            return dl.findLoaiSanPham(s);
        }

    }
}
