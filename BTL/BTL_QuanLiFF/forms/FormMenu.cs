using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLiFF.Forms;



namespace BTL_QuanLiFF.Forms
{
    public partial class frmMenu : Form
    {
        frmLogin frmLogin1 = new frmLogin();

        public static string username = "";
        public static string role = "";
      
        public frmMenu()
        {
            InitializeComponent();
           
        }

        private void btnThoatMenu_Click(object sender, EventArgs e)
        {
            
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDA);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //frmLogin1.ShowDialog();

            this.MaximizeBox = false;
            this.MinimizeBox = false; 

            /*
                Xu ly phan nhan lai thong tin tu form login
             */
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dgResult;
            dgResult = MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question );
            if (dgResult == DialogResult.No)
            {
                this.Close();
            }
          
        }
    }
}
