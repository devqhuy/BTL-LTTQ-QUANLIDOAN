using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLiFF.Forms;
using BTL_QuanLiFF.UserControls;

namespace BTL_QuanLiFF.Forms
{
    
    public partial class frmMenu : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();

        public static frmMenu fMenu = new frmMenu();
        frmLogin frmLogin1 = new frmLogin();
        ucThongKe ucDAU = new ucThongKe();
        ucDoAnUong ucDoAn = new ucDoAnUong();
        ucQuanLi ucQuan = new ucQuanLi();
        ucKhachHang ucKhach = new ucKhachHang();
        ucTimKiem ucTim = new ucTimKiem();
        ucThongTin ucTT = new ucThongTin();

        public string username = "";
        public string role = "";
        public string idNV = "";
       
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
            timerTime.Start();
            lblTen.Text = username;
            lblRole.Text = role;
            lblIDNV.Text = idNV;
        }

        public frmMenu(string name, string role , string idNV) :this()
        {
            this.username = name;
            this.role = role;
            this.idNV = idNV;
        }

        private void moveSidePanel(Control control)
        {
            panelSlide.Top = control.Top;
            panelSlide.Height = control.Height;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKhachHang);
            lblTieuDe.Text = "Mục khách hàng";
            
            addControlsToPanel(ucKhach);
        }

        private void btnDoAnUong_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDoAnUong);
            lblTieuDe.Text = "Lựa chọn đồ ăn uống";
            
            addControlsToPanel(ucDoAn);
            
            ucDoAn.getID(idNV);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(role == "Quản lý")
            {
                lblTieuDe.Text = "Mục thống kê";

                moveSidePanel(btnThongKe);

                addControlsToPanel(ucDAU);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này", " Thông báo ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              
        }

        private void frmMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            
        }
        //ham hien thi gio giac hien tai
        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString();
        }

        private void btnQuanLi_Click(object sender, EventArgs e)
        {   
           if (role == "Quản lý")
            {
                moveSidePanel(btnQuanLi);
                lblTieuDe.Text = "Mục quản lí";
                addControlsToPanel(ucQuan);
                ucQuan.getNV(idNV);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này", " Thông báo ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnThongTin);
            lblTieuDe.Text = "Mục Thông Tin" ;

            addControlsToPanel(ucTT);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("2894490800");
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            MessageBox.Show(sb.ToString());
            //nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa 
            //trong "X2" thành "x"
            dtbase.DataChange("update taikhoan set matKhau = '" + sb.ToString()+ "' where idUSER = 'US03' ");   
        }

        */
    }
}
