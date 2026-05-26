using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_thu_cung.GUI.Khach_Hang
{
    public partial class khachhang : UserControl
    {
        string chuoiKetNoi = @"Data Source=.\SQLEXPRESS; Initial Catalog=QuanLyThuCung; Integrated Security=True";
        public khachhang()
        {
            InitializeComponent();
        }
        //Lấy dữ liệu từ SQL Server và hiển thị lên DataGridView
        private void LoadKhachHang()
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            string sql = "SELECT * FROM KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;
          

        }
        //sự kiện Load của UserControl, khi UserControl được hiển thị lần đầu tiên thì sẽ gọi hàm LoadKhachHang để hiển thị dữ liệu khách hàng lên DataGridView
        private void khachhang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        //click vào 1 dòng trên DataGridView thì các thông tin của khách hàng đó sẽ hiển thị lên các TextBox tương ứng
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }
        private bool KiemTraDuLieu()
        {
            // Mã khách hàng không được để trống
            if (string.IsNullOrWhiteSpace(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.");
                txtMaKhachHang.Focus();
                return false;
            }

            // Họ tên không được để trống
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng.");
                txtHoTen.Focus();
                return false;
            }

            // Họ tên phải từ 2 đến 100 ký tự
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen.Length < 2 || hoTen.Length > 100)
            {
                MessageBox.Show("Họ tên phải từ 2 đến 100 ký tự.");
                txtHoTen.Focus();
                return false;
            }
            // Họ tên không được chứa số hoặc ký tự đặc biệt
            // Chỉ cho phép chữ cái, khoảng trắng, và dấu tiếng Việt
            if (!Regex.IsMatch(hoTen, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                MessageBox.Show("Họ tên không được chứa số hoặc ký tự đặc biệt.");
                txtHoTen.Focus();
                return false;
            }
            // Số điện thoại không được để trống
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                txtSoDienThoai.Focus();
                return false;
            }

            // Số điện thoại phải bắt đầu bằng 0 và có 10 chữ số
            string sdt = txtSoDienThoai.Text.Trim();
            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (phải là 10 số, bắt đầu bằng 0).");
                txtSoDienThoai.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraDuLieu())
                {
                    return;
                }
                //kết nối sql
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                //ktra mã trùng 
                string sqlCheck = "select count(*) from KhachHang " + "Where MaKhachHang = '" + txtMaKhachHang.Text.Trim() + "'";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                    txtMaKhachHang.Focus();
                    conn.Close();
                    return;
                }
                string sqlInsert = "Insert into KhachHang " + "Values (" + "'" + txtMaKhachHang.Text.Trim() + "'," +
                   "N'" + txtHoTen.Text.Trim() + "'," +
                    "'" + txtSoDienThoai.Text.Trim() + "'," +
                    "N'" + txtDiaChi.Text.Trim() + "'" + ")";
                SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
                //thực thi
                cmdInsert.ExecuteNonQuery();
                conn.Close() ;
                LoadKhachHang();
                MessageBox.Show("Thêm khách hàng thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //ktra dữ liệu
                if(!KiemTraDuLieu())
                {
                    return;
                }
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                //ktra khách hàng
                string sqlCheck = "select count(*) from KhachHang " + "where MaKhachHang = '" + txtMaKhachHang.Text.Trim() + "'";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                int count = (int)cmdCheck.ExecuteScalar();

                if(count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                    conn.Close();
                    return;
                }
                //update
                string sqlUpdate = "update KhachHang set HoTen = N'" + txtHoTen.Text.Trim() + "', SoDienThoai = '" + txtSoDienThoai.Text.Trim() + "', DiaChi = N'" + txtDiaChi.Text.Trim() + "' where MaKhachHang = '" + txtMaKhachHang.Text.Trim() + "'";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                int result = cmdUpdate.ExecuteNonQuery();
                conn.Close();
                if(result > 0)
                {
                    LoadKhachHang();
                    MessageBox.Show("Sửa Khách Hàng thành công");

                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách hàng: " + ex.Message);
            }
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhachHang.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "xác nhận", MessageBoxButtons.YesNo);
                if(result == DialogResult.No)
                {
                    return;
                }
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                //xóa thú cưng trước
                string sqlDeleteThuCung = "delete from ThuCung where MaKhachHang = '" + txtMaKhachHang.Text.Trim() + "'";
                SqlCommand cmdThuCung = new SqlCommand(sqlDeleteThuCung, conn);
                cmdThuCung.ExecuteNonQuery();
                //xóa khách hàng
                string sqlDeleteKH = "delete from KhachHang where MaKhachHang = '" + txtMaKhachHang.Text.Trim() + "'";
                SqlCommand cmdKH = new SqlCommand(sqlDeleteKH, conn);
                int row = cmdKH.ExecuteNonQuery();
                if (row > 0)
                {
                    LoadKhachHang();

                    txtMaKhachHang.Clear();
                    txtHoTen.Clear();
                    txtSoDienThoai.Clear();
                    txtDiaChi.Clear();

                    MessageBox.Show("Xóa khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy từ khóa
                string tuKhoa = txtTimKiem.Text.Trim();
                if(tuKhoa == "")
                {
                    LoadKhachHang() ;
                    return;

                }
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "select * from KhachHang where ";
                //tìm kiếm theo combobox
                if(cboTimKiem.Text == "Mã Khách hàng")
                {
                    sql += "MaKhachHang like '%" + tuKhoa + "%'";

                }
                else if(cboTimKiem.Text == "Họ tên")
                {
                    sql += "HoTen like N'%" + tuKhoa + "%'";
                }
                else if (cboTimKiem.Text == "Số điện thoại")
                {
                    sql += "SoDienThoai like '%" + tuKhoa +"%'";
                }
                //thực thi sql
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhachHang.DataSource = dt;
                conn.Close();
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("không tìm thấy dữ liệu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
            }
        }


    }
}
