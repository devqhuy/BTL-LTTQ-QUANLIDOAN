using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiFF.forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnThoatMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void moveSidePanel(Control control)
        {
            panelSlide.Top = control.Top;
            panelSlide.Height = control.Height;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKhachHang);
        }

        private void btnDoAnUong_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDoAnUong);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhanVien);
        }
    }
}
