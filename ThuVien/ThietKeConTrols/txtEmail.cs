using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.ThietKeConTrols
{
    public class txtEmail:TextBox
    {
        public txtEmail()
        {
            this.Leave += TxtEmail_Leave;
        }

      

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            string email = this.Text;

            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                // Sử dụng System.Net.Mail.MailAddress để kiểm tra định dạng email
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
