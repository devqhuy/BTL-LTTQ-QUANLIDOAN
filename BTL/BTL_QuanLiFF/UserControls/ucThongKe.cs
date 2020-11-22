using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiFF.UserControls
{
    public partial class ucThongKe : UserControl
    {
        Classes.Common cm = new Classes.Common();
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        DataTable dt = new DataTable();
        
        public ucThongKe()
        {
            InitializeComponent();
        }

        private void ucThongKe_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = dtbase.DataReader("select * from SANPHAM");

            rdb11.Checked = true;
            rdb21.Checked = true;
            rdb31.Checked = true;

            this.LoadNV();
        }

        public void LoadNV()
        {

            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select idNV from NHANVIEN" );
            try
            {
                cbTKHDBTenNV.DataSource = dt;
                cbTKHDBTenNV.DisplayMember = "idNV";
                cbTKHDBTenNV.ValueMember = "idNV";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {
                dgv1.DataSource = dtbase.DataReader("select * from SANPHAM");

                dgv1.Columns["idSP"].HeaderText = "Mã SP";
                dgv1.Columns["tenSP"].HeaderText = "Tên sản phẩm";
                dgv1.Columns["imgSP"].HeaderText = "Tên ảnh";
                dgv1.Columns["moTaSP"].HeaderText = "Mô tả SP";
                dgv1.Columns["giaTienSP"].HeaderText = "Giá tiền SP";
                dgv1.Columns["Status"].HeaderText = "Tình trạng";
            }
                
            else if (e.TabPage == tabPage2)
            {
                dgv2.DataSource = dtbase.DataReader("select HOADONBAN.idHD , " +
                    "idSP, soLuong, idNV, ngayTao, giaTien, tongTien  " +
                    "from HOADONBAN inner" +
                    " join CTHOADONBAN ON HOADONBAN.idHD = CTHOADONBAN.idHD");

                dgv2.Columns[1].Width = 100;
                dgv2.Columns[2].Width = 100;
                dgv2.Columns[0].Width = 210;
                dgv2.Columns[4].Width = 214;

                dgv2.Columns["idHD"].HeaderText = "Mã HĐ";
                dgv2.Columns["idNV"].HeaderText = "Mã NV";
                dgv2.Columns["ngayTao"].HeaderText = "Ngày tạo";
                dgv2.Columns["giaTien"].HeaderText = "Giá tiền";
                dgv2.Columns["tongTien"].HeaderText = "Tổng tiền";
                dgv2.Columns["idSP"].HeaderText = "Mã SP";
                dgv2.Columns["soLuong"].HeaderText = "Số lượng";
               

            }
            else if( e.TabPage == tabPage3)
            {
                dgv3.DataSource = dtbase.DataReader("SELECT CTHOADONNHAP.idCT, NHANVIEN.hoTenNV , " +
                "CTHOADONNHAP.idNCC, nguyenlieu.tenNL, ctnguyenlieu.soLuong, ngayTaoHD , sex  " +
                "FROM CTHOADONNHAP " +
                "INNER JOIN CTNGUYENLIEU ON CTNGUYENLIEU.idCT = CTHOADONNHAP.idCT " +
                "INNER JOIN NGUYENLIEU ON NGUYENLIEU.idNL = CTNGUYENLIEU.idNL " +
                "INNER JOIN NHACUNGCAP ON NHACUNGCAP.idNCC = CTHOADONNHAP.idNCC " +
                "INNER JOIN NHANVIEN ON NHANVIEN.idNV = CTHOADONNHAP.idNV ");

                dgv3.Columns[1].Width = 200;
                dgv3.Columns[5].Width = 200;

                dt = dtbase.DataReader("select * from NGUYENLIEU");
                cbTKHDNTenNV.DataSource = dt;
                cbTKHDNTenNV.DisplayMember = "tenNL";
                cbTKHDNTenNV.ValueMember = "tenNL";

                dgv3.Columns["idCT"].HeaderText = "Mã CT";
                dgv3.Columns["hotenNV"].HeaderText = "Họ tên NV";
                dgv3.Columns["idNCC"].HeaderText = "Nhà CC";
                dgv3.Columns["tenNL"].HeaderText = "Tên NL";
                dgv3.Columns["soLuong"].HeaderText = "Số lượng";
                dgv3.Columns["ngayTaoHD"].HeaderText = "Ngày tạo";
                dgv3.Columns["sex"].HeaderText = "Giới tính";

            }

        }

        private void btnXem1_Click(object sender, EventArgs e)
        {
            checkTabPage1();
        }

        public void checkTabPage1()
        {
            String from1 = "";
            String to1 = "";
            String rdb = "";

            from1 = dtpTKBestSellFrom.Value.ToShortDateString();
            to1 = dtpTKBestSellTo.Value.ToShortDateString();

            if (rdb11.Checked) rdb = "DESC";
            else rdb = "ASC";

            dt = dtbase.DataReader("SELECT TOP(10) WITH TIES SANPHAM.idSP ,tenSP, giaTienSP , sum(soLuong) as tong " +
                "FROM SANPHAM " +
                "INNER JOIN CTHOADONBAN ON CTHOADONBAN.idSP = SANPHAM.idSP " +
                "INNER JOIN HOADONBAN  ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                "WHERE ngayTao >= '" + Convert.ToDateTime(from1) +
                "' and ngayTao <= '" + Convert.ToDateTime(to1) + "' " +
                "GROUP BY SANPHAM.idSP , tenSP, giaTienSP " +
                " ORDER BY  tong " +rdb);

            dgv1.Columns[3].Width = 150;
          
            dgv1.DataSource = dt;
            dgv1.Columns["idSP"].HeaderText = "Mã SP";
            dgv1.Columns["tenSP"].HeaderText = "Tên sản phẩm";
            dgv1.Columns["tong"].HeaderText = "Tổng số lượng";
            dgv1.Columns["giaTienSP"].HeaderText = "Giá tiền SP";
            
        }

        public void checkTabPage2()
        {
            String from2 = "";
            String to2 = "";
            String rdb = "";
            String manv = "";

            from2 = dtpTKHDBFrom.Value.ToShortDateString();
            to2 = dtpTKHDBTo.Value.ToShortDateString();

            if (rdb21.Checked) rdb = "DESC";
            else rdb = "ASC";

            manv = cbTKHDBTenNV.Text;

            dt = dtbase.DataReader("select HOADONBAN.idHD , " +
                "hoTenNV, ngayTao, giaTien, tongTien " +
                "from HOADONBAN " +
                "inner join CTHOADONBAN ON HOADONBAN.idHD = CTHOADONBAN.idHD " +
                "inner join NHANVIEN ON NHANVIEN.idNV = '" + manv + "'" +
                "WHERE ngayTao >= '" + Convert.ToDateTime(from2) +
                "' and ngayTao <= '" + Convert.ToDateTime(to2) + "' " +
                 " ORDER BY tongTien " + rdb); 

            dgv2.DataSource = dt;
            dgv2.Columns[0].Width = 200;
            dgv2.Columns[1].Width = 200;
            dgv2.Columns[2].Width = 200;
            dgv2.Columns[4].Width = 120;

            dgv2.Columns["idHD"].HeaderText = "Mã HĐ";
            dgv2.Columns["hotenNV"].HeaderText = "Họ tên NV";
            dgv2.Columns["ngayTao"].HeaderText = "Ngày tạo";
            dgv2.Columns["giaTien"].HeaderText = "Giá tiền";
            dgv2.Columns["tongTien"].HeaderText = "Tổng tiền";
        }

        private void btnXem2_Click(object sender, EventArgs e)
        {
            checkTabPage2();
        }

        private void btnXem3_Click(object sender, EventArgs e)
        {
            String from3 = "";
            String to3 = "";
            String rdb = "";
            String manv = "";

            from3 = dtpTKHDNFrom.Value.ToShortDateString();
            to3 = dtpTKHDNTo.Value.ToShortDateString();

            if (rdb21.Checked) rdb = "DESC";
            else rdb = "ASC";

            manv = cbTKHDBTenNV.Text;

            dt = dtbase.DataReader("SELECT CTHOADONNHAP.idCT, NHANVIEN.hoTenNV , " +
                "CTHOADONNHAP.idNCC, nguyenlieu.tenNL, ctnguyenlieu.soLuong, " +
                "ngayTaoHD , sex  , cthoadonnhap.tongTien " +
                "FROM CTHOADONNHAP " +
                "INNER JOIN CTNGUYENLIEU ON CTNGUYENLIEU.idCT = CTHOADONNHAP.idCT " +
                "INNER JOIN NGUYENLIEU ON NGUYENLIEU.idNL = CTNGUYENLIEU.idNL " +
                "INNER JOIN NHACUNGCAP ON NHACUNGCAP.idNCC = CTHOADONNHAP.idNCC " +
                "INNER JOIN NHANVIEN ON NHANVIEN.idNV = '" + manv + "'" +
                "WHERE ngayTaoHD >= '" + Convert.ToDateTime(from3) +
                "' and ngayTaoHD <= '" + Convert.ToDateTime(to3) + "' " +
                 " ORDER BY tongTien " + rdb);

            dgv3.DataSource = dt;
            dgv3.Columns[0].Width = 200;
            dgv3.Columns[0].Width = 120;
            dgv3.Columns[3].Width = 200;
            dgv3.Columns[4].Width = 200;
            dgv3.Columns[5].Width = 200;

            dgv3.Columns["idCT"].HeaderText = "Mã CT";
            dgv3.Columns["hotenNV"].HeaderText = "Họ tên NV";
            dgv3.Columns["idNCC"].HeaderText = "Nhà CC";
            dgv3.Columns["tenNL"].HeaderText = "Tên NL";
            dgv3.Columns["soLuong"].HeaderText = "Số lượng";
            dgv3.Columns["ngayTaoHD"].HeaderText = "Ngày tạo";
            dgv3.Columns["sex"].HeaderText = "Giới tính";
            dgv3.Columns["tongTien"].HeaderText = "Tổng tiền";
        }
    }
}
