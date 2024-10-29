using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoan dl = new DAL_TaiKhoan();
        public BLL_TaiKhoan() { }

        public IQueryable getAllTaiKhoan()
        {
            return dl.getAllTaiKhoan();
        }

        public string createAutoMaQuyen()
        {
            return dl.GenerateMaQuyen();
        }

        public string hashPassword(string password)
        {
            return dl.hashPassword(password);
        }
        public bool insertTaiKhoan(taikhoanuser tk)
        {
            return dl.insertTaiKhoan(tk);
        }

        public taikhoanuser findTaiKhoan(string s)
        {
            return dl.findTaiKhoan(s);
        }

        public bool deleteTaiKhoan(taikhoanuser tk)
        {
            return dl.deleteTaiKhoan(tk) ;
        }


        public bool updateTaiKhoan(taikhoanuser temp, taikhoanuser nq)
        {
            return dl.updateTaiKhoan(temp, nq);
        }

    }
}
