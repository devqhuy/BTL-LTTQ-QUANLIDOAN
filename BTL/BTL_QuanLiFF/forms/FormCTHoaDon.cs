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
    public partial class FormCTHoaDon : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public string MaHD = "";
        public string MaKH = ""; 
        DataTable dt = new DataTable();

        public FormCTHoaDon()
        {
            InitializeComponent();
        }

        public FormCTHoaDon(String mahd, string makh ) :this()
        {
            this.MaHD = mahd;
            this.MaKH = makh;
        }

        private void FormCTHoaDon_Load(object sender, EventArgs e)
        {
            grbTT.Enabled = false;
            txtTimKiemMaMon.Enabled = false;
            txtTimKiemTenMon.Enabled = false;
            txtTimKiemDonGia.Enabled = false;
            txtTimKiemThanhTien.Enabled = false;
            txtTimKiemTongTien.Enabled = false;

            btnTimKiemCapNhat.Enabled = false;
            btnTimKiemXoa.Enabled = false;

            txtTimKiemMaHD.Text = MaHD;
            txtTimKiemMaKH.Text = MaKH;
            dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, idSP ,idNV, idKH, soLuong, " +
                "giaTien, ngayTao, tongTien , yeuCau " +
                "FROM CTHOADONBAN " +
                "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");
            txtTimKiemNgayBan.Text = Convert.ToDateTime(dt.Rows[0]["ngayTao"]).ToShortDateString();

            dtgvTimKiem.DataSource = dt;
            dtgvTimKiem.Columns[0].HeaderText = "Mã HD";
            dtgvTimKiem.Columns[1].HeaderText = "Mã SP";
            dtgvTimKiem.Columns[2].HeaderText = "Mã NV";
            dtgvTimKiem.Columns[3].HeaderText = "Mã KH";
            dtgvTimKiem.Columns[4].HeaderText = "Số lượng";
            dtgvTimKiem.Columns[5].HeaderText = "Giá tiền";
            dtgvTimKiem.Columns[6].HeaderText = "Ngày tạo";
            dtgvTimKiem.Columns[7].HeaderText = "Tổng tiền";
            dtgvTimKiem.Columns[8].HeaderText = "Yêu cầu thêm";

      
            DataTable dt3 = dtbase.DataReader("select * from KHACHHANG where idKH = '" +
                MaKH + "'");
            //txtMaKH.Text = dt3.Rows[0]["idKH"].ToString();
            txtTimKiemTenKH.Text = dt3.Rows[0]["hoTenKH"].ToString();
            txtTimKiemDiaChi.Text = dt3.Rows[0]["diaChi"].ToString();
            txtTimKiemSoDT.Text = dt3.Rows[0]["soDT"].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTimKiemCapNhat.Enabled = true;
            btnTimKiemXoa.Enabled = true;

            txtTimKiemMaMon.Text = dtgvTimKiem.CurrentRow.Cells[1].Value.ToString();
            txtTimKiemSoLuong.Text = dtgvTimKiem.CurrentRow.Cells[4].Value.ToString();
            txtTimKiemDonGia.Text = dtgvTimKiem.CurrentRow.Cells[5].Value.ToString();

            DataTable dt2 = dtbase.DataReader("select * from SANPHAM where idSP = '" + txtTimKiemMaMon.Text +
                "'");

            txtTimKiemTenMon.Text = dt2.Rows[0]["TenSP"].ToString();
            txtTimKiemThanhTien.Text = 
                Convert.ToString(Convert.ToInt32(txtTimKiemSoLuong.Text) * Convert.ToInt32(txtTimKiemDonGia.Text));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dtbase.DataChange("delete from CTHOADONBAN where idHD = '" + MaHD +
               "' and idSP = '" + txtTimKiemMaMon.Text + "'");

                dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, idSP ,idNV, idKH, soLuong, " +
                "giaTien, ngayTao, tongTien , yeuCau " +
                "FROM CTHOADONBAN " +
                "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");

                dtgvTimKiem.DataSource = dt;

                if(dt.Rows.Count == 0 )
                {
                    dtgvTimKiem.Enabled = false;
                    dtbase.DataChange("delete from HOADONBAN where idHD = '" + MaHD +
                    "' ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                dtbase.DataChange("delete from CTHOADONBAN where idHD = '" + MaHD +
               "' " );

                dtbase.DataChange("delete from HOADONBAN where idHD = '" + MaHD +
               "' ");

                dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, idSP ,idNV, idKH, soLuong, " +
               "giaTien, ngayTao, tongTien , yeuCau " +
               "FROM CTHOADONBAN " +
               "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
               "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");

                dtgvTimKiem.DataSource = dt;
                dtgvTimKiem.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
