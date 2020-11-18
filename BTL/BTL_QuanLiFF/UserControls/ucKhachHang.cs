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
using System.IO;

namespace BTL_QuanLiFF.UserControls
{
    public partial class ucKhachHang : UserControl
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.Common cm = new Classes.Common();
        private string makh = "";
        public string path = System.IO.Directory.GetCurrentDirectory().ToString();
        public string path2 = "";
        string strImageFileName;
        String img = "";
        string os = "open";

        public ucKhachHang()
        {
            InitializeComponent();
        }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            this.LoadKH();

            txtKHNgaySinh.Enabled = false;
            txtKHHoTen.Enabled = false;
            txtKHSoDT.Enabled = false;
            txtKHDiaChi.Enabled = false;

            btnKHLuu.Enabled = false;
            btnKHSua.Enabled = false;
            btnKHHuy.Enabled = false;
            btnKHXoa.Enabled = false;
            picAnh.Enabled = false;

            cbKHMaKhachHang.Text = "";
            txtKHHoTen.Text = "";
            txtKHDiaChi.Text = "";
            txtKHSoDT.Text = "";
            txtKHNgaySinh.Text = "";
            picAnh.Image = null;

        }

        public void LoadKH()
        {

            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select *  from KHACHHANG" +
                " where status = 'HD'");
            try
            {
                cbKHMaKhachHang.DataSource = dt;
                cbKHMaKhachHang.DisplayMember = "idKH";
                cbKHMaKhachHang.ValueMember = "idKH";

            }
            catch (Exception ex)
            {
               MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            makh = this.cbKHMaKhachHang.GetItemText(this.cbKHMaKhachHang.SelectedValue);
            os = "open";

            txtKHNgaySinh.Enabled = true;
            txtKHHoTen.Enabled = true;
            txtKHSoDT.Enabled = true;
            txtKHDiaChi.Enabled = true;
            picAnh.Enabled = true;

            btnKHSua.Enabled = true;
            btnKHXoa.Enabled = true;
            btnKHHuy.Enabled = true;

            DataTable dt = dtbase.DataReader("select * from KHACHHANG where idKH = '" +
                makh + "'");
            if(dt.Rows.Count >0)
            {
                txtKHHoTen.Text = dt.Rows[0]["hotenKH"].ToString();
                txtKHDiaChi.Text = dt.Rows[0]["diaChi"].ToString();
                txtKHSoDT.Text = dt.Rows[0]["soDT"].ToString();
                txtKHNgaySinh.Text = Convert.ToDateTime(dt.Rows[0]["ngaySinh"]).ToShortDateString();
                
                img = dt.Rows[0]["Image"].ToString();
                
                try
                {
                    picAnh.Image = Image.FromFile(path +
                "\\Images\\KhachHang\\" + img);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Loi ANH");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            

            btnKHLuu.Enabled = true;
            btnKHSua.Enabled = false;
            btnKHXoa.Enabled = false;
            btnKHHuy.Enabled = true;

            string KHACHHANG = "KHACHHANG";
            string idKH = "idKH";
            idKH = cm.AutoCode(KHACHHANG, idKH, "KH0");
            cbKHMaKhachHang.Text = idKH;

            txtKHNgaySinh.Enabled = true;
            txtKHHoTen.Enabled = true;
            txtKHSoDT.Enabled = true;
            txtKHDiaChi.Enabled = true;
            picAnh.Enabled = true;

            txtKHHoTen.Text = "";
            txtKHDiaChi.Text = "";
            txtKHSoDT.Text = "";
            txtKHNgaySinh.Text = "";
            picAnh.Image = null;

            os = "open";
        }

        public bool check()
        {
            if (txtKHHoTen.Text.Trim() == "")
            {
                err3.SetError(txtKHHoTen, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                err3.Clear();
            }
            
            if (txtKHDiaChi.Text.Trim() == "")
            {
                err3.SetError(txtKHDiaChi, "Trường này là bắt buộc");
                return false;

            }
            else
            {
                err3.Clear();
            }

            if (txtKHSoDT.Text.Trim() == "")
            {
                err3.SetError(txtKHSoDT, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                if (Regex.IsMatch(txtKHSoDT.Text, @"\d") != true ||
                        txtKHSoDT.Text.Length > 10)
                {
                    err3.SetError(txtKHSoDT, "Số điện thoại chỉ bao gồm số và không vượt quá 10");
                    return false;
                }
                else
                {
                    err3.Clear();
                }
                err3.Clear();
            }
            if (txtKHNgaySinh.Text.Trim() == "")
            {
                err3.SetError(txtKHNgaySinh, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDateTime(txtKHNgaySinh.Text);
                    err3.Clear();
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                return true;
            }
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (check())
            {
                try
                {
                    dtbase.DataChange("INSERT INTO KHACHHANG VALUES('" +
                        cbKHMaKhachHang.Text + "',N'" +
                        txtKHHoTen.Text + "','" +
                        txtKHDiaChi.Text + "','" +
                        txtKHSoDT.Text + "','" +
                        txtKHNgaySinh.Text + "','" +
                        "HD','" + strImageFileName + "')");
                  
                    MessageBox.Show("Thêm khách hàng thành công", " Thông báo ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LoadKH();
                    cbKHMaKhachHang.Text = "";
                    txtKHHoTen.Text = "";
                    txtKHDiaChi.Text = "";
                    txtKHSoDT.Text = "";
                    txtKHNgaySinh.Text = "";
                    picAnh.Image = null;


                }
                catch( Exception ex)
                {
                    System.IO.File.Delete(path + @"\Images\KhachHang\" + strImageFileName);
                    MessageBox.Show(ex.Message);
                }
            }

            os = "open";
        }

        private void picAnh_Click(object sender, EventArgs e)
        { 
            if(os == "open")
            {
                string[] Anh;
                OpenFileDialog dlgOpen = new OpenFileDialog();
                dlgOpen.Title = "Hiển thị ảnh người dùng";
                dlgOpen.Filter = "JPEG Images|*.jpg|All Files|*.*";
                
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    picAnh.Image = Image.FromFile(dlgOpen.FileName);
                    
                    Anh = dlgOpen.FileName.ToString().Split('\\');
                    strImageFileName = Anh[Anh.Length - 1];
                   
                    System.IO.File.Copy(dlgOpen.FileName, path + @"\Images\KhachHang\" + strImageFileName);
                    
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(check() )
            {
                try
                {
                    dtbase.DataChange("update KHACHHANG " +
                        "set hotenKH = N'" + txtKHHoTen.Text +
                        "', diaChi = N'" + txtKHDiaChi.Text + "', soDT = '" + txtKHSoDT.Text + "'," +
                        "ngaysinh = '" + txtKHNgaySinh.Text + "',status = 'HD' ," + " image = '" + strImageFileName + "'" +
                        "where idKH = '" + cbKHMaKhachHang.Text + "'");

                    btnKHSua.Enabled = false;
                    btnKHXoa.Enabled = false;
                    MessageBox.Show("Sửa khách hàng thành công", " Thông báo ",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cbKHMaKhachHang.Text = "";
                    txtKHHoTen.Text = "";
                    txtKHDiaChi.Text = "";
                    txtKHSoDT.Text = "";
                    txtKHNgaySinh.Text = "";
                    picAnh.Image = null;

                    btnKHSua.Enabled = false;
                    btnKHXoa.Enabled = false;
                    btnKHHuy.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbKHMaKhachHang.Enabled = true;

            cbKHMaKhachHang.Text = "";
            txtKHHoTen.Text = "";
            txtKHDiaChi.Text = "";
            txtKHSoDT.Text = "";
            txtKHNgaySinh.Text = "";
            picAnh.Image = null;

            btnKHLuu.Enabled = false;
            btnKHSua.Enabled = false;
            btnKHHuy.Enabled = false;
            btnKHXoa.Enabled = false;


            txtKHNgaySinh.Enabled = false;
            txtKHHoTen.Enabled = false;
            txtKHSoDT.Enabled = false;
            txtKHDiaChi.Enabled = false;
            picAnh.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa người dùng này không???", "Thông báo", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dtbase.DataChange("delete KHACHHANG where idKH = '" + cbKHMaKhachHang.Text + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                cbKHMaKhachHang.Text = "";
                txtKHHoTen.Text = "";
                txtKHDiaChi.Text = "";
                txtKHSoDT.Text = "";
                txtKHNgaySinh.Text = "";
                picAnh.Image = null;

                btnKHLuu.Enabled = false;
                btnKHSua.Enabled = false;
                btnKHHuy.Enabled = false;
                btnKHXoa.Enabled = false;

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = dtbase.DataReader("select * from KHACHHANG where hoTenKH like N'%" + txtKHTimKiem.Text
                +"%'");

            if(dt.Rows.Count >0)
            {
                cbKHMaKhachHang.DataSource = dt;
            }
            else
            {
                cbKHMaKhachHang.DataSource = dtbase.DataReader("select * from KHACHHANG");
            }
        }

    }
}
