using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_DanhGia
    {
        DAL_DanhGia dl = new DAL_DanhGia();
        public BLL_DanhGia() { }

        public IQueryable getAllDanhGia()
        {
            return dl.getAllDanhGia();
        }

        public danhgia findDanhGia(string s)
        {
            return dl.findDanhGia(s);
        }

    
        public bool updateDanhGia(int tinhtrang, danhgia lsp)
        {
            return dl.updateDanhGia(tinhtrang, lsp);
        }
    }
}
