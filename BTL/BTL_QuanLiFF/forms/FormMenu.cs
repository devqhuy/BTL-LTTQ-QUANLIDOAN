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

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDA);
        }

<<<<<<< HEAD
        private void frmMenu_Load(object sender, EventArgs e)
        {
            //frmLogin1.ShowDialog();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            frmLogin1.ShowDialog();
            lblTen.Text = username;


            
            
            

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
=======
>>>>>>> f3895feae0c7938966ee1ffaf2315ac26841e245
    }
}
