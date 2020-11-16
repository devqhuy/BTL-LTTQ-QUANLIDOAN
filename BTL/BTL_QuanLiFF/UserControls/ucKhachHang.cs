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

            txtDoB.Enabled = false;
            txtHT.Enabled = false;
            txtSDT.Enabled = false;
            txtDC.Enabled = false;

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
            picAnh.Enabled = false;

            cmbKH.Text = "";
            txtHT.Text = "";
            txtDC.Text = "";
            txtSDT.Text = "";
            txtDoB.Text = "";
            picAnh.Image = null;

        }

        public void LoadKH()
        {

            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select *  from KHACHHANG" +
                " where status = 'HD'");
            try
            {
                cmbKH.DataSource = dt;
                cmbKH.DisplayMember = "idKH";
                cmbKH.ValueMember = "idKH";

            }
            catch (Exception ex)
            {
               MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            makh = this.cmbKH.GetItemText(this.cmbKH.SelectedValue);
            os = "open";

            txtDoB.Enabled = true;
            txtHT.Enabled = true;
            txtSDT.Enabled = true;
            txtDC.Enabled = true;
            picAnh.Enabled = true;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;

            DataTable dt = dtbase.DataReader("select * from KHACHHANG where idKH = '" +
                makh + "'");
            if(dt.Rows.Count >0)
            {
                txtHT.Text = dt.Rows[0]["hotenKH"].ToString();
                txtDC.Text = dt.Rows[0]["diaChi"].ToString();
                txtSDT.Text = dt.Rows[0]["soDT"].ToString();
                txtDoB.Text = Convert.ToDateTime(dt.Rows[0]["ngaySinh"]).ToShortDateString();
                
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
            

            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

            string KHACHHANG = "KHACHHANG";
            string idKH = "idKH";
            idKH = cm.AutoCode(KHACHHANG, idKH, "KH0");
            cmbKH.Text = idKH;

            txtDoB.Enabled = true;
            txtHT.Enabled = true;
            txtSDT.Enabled = true;
            txtDC.Enabled = true;
            picAnh.Enabled = true;

            txtHT.Text = "";
            txtDC.Text = "";
            txtSDT.Text = "";
            txtDoB.Text = "";
            picAnh.Image = null;

            os = "open";
        }

        public bool check()
        {
            if (txtHT.Text.Trim() == "")
            {
                err3.SetError(txtHT, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                err3.Clear();
            }
            
            if (txtDC.Text.Trim() == "")
            {
                err3.SetError(txtDC, "Trường này là bắt buộc");
                return false;

            }
            else
            {
                err3.Clear();
            }

            if (txtSDT.Text.Trim() == "")
            {
                err3.SetError(txtSDT, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                if (Regex.IsMatch(txtSDT.Text, @"\d") != true ||
                        txtSDT.Text.Length > 10)
                {
                    err3.SetError(txtSDT, "Số điện thoại chỉ bao gồm số và không vượt quá 10");
                    return false;
                }
                else
                {
                    err3.Clear();
                }
                err3.Clear();
            }
            if (txtDoB.Text.Trim() == "")
            {
                err3.SetError(txtDoB, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDateTime(txtDoB.Text);
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
                        cmbKH.Text + "',N'" +
                        txtHT.Text + "','" +
                        txtDC.Text + "','" +
                        txtSDT.Text + "','" +
                        txtDoB.Text + "','" +
                        "HD','" + strImageFileName + "')");
                  
                    MessageBox.Show("Thêm khách hàng thành công", " Thông báo ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LoadKH();
                    cmbKH.Text = "";
                    txtHT.Text = "";
                    txtDC.Text = "";
                    txtSDT.Text = "";
                    txtDoB.Text = "";
                    picAnh.Image = null;


                }
                catch( Exception ex)
                {
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
                        "set hotenKH = N'" + txtHT.Text +
                        "', diaChi = N'" + txtDC.Text + "', soDT = '" + txtSDT.Text + "'," +
                        "ngaysinh = '" + txtDoB.Text + "',status = 'HD' ," + " image = '" + strImageFileName + "'" +
                        "where idKH = '" + cmbKH.Text + "'");

                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    MessageBox.Show("Sửa khách hàng thành công", " Thông báo ",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmbKH.Text = "";
                    txtHT.Text = "";
                    txtDC.Text = "";
                    txtSDT.Text = "";
                    txtDoB.Text = "";
                    picAnh.Image = null;

                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cmbKH.Enabled = true;

            cmbKH.Text = "";
            txtHT.Text = "";
            txtDC.Text = "";
            txtSDT.Text = "";
            txtDoB.Text = "";
            picAnh.Image = null;

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;


            txtDoB.Enabled = false;
            txtHT.Enabled = false;
            txtSDT.Enabled = false;
            txtDC.Enabled = false;
            picAnh.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dtbase.DataChange("delete KHACHHANG where idKH = '" + cmbKH.Text + "'");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            cmbKH.Text = "";
            txtHT.Text = "";
            txtDC.Text = "";
            txtSDT.Text = "";
            txtDoB.Text = "";
            picAnh.Image = null;

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = dtbase.DataReader("select * from KHACHHANG where hoTenKH like N'%" + txtSearch.Text
                +"%'");

            if(dt.Rows.Count >0)
            {
                cmbKH.DataSource = dt;
            }
            else
            {
                cmbKH.DataSource = dtbase.DataReader("select * from KHACHHANG");
            }
        }

    }
}
