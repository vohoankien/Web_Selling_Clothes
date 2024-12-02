using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{

    public class DAL_ChiTietHoaDon
    {
        QuanLyQuanAoDataContext ql = new QuanLyQuanAoDataContext();
        public DAL_ChiTietHoaDon() { }

        public string GenerateChiTietHoanDon()
        {
            var existingMaHoaDon = ql.chitiethoadons.Select(k => k.MACTHD).ToList();
            int newCodeNumber = 1;
            if (existingMaHoaDon.Count > 0)
            {
                var maxCode = existingMaHoaDon
                    .Select(m => int.Parse(m.Substring(4)))
                    .Max();
                newCodeNumber = maxCode + 1;
                string newMaHoaDon = "CTHD" + newCodeNumber.ToString("D3");

                return newMaHoaDon;
            }
            else
            {
                return "CTHD001";
            }
        }

        public DataTable getAllCTHD(string mahd)
        {
            var query = from tk in ql.chitiethoadons
                        where tk.MAHD == mahd
                        select new
                        {
                            tk.MACTHD,
                            tk.MASP,
                            tk.MAHD,
                            tk.SIZE,
                            tk.SOLUONG,
                            tk.THANHTIEN,
                            tk.TINHTRANG
                        };

            // Chuyển sang DataTable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MACTHD", typeof(string));
            dataTable.Columns.Add("MASP", typeof(string));
            dataTable.Columns.Add("MAHD", typeof(string));
            dataTable.Columns.Add("SIZE", typeof(string));
            dataTable.Columns.Add("SOLUONG", typeof(int));
            dataTable.Columns.Add("THANHTIEN", typeof(decimal));
            dataTable.Columns.Add("TINHTRANG", typeof(bool));

            foreach (var item in query)
            {
                dataTable.Rows.Add(
                    item.MACTHD,
                    item.MASP,
                    item.MAHD,
                    item.SIZE,
                    item.SOLUONG,
                    item.THANHTIEN,
                    item.TINHTRANG
                );
            }

            return dataTable;
        }

        public bool insertChiTietHoaDon(chitiethoadon nh)
        {
            try
            {
                ql.chitiethoadons.InsertOnSubmit(nh);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteChiTietHoaDon(chitiethoadon lsp)
        {
            try
            {
                ql.chitiethoadons.DeleteOnSubmit(lsp);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> updateSoLuongChiTietHoaDon(int soluong, chitiethoadon lsp)
        {
            try
            {
                lsp.SOLUONG = soluong;
                ql.SubmitChanges();
                return true;
            }
            catch (ChangeConflictException ex)
            {
                ql.Refresh(RefreshMode.OverwriteCurrentValues, lsp);
                try
                {
                    await Task.Run(() => ql.SubmitChanges());
                    return true;
                }
                catch (Exception retryEx)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                return false;
            }
        }

        public async Task<bool> UpdateSizeChiTietHoaDonAsync(string size, chitiethoadon lsp)
        {
            try
            {
                lsp.SIZE = size;
                var changeSet = ql.GetChangeSet();
                ql.SubmitChanges();
                return true;
            }
            catch (ChangeConflictException ex)
            {
                ql.Refresh(RefreshMode.OverwriteCurrentValues, lsp);  

                try
                {
                    // Thử lại việc cập nhật
                    lsp.SIZE = size;
                    await Task.Run(() => ql.SubmitChanges());
                    return true;
                }
                catch (Exception retryEx)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }                                                           
        public chitiethoadon findCTHD(string s)
        {
            var nq = (from n in ql.chitiethoadons
                      where n.MACTHD == s
                      select n).FirstOrDefault();
            return nq;
        }
    }
}
