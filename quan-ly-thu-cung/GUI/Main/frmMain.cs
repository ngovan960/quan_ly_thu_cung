using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_thu_cung.GUI.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = @"Data Source=.\SQLEXPRESS; Initial Catalog=QuanLyThuCung; Integrated Security=True";
        SqlConnection conn = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;
            conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            truyenDuLieuDashboard();
        }
        // Dashboard
        private void truyenDuLieuDashboard()
        {
            if(conn.State == ConnectionState.Closed) {
                conn.Open();
            }
            int slKH = 0, slThuCung = 0,slDichVu = 0,slHoaDon = 0;
            string sqlKH = "SELECT COUNT(*) FROM KhachHang";
            SqlCommand cmdKH = new SqlCommand(sqlKH, conn);
            slKH = (int)cmdKH.ExecuteScalar();

            string sqlThuCung = "SELECT COUNT(*) FROM ThuCung";
            SqlCommand cmdTC = new SqlCommand(sqlThuCung, conn);
            slThuCung = (int)cmdTC.ExecuteScalar();

            string sqlDichVu = "SELECT COUNT(*) FROM DichVu";
            SqlCommand cmdDv = new SqlCommand(sqlDichVu, conn);
            slDichVu = (int)cmdDv.ExecuteScalar();

            string sqlHoaDon = "SELECT COUNT(*) FROM HoaDon";
            SqlCommand cmdHoaDon = new SqlCommand(sqlHoaDon, conn);
            slHoaDon = (int)cmdHoaDon.ExecuteScalar();
            dashboard1.NapDuLieuVaoBtn(slKH, slThuCung, slDichVu, slHoaDon);

        }
        // DichVu
        private void LoadDataDichVu()
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
