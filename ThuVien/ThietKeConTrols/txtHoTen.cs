using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThuVien.ThietKeConTrols
{
    public class txtHoTen :TextBox
    {
        public txtHoTen()
        {
            this.KeyPress += TxtHoTen_KeyPress;
            this.Leave += TxtHoTen_Leave;
        }

        private void TxtHoTen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
            }
        }

        private void TxtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự khác
            }
        }


    }
}
