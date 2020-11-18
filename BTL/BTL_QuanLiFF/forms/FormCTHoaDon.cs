using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            txtTimKiemSoLuong.Enabled = false;

            btnTimKiemCapNhat.Enabled = false;
            btnTimKiemXoa.Enabled = false;

            txtTimKiemMaHD.Text = MaHD;
            txtTimKiemMaKH.Text = MaKH;
            dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, SANPHAM.idSP, SANPHAM.tenSP ,idNV, idKH, soLuong, " +
                "SANPHAM.giaTienSP, ngayTao, giaTien , yeuCau " +
                "FROM CTHOADONBAN " +
                "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                "INNER JOIN SANPHAM ON CTHOADONBAN.idSP = SANPHAM.idSP " +
                "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");
            txtTimKiemNgayBan.Text = Convert.ToDateTime(dt.Rows[0]["ngayTao"]).ToShortDateString();


            this.edit();

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
            txtTimKiemSoLuong.Enabled = true;

            txtTimKiemMaMon.Text = dtgvTimKiem.CurrentRow.Cells[1].Value.ToString();
            txtTimKiemSoLuong.Text = dtgvTimKiem.CurrentRow.Cells[5].Value.ToString();
            txtTimKiemDonGia.Text = dtgvTimKiem.CurrentRow.Cells[6].Value.ToString();
            txtTimKiemTenMon.Text = dtgvTimKiem.CurrentRow.Cells[2].Value.ToString();

            DataTable dt2 = dtbase.DataReader("select * from SANPHAM where idSP = '" + txtTimKiemMaMon.Text +
                "'");
            try
            {
                if(this.sales() != 1 )
                {
                    txtTimKiemKhuyenMai.Text = Convert.ToString(this.sales() * 100);
                }
                txtTimKiemTenMon.Text = dt2.Rows[0]["TenSP"].ToString();
                txtTimKiemThanhTien.Text =
                    Convert.ToString(Convert.ToInt32(txtTimKiemSoLuong.Text) * Convert.ToInt32(txtTimKiemDonGia.Text) * (1- this.sales()));
            }catch (Exception Ex)
            {
                Ex.ToString();
            }

            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dtbase.DataChange("delete from CTHOADONBAN where idHD = '" + MaHD +
               "' and idSP = '" + txtTimKiemMaMon.Text + "'");
                dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, SANPHAM.idSP, SANPHAM.tenSP ,idNV, idKH, soLuong, " +
                               "SANPHAM.giaTienSP, ngayTao, giaTien , yeuCau " +
                               "FROM CTHOADONBAN " +
                               "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                               "INNER JOIN SANPHAM ON CTHOADONBAN.idSP = SANPHAM.idSP " +
                               "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");
                dtgvTimKiem.DataSource = dt;
                

                this.edit();

                if(dt.Rows.Count == 0 )
                {
                    dtgvTimKiem.Enabled = false;
                    dtbase.DataChange("delete from HOADONBAN where idHD = '" + MaHD +
                    "' ");
                }

                dt = dtbase.DataReader("SELECT tongTien " +
               "FROM CTHOADONBAN " +
               "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
               "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");

                txtTimKiemTongTien.Text = dt.Rows[0]["tongTien"].ToString();

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

                dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, SANPHAM.idSP, SANPHAM.tenSP ,idNV, idKH, soLuong, " +
                               "SANPHAM.giaTienSP, ngayTao, giaTien , yeuCau " +
                               "FROM CTHOADONBAN " +
                               "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                               "INNER JOIN SANPHAM ON CTHOADONBAN.idSP = SANPHAM.idSP " +
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

        private void btnTimKiemCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                dtbase.DataChange("update CTHOADONBAN set soLuong = " + txtTimKiemSoLuong.Text +
                    " , giaTien = " + Convert.ToInt32(txtTimKiemThanhTien.Text) +
                    "where idHD = '" + txtTimKiemMaHD.Text + "' and idSP = '" + txtTimKiemMaMon.Text + "'");

                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, SANPHAM.idSP, SANPHAM.tenSP ,idNV, idKH, soLuong, " +
                              "SANPHAM.giaTienSP, ngayTao, giaTien , yeuCau " +
                              "FROM CTHOADONBAN " +
                              "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                              "INNER JOIN SANPHAM ON CTHOADONBAN.idSP = SANPHAM.idSP " +
                              "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");
                dtgvTimKiem.DataSource = dt;

                long t = 0;
                for (int i = 0; i < dt.Rows.Count - 2; i++)
                {
                    t += Convert.ToInt64(dt.Rows[i]["giaTien"].ToString());
                }
                txtTimKiemTongTien.Text = Convert.ToString(t);

                this.edit();

                dt = dtbase.DataReader("SELECT tongTien " +
               "FROM CTHOADONBAN " +
               "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
               "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");

                txtTimKiemTongTien.Text = dt.Rows[0]["tongTien"].ToString();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Exception Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

           
        }

        private void txtTimKiemSoLuong_TextChanged(object sender, EventArgs e)
        {
            
            if (Regex.IsMatch(txtTimKiemSoLuong.Text, @"\d") != true)
            {
                MessageBox.Show("Bạn phải nhập số trong mục này", "Exception Message", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                txtTimKiemSoLuong.Text = "";
                txtTimKiemSoLuong.Focus();
            }
            else
            {

                try
                {
                    txtTimKiemThanhTien.Text = Convert.ToString(
                       Convert.ToDouble(txtTimKiemSoLuong.Text) * Convert.ToDouble(txtTimKiemDonGia.Text) * (1-this.sales()));
                    dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, SANPHAM.idSP, SANPHAM.tenSP ,idNV, idKH, soLuong, " +
                                   "SANPHAM.giaTienSP, ngayTao, giaTien , yeuCau " +
                                   "FROM CTHOADONBAN " +
                                   "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                                   "INNER JOIN SANPHAM ON CTHOADONBAN.idSP = SANPHAM.idSP " +
                                   "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");
                }
                catch (Exception Ex)
                {
                    Ex.ToString();
                }
            }
        }

        public double sales()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dtbase.DataReader("select * from KHUYENMAI where idSP = '" + txtTimKiemMaMon.Text + "' " );
            }catch (Exception Ex)
            {
                Ex.ToString();
            }
          
            if (dt.Rows.Count > 0)
            {
                string masp1 = dt.Rows[0]["idSP"].ToString();
                string makm1 = dt.Rows[0]["idKM"].ToString();
                DateTime bd1 = Convert.ToDateTime(dt.Rows[0]["ngayBatDau"].ToString());
                DateTime kt1 = Convert.ToDateTime(dt.Rows[0]["ngayKetThuc"].ToString());
                double gg1 = Convert.ToDouble(dt.Rows[0]["giamGia"].ToString()) / 100.0;

                return gg1;
            }
            return 0;

        }

        public void edit()
        {

            dtgvTimKiem.DataSource = dt;
            dtgvTimKiem.Columns[0].HeaderText = "Mã HD";
            dtgvTimKiem.Columns[1].HeaderText = "Mã SP";
            dtgvTimKiem.Columns[2].HeaderText = "Tên SP";
            dtgvTimKiem.Columns[3].HeaderText = "Mã NV";
            dtgvTimKiem.Columns[4].HeaderText = "Mã KH";
            dtgvTimKiem.Columns[5].HeaderText = "Số lượng";
            dtgvTimKiem.Columns[6].HeaderText = "Giá tiền";
            dtgvTimKiem.Columns[7].HeaderText = "Ngày tạo";
            dtgvTimKiem.Columns[8].HeaderText = "Tổng tiền";
            dtgvTimKiem.Columns[9].HeaderText = "Yêu cầu thêm";
        }
    }
}
