using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_HinhAnh
    {
        DAL_HinhAnh dl = new DAL_HinhAnh();
        public IQueryable getALLHinhAnh(string masp)
        {
           return dl.getALLHinhAnh(masp);
        }
        public bool insertHinhAnh(hinhanh size)
        {
            return dl.insertHinhAnh(size);
        }

        public bool deleteHinhAnhTheoSanPham(string size)
        {
            return dl.deleteHinhAnhTheoSanPham(size);
        }
        
    }
}
