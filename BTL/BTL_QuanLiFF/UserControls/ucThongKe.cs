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
    public partial class ucThongKe : UserControl
    {
        Classes.Common cm = new Classes.Common();
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        DataTable dt = new DataTable();
        
        public ucThongKe()
        {
            InitializeComponent();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {

                dgv1.DataSource = dtbase.DataReader("select * from SANPHAM");
            }
                
            else if (e.TabPage == tabPage2)
            {
                dgv2.DataSource = dtbase.DataReader("select * from HOADONBAN inner" +
                    " join CTHOADONBAN ON HOADONBAN.idHD = CTHOADONBAN.idHD");
            }
            else if( e.TabPage == tabPage3)
            {
                dgv2.DataSource = dtbase.DataReader("SELECT CTHOADONNHAP.idCT, CTHOADONNHAP.idNCC , hotenNV,  ngayTaoHD , NGUYENLIEU.tenNL, CTHOADONNHAP.SoLuong, giaTien,  tinhTrang, " +
                    " NHANVIEN.Status AS NVS" +
                    " FROM CTHOADONNHAP" +
                    " INNER JOIN CTNGUYENLIEU ON CTHOADONNHAP.idCT = CTNGUYENLIEU.idCT" +
                    " INNER JOIN NGUYENLIEU ON NGUYENLIEU.IDNL = CTNGUYENLIEU.idNL" +
                    " INNER JOIN NHANVIEN ON NHANVIEN.idNV = CTHOADONNHAP.idNV" +
                    " INNER JOIN NHACUNGCAP ON CTHOADONNHAP.idNCC = NHACUNGCAP.idNCC ");

                dt = dtbase.DataReader("select * from NGUYENLIEU");
                cmbNL3.DataSource = dt;
                cmbNL3.DisplayMember = "tenNL";
                cmbNL3.ValueMember = "tenNL";

            }
        }
    }
}
