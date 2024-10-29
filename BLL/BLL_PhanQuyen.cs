using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_PhanQuyen
    {
        DAL_Quyen dl = new DAL_Quyen();
        public BLL_PhanQuyen() { }
        public List<nhomquyen> getAllQuyen()
        {
            return dl.getAllQuyen();
        }
        public string createAutoMaQuyen()
        {
            return dl.GenerateMaQuyen();
        }   
        
        public bool insertQuyen(nhomquyen nq)
        {
            return dl.insertQuyen(nq);  
        }
        public bool deleteQuyen(nhomquyen nq)
        {
            return dl.deleteQuyen(nq);
        }

        public bool updateQuyen(string ten,nhomquyen nq)
        {
            return dl.updateQuyen(ten,nq);
        }

        public nhomquyen findQuyen(string s)
        {
            return dl.findQuyen(s);
        }

    }
}
