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

using Excel = Microsoft.Office.Interop.Excel;


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


            dt = dtbase.DataReader("SELECT tongTien " +
             "FROM CTHOADONBAN " +
             "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
             "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");

            txtTimKiemTongTien.Text = dt.Rows[0]["tongTien"].ToString();

            dt = dtbase.DataReader("SELECT CTHOADONBAN.idHD, SANPHAM.idSP, SANPHAM.tenSP ,idNV, idKH, soLuong, " +
                "SANPHAM.giaTienSP, ngayTao, giaTien , yeuCau " +
                "FROM CTHOADONBAN " +
                "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                "INNER JOIN SANPHAM ON CTHOADONBAN.idSP = SANPHAM.idSP " +
                "WHERE CTHOADONBAN.idHD = '" + MaHD + "'");
            txtTimKiemNgayBan.Text = Convert.ToDateTime(dt.Rows[0]["ngayTao"]).ToShortDateString();


            dtgvTimKiem.DataSource = dt;
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
                    //this.edit();
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

        private void btnTimKiemInHoaDon_Click(object sender, EventArgs e)
        {
            if (dtgvTimKiem.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook =
                exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                

                //Định dạng chung
                Excel.Range hoadon = (Excel.Range)exSheet.Cells[1, 3];
                exSheet.get_Range("C1:H1").Merge(true);
                exSheet.Range["C1", "F1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                
                hoadon.Font.Size = 20;
                hoadon.Font.Bold = true;
                hoadon.Font.Color = Color.FromArgb(219, 82, 13);
                hoadon.Value = "CỬA HÀNG FAST FOOD ĐẠT HUY";

                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 5];
                exSheet.get_Range("E2:F2").Merge(true);
                exSheet.Range["E2", "F2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                dcCuaHang.Font.Size = 12;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Black;
                dcCuaHang.Value = "Địa chỉ: Xxx - xXx - XXX - xXX";

                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 5];
                exSheet.get_Range("E3:F3").Merge(true);
                exSheet.Range["E3", "F3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Black;
                dtCuaHang.Value = "Điện thoại: xxxxxxxxxx";

                Excel.Range header = (Excel.Range)exSheet.Cells[6, 2];
                exSheet.get_Range("B6:G6").Merge(true);
                header.Font.Size = 20;
                header.Font.Bold = true;
                header.Font.Color = Color.FromArgb(255, 218, 135);
                header.Value = "DANH SÁCH CÁC MẶT HÀNG";
                //Định dạng tiêu đề bảng

                exSheet.get_Range("A7:G7").Font.Bold = true;
                exSheet.get_Range("A7:G7").HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A8").Value = "STT";

                exSheet.get_Range("B8").Value = "Mã HĐ "; 
                exSheet.get_Range("B8").ColumnWidth = 20;

                exSheet.get_Range("C8").Value = "Mã NV ";
                exSheet.get_Range("C8").ColumnWidth = 10;
                exSheet.get_Range("D8").Value = "Tên NV ";
                exSheet.get_Range("D8").ColumnWidth = 20;

                exSheet.get_Range("E8").Value = "Mã KH";
                exSheet.get_Range("E8").ColumnWidth = 10;
                exSheet.get_Range("F8").Value = "Tên KH";
                exSheet.get_Range("F8").ColumnWidth = 20;

                exSheet.get_Range("G8").Value = "Mã SP";
                exSheet.get_Range("G8").ColumnWidth = 10;
                exSheet.get_Range("H8").Value = "Tên SP";
                exSheet.get_Range("H8").ColumnWidth = 20;

                exSheet.get_Range("I8").Value = "Ngày tạo";
                exSheet.get_Range("I8").ColumnWidth = 15;

                exSheet.get_Range("J8").Value = "Đơn giá";
                exSheet.get_Range("J8").ColumnWidth = 10;
                exSheet.get_Range("K8").Value = "Số lượng";
                exSheet.get_Range("K8").ColumnWidth = 10;

                exSheet.get_Range("M8").Value = "Tổng tiền";
                exSheet.get_Range("M8").ColumnWidth = 20;

                exSheet.get_Range("L8").Value = "Yêu cầu thêm";
                exSheet.get_Range("L8").ColumnWidth = 12;

                //In dữ liệu
                DataTable dt = dtbase.DataReader("select cthoadonban.idHD, " +
                    "nhanvien.idNV, nhanvien.hoTenNV," +
                    "khachhang.idKH, khachhang.hoTenKH, " +
                    "sanpham.idsp, sanpham.tensp," +
                    "sanpham.giaTienSP, cthoadonban.soLuong, " +
                    "cthoadonban.giaTien , " +
                    "cthoadonban.yeuCau , cthoadonban.ngayTao from cthoadonban " +
                    "inner join hoadonban on cthoadonban.idhd= hoadonban.idhd " +
                    "inner join sanpham on cthoadonban.idsp = sanpham.idsp " +
                    "inner join khachhang on khachhang.idKH = hoadonban.idKH " +
                    "inner join nhanvien on nhanvien.idNV = hoadonban.idNV " +
                    "where cthoadonban.idHD = '" + txtTimKiemMaHD.Text +"'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 9).ToString() + ":M" + (i + 9).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 9).ToString()).Value = (i + 1).ToString();

                    exSheet.get_Range("B" + (i + 9).ToString()).Value =
                                dt.Rows[i]["idHD"].ToString();
                    exSheet.get_Range("C" + (i + 9).ToString()).Value =
                                dt.Rows[i]["idNV"].ToString();
                    exSheet.get_Range("D" + (i + 9).ToString()).Value =
                                dt.Rows[i]["hoTenNV"].ToString();
                    exSheet.get_Range("E" + (i + 9).ToString()).Value =
                                dt.Rows[i]["idKH"].ToString();
                    exSheet.get_Range("F" + (i + 9).ToString()).Value =
                                dt.Rows[i]["hoTenKH"].ToString();

                    exSheet.get_Range("G" + (i + 9).ToString()).Value =
                                dt.Rows[i]["idsp"].ToString();
                    exSheet.get_Range("H" + (i + 9).ToString()).Value =
                                dt.Rows[i]["tenSP"].ToString();
                    exSheet.get_Range("I" + (i + 9).ToString()).Value =
                                dt.Rows[i]["ngayTao"].ToString();
                    exSheet.get_Range("J" + (i + 9).ToString()).Value =
                                dt.Rows[i]["giaTienSP"].ToString();
                    exSheet.get_Range("K" + (i + 9).ToString()).Value =
                                dt.Rows[i]["soLuong"].ToString();
                    exSheet.get_Range("M" + (i + 9).ToString()).Value =
                                dt.Rows[i]["giaTien"].ToString();
                    exSheet.get_Range("L" + (i + 9).ToString()).Value =
                                dt.Rows[i]["yeuCau"].ToString();
                 

                }
                exSheet.Name = "Hang";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của SaveFileDialog
                                   
                dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc)| *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xlsx";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng

                this.Close();
                                   
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");

        }
    }
}
