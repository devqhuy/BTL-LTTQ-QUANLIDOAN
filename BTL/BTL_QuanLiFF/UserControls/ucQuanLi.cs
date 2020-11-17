using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BTL_QuanLiFF.UserControls
{
    public partial class ucQuanLi : UserControl
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.Common cm = new Classes.Common();
        public string path = System.IO.Directory.GetCurrentDirectory().ToString();
        public string path2 = "";
        string strImageFileName;
        String gt = "";

        public ucQuanLi()
        {
            InitializeComponent();
        }

        private void tabNguyenLieu_Click(object sender, EventArgs e)
        {

        }

        private void tabNhanVien_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tpQLNV)
            {

                dtgvQLNVDSNhanVien.DataSource = dtbase.DataReader("select * from NHANVIEN");

                dtgvQLNVDSNhanVien.Columns[0].Width = 100;
                dtgvQLNVDSNhanVien.Columns[1].Width = 200;
                dtgvQLNVDSNhanVien.Columns["sex"].HeaderText = "Giới tính";

                cmb.Enabled = true;
                txtQLNVHoTen.Enabled = false;
                txtDoB.Enabled = false;
               
                txtQLNVSoDT.Enabled = false;
                txtQLNVChucVu.Enabled = false;
                txtAnh.Enabled = false;
                rdbNam.Checked = true;

                cmb.DataSource = dtbase.DataReader("select idNV from NHANVIEN");
                cmb.DisplayMember = "idNV";
                cmb.ValueMember = "idNV";

                btnQLNVSua.Enabled = false;
                btnQLNVXoa.Enabled = false;
                btnLuu1.Enabled = false;

            }
            else if (e.TabPage == tpQLNL)
            {

                dtgvQLNL.DataSource = dtbase.DataReader("select * from NGUYENLIEU");
            }
            
            else if (e.TabPage == tpQuanLiHDN)
            {

                dtgvQLHDN.DataSource = dtbase.DataReader("SELECT CTHOADONNHAP.idCT , CTHOADONNHAP.idNCC , " +
                    "hoTenNV , tenNL ,CTHOADONNHAP.soLuong , " +
                    "CTNGUYENLIEU.DONGIA, CTHOADONNHAP.TONGTIEN , " +
                    "ngayTaoHD , CTNGUYENLIEU.ghiChu  " +
                    "FROM CTHOADONNHAP " +
                    "INNER JOIN CTNGUYENLIEU ON CTHOADONNHAP.idCT = CTNGUYENLIEU.idCT " +
                    "INNER JOIN NHANVIEN ON NHANVIEN.idNV = CTHOADONNHAP.idNV INNER " +
                    "JOIN NHACUNGCAP ON NHACUNGCAP.idNCC = CTHOADONNHAP.idNCC " +
                    "INNER JOIN NGUYENLIEU ON NGUYENLIEU.idNL = CTNGUYENLIEU.idNL");
            }
            else if (e.TabPage == tpQLHDB)
            {

                dtgvQLHDB.DataSource = dtbase.DataReader("SELECT CTHOADONBAN.idHD , hoTenNV, " +
                    "SANPHAM.tenSP , CTHOADONBAN.soLuong, " +
                    "CTHOADONBAN.giaTien , CTHOADONBAN.KM , tongTien " +
                    " FROM CTHOADONBAN " +
                    "INNER JOIN HOADONBAN ON CTHOADONBAN.idHD = HOADONBAN.idHD " +
                    "INNER JOIN NHANVIEN ON NHANVIEN.idNV = HOADONBAN.idNV " +
                    "INNER JOIN SANPHAM ON SANPHAM.idSP = CTHOADONBAN.idSP");

                dtgvQLHDB.Columns[0].Width = 150;
                dtgvQLHDB.Columns[1].Width = 150;
                dtgvQLHDB.Columns[2].Width = 150;
                dtgvQLHDB.Columns[4].Width = 150;
                dtgvQLHDB.Columns[5].Width = 100;
               
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String manv = "";
            manv = this.cmb.GetItemText(this.cmb.SelectedValue);
            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select * from NHANVIEN where idNV = N'" + manv + "'");
            if(dt.Rows.Count >0)
            {
                txtQLNVHoTen.Text = dt.Rows[0]["hoTenNV"].ToString();
                txtDoB.Text = Convert.ToDateTime(dt.Rows[0]["ngaySinh"]).ToShortDateString();
               
                txtQLNVSoDT.Text = dt.Rows[0]["soDT"].ToString();
                txtQLNVChucVu.Text = dt.Rows[0]["chucVu"].ToString();
                 gt  = dt.Rows[0]["sex"].ToString();
                if (gt == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;

                txtAnh.Text = dt.Rows[0]["imgNV"].ToString();

            }

        }

        private void btnQLNVThem_Click(object sender, EventArgs e)
        {
            txtQLNVHoTen.Text = "";
            txtQLNVSoDT.Text = "";
            txtQLNVChucVu.Text = "";
            txtQLNVGhiChu.Text = "";
            txtDoB.Text = "";
            txtAnh.Text = "";

            txtQLNVHoTen.Enabled = true;
            txtDoB.Enabled = true;
           
            txtQLNVSoDT.Enabled = true;
            txtQLNVChucVu.Enabled = true;
            rdbNam.Checked = true;

            btnLuu1.Enabled = true;

            string idnv= cm.AutoCode("NHANVIEN", "idNV", "NV0");
            cmb.Text = idnv;

        }

        public bool check1()
        {
            if (cmb.Text.Trim() == "")
            {
                err4.SetError(cmb, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                err4.Clear();
            }
            if (txtQLNVHoTen.Text.Trim() == "")
            {
                err4.SetError(txtQLNVHoTen, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                err4.Clear();
            }

            if (txtQLNVChucVu.Text.Trim() == "")
            {
                err4.SetError(txtQLNVChucVu, "Trường này là bắt buộc");
                return false;

            }
            else
            {
                err4.Clear();
            }

            if (txtQLNVSoDT.Text.Trim() == "")
            {
                err4.SetError(txtQLNVSoDT, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                if (Regex.IsMatch(txtQLNVSoDT.Text, @"\d") != true ||
                        txtQLNVSoDT.Text.Length > 10)
                {
                    err4.SetError(txtQLNVSoDT, "Số điện thoại chỉ bao gồm số và không vượt quá 10");
                    return false;
                }
                else
                {
                    err4.Clear();
                }
                err4.Clear();
            }
            if (txtDoB.Text.Trim() == "")
            {
                err4.SetError(txtDoB, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDateTime(txtDoB.Text);
                    err4.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                
            }
            if(txtAnh.Text.Trim() == "")
            {
                err4.SetError(txtAnh, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                err4.Clear();
            }
            
            return true;

        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);

                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            if (check1())
            {
                try
                {
                    dtbase.DataChange("insert into nhanvien values('" + cmb.Text +
                   "',  N'" + txtQLNVHoTen.Text + "', '" + txtDoB.Text +
                   "', N'" + txtAnh.Text + "', '" + txtQLNVSoDT.Text +
                   "', N'" + txtQLNVChucVu.Text + "', N'" + gt +
                   "', 'HD ')");

                    MessageBox.Show("Thêm nhân viên thành công", " Thông báo ",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    System.IO.File.Delete(path + @"\Images\KhachHang\" + txtAnh.Text);
                    MessageBox.Show(Ex.Message, "Lỗi");
                    
                }
               
            }
        }

        private void lblAnh_Click(object sender, EventArgs e)
        {
            string[] Anh;
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Title = "Hiển thị ảnh người dùng";
            dlgOpen.Filter = "JPEG Images|*.jpg|All Files|*.*";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                //picAnh.Image = Image.FromFile(dlgOpen.FileName);

                Anh = dlgOpen.FileName.ToString().Split('\\');
                strImageFileName = Anh[Anh.Length - 1];
                txtAnh.Text = strImageFileName;

                System.IO.File.Copy(dlgOpen.FileName, path + @"\Images\KhachHang\" + strImageFileName);

            }
        }
    }
}
