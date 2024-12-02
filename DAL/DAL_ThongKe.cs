using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ThongKe
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_ThongKe() { }

        public List<sanpham> getSanPhamBanChay()
        {
            var result = ql.proc_DanhSachSanPhamBanChay(); // Đối tượng trả về kiểu ISingleResult<proc_DanhSachSanPhamBanChayResult>

            // Chuyển đổi từ ISingleResult thành List<sanpham>
            List<DTO.sanpham> sanPhamBanChayList = result
                .Select(x => new DTO.sanpham
                {
                    // Chuyển đổi các thuộc tính từ proc_DanhSachSanPhamBanChayResult sang sanpham
                    TENSANPHAM = x.TENSANPHAM,  // Ví dụ, nếu proc_DanhSachSanPhamBanChayResult có thuộc tính TenSanPham
                    Soluongban = (int)x.SoLuongMua  // Và SoLuongBan cũng là một thuộc tính trong proc_DanhSachSanPhamBanChayResult
                }).ToList();

            return sanPhamBanChayList;
        }

        public List<hoadon> getDoanhThuTheoThoiGian(DateTime ngaybd, DateTime ngaykt)
        {
            var result = ql.proc_ThongKeDoanhThuTheoNgay(ngaybd,ngaykt); 

            List<hoadon> doanhThuNgay = result
                .Select(x => new hoadon
                {
                    // Chuyển đổi các thuộc tính từ proc_DanhSachSanPhamBanChayResult sang sanpham
                    Ngay = x.Ngay.ToString(),  // Ví dụ, nếu proc_DanhSachSanPhamBanChayResult có thuộc tính TenSanPham
                    Doanhthu = (long)x.DoanhThuNgay  // Và SoLuongBan cũng là một thuộc tính trong proc_DanhSachSanPhamBanChayResult
                }).ToList();

            return doanhThuNgay;
        }



    }
}
