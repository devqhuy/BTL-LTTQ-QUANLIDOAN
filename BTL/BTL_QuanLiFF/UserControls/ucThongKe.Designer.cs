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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnXemTop10 = new System.Windows.Forms.Button();
            this.dgvTop10 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.btnXemHDN = new System.Windows.Forms.Button();
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.btnXemHDB = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(884, 500);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TOP 10 BEST SELLER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HÓA ĐƠN NHẬP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(876, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HÓA ĐƠN BÁN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemTop10);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 94);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTop10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 364);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(578, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btnXemTop10
            // 
            this.btnXemTop10.Location = new System.Drawing.Point(364, 32);
            this.btnXemTop10.Name = "btnXemTop10";
            this.btnXemTop10.Size = new System.Drawing.Size(118, 32);
            this.btnXemTop10.TabIndex = 2;
            this.btnXemTop10.Text = "XEM";
            this.btnXemTop10.UseVisualStyleBackColor = true;
            // 
            // dgvTop10
            // 
            this.dgvTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTop10.Location = new System.Drawing.Point(0, 0);
            this.dgvTop10.Name = "dgvTop10";
            this.dgvTop10.RowHeadersWidth = 51;
            this.dgvTop10.RowTemplate.Height = 24;
            this.dgvTop10.Size = new System.Drawing.Size(870, 364);
            this.dgvTop10.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXemHDN);
            this.panel3.Controls.Add(this.dateTimePicker4);
            this.panel3.Controls.Add(this.dateTimePicker3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 94);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvHDN);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 364);
            this.panel4.TabIndex = 1;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(36, 30);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker3.TabIndex = 0;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(584, 30);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker4.TabIndex = 1;
            // 
            // btnXemHDN
            // 
            this.btnXemHDN.Location = new System.Drawing.Point(351, 30);
            this.btnXemHDN.Name = "btnXemHDN";
            this.btnXemHDN.Size = new System.Drawing.Size(118, 32);
            this.btnXemHDN.TabIndex = 2;
            this.btnXemHDN.Text = "XEM";
            this.btnXemHDN.UseVisualStyleBackColor = true;
            // 
            // dgvHDN
            // 
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDN.Location = new System.Drawing.Point(0, 0);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.RowHeadersWidth = 51;
            this.dgvHDN.RowTemplate.Height = 24;
            this.dgvHDN.Size = new System.Drawing.Size(870, 364);
            this.dgvHDN.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXemHDB);
            this.panel5.Controls.Add(this.dateTimePicker6);
            this.panel5.Controls.Add(this.dateTimePicker5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(876, 100);
            this.panel5.TabIndex = 0;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(59, 33);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker5.TabIndex = 0;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(591, 33);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker6.TabIndex = 1;
            // 
            // btnXemHDB
            // 
            this.btnXemHDB.Location = new System.Drawing.Point(366, 33);
            this.btnXemHDB.Name = "btnXemHDB";
            this.btnXemHDB.Size = new System.Drawing.Size(118, 32);
            this.btnXemHDB.TabIndex = 2;
            this.btnXemHDB.Text = "XEM";
            this.btnXemHDB.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvHDB);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(876, 364);
            this.panel6.TabIndex = 1;
            // 
            // dgvHDB
            // 
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDB.Location = new System.Drawing.Point(0, 0);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.RowHeadersWidth = 51;
            this.dgvHDB.RowTemplate.Height = 24;
            this.dgvHDB.Size = new System.Drawing.Size(876, 364);
            this.dgvHDB.TabIndex = 0;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTop10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemTop10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXemHDN;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXemHDB;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvHDB;
    }
}
