using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SingIn
{
    public partial class Form1 : Form
    {
        private object lblResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }


        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            string specialCharPattern = @"[!@#$%^&*(),.?\:{ }|<>]";
            return Regex.IsMatch(password, specialCharPattern);
        }

        private void btnSingin_click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (txtUser.Text == "" || txtEmail.Text == "" || txtPassword.Text == "") {
                MessageBox.Show("Vui lòng lại nhập thông tin !", "Thông báo");
            }else if(!IsValidEmail(email)) {
                MessageBox.Show("Email không đúng định dạng!", "Thông báo");
            }else if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự và chứa ít nhất 1 ký tự đặc biệt!", "Thông báo");
            
            }else{
                MessageBox.Show("Đăng ký thành công!", "Thông báo");
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnUser_click(object sender, EventArgs e)
        {

        }

        private void btnEmail_click(object sender, EventArgs e)
        {

        }

        private void btnPass_click(object sender, EventArgs e)
        {

        }

        

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
