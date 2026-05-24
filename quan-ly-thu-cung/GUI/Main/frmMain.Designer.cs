namespace quan_ly_thu_cung.GUI.Main
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dashboard1 = new quan_ly_thu_cung.GUI.Main.Dashboard();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.khachhang1 = new quan_ly_thu_cung.GUI.Khach_Hang.khachhang();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.thu_Cung2 = new quan_ly_thu_cung.GUI.Thu_Cung.Thu_Cung();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dichVu1 = new quan_ly_thu_cung.GUI.DichVu.DichVu();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.hoaDon1 = new quan_ly_thu_cung.GUI.HoaDon.HoaDon();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dashboard1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1034, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chủ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(4, 4);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1026, 506);
            this.dashboard1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.khachhang1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1034, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khách Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // khachhang1
            // 
            this.khachhang1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khachhang1.Location = new System.Drawing.Point(4, 4);
            this.khachhang1.Name = "khachhang1";
            this.khachhang1.Size = new System.Drawing.Size(964, 506);
            this.khachhang1.TabIndex = 0;
            this.khachhang1.Load += new System.EventHandler(this.khachhang1_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.thu_Cung2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1034, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thú Cưng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dichVu1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1034, 514);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dịch Vụ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dichVu1
            // 
            this.dichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dichVu1.Location = new System.Drawing.Point(4, 4);
            this.dichVu1.Name = "dichVu1";
            this.dichVu1.Size = new System.Drawing.Size(1026, 506);
            this.dichVu1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.hoaDon1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1034, 514);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hoá Đơn";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // hoaDon1
            // 
            this.hoaDon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoaDon1.Location = new System.Drawing.Point(4, 4);
            this.hoaDon1.Name = "hoaDon1";
            this.hoaDon1.Size = new System.Drawing.Size(1026, 506);
            this.hoaDon1.TabIndex = 0;
            // 
            // thu_Cung2
            // 
            this.thu_Cung2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thu_Cung2.Location = new System.Drawing.Point(4, 4);
            this.thu_Cung2.Name = "thu_Cung2";
            this.thu_Cung2.Size = new System.Drawing.Size(1026, 506);
            this.thu_Cung2.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 543);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Dashboard dashboard1;
        private Khach_Hang.khachhang khachhang1;
        private Thu_Cung.Thu_Cung thu_Cung2;
        private DichVu.DichVu dichVu1;
        private HoaDon.HoaDon hoaDon1;
    }
}