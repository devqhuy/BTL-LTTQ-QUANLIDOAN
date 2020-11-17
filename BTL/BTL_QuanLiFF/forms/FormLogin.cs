using BTL_QuanLiFF;
using BTL_QuanLiFF.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiFF
{
    public partial class frmLogin : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();

        frmMenu frmMenu1;
        string username = "";
        string role = "";
        string idNV = "";



        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
            txtLoginEmail.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            validateLogin();

            if(!IsValidEmail(txtLoginEmail.Text))
            {
                MessageBox.Show("Bạn cần nhập email");
                return;
            }
            
            if(validateLogin() == true  && IsValidEmail(txtLoginEmail.Text) == true) 
            {
                DataTable dt = new DataTable();
                dt = dtbase.DataReader("select email, matKhau from TAIKHOAN where" +
                    " email = '" + txtLoginEmail.Text +
                    "' and matKhau = '" + txtLoginMK.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    dt = dtbase.DataReader("select * " +
                        "from taikhoan " +
                        "inner join nhanvien " +
                        "on nhanvien.idNV = TAIKHOAN.idNV " +
                        "where email = '" + txtLoginEmail.Text +"'");
                    username = dt.Rows[0]["hoTenNV"].ToString() ;

                    role = dt.Rows[0]["chucVu"].ToString(); 
                    idNV = dt.Rows[0]["idNV"].ToString();

                    txtLoginMK.Text = "";
                    txtLoginEmail.Text = "";
                    frmMenu1 = new frmMenu(username, role , idNV);
                    
                    this.Hide();
                    frmMenu1.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    txtLoginEmail.Focus();
                }
            }
        }

        public bool validateLogin()
        {
            if(txtLoginEmail.Text.Trim() == "")
            {
                err1.SetError(txtLoginEmail, "Bạn cần nhập vào tài khoản");
                return false;
            }
            else
            {
                if (!IsValidEmail(txtLoginEmail.Text))
                {
                    err1.SetError(txtLoginEmail, "Bạn cần nhập đúng định dạng email");
                }
                else return true;
            }

            if (txtLoginMK.Text.Trim() == "")
            {
                err1.SetError(txtLoginMK, "Bạn cần nhập vào mật khẩu");
                return false;
            }

            if(txtLoginEmail.Text.Trim() != "" & txtLoginMK.Text.Trim() != "")
            {
                btnLoginDangNhap.Enabled = true;
                err1.Clear();
                return true;
            }

            return false;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
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
