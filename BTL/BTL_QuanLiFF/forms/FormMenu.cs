using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLiFF.Forms;
using BTL_QuanLiFF.UserControls;

namespace BTL_QuanLiFF.Forms
{
    
    public partial class frmMenu : Form
    {
        public static frmMenu fMenu = new frmMenu();
        frmLogin frmLogin1 = new frmLogin();
        

        public string username = "";
        public string role = "";
        public bool start_session = false;
        public bool end_session = false;
        public bool bl = false;
      
        public frmMenu()
        {
            InitializeComponent();
            
        }

        //ham khi click tung button se cho form userControl vao panel cua form tuong ung
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }
          private void frmMenu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lblTen.Text = username;
            lblRole.Text = role;
        }

        public frmMenu(string name, string role, bool start) :this()
        {
            this.username = name;
            this.role = role;
            this.start_session = true;
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnThongKe);
            ucThongKe ucDAU = new ucThongKe();
            addControlsToPanel(ucDAU);
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
