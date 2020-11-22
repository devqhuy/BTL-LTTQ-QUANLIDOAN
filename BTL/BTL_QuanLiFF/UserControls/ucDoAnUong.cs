using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLiFF.forms;

namespace BTL_QuanLiFF.UserControls
{
    public partial class ucDoAnUong : UserControl
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.Common cm = new Classes.Common();
        public string Food_name = "";
        public string idKH = "";
        public string idNV = "";
        FormCTHoaDon frmCTHD ;
        

        public ucDoAnUong()
        {
            InitializeComponent();
        }

        private void ucDoAnUong_Load(object sender, EventArgs e)
        {
            txtDoAnUongMaMon.Enabled = false;
            cbDoAnUongTenMon.Enabled = true;
            txtDoAnUongDonGia.Enabled = false;
            txtDoAnUongMoTa.Enabled = false;
            txtKHMaHD.Enabled = false;
            cbDoAnUongMaKH.Enabled = true;
            lblTT2.Text = "";
            btnDoAnUongThem.Enabled = false;
            btnDoAnUongCTHD.Enabled = false;
            btnDoAnUongNhapLai.Enabled = false;

            this.LoadComboBox();
            this.LoadcmbKH();

            cbDoAnUongMaKH.Text = "";
            txtKHMaHD.Text = "";
            txtDoAnUongMaMon.Text = "";
            cbDoAnUongTenMon.Text = "";
            txtDoAnUongDonGia.Text = "0" ;
            NUM.Value = 0;
            txtDoAnUongMoTa.Text = "";
        }


        public void LoadComboBox()
        {
            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select tenSP from SANPHAM");
            try
            {
                cbDoAnUongTenMon.DataSource = dt;
                cbDoAnUongTenMon.DisplayMember = "tenSP";
                cbDoAnUongTenMon.ValueMember = "tenSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        public void LoadcmbKH()
        {
            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select *  from KHACHHANG" +
                " where status = 'HD'");
            try
            {
                cbDoAnUongMaKH.DataSource = dt;
                cbDoAnUongMaKH.DisplayMember = "idKH";
                cbDoAnUongMaKH.ValueMember = "idKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void cmbFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food_name = this.cbDoAnUongTenMon.GetItemText(this.cbDoAnUongTenMon.SelectedValue);
            //MessageBox.Show(Food_name);
            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select * from SANPHAM where tenSP = N'" +
                Food_name + "'");
            if (dt.Rows.Count > 0)
            {
                txtDoAnUongMaMon.Text = dt.Rows[0]["idSP"].ToString();
                txtDoAnUongDonGia.Text = dt.Rows[0]["giaTienSP"].ToString();
                txtDoAnUongMoTa.Text = dt.Rows[0]["moTaSP"].ToString();
                NUM.Value = 0;
                txtDoAnUongNote.Text = "";
            }
        }

        private void NUM_ValueChanged(object sender, EventArgs e)
        {
            int gia = Convert.ToInt32(txtDoAnUongDonGia.Text);
            int sl = Convert.ToInt32(NUM.Value);
            double gg = sales(txtDoAnUongMaMon.Text);
            if ( gg == 0)
            {
                lblTT2.Text = Convert.ToString(gia * sl);
            }
            else
            {
                lblTT2.Text = Convert.ToString(gia * sl * 1.0 * (1-gg) );

               
            }
            
        }
 
        private void btnTao_Click(object sender, EventArgs e)
        {
            string tableName = "HOADONBAN";
            string FildeName = "idHD";
            string startString = "HDB" + DateTime.Now.ToShortDateString();
            txtKHMaHD.Text = cm.AutoCode(tableName,FildeName, startString );

            btnDoAnUongCTHD.Enabled = false;
           
            cbDoAnUongMaKH.Enabled = true;
            btnDoAnUongThem.Enabled = true;
            btnDoAnUongNhapLai.Enabled = true; //xoa thong tin hoa don hien tai

            txtDoAnUongMaMon.Text = "";
            cbDoAnUongMaKH.Text = "";
            txtDoAnUongDonGia.Text = "0";
            NUM.Value = 0;
            txtDoAnUongMoTa.Text = "";
            cbDoAnUongTenMon.Text = "";
            txtDoAnUongNote.Text = "";
            
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            double gg = sales(txtDoAnUongMaMon.Text);
            if (gg != 0)
            {
                MessageBox.Show("Sản phẩm " + txtDoAnUongMaMon.Text + "được giảm giá " + gg * 100 + "%",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DataTable dt = new DataTable();
            bool status = this.check();
            if (cbDoAnUongMaKH.Text != "") cbDoAnUongMaKH.Enabled = false;
          
            if(status == true)
            {
                err2.Clear();
                dt = dtbase.DataReader("select idHD from HOADONBAN where idHD = '" + txtKHMaHD.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    try
                    {
                        dtbase.DataChange("insert into HOADONBAN (idHD, idNV, idKH , tongTien ) values ('" + txtKHMaHD.Text +
                        "','" + idNV + "','" + this.cbDoAnUongMaKH.GetItemText(this.cbDoAnUongMaKH.SelectedValue) 
                        + "',  0 )");
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    
                }

                try
                {
                    dtbase.DataChange("insert into CTHOADONBAN(idHD, idSP, soluong, giaTien, ngayTao," +
                        "yeuCau, KM)" +
                    "values('" + txtKHMaHD.Text + "','" + txtDoAnUongMaMon.Text + "'," + NUM.Value + "," +
                    Convert.ToInt32(lblTT2.Text) + ",'" + DateTime.Now.ToShortDateString() 
                    + "', N'" + txtDoAnUongNote.Text + "' , " + this.sales(txtDoAnUongMaMon.Text)/100 +
                    " )");


                    MessageBox.Show("Thêm hóa đơn thành công");
                    btnDoAnUongCTHD.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                

            }
        }

        public void getID(string IDNV)
        {
            this.idNV = IDNV;
        }

        private void btnCTHoaDon_Click(object sender, EventArgs e)
        {
            DataTable dt = dtbase.DataReader("select * FROM CTHOADONBAN WHERE idHD = '" +
                txtKHMaHD.Text + "'");

            if(dt.Rows.Count>0)
            {
                idKH = cbDoAnUongMaKH.Text;
                frmCTHD = new FormCTHoaDon(txtKHMaHD.Text, idKH );
                frmCTHD.ShowDialog();

            }
            else
            {
                MessageBox.Show("Không tồn tại hóa đơn bán", "Message", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
 
        }

        public bool check()
        {
            if (cbDoAnUongMaKH.Text.Trim() == "")
            {
                err2.SetError(cbDoAnUongMaKH, "Trường này là bắt buộc");
                return false;
            }

            if (txtKHMaHD.Text.Trim() == "")
            {
                err2.SetError(txtKHMaHD, "Trường này là bắt buộc");
                return false;
            }

            if ( txtDoAnUongMaMon.Text.Trim() == "" )
            {
                err2.SetError(txtDoAnUongMaMon, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                btnDoAnUongThem.Enabled = true;
            }

            if ( NUM.Value == 0)
            {
                err2.SetError(NUM, "Số lượng không thể là 0");
                return false;
            }

            if (cbDoAnUongTenMon.Text.Trim() == "")
            {
                err2.SetError(cbDoAnUongTenMon, "Số lượng không thể là 0");
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDoAnUongMaMon.Text = "";
            cbDoAnUongTenMon.Text = "";
            txtDoAnUongDonGia.Text = "0";
            NUM.Value = 0;
            txtDoAnUongMoTa.Text = "";
        }

        public double sales(string masp)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dtbase.DataReader("select * from KHUYENMAI where idSP = '" + masp + "'");
            }catch (Exception Ex)
            {
                Ex.ToString();
            }
           
            if (dt.Rows.Count >0)
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
    }
}
