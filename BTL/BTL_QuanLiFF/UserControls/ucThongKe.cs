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
            dt = dtbase.DataReader("select idNV from NHANVIEN" +
                " where status = 'HD'");
            try
            {
                cmbNV2.DataSource = dt;
                cmbNV2.DisplayMember = "idNV";
                cmbNV2.ValueMember = "idNV";

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
            }
                
            else if (e.TabPage == tabPage2)
            {
                dgv2.DataSource = dtbase.DataReader("select HOADONBAN.idHD , idSP, soLuong, idNV, ngayTao, giaTien, tongTien  " +
                    "from HOADONBAN inner" +
                    " join CTHOADONBAN ON HOADONBAN.idHD = CTHOADONBAN.idHD");

                dgv2.Columns[1].Width = 100;
                dgv2.Columns[2].Width = 100;
                dgv2.Columns[0].Width = 210;
                dgv2.Columns[4].Width = 214;

            }
            else if( e.TabPage == tabPage3)
            {
                dgv3.DataSource = dtbase.DataReader("SELECT CTHOADONNHAP.idCT, NHANVIEN.hoTenNV , " +
                "CTHOADONNHAP.idNCC, nguyenlieu.tenNL, ctnguyenlieu.soLuong, ngayTaoHD , sex , status " +
                "FROM CTHOADONNHAP " +
                "INNER JOIN CTNGUYENLIEU ON CTNGUYENLIEU.idCT = CTHOADONNHAP.idCT " +
                "INNER JOIN NGUYENLIEU ON NGUYENLIEU.idNL = CTNGUYENLIEU.idNL " +
                "INNER JOIN NHACUNGCAP ON NHACUNGCAP.idNCC = CTHOADONNHAP.idNCC " +
                "INNER JOIN NHANVIEN ON NHANVIEN.idNV = CTHOADONNHAP.idNV ");


                dgv3.Columns[1].Width = 200;
                dgv3.Columns[5].Width = 200;

                dt = dtbase.DataReader("select * from NGUYENLIEU");
                cmbNL3.DataSource = dt;
                cmbNL3.DisplayMember = "tenNL";
                cmbNL3.ValueMember = "tenNL";

            }

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            from1 = dtpFrom1.Value.ToShortDateString();
            to1 = dtpTo1.Value.ToShortDateString();

            if (rdb11.Checked) rdb = "DESC";
            else rdb = "ASC";

            dt = dtbase.DataReader("SELECT TOP(10) WITH TIES tenSP, giaTienSP , sum(soLuong) as tong " +
                "FROM SANPHAM " +
                "INNER JOIN CTHOADONBAN ON CTHOADONBAN.idSP = SANPHAM.idSP " +
                "INNER JOIN HOADONBAN  ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                "WHERE ngayTao >= '" + Convert.ToDateTime(from1) +
                "' and ngayTao <= '" + Convert.ToDateTime(to1) + "' " +
                "GROUP BY tenSP, giaTienSP " +
                " ORDER BY  tong " +rdb);

            dgv1.DataSource = dt;
        }

        private void btnIN1_Click(object sender, EventArgs e)
        {

        }

        public void checkTabPage2()
        {
            String from2 = "";
            String to2 = "";
            String rdb = "";
            String manv = "";

            from2 = dtpFrom2.Value.ToShortDateString();
            to2 = dtpTo2.Value.ToShortDateString();

            if (rdb21.Checked) rdb = "DESC";
            else rdb = "ASC";

            manv = cmbNV2.Text;

            dt = dtbase.DataReader("select HOADONBAN.idHD , idSP, soLuong, " +
                "hoTenNV, ngayTao, giaTien, tongTien " +
                "from HOADONBAN " +
                "inner join CTHOADONBAN ON HOADONBAN.idHD = CTHOADONBAN.idHD " +
                "inner join NHANVIEN ON NHANVIEN.idNV = '" + manv + "'" +
                "WHERE ngayTao >= '" + Convert.ToDateTime(from2) +
                "' and ngayTao <= '" + Convert.ToDateTime(to2) + "' " +
                 " ORDER BY tongTien " + rdb); 


            dgv2.DataSource = dt;
            dgv2.Columns[0].Width = 200;
            dgv2.Columns[3].Width = 200;
            dgv2.Columns[4].Width = 200;
            dgv2.Columns[5].Width = 200;
        }

        private void btnXem2_Click(object sender, EventArgs e)
        {
            checkTabPage2();
        }

        private void btnIN2_Click(object sender, EventArgs e)
        {

        }

        private void btnXem3_Click(object sender, EventArgs e)
        {
            String from3 = "";
            String to3 = "";
            String rdb = "";
            String manv = "";

            from3 = dtpFrom3.Value.ToShortDateString();
            to3 = dtpTo3.Value.ToShortDateString();

            if (rdb21.Checked) rdb = "DESC";
            else rdb = "ASC";

            manv = cmbNV2.Text;

            dt = dtbase.DataReader("SELECT CTHOADONNHAP.idCT, NHANVIEN.hoTenNV , " +
                "CTHOADONNHAP.idNCC, nguyenlieu.tenNL, ctnguyenlieu.soLuong, ngayTaoHD , sex , status " +
                "FROM CTHOADONNHAP " +
                "INNER JOIN CTNGUYENLIEU ON CTNGUYENLIEU.idCT = CTHOADONNHAP.idCT " +
                "INNER JOIN NGUYENLIEU ON NGUYENLIEU.idNL = CTNGUYENLIEU.idNL " +
                "INNER JOIN NHACUNGCAP ON NHACUNGCAP.idNCC = CTHOADONNHAP.idNCC " +
                "INNER JOIN NHANVIEN ON NHANVIEN.idNV = '" + manv + "'" +
                "WHERE ngayTao >= '" + Convert.ToDateTime(from3) +
                "' and ngayTao <= '" + Convert.ToDateTime(to3) + "' " +
                 " ORDER BY tongTien " + rdb);


            dgv2.DataSource = dt;
            dgv2.Columns[0].Width = 200;
            dgv2.Columns[3].Width = 200;
            dgv2.Columns[4].Width = 200;
            dgv2.Columns[5].Width = 200;
        }
    }
}
