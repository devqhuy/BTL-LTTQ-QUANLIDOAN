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
            this.btnXem1 = new System.Windows.Forms.Button();
            this.dtpTo1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpXem3 = new System.Windows.Forms.Button();
            this.dtpTo2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom2 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnTOP3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpTo3 = new System.Windows.Forms.DateTimePicker();
            this.dtpForm32 = new System.Windows.Forms.DateTimePicker();
            this.lblFrom3 = new System.Windows.Forms.Label();
            this.lblTo3 = new System.Windows.Forms.Label();
            this.lblNV3 = new System.Windows.Forms.Label();
            this.lblSX3 = new System.Windows.Forms.Label();
            this.txtNV3 = new System.Windows.Forms.TextBox();
            this.rdb31 = new System.Windows.Forms.RadioButton();
            this.rdb32 = new System.Windows.Forms.RadioButton();
            this.pnBOTTOM3 = new System.Windows.Forms.Panel();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.cmbNL3 = new System.Windows.Forms.ComboBox();
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
            this.pnTOP3.SuspendLayout();
            this.pnBOTTOM3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(3, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 375);
            this.panel2.TabIndex = 1;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(870, 375);
            this.dgv1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXem1);
            this.panel1.Controls.Add(this.dtpTo1);
            this.panel1.Controls.Add(this.dtpFrom1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnXem1
            // 
            this.btnXem1.Location = new System.Drawing.Point(686, 31);
            this.btnXem1.Name = "btnXem1";
            this.btnXem1.Size = new System.Drawing.Size(118, 32);
            this.btnXem1.TabIndex = 2;
            this.btnXem1.Text = "XEM";
            this.btnXem1.UseVisualStyleBackColor = true;
            // 
            // dtpTo1
            // 
            this.dtpTo1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo1.Location = new System.Drawing.Point(352, 31);
            this.dtpTo1.Name = "dtpTo1";
            this.dtpTo1.Size = new System.Drawing.Size(200, 32);
            this.dtpTo1.TabIndex = 1;
            // 
            // dtpFrom1
            // 
            this.dtpFrom1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom1.Location = new System.Drawing.Point(40, 31);
            this.dtpFrom1.Name = "dtpFrom1";
            this.dtpFrom1.Size = new System.Drawing.Size(200, 32);
            this.dtpFrom1.TabIndex = 0;
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
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(876, 375);
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
            this.dgv2.Size = new System.Drawing.Size(876, 375);
            this.dgv2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpXem3);
            this.panel5.Controls.Add(this.dtpTo2);
            this.panel5.Controls.Add(this.dtpFrom2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(876, 100);
            this.panel5.TabIndex = 0;
            // 
            // dtpXem3
            // 
            this.dtpXem3.Location = new System.Drawing.Point(686, 31);
            this.dtpXem3.Name = "dtpXem3";
            this.dtpXem3.Size = new System.Drawing.Size(118, 35);
            this.dtpXem3.TabIndex = 2;
            this.dtpXem3.Text = "XEM";
            this.dtpXem3.UseVisualStyleBackColor = true;
            // 
            // dtpTo2
            // 
            this.dtpTo2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo2.Location = new System.Drawing.Point(43, 34);
            this.dtpTo2.Name = "dtpTo2";
            this.dtpTo2.Size = new System.Drawing.Size(200, 32);
            this.dtpTo2.TabIndex = 1;
            // 
            // dtpFrom2
            // 
            this.dtpFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom2.Location = new System.Drawing.Point(346, 31);
            this.dtpFrom2.Name = "dtpFrom2";
            this.dtpFrom2.Size = new System.Drawing.Size(200, 32);
            this.dtpFrom2.TabIndex = 0;
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
            // pnTOP3
            // 
            this.pnTOP3.AutoScroll = true;
            this.pnTOP3.Controls.Add(this.cmbNL3);
            this.pnTOP3.Controls.Add(this.rdb32);
            this.pnTOP3.Controls.Add(this.rdb31);
            this.pnTOP3.Controls.Add(this.txtNV3);
            this.pnTOP3.Controls.Add(this.lblSX3);
            this.pnTOP3.Controls.Add(this.lblNV3);
            this.pnTOP3.Controls.Add(this.lblTo3);
            this.pnTOP3.Controls.Add(this.lblFrom3);
            this.pnTOP3.Controls.Add(this.button1);
            this.pnTOP3.Controls.Add(this.dtpTo3);
            this.pnTOP3.Controls.Add(this.dtpForm32);
            this.pnTOP3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTOP3.Location = new System.Drawing.Point(3, 3);
            this.pnTOP3.Name = "pnTOP3";
            this.pnTOP3.Size = new System.Drawing.Size(870, 249);
            this.pnTOP3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "XEM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpTo3
            // 
            this.dtpTo3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo3.Location = new System.Drawing.Point(341, 23);
            this.dtpTo3.Name = "dtpTo3";
            this.dtpTo3.Size = new System.Drawing.Size(200, 32);
            this.dtpTo3.TabIndex = 4;
            // 
            // dtpForm32
            // 
            this.dtpForm32.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpForm32.Location = new System.Drawing.Point(77, 23);
            this.dtpForm32.Name = "dtpForm32";
            this.dtpForm32.Size = new System.Drawing.Size(200, 32);
            this.dtpForm32.TabIndex = 3;
            // 
            // lblFrom3
            // 
            this.lblFrom3.AutoSize = true;
            this.lblFrom3.Location = new System.Drawing.Point(41, 32);
            this.lblFrom3.Name = "lblFrom3";
            this.lblFrom3.Size = new System.Drawing.Size(30, 23);
            this.lblFrom3.TabIndex = 6;
            this.lblFrom3.Text = "TỪ";
            // 
            // lblTo3
            // 
            this.lblTo3.AutoSize = true;
            this.lblTo3.Location = new System.Drawing.Point(283, 32);
            this.lblTo3.Name = "lblTo3";
            this.lblTo3.Size = new System.Drawing.Size(52, 23);
            this.lblTo3.TabIndex = 7;
            this.lblTo3.Text = "ĐẾN";
            // 
            // lblNV3
            // 
            this.lblNV3.AutoSize = true;
            this.lblNV3.Location = new System.Drawing.Point(41, 82);
            this.lblNV3.Name = "lblNV3";
            this.lblNV3.Size = new System.Drawing.Size(85, 23);
            this.lblNV3.TabIndex = 8;
            this.lblNV3.Text = "TÊN NV:";
            // 
            // lblSX3
            // 
            this.lblSX3.AutoSize = true;
            this.lblSX3.Location = new System.Drawing.Point(41, 128);
            this.lblSX3.Name = "lblSX3";
            this.lblSX3.Size = new System.Drawing.Size(346, 23);
            this.lblSX3.TabIndex = 9;
            this.lblSX3.Text = "SẮP XẾP ( THEO TRỊ GIÁ HÓA ĐƠN ):";
            // 
            // txtNV3
            // 
            this.txtNV3.Location = new System.Drawing.Point(151, 73);
            this.txtNV3.Name = "txtNV3";
            this.txtNV3.Size = new System.Drawing.Size(381, 32);
            this.txtNV3.TabIndex = 10;
            // 
            // rdb31
            // 
            this.rdb31.AutoSize = true;
            this.rdb31.Location = new System.Drawing.Point(406, 126);
            this.rdb31.Name = "rdb31";
            this.rdb31.Size = new System.Drawing.Size(83, 27);
            this.rdb31.TabIndex = 11;
            this.rdb31.TabStop = true;
            this.rdb31.Text = "DESC";
            this.rdb31.UseVisualStyleBackColor = true;
            // 
            // rdb32
            // 
            this.rdb32.AutoSize = true;
            this.rdb32.Location = new System.Drawing.Point(618, 126);
            this.rdb32.Name = "rdb32";
            this.rdb32.Size = new System.Drawing.Size(72, 27);
            this.rdb32.TabIndex = 12;
            this.rdb32.TabStop = true;
            this.rdb32.Text = "ASC";
            this.rdb32.UseVisualStyleBackColor = true;
            // 
            // pnBOTTOM3
            // 
            this.pnBOTTOM3.Controls.Add(this.dgv3);
            this.pnBOTTOM3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBOTTOM3.Location = new System.Drawing.Point(3, 293);
            this.pnBOTTOM3.Name = "pnBOTTOM3";
            this.pnBOTTOM3.Size = new System.Drawing.Size(870, 179);
            this.pnBOTTOM3.TabIndex = 1;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv3.Location = new System.Drawing.Point(0, 2);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.Size = new System.Drawing.Size(870, 177);
            this.dgv3.TabIndex = 0;
            // 
            // cmbNL3
            // 
            this.cmbNL3.FormattingEnabled = true;
            this.cmbNL3.Location = new System.Drawing.Point(45, 175);
            this.cmbNL3.Name = "cmbNL3";
            this.cmbNL3.Size = new System.Drawing.Size(272, 31);
            this.cmbNL3.TabIndex = 13;
            // 
            // ucThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(923, 532);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnTOP3.ResumeLayout(false);
            this.pnTOP3.PerformLayout();
            this.pnBOTTOM3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem1;
        private System.Windows.Forms.DateTimePicker dtpTo1;
        private System.Windows.Forms.DateTimePicker dtpFrom1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button dtpXem3;
        private System.Windows.Forms.DateTimePicker dtpTo2;
        private System.Windows.Forms.DateTimePicker dtpFrom2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnBOTTOM3;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Panel pnTOP3;
        private System.Windows.Forms.RadioButton rdb32;
        private System.Windows.Forms.RadioButton rdb31;
        private System.Windows.Forms.TextBox txtNV3;
        private System.Windows.Forms.Label lblSX3;
        private System.Windows.Forms.Label lblNV3;
        private System.Windows.Forms.Label lblTo3;
        private System.Windows.Forms.Label lblFrom3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpTo3;
        private System.Windows.Forms.DateTimePicker dtpForm32;
        private System.Windows.Forms.ComboBox cmbNL3;
    }
}
