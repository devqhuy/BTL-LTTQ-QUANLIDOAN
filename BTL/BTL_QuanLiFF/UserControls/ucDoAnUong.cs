using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiFF.UserControls
{
    public partial class ucDoAnUong : UserControl
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.Common cm = new Classes.Common();
        public string Food_name = "";
        public string idKH = "";
        public string idNV = "";

        public ucDoAnUong()
        {
            InitializeComponent();
        }

        private void ucDoAnUong_Load(object sender, EventArgs e)
        {
            txtIDFood.Enabled = false;
            cmbFoodName.Enabled = true;
            txtDonGia.Enabled = false;
            txtMoTa.Enabled = true;
            txtHD.Enabled = false;
            cmbKH.Enabled = true;

            this.LoadComboBox();
            this.LoadcmbKH();
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
            dt = dtbase.DataReader("select * from KHACHHANG");
            try
            {
                cmbKH.DataSource = dt;
                cmbKH.DisplayMember = "idKH";
                
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
            }
            else return;

            
        }

        private void NUM_ValueChanged(object sender, EventArgs e)
        {
            int gia = Convert.ToInt32(txtDonGia.Text);
            int sl = Convert.ToInt32(NUM.Value);
            lblTT2.Text =  Convert.ToString(gia * sl);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string tableName = "HOADONBAN";
            string FildeName = "idHD";
            string startString = "HDB" + DateTime.Now.ToShortDateString();
            txtHD.Text = cm.AutoCode(tableName,FildeName, startString );
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //Kiem tra xem trong hoadonban co idHD nay chua 
            //Chua co thi them vao 
            dt = dtbase.DataReader("select idHD from HOADONBAN where idHD = '" + txtHD.Text +"'");
            if(dt.Rows.Count == 0 )
            {
                dtbase.DataChange("insert into HOADONBAN values ('" + txtHD.Text +
                    "','" + idNV + "','" + this.cmbKH.GetItemText(this.cmbKH.SelectedValue) + "'," + 1 + ")");
            }

            dtbase.DataChange("insert into CTHOADONBAN(idHD, idSP, soluong, giaTien, ngayTao)" +
                "values('" + txtHD.Text + "','" + txtIDFood.Text + "'," + NUM.Value + "," +
                Convert.ToInt32(lblTT2.Text) + ",'" + DateTime.Now.ToShortDateString() + "')");

            MessageBox.Show("Thêm hóa đơn thành công");

           
        }

        public void getID(string IDNV)
        {
            this.idNV = IDNV;
        }
      
    }
}
