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
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = @"Data Source=.\SQLEXPRESS; Initial Catalog=QuanLyThuCung; Integrated Security=True";
        SqlConnection conn = null;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Load form

        private void HoaDon_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiKetNoi);
            loadKhachHang();
            loadDichVu();
        }

        // Load khách hàng vào comboBox
        private void loadKhachHang()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string sql = "SELECT MaKhachHang, HoTen, SoDienThoai FROM KhachHang";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dt.Columns.Add("HienThi");
            foreach (DataRow row in dt.Rows)
            {
                row["HienThi"] = row["MaKhachHang"].ToString() + " - " + row["HoTen"].ToString() + " - " + row["SoDienThoai"].ToString();
            }
            comboBoxKhachHang.DataSource = dt;
            comboBoxKhachHang.DisplayMember = "HienThi";
            comboBoxKhachHang.ValueMember = "MaKhachHang";


            comboBoxKhachHang.AutoCompleteMode =
        AutoCompleteMode.SuggestAppend;

            comboBoxKhachHang.AutoCompleteSource =
                AutoCompleteSource.ListItems;
        }


        private void load(object sender, EventArgs e)
        {
            
        }
        // Load thú cưng vào comboBox theo khách hàng

        private void loadThuCungTheoKH(object sender, EventArgs e)
        {
            if(comboBoxKhachHang.SelectedValue != null)
            {
                string maKH = comboBoxKhachHang.SelectedValue.ToString();
                loadThuCung(maKH);
            }
        }

        // Load thú cưng vào comboBox theo khách hàng
        private void loadThuCung(string maKH) {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string sql = "SELECT MaThuCung, TenThuCung FROM ThuCung WHERE MaKhachHang = '"+maKH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxThuCung.DataSource = dt;
            comboBoxThuCung.DisplayMember = "TenThuCung";
            comboBoxThuCung.ValueMember = "MaThuCung";
        }

        // Load dịch vụ vào comboBox
        private void loadDichVu()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string sql = "SELECT MaDichVu, TenDichVu, DonGia FROM DichVu";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxDichVu.DataSource = dt;
            comboBoxDichVu.DisplayMember = "TenDichVu";
            comboBoxDichVu.ValueMember = "MaDichVu"; 

        }

        // Thêm dịch vụ vào hoá đơn

        private void buttonThem_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)comboBoxDichVu.SelectedItem;
            string maDichVu = row["MaDichVu"].ToString();
            string tenDichVu = row["TenDichVu"].ToString();
            decimal donGia = (decimal)row["DonGia"];
            int soLuong = (int)numericSL.Value;
            decimal ThanhTien = donGia * soLuong;
            dgvDichVu.Rows.Add(maDichVu,tenDichVu, donGia, soLuong, ThanhTien);
            tinhTongTien();

        }

        // Xóa dịch vụ

        private void xoaCell(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvDichVu.Columns["xoa"].Index && e.RowIndex >= 0) {
                dgvDichVu.Rows.RemoveAt(e.RowIndex);
            }
            tinhTongTien();

        }

        // Tổng tiền
        private decimal tinhTongTien()
        {
            decimal tongTien = 0;
            foreach(DataGridViewRow row in dgvDichVu.Rows) {
                if (row.Cells["ThanhTien"].Value != null) { 
                    tongTien+= (decimal)row.Cells["ThanhTien"].Value;
                }
            }
            labelTongTien.Text = "Tổng tiền: " + tongTien.ToString() + " VND";
            return tongTien;
        }
        // tạo mã hoá đơn tự động
        private string TaoMaHoaDon()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql =
                "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            object result = cmd.ExecuteScalar();

            if (result == null)
            {
                return "HD001";
            }

            string maCu = result.ToString();

            int so =
                int.Parse(maCu.Substring(2)) + 1;

            return "HD" + so.ToString("000");
        }
        // Lưu hoá đơn
        private void lapHoaDon_click()
        {
            if(comboBoxKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
                return;
            }
            if(comboBoxThuCung.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thú cưng");
                return;
            }
            if(dgvDichVu.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm dịch vụ");
                return;
            }
            if(conn.State == ConnectionState.Closed) conn.Open();
            string maHD = TaoMaHoaDon();

            SqlTransaction trans =conn.BeginTransaction(); // gom câu lệnh thành 1 nhóm, nếu có lỗi sẽ rollback về trạng thái ban đầu
            try {
                
                string maKh = comboBoxKhachHang.SelectedValue.ToString();
                string maThuCung = comboBoxThuCung.SelectedValue.ToString();
                decimal tongTien = tinhTongTien();

                string sqlHoaDon = "INSERT INTO HoaDon " + "VALUES('" + maHD + "','" + maKh+"','"+maThuCung+"', GETDATE(), "+ tongTien + ")";

                SqlCommand cmdHD = new SqlCommand(sqlHoaDon, conn, trans);
                cmdHD.ExecuteNonQuery();
                // Lưu chi tiết hoá đơn
                foreach (DataGridViewRow row in dgvDichVu.Rows)
                {
                    if (row.Cells["MaDichVu"].Value == null)
                        continue;

                    string maDV =
                        row.Cells["MaDichVu"].Value.ToString();

                    decimal donGia =
                        Convert.ToDecimal(
                            row.Cells["DonGia"].Value);

                    int soLuong =
                        Convert.ToInt32(
                            row.Cells["SoLuong"].Value);

                    decimal thanhTien =
                        Convert.ToDecimal(
                            row.Cells["ThanhTien"].Value);

                    string sqlCT =
                        "INSERT INTO ChiTietHoaDon " +
                        "VALUES('" + maHD + "', '" +
                        maDV + "', " +
                        donGia + ", " +
                        soLuong + ", " +
                        thanhTien + ")";

                    SqlCommand cmdCT =
                        new SqlCommand(sqlCT, conn, trans);

                    cmdCT.ExecuteNonQuery();
                }
                trans.Commit();
                MessageBox.Show("Lập hoá đơn thành công!");
                dgvDichVu.Rows.Clear();
                labelTongTien.Text = "Tổng tiền: 0 VND";


            }
            catch (Exception ex) {
                trans.Rollback();
                MessageBox.Show("Lập hoá đơn thất bại! Lỗi: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lapHoaDon_click();
        }
    }
}
