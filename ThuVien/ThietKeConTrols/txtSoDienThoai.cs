using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.ThietKeConTrols
{
    public class txtSoDienThoai :TextBox
    {
        public txtSoDienThoai()
        {
            this.KeyPress += TxtSoDienThoai_KeyPress;
            this.TextChanged += TxtSoDienThoai_TextChanged;
        }

        private void TxtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
            }
        }

        private void TxtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
