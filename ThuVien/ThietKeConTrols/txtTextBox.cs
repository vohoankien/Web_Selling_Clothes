using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace ThuVien.ThietKeConTrols
{
    public class txtTextBox : TextBox
    {
        public txtTextBox() 
        {
            this.Leave += TxtTextBox_Leave;
        }

        private void TxtTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                MessageBox.Show("Trường này không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus(); 
            }
        }
    }
}
