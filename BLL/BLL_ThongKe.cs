using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_ThongKe
    {
        DAL_ThongKe dl = new DAL_ThongKe(); 
        
        public BLL_ThongKe() { }
        public List<sanpham> getSanPhamBanChay()
        {
            return dl.getSanPhamBanChay();
        }
        public List<hoadon> getDoanhThuTHeoNgay(DateTime ngbd,DateTime ngkt)
        {
            return dl.getDoanhThuTheoThoiGian(ngbd,ngkt);
        }
    }
}
