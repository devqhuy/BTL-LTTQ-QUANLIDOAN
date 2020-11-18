namespace BTL_QuanLiFF.UserControls
{
    partial class ucKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKHMaKhachHang = new System.Windows.Forms.ComboBox();
            this.txtKHHoTen = new System.Windows.Forms.TextBox();
            this.txtKHDiaChi = new System.Windows.Forms.TextBox();
            this.txtKHSoDT = new System.Windows.Forms.TextBox();
            this.txtKHNgaySinh = new System.Windows.Forms.TextBox();
            this.btnKHThem = new System.Windows.Forms.Button();
            this.btnKHSua = new System.Windows.Forms.Button();
            this.btnKHXoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKHTimKiem = new System.Windows.Forms.TextBox();
            this.err3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnKHLuu = new System.Windows.Forms.Button();
            this.btnKHHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(229, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID KHÁCH HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "HỌ TÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(37, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "ĐỊA CHỈ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(37, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "SỐ ĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(37, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "NGÀY SINH";
            // 
            // cbKHMaKhachHang
            // 
            this.cbKHMaKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKHMaKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKHMaKhachHang.FormattingEnabled = true;
            this.cbKHMaKhachHang.Location = new System.Drawing.Point(234, 115);
            this.cbKHMaKhachHang.Name = "cbKHMaKhachHang";
            this.cbKHMaKhachHang.Size = new System.Drawing.Size(354, 32);
            this.cbKHMaKhachHang.TabIndex = 7;
            this.cbKHMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbKH_SelectedIndexChanged);
            // 
            // txtKHHoTen
            // 
            this.txtKHHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKHHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKHHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHHoTen.Location = new System.Drawing.Point(234, 186);
            this.txtKHHoTen.Name = "txtKHHoTen";
            this.txtKHHoTen.Size = new System.Drawing.Size(354, 30);
            this.txtKHHoTen.TabIndex = 8;
            // 
            // txtKHDiaChi
            // 
            this.txtKHDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKHDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKHDiaChi.Location = new System.Drawing.Point(234, 252);
            this.txtKHDiaChi.Name = "txtKHDiaChi";
            this.txtKHDiaChi.Size = new System.Drawing.Size(354, 30);
            this.txtKHDiaChi.TabIndex = 9;
            // 
            // txtKHSoDT
            // 
            this.txtKHSoDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKHSoDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKHSoDT.Location = new System.Drawing.Point(234, 316);
            this.txtKHSoDT.Name = "txtKHSoDT";
            this.txtKHSoDT.Size = new System.Drawing.Size(354, 30);
            this.txtKHSoDT.TabIndex = 10;
            // 
            // txtKHNgaySinh
            // 
            this.txtKHNgaySinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKHNgaySinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKHNgaySinh.Location = new System.Drawing.Point(234, 380);
            this.txtKHNgaySinh.Name = "txtKHNgaySinh";
            this.txtKHNgaySinh.Size = new System.Drawing.Size(354, 30);
            this.txtKHNgaySinh.TabIndex = 11;
            // 
            // btnKHThem
            // 
            this.btnKHThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKHThem.Location = new System.Drawing.Point(41, 457);
            this.btnKHThem.Name = "btnKHThem";
            this.btnKHThem.Size = new System.Drawing.Size(162, 50);
            this.btnKHThem.TabIndex = 12;
            this.btnKHThem.Text = "THÊM";
            this.btnKHThem.UseVisualStyleBackColor = true;
            this.btnKHThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnKHSua
            // 
            this.btnKHSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKHSua.Location = new System.Drawing.Point(209, 457);
            this.btnKHSua.Name = "btnKHSua";
            this.btnKHSua.Size = new System.Drawing.Size(162, 50);
            this.btnKHSua.TabIndex = 13;
            this.btnKHSua.Text = "SỬA";
            this.btnKHSua.UseVisualStyleBackColor = true;
            this.btnKHSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKHXoa
            // 
            this.btnKHXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKHXoa.Location = new System.Drawing.Point(377, 457);
            this.btnKHXoa.Name = "btnKHXoa";
            this.btnKHXoa.Size = new System.Drawing.Size(162, 50);
            this.btnKHXoa.TabIndex = 14;
            this.btnKHXoa.Text = "XÓA";
            this.btnKHXoa.UseVisualStyleBackColor = true;
            this.btnKHXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(604, 113);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(292, 295);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 17;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.picAnh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(518, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tìm kiếm: ";
            // 
            // txtKHTimKiem
            // 
            this.txtKHTimKiem.Location = new System.Drawing.Point(649, 44);
            this.txtKHTimKiem.Name = "txtKHTimKiem";
            this.txtKHTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKHTimKiem.Size = new System.Drawing.Size(247, 30);
            this.txtKHTimKiem.TabIndex = 19;
            this.txtKHTimKiem.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // err3
            // 
            this.err3.ContainerControl = this;
            // 
            // btnKHLuu
            // 
            this.btnKHLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKHLuu.Location = new System.Drawing.Point(545, 457);
            this.btnKHLuu.Name = "btnKHLuu";
            this.btnKHLuu.Size = new System.Drawing.Size(162, 50);
            this.btnKHLuu.TabIndex = 20;
            this.btnKHLuu.Text = "LƯU";
            this.btnKHLuu.UseVisualStyleBackColor = true;
            this.btnKHLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKHHuy
            // 
            this.btnKHHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKHHuy.Location = new System.Drawing.Point(713, 457);
            this.btnKHHuy.Name = "btnKHHuy";
            this.btnKHHuy.Size = new System.Drawing.Size(162, 50);
            this.btnKHHuy.TabIndex = 21;
            this.btnKHHuy.Text = "HỦY";
            this.btnKHHuy.UseVisualStyleBackColor = true;
            this.btnKHHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnKHHuy);
            this.Controls.Add(this.btnKHLuu);
            this.Controls.Add(this.txtKHTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKHXoa);
            this.Controls.Add(this.btnKHSua);
            this.Controls.Add(this.btnKHThem);
            this.Controls.Add(this.txtKHNgaySinh);
            this.Controls.Add(this.txtKHSoDT);
            this.Controls.Add(this.txtKHDiaChi);
            this.Controls.Add(this.txtKHHoTen);
            this.Controls.Add(this.cbKHMaKhachHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(923, 551);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbKHMaKhachHang;
        private System.Windows.Forms.TextBox txtKHHoTen;
        private System.Windows.Forms.TextBox txtKHDiaChi;
        private System.Windows.Forms.TextBox txtKHSoDT;
        private System.Windows.Forms.TextBox txtKHNgaySinh;
        private System.Windows.Forms.Button btnKHThem;
        private System.Windows.Forms.Button btnKHSua;
        private System.Windows.Forms.Button btnKHXoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKHTimKiem;
        public System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.ErrorProvider err3;
        private System.Windows.Forms.Button btnKHLuu;
        private System.Windows.Forms.Button btnKHHuy;
    }
}
