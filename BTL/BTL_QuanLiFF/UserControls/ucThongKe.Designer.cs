namespace BTL_QuanLiFF.UserControls
{
    partial class ucThongKe
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb12 = new System.Windows.Forms.RadioButton();
            this.rdb11 = new System.Windows.Forms.RadioButton();
            this.lblSX1 = new System.Windows.Forms.Label();
            this.btnTKBestSellInBaoCao = new System.Windows.Forms.Button();
            this.lblTo1 = new System.Windows.Forms.Label();
            this.lblFrom1 = new System.Windows.Forms.Label();
            this.btnTKBestSellXem = new System.Windows.Forms.Button();
            this.dtpTKBestSellTo = new System.Windows.Forms.DateTimePicker();
            this.dtpTKBestSellFrom = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTKHDBNInBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTKHDBTenNV = new System.Windows.Forms.ComboBox();
            this.rdb22 = new System.Windows.Forms.RadioButton();
            this.rdb21 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTKHDBXem = new System.Windows.Forms.Button();
            this.dtpTKHDBTo = new System.Windows.Forms.DateTimePicker();
            this.dtpTKHDBFrom = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnBOTTOM3 = new System.Windows.Forms.Panel();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.pnTOP3 = new System.Windows.Forms.Panel();
            this.btnTKHDNInBaoCao = new System.Windows.Forms.Button();
            this.lblNL3 = new System.Windows.Forms.Label();
            this.cbTKHDNTenNV = new System.Windows.Forms.ComboBox();
            this.rdb32 = new System.Windows.Forms.RadioButton();
            this.rdb31 = new System.Windows.Forms.RadioButton();
            this.lblSX3 = new System.Windows.Forms.Label();
            this.lblTo3 = new System.Windows.Forms.Label();
            this.lblFrom3 = new System.Windows.Forms.Label();
            this.btnTKHDNXem = new System.Windows.Forms.Button();
            this.dtpTKHDNTo = new System.Windows.Forms.DateTimePicker();
            this.dtpTKHDNFrom = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnBOTTOM3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.pnTOP3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(16, 18);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 511);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TOP 10 BEST SELLER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 342);
            this.panel2.TabIndex = 1;
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(870, 342);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb12);
            this.panel1.Controls.Add(this.rdb11);
            this.panel1.Controls.Add(this.lblSX1);
            this.panel1.Controls.Add(this.btnTKBestSellInBaoCao);
            this.panel1.Controls.Add(this.lblTo1);
            this.panel1.Controls.Add(this.lblFrom1);
            this.panel1.Controls.Add(this.btnTKBestSellXem);
            this.panel1.Controls.Add(this.dtpTKBestSellTo);
            this.panel1.Controls.Add(this.dtpTKBestSellFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 127);
            this.panel1.TabIndex = 0;
            // 
            // rdb12
            // 
            this.rdb12.AutoSize = true;
            this.rdb12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb12.Location = new System.Drawing.Point(391, 84);
            this.rdb12.Name = "rdb12";
            this.rdb12.Size = new System.Drawing.Size(69, 26);
            this.rdb12.TabIndex = 27;
            this.rdb12.TabStop = true;
            this.rdb12.Text = "ASC";
            this.rdb12.UseVisualStyleBackColor = true;
            // 
            // rdb11
            // 
            this.rdb11.AutoSize = true;
            this.rdb11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb11.Location = new System.Drawing.Point(276, 84);
            this.rdb11.Name = "rdb11";
            this.rdb11.Size = new System.Drawing.Size(81, 26);
            this.rdb11.TabIndex = 26;
            this.rdb11.TabStop = true;
            this.rdb11.Text = "DESC";
            this.rdb11.UseVisualStyleBackColor = true;
            // 
            // lblSX1
            // 
            this.lblSX1.AutoSize = true;
            this.lblSX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSX1.Location = new System.Drawing.Point(35, 86);
            this.lblSX1.Name = "lblSX1";
            this.lblSX1.Size = new System.Drawing.Size(215, 22);
            this.lblSX1.TabIndex = 25;
            this.lblSX1.Text = "SẮP XẾP ( SỐ LƯỢNG):";
            // 
            // btnTKBestSellInBaoCao
            // 
            this.btnTKBestSellInBaoCao.Location = new System.Drawing.Point(644, 81);
            this.btnTKBestSellInBaoCao.Name = "btnTKBestSellInBaoCao";
            this.btnTKBestSellInBaoCao.Size = new System.Drawing.Size(160, 32);
            this.btnTKBestSellInBaoCao.TabIndex = 19;
            this.btnTKBestSellInBaoCao.Text = "IN BÁO CÁO";
            this.btnTKBestSellInBaoCao.UseVisualStyleBackColor = true;
            this.btnTKBestSellInBaoCao.Click += new System.EventHandler(this.btnIN1_Click);
            // 
            // lblTo1
            // 
            this.lblTo1.AutoSize = true;
            this.lblTo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo1.Location = new System.Drawing.Point(357, 31);
            this.lblTo1.Name = "lblTo1";
            this.lblTo1.Size = new System.Drawing.Size(31, 22);
            this.lblTo1.TabIndex = 18;
            this.lblTo1.Text = "To";
            // 
            // lblFrom1
            // 
            this.lblFrom1.AutoSize = true;
            this.lblFrom1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom1.Location = new System.Drawing.Point(35, 29);
            this.lblFrom1.Name = "lblFrom1";
            this.lblFrom1.Size = new System.Drawing.Size(52, 22);
            this.lblFrom1.TabIndex = 17;
            this.lblFrom1.Text = "From";
            // 
            // btnTKBestSellXem
            // 
            this.btnTKBestSellXem.Location = new System.Drawing.Point(644, 24);
            this.btnTKBestSellXem.Name = "btnTKBestSellXem";
            this.btnTKBestSellXem.Size = new System.Drawing.Size(160, 32);
            this.btnTKBestSellXem.TabIndex = 2;
            this.btnTKBestSellXem.Text = "XEM";
            this.btnTKBestSellXem.UseVisualStyleBackColor = true;
            this.btnTKBestSellXem.Click += new System.EventHandler(this.btnXem1_Click);
            // 
            // dtpTKBestSellTo
            // 
            this.dtpTKBestSellTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTKBestSellTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTKBestSellTo.Location = new System.Drawing.Point(408, 22);
            this.dtpTKBestSellTo.Name = "dtpTKBestSellTo";
            this.dtpTKBestSellTo.Size = new System.Drawing.Size(200, 30);
            this.dtpTKBestSellTo.TabIndex = 1;
            // 
            // dtpTKBestSellFrom
            // 
            this.dtpTKBestSellFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTKBestSellFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTKBestSellFrom.Location = new System.Drawing.Point(113, 20);
            this.dtpTKBestSellFrom.Name = "dtpTKBestSellFrom";
            this.dtpTKBestSellFrom.Size = new System.Drawing.Size(200, 30);
            this.dtpTKBestSellFrom.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(876, 475);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "HÓA ĐƠN BÁN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgv2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(876, 356);
            this.panel6.TabIndex = 1;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv2.Location = new System.Drawing.Point(0, 0);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(876, 356);
            this.dgv2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.btnTKHDBNInBaoCao);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cbTKHDBTenNV);
            this.panel5.Controls.Add(this.rdb22);
            this.panel5.Controls.Add(this.rdb21);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnTKHDBXem);
            this.panel5.Controls.Add(this.dtpTKHDBTo);
            this.panel5.Controls.Add(this.dtpTKHDBFrom);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(876, 119);
            this.panel5.TabIndex = 0;
            // 
            // btnTKHDBNInBaoCao
            // 
            this.btnTKHDBNInBaoCao.Location = new System.Drawing.Point(637, 66);
            this.btnTKHDBNInBaoCao.Name = "btnTKHDBNInBaoCao";
            this.btnTKHDBNInBaoCao.Size = new System.Drawing.Size(191, 33);
            this.btnTKHDBNInBaoCao.TabIndex = 27;
            this.btnTKHDBNInBaoCao.Text = "IN BÁO CÁO";
            this.btnTKHDBNInBaoCao.UseVisualStyleBackColor = true;
            this.btnTKHDBNInBaoCao.Click += new System.EventHandler(this.btnIN2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "TÊN NV:";
            // 
            // cbTKHDBTenNV
            // 
            this.cbTKHDBTenNV.FormattingEnabled = true;
            this.cbTKHDBTenNV.Location = new System.Drawing.Point(158, 127);
            this.cbTKHDBTenNV.Name = "cbTKHDBTenNV";
            this.cbTKHDBTenNV.Size = new System.Drawing.Size(381, 31);
            this.cbTKHDBTenNV.TabIndex = 25;
            // 
            // rdb22
            // 
            this.rdb22.AutoSize = true;
            this.rdb22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb22.Location = new System.Drawing.Point(476, 73);
            this.rdb22.Name = "rdb22";
            this.rdb22.Size = new System.Drawing.Size(69, 26);
            this.rdb22.TabIndex = 24;
            this.rdb22.TabStop = true;
            this.rdb22.Text = "ASC";
            this.rdb22.UseVisualStyleBackColor = true;
            // 
            // rdb21
            // 
            this.rdb21.AutoSize = true;
            this.rdb21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb21.Location = new System.Drawing.Point(348, 71);
            this.rdb21.Name = "rdb21";
            this.rdb21.Size = new System.Drawing.Size(81, 26);
            this.rdb21.TabIndex = 23;
            this.rdb21.TabStop = true;
            this.rdb21.Text = "DESC";
            this.rdb21.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "SẮP XẾP ( THEO TỔNG TIỀN ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "ĐẾN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "TỪ";
            // 
            // btnTKHDBXem
            // 
            this.btnTKHDBXem.Location = new System.Drawing.Point(637, 18);
            this.btnTKHDBXem.Name = "btnTKHDBXem";
            this.btnTKHDBXem.Size = new System.Drawing.Size(191, 35);
            this.btnTKHDBXem.TabIndex = 17;
            this.btnTKHDBXem.Text = "XEM";
            this.btnTKHDBXem.UseVisualStyleBackColor = true;
            this.btnTKHDBXem.Click += new System.EventHandler(this.btnXem2_Click);
            // 
            // dtpTKHDBTo
            // 
            this.dtpTKHDBTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTKHDBTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTKHDBTo.Location = new System.Drawing.Point(348, 21);
            this.dtpTKHDBTo.Name = "dtpTKHDBTo";
            this.dtpTKHDBTo.Size = new System.Drawing.Size(200, 30);
            this.dtpTKHDBTo.TabIndex = 16;
            // 
            // dtpTKHDBFrom
            // 
            this.dtpTKHDBFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTKHDBFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTKHDBFrom.Location = new System.Drawing.Point(84, 21);
            this.dtpTKHDBFrom.Name = "dtpTKHDBFrom";
            this.dtpTKHDBFrom.Size = new System.Drawing.Size(200, 30);
            this.dtpTKHDBFrom.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnBOTTOM3);
            this.tabPage3.Controls.Add(this.pnTOP3);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 475);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "HÓA ĐƠN NHẬP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnBOTTOM3
            // 
            this.pnBOTTOM3.Controls.Add(this.dgv3);
            this.pnBOTTOM3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBOTTOM3.Location = new System.Drawing.Point(3, 123);
            this.pnBOTTOM3.Name = "pnBOTTOM3";
            this.pnBOTTOM3.Size = new System.Drawing.Size(870, 349);
            this.pnBOTTOM3.TabIndex = 1;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv3.Location = new System.Drawing.Point(0, 0);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.Size = new System.Drawing.Size(870, 349);
            this.dgv3.TabIndex = 0;
            // 
            // pnTOP3
            // 
            this.pnTOP3.AutoScroll = true;
            this.pnTOP3.Controls.Add(this.btnTKHDNInBaoCao);
            this.pnTOP3.Controls.Add(this.lblNL3);
            this.pnTOP3.Controls.Add(this.cbTKHDNTenNV);
            this.pnTOP3.Controls.Add(this.rdb32);
            this.pnTOP3.Controls.Add(this.rdb31);
            this.pnTOP3.Controls.Add(this.lblSX3);
            this.pnTOP3.Controls.Add(this.lblTo3);
            this.pnTOP3.Controls.Add(this.lblFrom3);
            this.pnTOP3.Controls.Add(this.btnTKHDNXem);
            this.pnTOP3.Controls.Add(this.dtpTKHDNTo);
            this.pnTOP3.Controls.Add(this.dtpTKHDNFrom);
            this.pnTOP3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTOP3.Location = new System.Drawing.Point(3, 3);
            this.pnTOP3.Name = "pnTOP3";
            this.pnTOP3.Size = new System.Drawing.Size(870, 120);
            this.pnTOP3.TabIndex = 0;
            // 
            // btnTKHDNInBaoCao
            // 
            this.btnTKHDNInBaoCao.Location = new System.Drawing.Point(630, 69);
            this.btnTKHDNInBaoCao.Name = "btnTKHDNInBaoCao";
            this.btnTKHDNInBaoCao.Size = new System.Drawing.Size(191, 35);
            this.btnTKHDNInBaoCao.TabIndex = 20;
            this.btnTKHDNInBaoCao.Text = "IN BÁO CÁO";
            this.btnTKHDNInBaoCao.UseVisualStyleBackColor = true;
            // 
            // lblNL3
            // 
            this.lblNL3.AutoSize = true;
            this.lblNL3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNL3.Location = new System.Drawing.Point(32, 125);
            this.lblNL3.Name = "lblNL3";
            this.lblNL3.Size = new System.Drawing.Size(85, 22);
            this.lblNL3.TabIndex = 14;
            this.lblNL3.Text = "TÊN NV:";
            // 
            // cbTKHDNTenNV
            // 
            this.cbTKHDNTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTKHDNTenNV.FormattingEnabled = true;
            this.cbTKHDNTenNV.Location = new System.Drawing.Point(142, 117);
            this.cbTKHDNTenNV.Name = "cbTKHDNTenNV";
            this.cbTKHDNTenNV.Size = new System.Drawing.Size(381, 30);
            this.cbTKHDNTenNV.TabIndex = 13;
            // 
            // rdb32
            // 
            this.rdb32.AutoSize = true;
            this.rdb32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb32.Location = new System.Drawing.Point(472, 78);
            this.rdb32.Name = "rdb32";
            this.rdb32.Size = new System.Drawing.Size(69, 26);
            this.rdb32.TabIndex = 12;
            this.rdb32.TabStop = true;
            this.rdb32.Text = "ASC";
            this.rdb32.UseVisualStyleBackColor = true;
            // 
            // rdb31
            // 
            this.rdb31.AutoSize = true;
            this.rdb31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb31.Location = new System.Drawing.Point(379, 78);
            this.rdb31.Name = "rdb31";
            this.rdb31.Size = new System.Drawing.Size(81, 26);
            this.rdb31.TabIndex = 11;
            this.rdb31.TabStop = true;
            this.rdb31.Text = "DESC";
            this.rdb31.UseVisualStyleBackColor = true;
            // 
            // lblSX3
            // 
            this.lblSX3.AutoSize = true;
            this.lblSX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSX3.Location = new System.Drawing.Point(32, 82);
            this.lblSX3.Name = "lblSX3";
            this.lblSX3.Size = new System.Drawing.Size(341, 22);
            this.lblSX3.TabIndex = 9;
            this.lblSX3.Text = "SẮP XẾP ( THEO TRỊ GIÁ HÓA ĐƠN ):";
            // 
            // lblTo3
            // 
            this.lblTo3.AutoSize = true;
            this.lblTo3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo3.Location = new System.Drawing.Point(283, 32);
            this.lblTo3.Name = "lblTo3";
            this.lblTo3.Size = new System.Drawing.Size(50, 22);
            this.lblTo3.TabIndex = 7;
            this.lblTo3.Text = "ĐẾN";
            // 
            // lblFrom3
            // 
            this.lblFrom3.AutoSize = true;
            this.lblFrom3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom3.Location = new System.Drawing.Point(32, 33);
            this.lblFrom3.Name = "lblFrom3";
            this.lblFrom3.Size = new System.Drawing.Size(38, 22);
            this.lblFrom3.TabIndex = 6;
            this.lblFrom3.Text = "TỪ";
            // 
            // btnTKHDNXem
            // 
            this.btnTKHDNXem.Location = new System.Drawing.Point(630, 20);
            this.btnTKHDNXem.Name = "btnTKHDNXem";
            this.btnTKHDNXem.Size = new System.Drawing.Size(191, 35);
            this.btnTKHDNXem.TabIndex = 5;
            this.btnTKHDNXem.Text = "XEM";
            this.btnTKHDNXem.UseVisualStyleBackColor = true;
            this.btnTKHDNXem.Click += new System.EventHandler(this.btnXem3_Click);
            // 
            // dtpTKHDNTo
            // 
            this.dtpTKHDNTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTKHDNTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTKHDNTo.Location = new System.Drawing.Point(341, 23);
            this.dtpTKHDNTo.Name = "dtpTKHDNTo";
            this.dtpTKHDNTo.Size = new System.Drawing.Size(200, 30);
            this.dtpTKHDNTo.TabIndex = 4;
            // 
            // dtpTKHDNFrom
            // 
            this.dtpTKHDNFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTKHDNFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTKHDNFrom.Location = new System.Drawing.Point(77, 23);
            this.dtpTKHDNFrom.Name = "dtpTKHDNFrom";
            this.dtpTKHDNFrom.Size = new System.Drawing.Size(200, 30);
            this.dtpTKHDNFrom.TabIndex = 3;
            // 
            // ucThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(923, 532);
            this.Load += new System.EventHandler(this.ucThongKe_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.pnBOTTOM3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.pnTOP3.ResumeLayout(false);
            this.pnTOP3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTKBestSellXem;
        private System.Windows.Forms.DateTimePicker dtpTKBestSellTo;
        private System.Windows.Forms.DateTimePicker dtpTKBestSellFrom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnBOTTOM3;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Panel pnTOP3;
        private System.Windows.Forms.RadioButton rdb32;
        private System.Windows.Forms.RadioButton rdb31;
        private System.Windows.Forms.Label lblSX3;
        private System.Windows.Forms.Label lblTo3;
        private System.Windows.Forms.Label lblFrom3;
        private System.Windows.Forms.Button btnTKHDNXem;
        private System.Windows.Forms.DateTimePicker dtpTKHDNTo;
        private System.Windows.Forms.DateTimePicker dtpTKHDNFrom;
        private System.Windows.Forms.ComboBox cbTKHDNTenNV;
        private System.Windows.Forms.Label lblNL3;
        private System.Windows.Forms.Label lblTo1;
        private System.Windows.Forms.Label lblFrom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTKHDBTenNV;
        private System.Windows.Forms.RadioButton rdb22;
        private System.Windows.Forms.RadioButton rdb21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTKHDBXem;
        private System.Windows.Forms.DateTimePicker dtpTKHDBTo;
        private System.Windows.Forms.DateTimePicker dtpTKHDBFrom;
        private System.Windows.Forms.Button btnTKBestSellInBaoCao;
        private System.Windows.Forms.RadioButton rdb12;
        private System.Windows.Forms.RadioButton rdb11;
        private System.Windows.Forms.Label lblSX1;
        private System.Windows.Forms.Button btnTKHDBNInBaoCao;
        private System.Windows.Forms.Button btnTKHDNInBaoCao;
    }
}
