namespace quan_ly_thu_cung.GUI.Khach_Hang
{
    partial class khachhang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTieuChi = new System.Windows.Forms.ComboBox();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 3);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(990, 267);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(453, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(53, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(453, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMaKhachHang.Location = new System.Drawing.Point(205, 21);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(152, 31);
            this.txtMaKhachHang.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(205, 76);
            this.txtSoDienThoai.Multiline = true;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(152, 31);
            this.txtSoDienThoai.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtHoTen.Location = new System.Drawing.Point(533, 21);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(378, 31);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDiaChi.Location = new System.Drawing.Point(533, 76);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(378, 31);
            this.txtDiaChi.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.cboTieuChi);
            this.panel1.Controls.Add(this.BtnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtSoDienThoai);
            this.panel1.Controls.Add(this.txtMaKhachHang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel1.Location = new System.Drawing.Point(27, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 267);
            this.panel1.TabIndex = 1;
            // 
            // cboTieuChi
            // 
            this.cboTieuChi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboTieuChi.FormattingEnabled = true;
            this.cboTieuChi.Items.AddRange(new object[] {
            "Tìm tất cả",
            "Họ Tên",
            "Số điện thoại"});
            this.cboTieuChi.Location = new System.Drawing.Point(145, 208);
            this.cboTieuChi.Name = "cboTieuChi";
            this.cboTieuChi.Size = new System.Drawing.Size(148, 30);
            this.cboTieuChi.TabIndex = 13;
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnTimKiem.Location = new System.Drawing.Point(736, 204);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(111, 39);
            this.BtnTimKiem.TabIndex = 12;
            this.BtnTimKiem.Text = "Tìm kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = false;
            this.BtnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTimKiem.Location = new System.Drawing.Point(299, 208);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(431, 31);
            this.txtTimKiem.TabIndex = 11;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSua.Location = new System.Drawing.Point(416, 137);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 36);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.txtXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtXoa.Location = new System.Drawing.Point(533, 137);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(100, 36);
            this.txtXoa.TabIndex = 9;
            this.txtXoa.Text = "Xóa";
            this.txtXoa.UseVisualStyleBackColor = false;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnThem.Location = new System.Drawing.Point(299, 137);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 36);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvKhachHang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 546);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "khachhang";
            this.Size = new System.Drawing.Size(996, 546);
            this.Load += new System.EventHandler(this.khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.ComboBox cboTieuChi;
    }
}
