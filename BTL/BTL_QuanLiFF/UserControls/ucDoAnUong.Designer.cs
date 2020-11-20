


namespace BTL_QuanLiFF.UserControls
{
    partial class ucDoAnUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDoAnUong));
            this.lblFood = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblNOTE = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtDoAnUongMaMon = new System.Windows.Forms.TextBox();
            this.txtDoAnUongDonGia = new System.Windows.Forms.TextBox();
            this.txtDoAnUongNote = new System.Windows.Forms.TextBox();
            this.btnDoAnUongThem = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnDoAnUongCTHD = new System.Windows.Forms.Button();
            this.NUM = new System.Windows.Forms.NumericUpDown();
            this.cbDoAnUongTenMon = new System.Windows.Forms.ComboBox();
            this.txtDoAnUongMoTa = new System.Windows.Forms.TextBox();
            this.txtKHMaHD = new System.Windows.Forms.TextBox();
            this.lblHD = new System.Windows.Forms.Label();
            this.btnDoAnUongHDMoi = new System.Windows.Forms.Button();
            this.btnDoAnUongNhapLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDoAnUongMaKH = new System.Windows.Forms.ComboBox();
            this.err2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTT2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFood.Location = new System.Drawing.Point(23, 134);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(80, 22);
            this.lblFood.TabIndex = 2;
            this.lblFood.Text = "ID MÓN";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFoodName.Location = new System.Drawing.Point(23, 179);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(98, 22);
            this.lblFoodName.TabIndex = 3;
            this.lblFoodName.Text = "TÊN MÓN";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDonGia.Location = new System.Drawing.Point(23, 231);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(91, 22);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "ĐƠN GIÁ";
            // 
            // lblNOTE
            // 
            this.lblNOTE.AutoSize = true;
            this.lblNOTE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNOTE.Location = new System.Drawing.Point(23, 375);
            this.lblNOTE.Name = "lblNOTE";
            this.lblNOTE.Size = new System.Drawing.Size(154, 22);
            this.lblNOTE.TabIndex = 5;
            this.lblNOTE.Text = "YÊU CẦU THÊM";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMoTa.Location = new System.Drawing.Point(23, 330);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(72, 22);
            this.lblMoTa.TabIndex = 6;
            this.lblMoTa.Text = "MÔ TẢ";
            // 
            // txtDoAnUongMaMon
            // 
            this.txtDoAnUongMaMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDoAnUongMaMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDoAnUongMaMon.Location = new System.Drawing.Point(403, 124);
            this.txtDoAnUongMaMon.Name = "txtDoAnUongMaMon";
            this.txtDoAnUongMaMon.Size = new System.Drawing.Size(496, 32);
            this.txtDoAnUongMaMon.TabIndex = 8;
            // 
            // txtDoAnUongDonGia
            // 
            this.txtDoAnUongDonGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDoAnUongDonGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDoAnUongDonGia.Location = new System.Drawing.Point(403, 221);
            this.txtDoAnUongDonGia.Name = "txtDoAnUongDonGia";
            this.txtDoAnUongDonGia.Size = new System.Drawing.Size(496, 32);
            this.txtDoAnUongDonGia.TabIndex = 9;
            // 
            // txtDoAnUongNote
            // 
            this.txtDoAnUongNote.Location = new System.Drawing.Point(403, 375);
            this.txtDoAnUongNote.Multiline = true;
            this.txtDoAnUongNote.Name = "txtDoAnUongNote";
            this.txtDoAnUongNote.Size = new System.Drawing.Size(496, 96);
            this.txtDoAnUongNote.TabIndex = 10;
            // 
            // btnDoAnUongThem
            // 
            this.btnDoAnUongThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAnUongThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDoAnUongThem.Image = ((System.Drawing.Image)(resources.GetObject("btnDoAnUongThem.Image")));
            this.btnDoAnUongThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoAnUongThem.Location = new System.Drawing.Point(27, 491);
            this.btnDoAnUongThem.Name = "btnDoAnUongThem";
            this.btnDoAnUongThem.Size = new System.Drawing.Size(115, 42);
            this.btnDoAnUongThem.TabIndex = 12;
            this.btnDoAnUongThem.Text = "Thêm";
            this.btnDoAnUongThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoAnUongThem.UseVisualStyleBackColor = true;
            this.btnDoAnUongThem.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSoLuong.Location = new System.Drawing.Point(23, 281);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(109, 22);
            this.lblSoLuong.TabIndex = 13;
            this.lblSoLuong.Text = "SỐ LƯỢNG";
            // 
            // btnDoAnUongCTHD
            // 
            this.btnDoAnUongCTHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAnUongCTHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDoAnUongCTHD.Image = ((System.Drawing.Image)(resources.GetObject("btnDoAnUongCTHD.Image")));
            this.btnDoAnUongCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoAnUongCTHD.Location = new System.Drawing.Point(27, 429);
            this.btnDoAnUongCTHD.Name = "btnDoAnUongCTHD";
            this.btnDoAnUongCTHD.Size = new System.Drawing.Size(272, 42);
            this.btnDoAnUongCTHD.TabIndex = 15;
            this.btnDoAnUongCTHD.Text = "CHI TIẾT HÓA ĐƠN";
            this.btnDoAnUongCTHD.UseVisualStyleBackColor = true;
            this.btnDoAnUongCTHD.Click += new System.EventHandler(this.btnCTHoaDon_Click);
            // 
            // NUM
            // 
            this.NUM.Location = new System.Drawing.Point(403, 271);
            this.NUM.Name = "NUM";
            this.NUM.Size = new System.Drawing.Size(496, 32);
            this.NUM.TabIndex = 18;
            this.NUM.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // cbDoAnUongTenMon
            // 
            this.cbDoAnUongTenMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDoAnUongTenMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDoAnUongTenMon.FormattingEnabled = true;
            this.cbDoAnUongTenMon.Location = new System.Drawing.Point(403, 170);
            this.cbDoAnUongTenMon.Name = "cbDoAnUongTenMon";
            this.cbDoAnUongTenMon.Size = new System.Drawing.Size(496, 31);
            this.cbDoAnUongTenMon.TabIndex = 19;
            this.cbDoAnUongTenMon.SelectedIndexChanged += new System.EventHandler(this.cmbFoodName_SelectedIndexChanged);
            // 
            // txtDoAnUongMoTa
            // 
            this.txtDoAnUongMoTa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDoAnUongMoTa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDoAnUongMoTa.Location = new System.Drawing.Point(403, 325);
            this.txtDoAnUongMoTa.Multiline = true;
            this.txtDoAnUongMoTa.Name = "txtDoAnUongMoTa";
            this.txtDoAnUongMoTa.Size = new System.Drawing.Size(496, 33);
            this.txtDoAnUongMoTa.TabIndex = 16;
            // 
            // txtKHMaHD
            // 
            this.txtKHMaHD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKHMaHD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKHMaHD.Location = new System.Drawing.Point(403, 77);
            this.txtKHMaHD.Name = "txtKHMaHD";
            this.txtKHMaHD.Size = new System.Drawing.Size(496, 32);
            this.txtKHMaHD.TabIndex = 21;
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHD.Location = new System.Drawing.Point(23, 87);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(124, 22);
            this.lblHD.TabIndex = 20;
            this.lblHD.Text = "ID HOÁ ĐƠN";
            // 
            // btnDoAnUongHDMoi
            // 
            this.btnDoAnUongHDMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDoAnUongHDMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnDoAnUongHDMoi.Image")));
            this.btnDoAnUongHDMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoAnUongHDMoi.Location = new System.Drawing.Point(379, 491);
            this.btnDoAnUongHDMoi.Name = "btnDoAnUongHDMoi";
            this.btnDoAnUongHDMoi.Size = new System.Drawing.Size(188, 42);
            this.btnDoAnUongHDMoi.TabIndex = 22;
            this.btnDoAnUongHDMoi.Text = "HÓA ĐƠN MỚI";
            this.btnDoAnUongHDMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoAnUongHDMoi.UseVisualStyleBackColor = true;
            this.btnDoAnUongHDMoi.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnDoAnUongNhapLai
            // 
            this.btnDoAnUongNhapLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAnUongNhapLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDoAnUongNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnDoAnUongNhapLai.Image")));
            this.btnDoAnUongNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoAnUongNhapLai.Location = new System.Drawing.Point(180, 491);
            this.btnDoAnUongNhapLai.Name = "btnDoAnUongNhapLai";
            this.btnDoAnUongNhapLai.Size = new System.Drawing.Size(129, 42);
            this.btnDoAnUongNhapLai.TabIndex = 23;
            this.btnDoAnUongNhapLai.Text = "Nhập lại";
            this.btnDoAnUongNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoAnUongNhapLai.UseVisualStyleBackColor = true;
            this.btnDoAnUongNhapLai.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID KHÁCH HÀNG";
            // 
            // cbDoAnUongMaKH
            // 
            this.cbDoAnUongMaKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDoAnUongMaKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDoAnUongMaKH.FormattingEnabled = true;
            this.cbDoAnUongMaKH.Location = new System.Drawing.Point(403, 30);
            this.cbDoAnUongMaKH.Name = "cbDoAnUongMaKH";
            this.cbDoAnUongMaKH.Size = new System.Drawing.Size(496, 31);
            this.cbDoAnUongMaKH.TabIndex = 25;
            // 
            // err2
            // 
            this.err2.ContainerControl = this;
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTT.Location = new System.Drawing.Point(575, 505);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(160, 29);
            this.lblTT.TabIndex = 17;
            this.lblTT.Text = "TỔNG TIỀN : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(739, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 26;
            // 
            // lblTT2
            // 
            this.lblTT2.AutoSize = true;
            this.lblTT2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTT2.Location = new System.Drawing.Point(745, 511);
            this.lblTT2.Name = "lblTT2";
            this.lblTT2.Size = new System.Drawing.Size(129, 22);
            this.lblTT2.TabIndex = 27;
            this.lblTT2.Text = "TỔNG TIỀN : ";
            // 
            // ucDoAnUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblTT2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDoAnUongMaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoAnUongNhapLai);
            this.Controls.Add(this.btnDoAnUongHDMoi);
            this.Controls.Add(this.txtKHMaHD);
            this.Controls.Add(this.lblHD);
            this.Controls.Add(this.cbDoAnUongTenMon);
            this.Controls.Add(this.NUM);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.txtDoAnUongMoTa);
            this.Controls.Add(this.btnDoAnUongCTHD);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.btnDoAnUongThem);
            this.Controls.Add(this.txtDoAnUongNote);
            this.Controls.Add(this.txtDoAnUongDonGia);
            this.Controls.Add(this.txtDoAnUongMaMon);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblNOTE);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.lblFood);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDoAnUong";
            this.Size = new System.Drawing.Size(923, 549);
            this.Load += new System.EventHandler(this.ucDoAnUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblNOTE;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtDoAnUongMaMon;
        private System.Windows.Forms.TextBox txtDoAnUongDonGia;
        private System.Windows.Forms.TextBox txtDoAnUongNote;
        private System.Windows.Forms.Button btnDoAnUongThem;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnDoAnUongCTHD;
        private System.Windows.Forms.NumericUpDown NUM;
        private System.Windows.Forms.ComboBox cbDoAnUongTenMon;
        private System.Windows.Forms.TextBox txtDoAnUongMoTa;
        private System.Windows.Forms.TextBox txtKHMaHD;
        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.Button btnDoAnUongHDMoi;
        private System.Windows.Forms.Button btnDoAnUongNhapLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDoAnUongMaKH;
        private System.Windows.Forms.ErrorProvider err2;
        private System.Windows.Forms.Label lblTT2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTT;
    }
}
