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

namespace quan_ly_thu_cung.GUI.HoaDon
{
    public partial class LichSuHoaDon : UserControl
    {
        public LichSuHoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string chuoiKetNoi = @"Data Source=.\SQLEXPRESS; Initial Catalog=QuanLyThuCung; Integrated Security=True";
        SqlConnection conn = null;

        private void LichSuHoaDon_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiKetNoi);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = @"
    SELECT
        hd.MaHoaDon,
        kh.HoTen,
        tc.TenThuCung,
        hd.NgayLap,
        hd.TongTien
    FROM HoaDon hd
    JOIN KhachHang kh
        ON hd.MaKhachHang = kh.MaKhachHang
    JOIN ThuCung tc
        ON hd.MaThuCung = tc.MaThuCung
    ORDER BY hd.NgayLap DESC";

            SqlDataAdapter da =
                new SqlDataAdapter(sql, conn);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
