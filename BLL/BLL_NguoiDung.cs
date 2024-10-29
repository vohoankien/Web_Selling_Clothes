using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_NguoiDung
    {
        DAL_NguoiDung dl = new DAL_NguoiDung();
        public BLL_NguoiDung() { }

        public string createMaNguoiDung()
        {
            return dl.GenerateMaQuyen();
        }

        public bool insertNguoiDung(nguoidung nd)
        {
            return dl.insertNguoiDung(nd);
        }

        public nguoidung findNguoiDung(string s)
        {
            return dl.findNguoiDung(s);
        }

        public bool deleteNguoiDung(nguoidung tk)
        {
            return dl.deleteNguoiDung(tk);
        }

        public bool updateNguoiDung(nguoidung temp, nguoidung nq)
        {
            return dl.updateNguoiDung(temp, nq);
        }

    }
}
