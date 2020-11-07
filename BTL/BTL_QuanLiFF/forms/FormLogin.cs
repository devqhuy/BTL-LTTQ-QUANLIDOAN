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
<<<<<<< HEAD
        
        public static string username = "";
        public static string role = "";
=======

        frmMenu frmMenu1;
        string username = "";
        string role = "";
>>>>>>> f3895feae0c7938966ee1ffaf2315ac26841e245

        
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
            txtTK.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*if(validateLogin() == true  & IsValidEmail(txtTK.Text) == true) 
            {
                DataTable dt = new DataTable();
                dt = dtbase.DataReader("select email, matKhau from TAIKHOAN where" +
                    " email = '" + txtTK.Text +
                    "' and matKhau = '" + txtMK.Text + "'");
                if (dt.Rows.Count >= 0)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    dt = dtbase.DataReader("select * " +
                        "from taikhoan " +
                        "inner join nhanvien " +
                        "on nhanvien.idNV = TAIKHOAN.idNV " +
                        "where email = '" + txtTK.Text +"'");
                    username = dt.Rows[0]["hoTenNV"].ToString() ;
<<<<<<< HEAD
                    role = dt.Rows[0]["chucVu"].ToString();  
                    /*
                        Xu ly phan quay tro lai trnag menu ban dau 
                     
=======
                    role = dt.Rows[0]["chucVu"].ToString();

                    MessageBox.Show(username);

                    txtMK.Text = "";
                    txtTK.Text = "";

                    frmMenu1 = new frmMenu(username, role, true);
                    frmMenu1.ShowDialog();
                    
>>>>>>> f3895feae0c7938966ee1ffaf2315ac26841e245
                }
                else
                {
                    MessageBox.Show(txtMK.Text);
                    MessageBox.Show("Ten dang nhap hay mat khau khong dung");
                }
                
            }
            */
            if (txtTK.Text == "admin" & txtMK.Text == "123")
            {
                username = txtTK.Text;
                frmMenu f = new frmMenu();
                f.ShowDialog();
            }
        }

       
        public bool validateLogin()
        {
            if(txtTK.Text.Trim() == "")
            {
                err1.SetError(txtTK, "Bạn cần nhập vào tài khoản");
                return false;
            }
            else
            {
                if (!IsValidEmail(txtTK.Text))
                {
                    err1.SetError(txtTK, "Bạn cần nhập đúng định dạng email");
                }
                else return true;
            }

            if (txtMK.Text.Trim() == "")
            {
                err1.SetError(txtMK, "Bạn cần nhập vào mật khẩu");
                return false;
            }

            if(txtTK.Text.Trim() != "" & txtMK.Text.Trim() != "")
            {
                btnSubmit.Enabled = true;
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
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*
        private void tm1_Tick(object sender, EventArgs e)
        {
            if(frmMenu1.bl == true )
            {
               DialogResult dgResult = MessageBox.Show("Bạn Có Muốn Thoát KHỎI CHƯƠNG TRÌNH", "Thông Báo 2",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (dgResult == DialogResult.No)
                {
                    this.Show();
                }

            }

            
        }

        */
    }
}
