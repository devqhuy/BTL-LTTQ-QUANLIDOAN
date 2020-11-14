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
            txtIDFood.Enabled = false;
            cmbFoodName.Enabled = true;
            txtDonGia.Enabled = false;
            txtMoTa.Enabled = false;
            txtHD.Enabled = false;
            cmbKH.Enabled = true;
            lblTT2.Text = "";
            btnADD.Enabled = false;
            btnCTHoaDon.Enabled = false;
            btnXoa.Enabled = false;

            this.LoadComboBox();
            this.LoadcmbKH();

            cmbKH.Text = "";
            txtHD.Text = "";
            txtIDFood.Text = "";
            cmbFoodName.Text = "";
            txtDonGia.Text = "0" ;
            NUM.Value = 0;
            txtMoTa.Text = "";
        }


        public void LoadComboBox()
        {
            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select tenSP from SANPHAM");
            try
            {
                cmbFoodName.DataSource = dt;
                cmbFoodName.DisplayMember = "tenSP";
                cmbFoodName.ValueMember = "tenSP";
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
                cmbKH.DataSource = dt;
                cmbKH.DisplayMember = "idKH";
                cmbKH.ValueMember = "idKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void cmbFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food_name = this.cmbFoodName.GetItemText(this.cmbFoodName.SelectedValue);
            //MessageBox.Show(Food_name);
            DataTable dt = new DataTable();
            dt = dtbase.DataReader("select * from SANPHAM where tenSP = N'" +
                Food_name + "'");
            if (dt.Rows.Count > 0)
            {
                txtIDFood.Text = dt.Rows[0]["idSP"].ToString();
                txtDonGia.Text = dt.Rows[0]["giaTienSP"].ToString();
                txtMoTa.Text = dt.Rows[0]["moTaSP"].ToString();
                NUM.Value = 0;
                txtNOTE.Text = "";
            }
        }

        private void NUM_ValueChanged(object sender, EventArgs e)
        {
            int gia = Convert.ToInt32(txtDonGia.Text);
            int sl = Convert.ToInt32(NUM.Value);

            if(sales() == 0)
            {
                lblTT2.Text = Convert.ToString(gia * sl);
            }
            else
            {
                lblTT2.Text = Convert.ToString(gia * sl * 1.0 * sales() / 100);
            }
            
        }
 
        private void btnTao_Click(object sender, EventArgs e)
        {
            string tableName = "HOADONBAN";
            string FildeName = "idHD";
            string startString = "HDB" + DateTime.Now.ToShortDateString();
            txtHD.Text = cm.AutoCode(tableName,FildeName, startString );

            btnCTHoaDon.Enabled = false;
           
            cmbKH.Enabled = true;
            btnADD.Enabled = true;
            btnXoa.Enabled = true; //xoa thong tin hoa don hien tai

            txtIDFood.Text = "";
            cmbKH.Text = "";
            txtDonGia.Text = "0";
            NUM.Value = 0;
            txtMoTa.Text = "";
            cmbFoodName.Text = "";
            txtNOTE.Text = "";
            
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            bool status = this.check();
            if (cmbKH.Text != "") cmbKH.Enabled = false;
          
            if(status == true)
            {
                err2.Clear();
                dt = dtbase.DataReader("select idHD from HOADONBAN where idHD = '" + txtHD.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    try
                    {
                        dtbase.DataChange("insert into HOADONBAN values ('" + txtHD.Text +
                        "','" + idNV + "','" + this.cmbKH.GetItemText(this.cmbKH.SelectedValue) 
                        + "'," + 1 + ")");
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    
                }

                try
                {
                    dtbase.DataChange("insert into CTHOADONBAN(idHD, idSP, soluong, giaTien, ngayTao," +
                        "yeuCau)" +
                    "values('" + txtHD.Text + "','" + txtIDFood.Text + "'," + NUM.Value + "," +
                    Convert.ToInt32(lblTT2.Text) + ",'" + DateTime.Now.ToShortDateString() 
                    + "', N'" + txtNOTE.Text + "')");


                    MessageBox.Show("Thêm hóa đơn thành công");
                    btnCTHoaDon.Enabled = true;
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
                txtHD.Text + "'");

            if(dt.Rows.Count>0)
            {
                idKH = cmbKH.Text;
                frmCTHD = new FormCTHoaDon(txtHD.Text, idKH);
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
            if (cmbKH.Text.Trim() == "")
            {
                err2.SetError(cmbKH, "Trường này là bắt buộc");
                return false;
            }

            if (txtHD.Text.Trim() == "")
            {
                err2.SetError(txtHD, "Trường này là bắt buộc");
                return false;
            }

            if ( txtIDFood.Text.Trim() == "" )
            {
                err2.SetError(txtIDFood, "Trường này là bắt buộc");
                return false;
            }
            else
            {
                btnADD.Enabled = true;
            }

            if ( NUM.Value == 0)
            {
                err2.SetError(NUM, "Số lượng không thể là 0");
                return false;
            }

            if (cmbFoodName.Text.Trim() == "")
            {
                err2.SetError(cmbFoodName, "Số lượng không thể là 0");
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtIDFood.Text = "";
            cmbFoodName.Text = "";
            txtDonGia.Text = "0";
            NUM.Value = 0;
            txtMoTa.Text = "";
        }

        public int sales()
        {
            return 0;
        }
    }
}
