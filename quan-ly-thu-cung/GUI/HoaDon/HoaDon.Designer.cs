namespace quan_ly_thu_cung.GUI.HoaDon
{
    partial class HoaDon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKhachHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxThuCung = new System.Windows.Forms.ComboBox();
            this.comboBoxDichVu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericSL = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvDichVu);
            this.panel2.Location = new System.Drawing.Point(4, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 267);
            this.panel2.TabIndex = 1;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu,
            this.TenDichVu,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien,
            this.xoa});
            this.dgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.Size = new System.Drawing.Size(971, 267);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xoaCell);
            // 
            // MaDichVu
            // 
            this.MaDichVu.HeaderText = "Mã DV";
            this.MaDichVu.MinimumWidth = 6;
            this.MaDichVu.Name = "MaDichVu";
            // 
            // TenDichVu
            // 
            this.TenDichVu.HeaderText = "Tên DV";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xoá";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.Text = "Xoá";
            this.xoa.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.labelTongTien);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(30, 444);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 87);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(629, 41);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 42);
            this.button3.TabIndex = 20;
            this.button3.Text = "In hoá đơn";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(768, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "Lập hoá đơn";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 157);
            this.panel1.TabIndex = 0;
            // 
            // labelTongTien
            // 
            this.labelTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTongTien.Location = new System.Drawing.Point(4, 52);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(106, 20);
            this.labelTongTien.TabIndex = 22;
            this.labelTongTien.Text = "Tổng: 0 VND";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(5, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Đã chọn: 0";
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonThem.Location = new System.Drawing.Point(852, 75);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(113, 75);
            this.buttonThem.TabIndex = 27;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.numericSL);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBoxKhachHang);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboBoxThuCung);
            this.panel4.Controls.Add(this.comboBoxDichVu);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(842, 129);
            this.panel4.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Khách hàng:";
            // 
            // comboBoxKhachHang
            // 
            this.comboBoxKhachHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxKhachHang.FormattingEnabled = true;
            this.comboBoxKhachHang.Location = new System.Drawing.Point(152, 9);
            this.comboBoxKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKhachHang.Name = "comboBoxKhachHang";
            this.comboBoxKhachHang.Size = new System.Drawing.Size(446, 30);
            this.comboBoxKhachHang.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thú Cưng:";
            // 
            // comboBoxThuCung
            // 
            this.comboBoxThuCung.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxThuCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxThuCung.FormattingEnabled = true;
            this.comboBoxThuCung.Location = new System.Drawing.Point(152, 51);
            this.comboBoxThuCung.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxThuCung.Name = "comboBoxThuCung";
            this.comboBoxThuCung.Size = new System.Drawing.Size(446, 30);
            this.comboBoxThuCung.TabIndex = 20;
            // 
            // comboBoxDichVu
            // 
            this.comboBoxDichVu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxDichVu.FormattingEnabled = true;
            this.comboBoxDichVu.Location = new System.Drawing.Point(152, 94);
            this.comboBoxDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDichVu.Name = "comboBoxDichVu";
            this.comboBoxDichVu.Size = new System.Drawing.Size(446, 30);
            this.comboBoxDichVu.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Thêm dịch vu:";
            // 
            // numericSL
            // 
            this.numericSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericSL.Location = new System.Drawing.Point(710, 95);
            this.numericSL.Margin = new System.Windows.Forms.Padding(4);
            this.numericSL.Name = "numericSL";
            this.numericSL.Size = new System.Drawing.Size(88, 28);
            this.numericSL.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(613, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số lượng:";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(979, 550);
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxThuCung;
        private System.Windows.Forms.ComboBox comboBoxDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.NumericUpDown numericSL;
        private System.Windows.Forms.Label label5;
    }
}
