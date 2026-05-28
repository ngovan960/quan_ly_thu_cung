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
            conn.Close();

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
                if (!KiemTraDuLieu())
                {
                    return;
                }
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                //ktra ma trùng
                string sqlCheck = "select count(*) from ThuCung where MaThuCung = '" + txtMaThuCung.Text.Trim() + "'";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã thú cưng đã tồn tại");
                    txtMaThuCung.Focus();
                    conn.Close();
                    return;
                }
                //ktra mã khách hàng
                string sqlCheckKH= "select count(*) from KhachHang where MaKhachHang = '" + txtMaKH.Text.Trim() + "'";
                SqlCommand cmdCheckKH = new SqlCommand(sqlCheckKH, conn);
                int countKH = (int)cmdCheckKH.ExecuteScalar();
                if(countKH == 0)
                {
                    MessageBox.Show("Mã Khách hàng không tồn tại");
                    txtMaKH.Focus();
                    conn.Close();
                    return;
                }
                //insert
                string sqlInsert =
                 "insert into ThuCung " +
                 "(MaThuCung, TenThuCung, LoaiThuCung, Giong, Tuoi, TinhTrangSucKhoe, MaKhachHang) " +
                 "values (" +
                 "'" + txtMaThuCung.Text.Trim() + "'," +
                 "N'" + txtTenThuCung.Text.Trim() + "'," +
                 "N'" + txtLoaiThuCung.Text.Trim() + "'," +
                 "N'" + txtGiong.Text.Trim() + "'," +
                 txtTuoi.Text.Trim() + "," +
                 "N'" + txtTinhTrangSK.Text.Trim() + "'," +
                 "'" + txtMaKH.Text.Trim() + "'" +
                 ")";
                SqlCommand cmdInsert = new SqlCommand( sqlInsert, conn);
                cmdInsert.ExecuteNonQuery();
                conn.Close();
                LoadThuCung();
                MessageBox.Show("Thêm thú cưng thành công");
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
                if (!KiemTraDuLieu())
                {
                    return;
                }
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sqlCheck = "select count(*) from ThuCung where MaThuCung = '" + txtMaThuCung.Text.Trim() + "'";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                int count = (int)cmdCheck.ExecuteScalar();
                if(count == 0)
                {
                    MessageBox.Show("Không tìm thấy thú cưng");
                    conn.Close();
                    return;

                }
                string sqlUpdate =
               "update ThuCung set " +
               "TenThuCung = N'" + txtTenThuCung.Text.Trim() + "'," +
               "LoaiThuCung = N'" + txtLoaiThuCung.Text.Trim() + "'," +
               "Giong = N'" + txtGiong.Text.Trim() + "'," +
               "Tuoi = " + txtTuoi.Text.Trim() + "," +
               "TinhTrangSucKhoe = N'" + txtTinhTrangSK.Text.Trim() + "'," +
               "MaKhachHang = '" + txtMaKH.Text.Trim() + "' " +
               "where MaThuCung = '" + txtMaThuCung.Text.Trim() + "'";

                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                int result = cmdUpdate.ExecuteNonQuery();
                conn.Close();
                if(result > 0)
                {
                    LoadThuCung();
                    MessageBox.Show("Sửa thú cưng thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thú cưng thất bại");
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
                if (txtMaThuCung.Text.Trim() == "")
                {
                    MessageBox.Show("vui lòng chọn thú cưng");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sqlDelete = "delete from ThuCung where MaThuCung = '" + txtMaThuCung.Text.Trim() + "'";
                SqlCommand cmdDelete = new SqlCommand(sqlDelete, conn);
                int rows = cmdDelete.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    LoadThuCung();
                    txtMaThuCung.Clear();
                    txtTenThuCung.Clear();
                    txtMaKH.Clear();
                    txtTuoi.Clear();
                    txtLoaiThuCung.Clear();
                    txtGiong.Clear();
                    txtTinhTrangSK.Clear();
                    MessageBox.Show("Xóa thú cưng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
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
                string tuKhoa = txtTimKiem.Text.Trim();
                if(tuKhoa == "")
                {
                    LoadThuCung();
                    return;
                }
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "select * from ThuCung where ";

                if(cboTimKiem.Text == "Mã thú cưng")
                {
                    sql += "MaThuCung like '%" + tuKhoa + "%'";
                }
                else if (cboTimKiem.Text == "Tên thú cưng")
                {
                    sql += "TenThuCung like N'%" + tuKhoa + "%'";
                }
                else if (cboTimKiem.Text == "Loại thú cưng")
                {
                    sql += "LoaiThuCung like N'%" + tuKhoa + "%'";
                }

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvThuCung.DataSource = dt;
                conn.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
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
