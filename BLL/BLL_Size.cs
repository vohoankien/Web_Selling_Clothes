using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_Size
    {
        DAL_Size dl = new DAL_Size();
        public BLL_Size() { }   

        public IQueryable getALLSize(string masp)
        {
            return  dl.getALLSize(masp);
        }
        public string getSizeFirst(string masp)
        {
            return dl.getSizeFirst(masp);   
        }
    }
}
