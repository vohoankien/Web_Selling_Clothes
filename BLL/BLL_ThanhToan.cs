using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_ThanhToan
    {
        DAL_ThanhToan dl = new DAL_ThanhToan();
        public BLL_ThanhToan() { }

        public string GenerateMaThanhToan()
        {
            return dl.GenerateMaThanhToan();
        }

        public bool insertThanhToan(thanhtoan th)
        {
            return dl.insertThanhToan(th);
        }
    }
}
