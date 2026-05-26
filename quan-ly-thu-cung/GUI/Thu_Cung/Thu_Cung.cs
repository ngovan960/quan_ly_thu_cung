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
using System.Text.RegularExpressions;


namespace quan_ly_thu_cung.GUI.Thu_Cung
{
    public partial class Thu_Cung : UserControl
    {
        string chuoiKetNoi = @"Data Source=.\SQLEXPRESS; Initial Catalog=QuanLyThuCung; Integrated Security=True";
        public Thu_Cung()
        {
            InitializeComponent();
        }
        //Lấy dữ liệu từ database và hiển thị lên DataGridView
        private void LoadThuCung()
        {
           SqlConnection conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            string sql = "select * from ThuCung";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThuCung.DataSource = dt;

        }
        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra có click đúng dòng dữ liệu không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng đang chọn
                DataGridViewRow row = dgvThuCung.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên textbox
                txtMaThuCung.Text = row.Cells["MaThuCung"].Value.ToString();
                txtTenThuCung.Text = row.Cells["TenThuCung"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTuoi.Text = row.Cells["Tuoi"].Value.ToString();
                txtLoaiThuCung.Text = row.Cells["LoaiThuCung"].Value.ToString();
                txtGiong.Text = row.Cells["Giong"].Value.ToString();
                txtTinhTrangSK.Text = row.Cells["TinhTrangSucKhoe"].Value.ToString();
            }
        }
        private bool KiemTraDuLieu()
        {
            // Kiểm tra mã thú cưng
            if (string.IsNullOrWhiteSpace(txtMaThuCung.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thú cưng.");
                txtMaThuCung.Focus();
                return false;
            }

            // Kiểm tra tên thú cưng
            if (string.IsNullOrWhiteSpace(txtTenThuCung.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thú cưng.");
                txtTenThuCung.Focus();
                return false;
            }

            // Tên phải từ 2 ký tự trở lên
            if (txtTenThuCung.Text.Trim().Length < 2)
            {
                MessageBox.Show("Tên thú cưng phải từ 2 ký tự.");
                txtTenThuCung.Focus();
                return false;
            }

            // Kiểm tra mã khách hàng
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.");
                txtMaKH.Focus();
                return false;
            }

            // Kiểm tra tuổi
            if (string.IsNullOrWhiteSpace(txtTuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tuổi.");
                txtTuoi.Focus();
                return false;
            }

            // Tuổi phải là số
            int tuoi;

            if (!int.TryParse(txtTuoi.Text.Trim(), out tuoi))
            {
                MessageBox.Show("Tuổi phải là số.");
                txtTuoi.Focus();
                return false;
            }

            // Tuổi không âm
            if (tuoi < 0)
            {
                MessageBox.Show("Tuổi không hợp lệ.");
                txtTuoi.Focus();
                return false;
            }

            // Kiểm tra loại thú cưng
            if (string.IsNullOrWhiteSpace(txtLoaiThuCung.Text))
            {
                MessageBox.Show("Vui lòng nhập loại thú cưng.");
                txtLoaiThuCung.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // KIỂM TRA DỮ LIỆU
               
                if (!KiemTraDuLieu())
                    return;

                // Tạo kết nối SQL
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    //kiểm tra mã thú cưng đã tồn tại

                    string sqlCheckMa = "SELECT COUNT(*) FROM ThuCung WHERE MaThuCung = @MaThuCung";

                    using (SqlCommand cmdCheckMa = new SqlCommand(sqlCheckMa, conn))
                    {
                        cmdCheckMa.Parameters.AddWithValue("@MaThuCung", txtMaThuCung.Text.Trim());

                        int count = (int)cmdCheckMa.ExecuteScalar();

                        // Nếu mã đã tồn tại
                        if (count > 0)
                        {
                            MessageBox.Show("Mã thú cưng đã tồn tại.");

                            txtMaThuCung.Focus();

                            return;
                        }
                    }

                    // KIỂM TRA MÃ KHÁCH HÀNG TỒN TẠI
                    
                    string sqlCheckKH = "SELECT COUNT(*) FROM KhachHang WHERE MaKhachHang = @MaKH";

                    using (SqlCommand cmdCheckKH = new SqlCommand(sqlCheckKH, conn))
                    {
                        cmdCheckKH.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());

                        int countKH = (int)cmdCheckKH.ExecuteScalar();

                        // Nếu không tồn tại khách hàng
                        if (countKH == 0)
                        {
                            MessageBox.Show("Mã khách hàng không tồn tại.");

                            txtMaKH.Focus();

                            return;
                        }
                    }

  
                    // CÂU LỆNH INSERT

                    string sqlInsert = @"  INSERT INTO ThuCung (
                        MaThuCung,
                        TenThuCung,
                        MaKhachHang,
                        Tuoi,
                        LoaiThuCung,
                        Giong,
                        TinhTrangSucKhoe
                     )
                    VALUES
                    (
                        @MaThuCung,
                        @TenThuCung,
                        @MaKhachHang,
                        @Tuoi,
                        @LoaiThuCung,
                        @Giong,
                        @TinhTrangSucKhoe
                    )";

                    // Tạo command thêm dữ liệu
                    using (SqlCommand command = new SqlCommand(sqlInsert, conn))
                    {
                        // Truyền dữ liệu từ textbox vào SQL
                        command.Parameters.AddWithValue("@MaThuCung", txtMaThuCung.Text.Trim());

                        command.Parameters.AddWithValue("@TenThuCung", txtTenThuCung.Text.Trim());

                        command.Parameters.AddWithValue("@MaKhachHang", txtMaKH.Text.Trim());

                        command.Parameters.AddWithValue("@Tuoi", int.Parse(txtTuoi.Text.Trim()));

                        command.Parameters.AddWithValue("@LoaiThuCung", txtLoaiThuCung.Text.Trim());

                        command.Parameters.AddWithValue("@Giong", txtGiong.Text.Trim());

                        command.Parameters.AddWithValue("@TinhTrangSucKhoe", txtTinhTrangSK.Text.Trim());

                        // Thực thi lệnh INSERT
                        command.ExecuteNonQuery();
                    }
                }

                // LOAD LẠI DỮ LIỆU

                LoadThuCung();

                // Thông báo thành công
                MessageBox.Show("Thêm thú cưng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thú cưng: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu
                if (!KiemTraDuLieu())
                    return;

                // Kết nối SQL
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    // Kiểm tra thú cưng tồn tại
                    string sqlCheck = "SELECT COUNT(*) FROM ThuCung WHERE MaThuCung = @MaThuCung";

                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@MaThuCung", txtMaThuCung.Text.Trim());

                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Không tìm thấy thú cưng để sửa.");
                            return;
                        }
                    }

                    // Kiểm tra mã khách hàng tồn tại
                    string sqlCheckKH = "SELECT COUNT(*) FROM KhachHang WHERE MaKhachHang = @MaKH";

                    using (SqlCommand cmdCheckKH = new SqlCommand(sqlCheckKH, conn))
                    {
                        cmdCheckKH.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());

                        int countKH = (int)cmdCheckKH.ExecuteScalar();

                        if (countKH == 0)
                        {
                            MessageBox.Show("Mã khách hàng không tồn tại.");
                            txtMaKH.Focus();
                            return;
                        }
                    }

                    // Câu lệnh UPDATE
                    string sqlUpdate = @"UPDATE ThuCung SET
                    TenThuCung = @TenThuCung,
                    MaKhachHang = @MaKhachHang,
                    Tuoi = @Tuoi,
                    LoaiThuCung = @LoaiThuCung,
                    Giong = @Giong,
                    TinhTrangSucKhoe = @TinhTrangSucKhoe WHERE MaThuCung = @MaThuCung";

                    using (SqlCommand command = new SqlCommand(sqlUpdate, conn))
                    {
                        command.Parameters.AddWithValue("@MaThuCung", txtMaThuCung.Text.Trim());
                        command.Parameters.AddWithValue("@TenThuCung", txtTenThuCung.Text.Trim());
                        command.Parameters.AddWithValue("@MaKhachHang", txtMaKH.Text.Trim());
                        command.Parameters.AddWithValue("@Tuoi", int.Parse(txtTuoi.Text.Trim()));
                        command.Parameters.AddWithValue("@LoaiThuCung", txtLoaiThuCung.Text.Trim());
                        command.Parameters.AddWithValue("@Giong", txtGiong.Text.Trim());
                        command.Parameters.AddWithValue("@TinhTrangSucKhoe", txtTinhTrangSK.Text.Trim());

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            LoadThuCung();
                            MessageBox.Show("Sửa thú cưng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thú cưng: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã thú cưng
                if (string.IsNullOrWhiteSpace(txtMaThuCung.Text))
                {
                    MessageBox.Show("Vui lòng chọn thú cưng cần xóa.");
                    return;
                }

                // Hộp xác nhận
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa thú cưng này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // Nếu chọn No thì dừng
                if (result == DialogResult.No)
                    return;

                // Kết nối SQL
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    // Câu lệnh DELETE
                    string sqlDelete = "DELETE FROM ThuCung WHERE MaThuCung = @MaThuCung";

                    using (SqlCommand command = new SqlCommand(sqlDelete, conn))
                    {
                        command.Parameters.AddWithValue("@MaThuCung", txtMaThuCung.Text.Trim());

                        int rows = command.ExecuteNonQuery();

                        // Nếu xóa thành công
                        if (rows > 0)
                        {
                            // Load lại DataGridView
                            LoadThuCung();

                            // Xóa trắng textbox
                            txtMaThuCung.Clear();
                            txtTenThuCung.Clear();
                            txtMaKH.Clear();
                            txtTuoi.Clear();
                            txtLoaiThuCung.Clear();
                            txtGiong.Clear();
                            txtTinhTrangSK.Clear();

                            MessageBox.Show("Xóa thú cưng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thú cưng để xóa.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa thú cưng: " + ex.Message);
            }
        }
      

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy từ khóa
                string tuKhoa = txtTimKiem.Text.Trim();

                // Nếu trống thì load lại toàn bộ
                if (string.IsNullOrWhiteSpace(tuKhoa))
                {
                    LoadThuCung();
                    return;
                }

                // Kết nối SQL
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    // SQL cơ bản
                    string sql = @"
                    SELECT 
                        ThuCung.MaThuCung,
                        ThuCung.MaKhachHang,
                        ThuCung.TenThuCung,
                        ThuCung.LoaiThuCung,
                        ThuCung.Giong,
                        ThuCung.Tuoi,
                        ThuCung.TinhTrangSucKhoe
                    FROM ThuCung
                    INNER JOIN KhachHang
                    ON ThuCung.MaKhachHang = KhachHang.MaKhachHang
                    WHERE ";

                    // TÌM THEO COMBOBOX

                    if (cboTimKiem.Text == "Mã thú cưng")
                    {
                        sql += "ThuCung.MaThuCung LIKE '%' + @TuKhoa + '%'";
                    }
                    else if (cboTimKiem.Text == "Tên thú cưng")
                    {
                        sql += "ThuCung.TenThuCung LIKE N'%' + @TuKhoa + '%'";
                    }
                    
                    else if (cboTimKiem.Text == "Loại thú cưng")
                    {
                        sql += "ThuCung.LoaiThuCung LIKE N'%' + @TuKhoa + '%'";
                    }

                    // Tạo command
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                    // Đổ dữ liệu ra bảng
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvThuCung.DataSource = dt;

                    // Không tìm thấy
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }


       

        private void Thu_Cung_Load(object sender, EventArgs e)
        {
            LoadThuCung();
            
        }
    }
}
