using BTL_QuanLiFF.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiFF
{
    public partial class btnThoat : Form
    {
        public btnThoat()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormMenu f = new FormMenu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThoatDangNhap_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "ok";
        }
    }
}
