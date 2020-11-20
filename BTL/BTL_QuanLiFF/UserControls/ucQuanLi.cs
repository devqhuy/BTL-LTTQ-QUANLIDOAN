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
        string idCT = "";
        string dv = "";
        string nv3 = "";
        int dg3 = 0;
        DateTime date3 ;

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

            if(e.TabPage == QLHDN)
            {
                this.Load3();
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
            MessageBox.Show("Thao tác cuối bạn thực hiện không được lưu", " Thông báo ",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Load2();
           
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
        public void Load3()
        {
            dgv3.DataSource = dtbase.DataReader("SELECT CTHOADONNHAP.idCT , NHACUNGCAP.IDNCC , " +
                "NGUYENLIEU.tenNL, " +
                "CTNGUYENLIEU.soLuong , CTNGUYENLIEU.DONGIA , CTNGUYENLIEU.donVi , " +
                "CTHOADONNHAP.ngayTaoHD ,CTHOADONNHAP.TONGTIEN " +
                "FROM CTHOADONNHAP " +
                "INNER JOIN CTNGUYENLIEU ON CTNGUYENLIEU.idCT = CTHOADONNHAP.idCT " +
                "INNER JOIN NHACUNGCAP ON NHACUNGCAP.idNCC = CTHOADONNHAP.idNCC " +
                "INNER JOIN NGUYENLIEU ON NGUYENLIEU.idNL = CTNGUYENLIEU.idNL " +
                "INNER JOIN NHANVIEN ON NHANVIEN.idNV = CTHOADONNHAP.idNV");

            cmbCC.DataSource = dtbase.DataReader("select idNCC from NHACUNGCAP ");
            cmbCC.DisplayMember = "idNCC";
            cmbCC.ValueMember = "idNCC";

            cmbNL.DataSource = dtbase.DataReader("select idNL from nguyenlieu ");
            cmbNL.DisplayMember = "idNL";
            cmbNL.ValueMember = "idNL";

            cmbCC.Enabled = false;
            cmbNL.Enabled = false;
            txtNL.Enabled = false;
            NUM3.Enabled = false;
            txtDG.Enabled = false;
            txtTT3.Enabled = false;

            btnThem3.Enabled = true;
            btnLuu3.Enabled = false;
            //btnXoa3.Enabled = false;
            btnSua3.Enabled = false;
            btnHuy.Enabled = false;

            this.edit3();
        }

        public void  edit3()
        {
            dgv3.Columns["TONGTIEN"].HeaderText = "Tổng tiền";
        }

        public void LoadNL3(string mnl)
        {
            DataTable dt = dtbase.DataReader("select * from nguyenlieu where idNL = '" + mnl + "'");

            if(dt.Rows.Count >0)
            {
                txtNL.Text = dt.Rows[0]["TenNL"].ToString();

            }

        }

        private void dgv3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem3.Enabled = true;
            btnLuu3.Enabled = true;
            //btnXoa3.Enabled = false;
            btnSua3.Enabled = true;
            btnHuy.Enabled = true;

            try
            {
                idCT = dgv3.CurrentRow.Cells[0].Value.ToString();
                cmbCC.Text = dgv3.CurrentRow.Cells[1].Value.ToString();
                txtNL.Text = dgv3.CurrentRow.Cells[2].Value.ToString();
                NUM3.Value = Convert.ToInt32(dgv3.CurrentRow.Cells[3].Value.ToString());
                txtDG.Text = dgv3.CurrentRow.Cells[4].Value.ToString();
                dv = dgv3.CurrentRow.Cells[5].Value.ToString();
                date3 = Convert.ToDateTime(dgv3.CurrentRow.Cells[6].Value.ToString());
                txtTT3.Text = dgv3.CurrentRow.Cells[7].Value.ToString();

                DataTable dt = dtbase.DataReader("select * from nguyenlieu where tenNL = N'" + txtNL.Text + "'");
            }catch ( Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Lỗi");
            }
        }
        private void btnHuy3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thao tác cuối bạn thực hiện không được lưu", " Thông báo ",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Load3();
        }

        private void btnLuu3_Click(object sender, EventArgs e)
        {
            if(check3()== true && btnThem3.Enabled == true)
            {
                try
                {
                    dtbase.DataChange("insert into ctnguyenlieu " +
                        "values('" + idCT + "', '" + cmbNL.Text +
                        "' , " + NUM3.Value +
                        ",   N'Sử dụng' , " +
                        "'Túi' , " + txtDG.Text + " , N'Không có ghi chú') ");

                    string dateeeee = DateTime.Now.ToShortDateString();
                    dtbase.DataChange("insert into cthoadonnhap values ('" + idCT + "','" +
                        nv3 + "','" + cmbCC.Text + "','" + dateeeee + "'," + txtTT3.Text + ")");

                    MessageBox.Show("Thêm hóa đơn nhập thành công", " Thông báo ",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception Ex)
                {
                    dtbase.DataChange("delete ctnguyenlieu where idCT = '" + idCT + "'");
                    dtbase.DataChange("delete cthoadonnhap where idCT = '" + idCT + "'");
                    MessageBox.Show(Ex.Message, "Lỗi");
                    return;
                }
            }
            if(check3() == true && btnSua3.Enabled ==true)
            {
                try
                {
                    string dateeeee = DateTime.Now.ToShortDateString();
                    dtbase.DataChange("update ctnguyenlieu set idNL = '" + txtNL.Text + "', soLuong = " +
                        Convert.ToInt32(NUM3.Value) + " ', N'Túi' , " +
                        txtDG.Text + "', N'Không có ghi chú' where idCT = '" + idCT + "'");

                    dtbase.DataChange("update cthoadonnhap set idNV ='" + nv3 + "' , idNCC = '" +
                        cmbCC.Text + "' , ngayTaoHD = '" + dateeeee + "', TONGTIEN = '" + txtTT3.Text + "'" +
                        " where idCT = '" + idCT + "'");

                    MessageBox.Show("Sửa hóa đơn nhập thành công", " Thông báo ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Lỗi");
                   
                    return;
                }
            }
            this.Load3();
        }

        public bool check3()
        {
            if (cmbCC.Text.Trim() == "")
            {
                err4.SetError(cmbCC, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                err4.Clear();
            }
            if (cmbNL.Text.Trim() == "")
            {
                err4.SetError(cmbNL, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                err4.Clear();
            }
            if(NUM3.Value <= 0 )
            {
                err4.SetError(NUM3, "Giá trị không hợp lệ");
                return false;
            }
            else
            {
                err4.Clear();
            }

            if(txtDG.Text.Trim() == "" )
            {
                err4.SetError(txtDG, "Trường này là bắt buộc");
                
            }
            else
            {
                err4.Clear();
                try
                {
                    dg3 = Convert.ToInt32(txtDG.Text);
                    if (dg3 < 0)
                    {
                        err4.SetError(txtDG, "Đơn giá phải lớn hơn 0 ");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Lỗi");
                    return false;
                }
            }
            return true;
        }

        private void btnThem3_Click(object sender, EventArgs e)
        {
            idCT = cm.AutoCode("cthoadonnhap", "idCT", "CT0");

            cmbCC.Enabled = true;
            cmbNL.Enabled = true;
            txtNL.Enabled = false;
            NUM3.Enabled = true;
            txtDG.Enabled = true;
            txtTT3.Enabled = false;

            btnThem3.Enabled = true;
            btnLuu3.Enabled = true;
            //btnXoa3.Enabled = false;
            btnSua3.Enabled = false;
            btnHuy3.Enabled = true;
        }

        public void getNV(string manv)
        {
            nv3 =  manv;
        }

        private void NUM3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dg3 = Convert.ToInt32(txtDG.Text);
                int sl3 = Convert.ToInt32(NUM3.Value);

                txtTT3.Text = Convert.ToString(dg3 * sl3);

            }catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Lỗi");
            }
        }

        private void btnSua3_Click(object sender, EventArgs e)
        {
            cmbCC.Enabled = true;
            cmbNL.Enabled = true;
            txtNL.Enabled = false;
            NUM3.Enabled = true;
            txtDG.Enabled = true;
            txtTT3.Enabled = false;

            btnThem3.Enabled = true;
            btnLuu3.Enabled = false;
            //btnXoa3.Enabled = false;
            btnSua3.Enabled = false;
            btnHuy.Enabled = false;

            idCT = dgv3.CurrentRow.Cells[0].Value.ToString();
        }

        private void cmbNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadNL3(cmbNL.Text);
        }

        private void btnHuy3_Click_1(object sender, EventArgs e)
        {
            this.Load3();
        }
    }
}
