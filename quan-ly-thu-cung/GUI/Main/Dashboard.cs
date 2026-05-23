using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_thu_cung.GUI.Main
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
          
        } 
        public void NapDuLieuVaoBtn(int slKH, int slThuCung, int slDichVu, int slHoaDon) {
            btnKhachHang.Text = slKH.ToString() + " " + "Khách Hàng";
            btnThuCung.Text = slThuCung.ToString() + " " + "Thú Cưng";
            btnDichVu.Text = slDichVu.ToString() + " " + "Dịch Vụ";
            btnHoaDon.Text = slHoaDon.ToString() + " " + "Hoá Đơn";
        }
    }
}
