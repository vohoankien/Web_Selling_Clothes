using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThuVien.ThietKeConTrols
{
    public class txtMatKhau : TextBox
    {
        public txtMatKhau() 
        {
            this.PasswordChar ='*';
            this.Leave += TxtMatKhau_Leave;
        }

        private void TxtMatKhau_Leave(object sender, EventArgs e)
        {
            string password = this.Text;


            // Kiểm tra độ dài ít nhất 8 ký tự
            if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
                return;
            }

            // Kiểm tra có ít nhất 1 chữ cái
            if (!password.Any(char.IsLetter))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 1 chữ cái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
                return;
            }

            // Kiểm tra có ít nhất 1 chữ số
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 1 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
                return;
            }

            // Kiểm tra có ít nhất 1 ký tự đặc biệt
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 1 ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
            }
        }

    }
}
