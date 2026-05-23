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
        private void LoadKhachHang()
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);

            string sql = "SELECT * FROM KhachHang";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvKhachHang.DataSource = dt;
          

        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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

            // Số điện thoại phải bắt đầu bằng 0 và có 10-11 chữ số
            string sdt = txtSoDienThoai.Text.Trim();
            if (!Regex.IsMatch(sdt, @"^0\d{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (phải là 10-11 số, bắt đầu bằng 0).");
                txtSoDienThoai.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu trước khi thêm
                if (!KiemTraDuLieu())
                    return;

                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    // Kiểm tra mã khách hàng đã tồn tại chưa
                    string sqlCheckMa = "SELECT COUNT(*) FROM KhachHang WHERE MaKhachHang = @MaKH";
                    using (SqlCommand cmdCheckMa = new SqlCommand(sqlCheckMa, conn))
                    {
                        cmdCheckMa.Parameters.AddWithValue("@MaKH", txtMaKhachHang.Text.Trim());
                        int countMa = (int)cmdCheckMa.ExecuteScalar();

                        if (countMa > 0)
                        {
                            MessageBox.Show("Mã khách hàng đã tồn tại trong hệ thống.");
                            txtMaKhachHang.Focus();
                            return;
                        }
                    }

                    // Kiểm tra số điện thoại đã tồn tại chưa
                    string sqlCheckSDT = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SDT";
                    using (SqlCommand cmdCheckSDT = new SqlCommand(sqlCheckSDT, conn))
                    {
                        cmdCheckSDT.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text.Trim());
                        int countSDT = (int)cmdCheckSDT.ExecuteScalar();

                        if (countSDT > 0)
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống.");
                            txtSoDienThoai.Focus();
                            return;
                        }
                    }

                    // Nếu hợp lệ thì mới insert
                    string sqlInsert = @"INSERT INTO KhachHang(MaKhachHang, HoTen, SoDienThoai, DiaChi)
                                 VALUES (@MaKH, @HoTen, @SDT, @DiaChi)";

                    using (SqlCommand command = new SqlCommand(sqlInsert, conn))
                    {
                        command.Parameters.AddWithValue("@MaKH", txtMaKhachHang.Text.Trim());
                        command.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                        command.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text.Trim());
                        command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());

                        command.ExecuteNonQuery();
                    }
                }

                LoadKhachHang();
                MessageBox.Show("Thêm khách hàng thành công!");
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
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    string sql = @"UPDATE KhachHang SET HoTen = @HoTen,SoDienThoai = @SoDienThoai,DiaChi = @DiaChi
                           WHERE MaKhachHang = @MaKhachHang";

                    SqlCommand command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text.Trim());
                    command.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                    command.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text.Trim());
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());

                    conn.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        LoadKhachHang();
                        MessageBox.Show("Sửa khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng để sửa.");
                    }
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
                if (string.IsNullOrWhiteSpace(txtMaKhachHang.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa khách hàng này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();

                    try
                    {
                        string maKH = txtMaKhachHang.Text.Trim();

                        // Xóa thú cưng trước
                        string sql1 = "DELETE FROM ThuCung WHERE MaKhachHang = @MaKhachHang";
                        SqlCommand cmd1 = new SqlCommand(sql1, conn, tran);
                        cmd1.Parameters.AddWithValue("@MaKhachHang", maKH);
                        cmd1.ExecuteNonQuery();

                        // Sau đó xóa khách hàng
                        string sql2 = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn, tran);
                        cmd2.Parameters.AddWithValue("@MaKhachHang", maKH);
                        int rows = cmd2.ExecuteNonQuery();

                        tran.Commit();

                        if (rows > 0)
                        {
                            LoadKhachHang();
                            txtMaKhachHang.Clear();
                            txtHoTen.Clear();
                            txtSoDienThoai.Clear();
                            txtDiaChi.Clear();
                            MessageBox.Show("Xóa khách hàng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để xóa.");
                        }
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }
    }
}
