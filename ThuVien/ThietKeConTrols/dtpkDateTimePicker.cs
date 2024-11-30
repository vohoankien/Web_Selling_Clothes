using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThuVien.ThietKeConTrols
{
    public class dtpkDateTimePicker :DateTimePicker
    {
        public dtpkDateTimePicker() 
        {
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "dd/MM/yyy";
        }
    }
}
