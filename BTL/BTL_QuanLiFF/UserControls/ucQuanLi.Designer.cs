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
            this.tabNhanVien = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabNguyenLieu = new System.Windows.Forms.TabPage();
            this.lblIDNhanVien = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblAnhNhanVien = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dtgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.lblDSNhanVien = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tabNhanVien.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.tabPage1);
            this.tabNhanVien.Controls.Add(this.tabNguyenLieu);
            this.tabNhanVien.Location = new System.Drawing.Point(3, 0);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.SelectedIndex = 0;
            this.tabNhanVien.Size = new System.Drawing.Size(917, 548);
            this.tabNhanVien.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.lblDSNhanVien);
            this.tabPage1.Controls.Add(this.picNhanVien);
            this.tabPage1.Controls.Add(this.dtgvDSNhanVien);
            this.tabPage1.Controls.Add(this.lblGioiTinh);
            this.tabPage1.Controls.Add(this.lblChucVu);
            this.tabPage1.Controls.Add(this.lblSoDT);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblAnhNhanVien);
            this.tabPage1.Controls.Add(this.lblNgaySinh);
            this.tabPage1.Controls.Add(this.lblHoTen);
            this.tabPage1.Controls.Add(this.lblIDNhanVien);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QUẢN LÍ NHÂN VIÊN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabNguyenLieu
            // 
            this.tabNguyenLieu.Location = new System.Drawing.Point(4, 31);
            this.tabNguyenLieu.Name = "tabNguyenLieu";
            this.tabNguyenLieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabNguyenLieu.Size = new System.Drawing.Size(909, 513);
            this.tabNguyenLieu.TabIndex = 1;
            this.tabNguyenLieu.Text = "tabPage2";
            this.tabNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // lblIDNhanVien
            // 
            this.lblIDNhanVien.AutoSize = true;
            this.lblIDNhanVien.Location = new System.Drawing.Point(62, 60);
            this.lblIDNhanVien.Name = "lblIDNhanVien";
            this.lblIDNhanVien.Size = new System.Drawing.Size(58, 22);
            this.lblIDNhanVien.TabIndex = 0;
            this.lblIDNhanVien.Text = "id NV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(62, 106);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(81, 22);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "HỌ TÊN";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(62, 152);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(115, 22);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "NGÀY SINH";
            // 
            // lblAnhNhanVien
            // 
            this.lblAnhNhanVien.AutoSize = true;
            this.lblAnhNhanVien.Location = new System.Drawing.Point(62, 202);
            this.lblAnhNhanVien.Name = "lblAnhNhanVien";
            this.lblAnhNhanVien.Size = new System.Drawing.Size(52, 22);
            this.lblAnhNhanVien.TabIndex = 3;
            this.lblAnhNhanVien.Text = "ẢNH";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(515, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 22);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(515, 106);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(66, 22);
            this.lblSoDT.TabIndex = 5;
            this.lblSoDT.Text = "SỐ ĐT";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(515, 152);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(97, 22);
            this.lblChucVu.TabIndex = 6;
            this.lblChucVu.Text = "CHỨC VỤ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(515, 202);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(102, 22);
            this.lblGioiTinh.TabIndex = 7;
            this.lblGioiTinh.Text = "GIỚI TÍNH";
            // 
            // dtgvDSNhanVien
            // 
            this.dtgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNhanVien.Location = new System.Drawing.Point(320, 280);
            this.dtgvDSNhanVien.Name = "dtgvDSNhanVien";
            this.dtgvDSNhanVien.RowHeadersWidth = 51;
            this.dtgvDSNhanVien.RowTemplate.Height = 24;
            this.dtgvDSNhanVien.Size = new System.Drawing.Size(498, 150);
            this.dtgvDSNhanVien.TabIndex = 9;
            // 
            // picNhanVien
            // 
            this.picNhanVien.Location = new System.Drawing.Point(66, 280);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(149, 78);
            this.picNhanVien.TabIndex = 10;
            this.picNhanVien.TabStop = false;
            // 
            // lblDSNhanVien
            // 
            this.lblDSNhanVien.AutoSize = true;
            this.lblDSNhanVien.Location = new System.Drawing.Point(316, 237);
            this.lblDSNhanVien.Name = "lblDSNhanVien";
            this.lblDSNhanVien.Size = new System.Drawing.Size(171, 22);
            this.lblDSNhanVien.TabIndex = 11;
            this.lblDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.Location = new System.Drawing.Point(528, 445);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 48);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.Location = new System.Drawing.Point(686, 445);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 48);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Location = new System.Drawing.Point(372, 445);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 48);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // ucQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ucQuanLi";
            this.Size = new System.Drawing.Size(923, 551);
            this.tabNhanVien.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNhanVien;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblDSNhanVien;
        private System.Windows.Forms.PictureBox picNhanVien;
        private System.Windows.Forms.DataGridView dtgvDSNhanVien;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAnhNhanVien;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblIDNhanVien;
        private System.Windows.Forms.TabPage tabNguyenLieu;
    }
}
