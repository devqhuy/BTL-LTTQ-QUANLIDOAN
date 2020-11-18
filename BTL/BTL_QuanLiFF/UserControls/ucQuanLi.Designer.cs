namespace BTL_QuanLiFF.UserControls
{
    partial class ucQuanLi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.err4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpQLNV = new System.Windows.Forms.TabPage();
            this.lblIDNhanVien = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.dtgvQLNVDSNhanVien = new System.Windows.Forms.DataGridView();
            this.btnQLNVSua = new System.Windows.Forms.Button();
            this.btnQLNVXoa = new System.Windows.Forms.Button();
            this.btnQLNVThem = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.txtQLNVHoTen = new System.Windows.Forms.TextBox();
            this.txtQLNVSoDT = new System.Windows.Forms.TextBox();
            this.txtQLNVChucVu = new System.Windows.Forms.TextBox();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.btnLuu1 = new System.Windows.Forms.Button();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tabNhanVien = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.err4)).BeginInit();
            this.tpQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLNVDSNhanVien)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // err4
            // 
            this.err4.ContainerControl = this;
            // 
            // tpQLNV
            // 
            this.tpQLNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpQLNV.Controls.Add(this.txtAnh);
            this.tpQLNV.Controls.Add(this.txtDoB);
            this.tpQLNV.Controls.Add(this.txtQLNVChucVu);
            this.tpQLNV.Controls.Add(this.txtQLNVSoDT);
            this.tpQLNV.Controls.Add(this.btnHuy);
            this.tpQLNV.Controls.Add(this.rdbNu);
            this.tpQLNV.Controls.Add(this.rdbNam);
            this.tpQLNV.Controls.Add(this.txtQLNVHoTen);
            this.tpQLNV.Controls.Add(this.lblAnh);
            this.tpQLNV.Controls.Add(this.btnLuu1);
            this.tpQLNV.Controls.Add(this.cmb);
            this.tpQLNV.Controls.Add(this.btnQLNVThem);
            this.tpQLNV.Controls.Add(this.btnQLNVXoa);
            this.tpQLNV.Controls.Add(this.btnQLNVSua);
            this.tpQLNV.Controls.Add(this.dtgvQLNVDSNhanVien);
            this.tpQLNV.Controls.Add(this.lblChucVu);
            this.tpQLNV.Controls.Add(this.lblSoDT);
            this.tpQLNV.Controls.Add(this.lblNgaySinh);
            this.tpQLNV.Controls.Add(this.lblHoTen);
            this.tpQLNV.Controls.Add(this.lblIDNhanVien);
            this.tpQLNV.Location = new System.Drawing.Point(4, 31);
            this.tpQLNV.Name = "tpQLNV";
            this.tpQLNV.Padding = new System.Windows.Forms.Padding(3);
            this.tpQLNV.Size = new System.Drawing.Size(909, 494);
            this.tpQLNV.TabIndex = 0;
            this.tpQLNV.Text = "QL Nhân viên";
            this.tpQLNV.UseVisualStyleBackColor = true;
            // 
            // lblIDNhanVien
            // 
            this.lblIDNhanVien.AutoSize = true;
            this.lblIDNhanVien.Location = new System.Drawing.Point(63, 34);
            this.lblIDNhanVien.Name = "lblIDNhanVien";
            this.lblIDNhanVien.Size = new System.Drawing.Size(58, 22);
            this.lblIDNhanVien.TabIndex = 0;
            this.lblIDNhanVien.Text = "id NV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(63, 77);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(81, 22);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "HỌ TÊN";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(63, 122);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(115, 22);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "NGÀY SINH";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(531, 34);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(66, 22);
            this.lblSoDT.TabIndex = 5;
            this.lblSoDT.Text = "SỐ ĐT";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(531, 78);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(97, 22);
            this.lblChucVu.TabIndex = 6;
            this.lblChucVu.Text = "CHỨC VỤ";
            // 
            // dtgvQLNVDSNhanVien
            // 
            this.dtgvQLNVDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLNVDSNhanVien.Location = new System.Drawing.Point(55, 188);
            this.dtgvQLNVDSNhanVien.Name = "dtgvQLNVDSNhanVien";
            this.dtgvQLNVDSNhanVien.RowHeadersWidth = 51;
            this.dtgvQLNVDSNhanVien.RowTemplate.Height = 24;
            this.dtgvQLNVDSNhanVien.Size = new System.Drawing.Size(788, 245);
            this.dtgvQLNVDSNhanVien.TabIndex = 9;
            this.dtgvQLNVDSNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQLNVDSNhanVien_CellClick);
            // 
            // btnQLNVSua
            // 
            this.btnQLNVSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQLNVSua.Location = new System.Drawing.Point(231, 439);
            this.btnQLNVSua.Name = "btnQLNVSua";
            this.btnQLNVSua.Size = new System.Drawing.Size(134, 48);
            this.btnQLNVSua.TabIndex = 12;
            this.btnQLNVSua.Text = "SỬA";
            this.btnQLNVSua.UseVisualStyleBackColor = false;
            this.btnQLNVSua.Click += new System.EventHandler(this.btnQLNVSua_Click);
            // 
            // btnQLNVXoa
            // 
            this.btnQLNVXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQLNVXoa.Location = new System.Drawing.Point(371, 439);
            this.btnQLNVXoa.Name = "btnQLNVXoa";
            this.btnQLNVXoa.Size = new System.Drawing.Size(134, 48);
            this.btnQLNVXoa.TabIndex = 13;
            this.btnQLNVXoa.Text = "XÓA";
            this.btnQLNVXoa.UseVisualStyleBackColor = false;
            this.btnQLNVXoa.Click += new System.EventHandler(this.btnQLNVXoa_Click);
            // 
            // btnQLNVThem
            // 
            this.btnQLNVThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQLNVThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnQLNVThem.Location = new System.Drawing.Point(91, 439);
            this.btnQLNVThem.Name = "btnQLNVThem";
            this.btnQLNVThem.Size = new System.Drawing.Size(134, 48);
            this.btnQLNVThem.TabIndex = 14;
            this.btnQLNVThem.Text = "THÊM";
            this.btnQLNVThem.UseVisualStyleBackColor = false;
            this.btnQLNVThem.Click += new System.EventHandler(this.btnQLNVThem_Click);
            // 
            // cmb
            // 
            this.cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(183, 26);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(200, 30);
            this.cmb.TabIndex = 19;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // txtQLNVHoTen
            // 
            this.txtQLNVHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQLNVHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQLNVHoTen.Location = new System.Drawing.Point(183, 69);
            this.txtQLNVHoTen.Name = "txtQLNVHoTen";
            this.txtQLNVHoTen.Size = new System.Drawing.Size(200, 30);
            this.txtQLNVHoTen.TabIndex = 16;
            // 
            // txtQLNVSoDT
            // 
            this.txtQLNVSoDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQLNVSoDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQLNVSoDT.Location = new System.Drawing.Point(643, 26);
            this.txtQLNVSoDT.Name = "txtQLNVSoDT";
            this.txtQLNVSoDT.Size = new System.Drawing.Size(200, 30);
            this.txtQLNVSoDT.TabIndex = 21;
            // 
            // txtQLNVChucVu
            // 
            this.txtQLNVChucVu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQLNVChucVu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQLNVChucVu.Location = new System.Drawing.Point(643, 70);
            this.txtQLNVChucVu.Name = "txtQLNVChucVu";
            this.txtQLNVChucVu.Size = new System.Drawing.Size(200, 30);
            this.txtQLNVChucVu.TabIndex = 22;
            // 
            // txtDoB
            // 
            this.txtDoB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDoB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDoB.Location = new System.Drawing.Point(183, 114);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(200, 30);
            this.txtDoB.TabIndex = 24;
            // 
            // btnLuu1
            // 
            this.btnLuu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLuu1.Location = new System.Drawing.Point(511, 439);
            this.btnLuu1.Name = "btnLuu1";
            this.btnLuu1.Size = new System.Drawing.Size(134, 48);
            this.btnLuu1.TabIndex = 25;
            this.btnLuu1.Text = "LƯU";
            this.btnLuu1.UseVisualStyleBackColor = false;
            this.btnLuu1.Click += new System.EventHandler(this.btnLuu1_Click);
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(531, 122);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(52, 22);
            this.lblAnh.TabIndex = 26;
            this.lblAnh.Text = "ẢNH";
            this.lblAnh.Click += new System.EventHandler(this.lblAnh_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAnh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAnh.Location = new System.Drawing.Point(643, 114);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(200, 30);
            this.txtAnh.TabIndex = 27;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(643, 156);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(68, 26);
            this.rdbNam.TabIndex = 28;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(787, 156);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(56, 26);
            this.rdbNu.TabIndex = 29;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHuy.Location = new System.Drawing.Point(651, 439);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(134, 48);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.tpQLNV);
            this.tabNhanVien.Location = new System.Drawing.Point(3, 19);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.SelectedIndex = 0;
            this.tabNhanVien.Size = new System.Drawing.Size(917, 529);
            this.tabNhanVien.TabIndex = 0;
            // 
            // ucQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ucQuanLi";
            this.Size = new System.Drawing.Size(923, 551);
            this.Load += new System.EventHandler(this.ucQuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err4)).EndInit();
            this.tpQLNV.ResumeLayout(false);
            this.tpQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLNVDSNhanVien)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider err4;
        private System.Windows.Forms.TabControl tabNhanVien;
        private System.Windows.Forms.TabPage tpQLNV;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.TextBox txtQLNVChucVu;
        private System.Windows.Forms.TextBox txtQLNVSoDT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtQLNVHoTen;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Button btnLuu1;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button btnQLNVThem;
        private System.Windows.Forms.Button btnQLNVXoa;
        private System.Windows.Forms.Button btnQLNVSua;
        private System.Windows.Forms.DataGridView dtgvQLNVDSNhanVien;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblIDNhanVien;
    }
}
