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
            txtMaMA.Enabled = false;
            txtTenMon.Enabled = false;
            txtDonGia.Enabled = false;
            txtThanhTien.Enabled = false;
            txtTT.Enabled = false;

            btnCN.Enabled = false;
            btnXoa.Enabled = false;

            txtMaHD.Text = MaHD;
            txtMaKH.Text = MaKH;
            dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, idSP ,idNV, idKH, soLuong, " +
                "giaTien, ngayTao, tongTien , yeuCau " +
                "FROM CTHOADONBAN " +
                "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");
            txtNgayBan.Text = Convert.ToDateTime(dt.Rows[0]["ngayTao"]).ToShortDateString();

            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã HD";
            dgv.Columns[1].HeaderText = "Mã SP";
            dgv.Columns[2].HeaderText = "Mã NV";
            dgv.Columns[3].HeaderText = "Mã KH";
            dgv.Columns[4].HeaderText = "Số lượng";
            dgv.Columns[5].HeaderText = "Giá tiền";
            dgv.Columns[6].HeaderText = "Ngày tạo";
            dgv.Columns[7].HeaderText = "Tổng tiền";
            dgv.Columns[8].HeaderText = "Yêu cầu thêm";

      
            DataTable dt3 = dtbase.DataReader("select * from KHACHHANG where idKH = '" +
                MaKH + "'");
            //txtMaKH.Text = dt3.Rows[0]["idKH"].ToString();
            txtTenKH.Text = dt3.Rows[0]["hoTenKH"].ToString();
            txtDiaChi.Text = dt3.Rows[0]["diaChi"].ToString();
            txtSDT.Text = dt3.Rows[0]["soDT"].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCN.Enabled = true;
            btnXoa.Enabled = true;

            txtMaMA.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = dgv.CurrentRow.Cells[5].Value.ToString();

            DataTable dt2 = dtbase.DataReader("select * from SANPHAM where idSP = '" + txtMaMA.Text +
                "'");

            txtTenMon.Text = dt2.Rows[0]["TenSP"].ToString();
            txtThanhTien.Text = 
                Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dtbase.DataChange("delete from CTHOADONBAN where idHD = '" + MaHD +
               "' and idSP = '" + txtMaMA.Text + "'");

                dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, idSP ,idNV, idKH, soLuong, " +
                "giaTien, ngayTao, tongTien , yeuCau " +
                "FROM CTHOADONBAN " +
                "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");

                dgv.DataSource = dt;

                if(dt.Rows.Count == 0 )
                {
                    dgv.Enabled = false;
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

                dgv.DataSource = dt;
                dgv.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
