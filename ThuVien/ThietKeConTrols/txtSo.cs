using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThuVien.ThietKeConTrols
{
    public class txtSo : TextBox
    {
        public txtSo()
        {
            this.Leave += TxtSo_Leave;
            this.Validating += TxtSo_Validating;
        }

        private void TxtSo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(this.Text, out _))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void TxtSo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                MessageBox.Show("Trường này không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
            }
        }
    }
}
