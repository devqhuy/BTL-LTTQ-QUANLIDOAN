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
        String idKM = "";

        public ucQuanLi()
        {
            InitializeComponent();
        }

        private void ucQuanLi_Load(object sender, EventArgs e)
        {
            if (1==1)
            {
                dtgvQLNVDSNhanVien.DataSource = dtbase.DataReader("select * from NHANVIEN");

                dtgvQLNVDSNhanVien.Columns[0].Width = 100;
                dtgvQLNVDSNhanVien.Columns[1].Width = 200;


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
                btnHuy.Enabled = false;

                this.customDgv1();

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
           
            txtDoB.Text = "";
            txtAnh.Text = "";

            cmb.Enabled = false;
            txtQLNVHoTen.Enabled = true;
            txtDoB.Enabled = true;
            txtQLNVSoDT.Enabled = true;
            txtQLNVChucVu.Enabled = true;
            rdbNam.Checked = true;
            btnLuu1.Enabled = true;

            string idnv= cm.AutoCode("NHANVIEN", "idNV", "NV0");
            cmb.Text = idnv;

            btnQLNVSua.Enabled = false;
            btnQLNVXoa.Enabled = false;
            btnHuy.Enabled = true;

            if (rdbNam.Checked == true) gt = "Nam";
            else gt = "Nữ";

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
                if(txtQLNVChucVu.Text.Trim() != "Thu ngân" && 
                        txtQLNVChucVu.Text.Trim() != "Quản lý" &&
                        txtQLNVChucVu.Text.Trim() != "Admin")
                {
                    err4.SetError(txtQLNVChucVu, "Chức vụ hiện có thu ngân và quản lý");
                    return false;
                }
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


        private void btnLuu1_Click(object sender, EventArgs e)
        {
            if (check1()== true && btnQLNVThem.Enabled == true)
            {

                try
                {
                    dtbase.DataChange("insert into nhanvien values('" + cmb.Text +
                   "',  N'" + txtQLNVHoTen.Text + "', '" + txtDoB.Text +
                   "', N'" + txtAnh.Text + "', '" + txtQLNVSoDT.Text +
                   "', N'" + txtQLNVChucVu.Text + "', N'" + gt +
                   "')");

                    MessageBox.Show("Thêm nhân viên thành công", " Thông báo ",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    System.IO.File.Delete(path + @"\Images\KhachHang\" + txtAnh.Text);
                    MessageBox.Show(Ex.Message, "Lỗi");
                    
                }

            }
            if (check1() && btnQLNVSua.Enabled == true)
            {
                try
                {
                    dtbase.DataChange("update NHANVIEN set hoTenNV = N'" +
                        txtQLNVHoTen.Text + "' , ngaySinh = '" +
                        txtDoB.Text + "', soDT = ' " +
                        txtQLNVSoDT.Text + "', chucVu = N'" +
                        txtQLNVChucVu.Text + "', sex = N'" +
                        gt + " ' " + 
                        "where idNV = '" + cmb.Text + "'");

                    MessageBox.Show("Sửa thông tin nhân viên thành công", " Thông báo ",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Lỗi");
                }
            }
            dtgvQLNVDSNhanVien.DataSource = dtbase.DataReader("select * from nhanvien");
            this.customDgv1();

            cmb.DataSource = dtbase.DataReader("select idNV from NHANVIEN");
            cmb.DisplayMember = "idNV";
            cmb.ValueMember = "idNV";

            cmb.Enabled = true;
            txtQLNVHoTen.Enabled = false;
            txtDoB.Enabled = false;
            txtQLNVSoDT.Enabled = false;
            txtQLNVChucVu.Enabled = false;
            rdbNam.Checked = true;
            btnLuu1.Enabled = false;
            txtAnh.Enabled = false;
            btnHuy.Enabled = false;

            txtQLNVHoTen.Text = "";
            txtQLNVSoDT.Text = "";
            txtQLNVChucVu.Text = "";
            
            txtDoB.Text = "";
            txtAnh.Text = "";
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

        private void dtgvQLNVDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            btnQLNVSua.Enabled = true;
            btnQLNVXoa.Enabled = true;
            btnLuu1.Enabled = false;
            btnHuy.Enabled = false;
            btnQLNVThem.Enabled = true;

            cmb.Text = dtgvQLNVDSNhanVien.CurrentRow.Cells[0].Value.ToString();
        }

        public void customDgv1()
        {
            dtgvQLNVDSNhanVien.Columns["sex"].HeaderText = "Giới tính";
        }

        public void customDgv2()
        {

        }

        private void btnQLNVSua_Click(object sender, EventArgs e)
        {
            cmb.Enabled = false;
            txtQLNVHoTen.Enabled = true;
            txtDoB.Enabled = true;
            txtQLNVSoDT.Enabled = true;
            txtQLNVChucVu.Enabled = true;

            btnLuu1.Enabled = true;
            btnHuy.Enabled = true;
            btnQLNVThem.Enabled = false;
            btnQLNVXoa.Enabled = false;

            if (rdbNam.Checked == true) gt = "Nam";
            else gt = "Nữ";

        }

        private void btnQLNVXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa nhân viên này không?", " Thông báo ",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                { return; }
            try
            {
                dtbase.DataChange("delete NHANVIEN where idNV = '" + cmb.Text + "'");
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Lỗi");
            }
            dtgvQLNVDSNhanVien.DataSource = dtbase.DataReader("select * from nhanvien");
            this.customDgv1();

            cmb.DataSource = dtbase.DataReader("select idNV from NHANVIEN");
            cmb.DisplayMember = "idNV";
            cmb.ValueMember = "idNV";

            cmb.Enabled = true;
            txtQLNVHoTen.Enabled = false;
            txtDoB.Enabled = false;
            txtQLNVSoDT.Enabled = false;
            txtQLNVChucVu.Enabled = false;
            rdbNam.Checked = true;
            btnLuu1.Enabled = false;
            txtAnh.Enabled = false;
            btnHuy.Enabled = false;

            txtQLNVHoTen.Text = "";
            txtQLNVSoDT.Text = "";
            txtQLNVChucVu.Text = "";
            
            txtDoB.Text = "";
            txtAnh.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thao tác cuối bạn thực hiện không được lưu", " Thông báo ",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmb.DataSource = dtbase.DataReader("Select * from NhanVien");
            this.customDgv1();

            txtQLNVHoTen.Enabled = false;
            txtDoB.Enabled = false;
            txtQLNVSoDT.Enabled = false;
            txtQLNVChucVu.Enabled = false;
            txtAnh.Enabled = false;

            btnQLNVThem.Enabled = true;
            btnQLNVSua.Enabled = false;
            btnQLNVXoa.Enabled = false;
            btnLuu1.Enabled = false;

            cmb.Enabled = true;
            txtQLNVHoTen.Text = "";
            txtQLNVSoDT.Text = "";
            txtQLNVChucVu.Text = "";
           
            txtDoB.Text = "";
            txtAnh.Text = "";
        }

        private void tabNhanVien_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tpQLNV)
            {
                dtgvQLNVDSNhanVien.DataSource = dtbase.DataReader("select * from NHANVIEN");

                dtgvQLNVDSNhanVien.Columns[0].Width = 100;
                dtgvQLNVDSNhanVien.Columns[1].Width = 200;

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
                btnHuy.Enabled = false;

                this.customDgv1();
            }

            if(e.TabPage == tpKM)
            {
                this.Load2();
            }
        }

        public void Load2()
        {
            try
            {
                dgv2.DataSource = dtbase.DataReader("select * from KHUYENMAI");

                cmbSP2.DataSource = dtbase.DataReader("select idSP from SANPHAM");
                cmbSP2.DisplayMember = "idSP";
                cmbSP2.ValueMember = "idSP";

                cmbSP2.Enabled = false;
                txtGG.Enabled = false;
                dtpFrom2.Enabled = false;
                dtpTo2.Enabled = false;

                btnLuu2.Enabled = false;
                btnSua2.Enabled = false;
                btnHuy2.Enabled = false;

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            

            this.customDgv2();
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            idKM = cm.AutoCode("KHUYENMAI", "idKM", "KM0");
            
            cmbSP2.Enabled = true;
            txtGG.Enabled = true;
            dtpFrom2.Enabled = true;
            dtpTo2.Enabled = true;

            btnLuu2.Enabled = true;
            btnSua2.Enabled = false;
            btnHuy2.Enabled = true;
            btnThem2.Enabled = true;
        }

        public bool check2()
        {
            if (txtGG.Text.Trim() == "")
            {
                err4.SetError(txtGG, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                try
                {
                    int gg2 = Convert.ToInt32(txtGG.Text);
                    err4.Clear();
                    

                    if(gg2 < 0 || gg2 > 100)
                    {
                        err4.SetError(txtGG, "Giam gia tu 0 - 100 %");
                        return false;
                    }
                    return true;

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Loi");
                    return false;
                }
            }
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {

            if (check2() == true && btnThem2.Enabled == true)
            {
               
                try
                {
                    int gg2 = Convert.ToInt32(txtGG.Text);

                    dtbase.DataChange("insert into KHUYENMAI values('" + idKM + "','" + cmbSP2.Text + "','" +
                        dtpFrom2.Text + "','" + dtpTo2.Text + "', " + gg2 + ")");

                    MessageBox.Show("Thêm khuyến mại thành công", " Thông báo ",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Load2();

                    idKM = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnHuy2_Click(object sender, EventArgs e)
        {
            this.Load2();
            idKM = "";
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbSP2.Enabled = true;
            txtGG.Enabled = true;
            dtpFrom2.Enabled = true;
            dtpTo2.Enabled = true;

            try
            {
                idKM = dgv2.CurrentRow.Cells[0].Value.ToString();
                cmbSP2.Text = dgv2.CurrentRow.Cells[1].Value.ToString();
                txtGG.Text = dgv2.CurrentRow.Cells[4].Value.ToString();
                dtpFrom2.Text = dgv2.CurrentRow.Cells[2].Value.ToString();
                dtpTo2.Text = dgv2.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            btnLuu1.Enabled = true;
            btnSua2.Enabled = true;
            btnThem2.Enabled = true;
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            try
            {
                string fr2 = dtpFrom2.Value.ToShortDateString();
                string t2 = dtpTo2.Value.ToShortDateString();

                MessageBox.Show(" fr: " + fr2 + " to: " + t2);

                dtbase.DataChange("update KHUYENMAI set idSP = '" + cmbSP2.Text + "', ngayBatDau = '" + 
                    (fr2) + "', ngayKetThuc = '" +
                    (t2) + "',  giamGia = " + Convert.ToInt32(txtGG.Text) + 
                    " where idKM = '" + idKM + "'");

                MessageBox.Show("Sửa khuyến mại thành công", " Thông báo ",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Load2();

                idKM = "";
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Lỗi");
            }
        }
    }
}
