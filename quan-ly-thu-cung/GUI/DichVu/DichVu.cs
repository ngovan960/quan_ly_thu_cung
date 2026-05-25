using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;


namespace quan_ly_thu_cung.GUI.DichVu
{
    public partial class DichVu : UserControl
    {
        public DichVu()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = @"Data Source=.\SQLEXPRESS; Initial Catalog=QuanLyThuCung; Integrated Security=True";
        SqlConnection conn = null;

        private void DichVu_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;
            conn = new SqlConnection(chuoiKetNoi);
            //string layDichVu = "SELECT * FROM DichVu";
            //SqlDataAdapter dichVu = new SqlDataAdapter(layDichVu, conn);
            //DataTable dtDichVu = new DataTable();
            //dichVu.Fill(dtDichVu);
            //dataGridView1.DataSource = dtDichVu;
            loadDichVu();
        }

        private void loadDichVu()
        {
            string sql = "SELECT * FROM DichVu";
            SqlDataAdapter dichVu = new SqlDataAdapter(sql, conn);
            DataTable dtDichVu = new DataTable();
            dichVu.Fill(dtDichVu);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtDichVu;
        }

        private void layData(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 )
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxMaDichVu.Text = row.Cells["MaDichVu"].Value.ToString();
                textBoxTenDichVu.Text = row.Cells["TenDichVu"].Value.ToString();
                textBoxTien.Text = row.Cells["DonGia"].Value.ToString();

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaDichVu.Text)
                || string.IsNullOrWhiteSpace(textBoxTenDichVu.Text)
                || string.IsNullOrWhiteSpace(textBoxTien.Text))
                return;

            // kiểm tra giá tiền
            if (!decimal.TryParse(textBoxTien.Text, out decimal price))
            {
                MessageBox.Show("Giá tiền không hợp lệ.");
                return;
            }

            string id = textBoxMaDichVu.Text.Replace("'", "''");
            string name = textBoxTenDichVu.Text.Replace("'", "''");

            SqlCommand sqlCheck = new SqlCommand(
                "SELECT MaDichVu FROM DichVu WHERE MaDichVu = '" + id + "'", conn);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                object result = sqlCheck.ExecuteScalar();
                if (result == null) // không tồn tại -> insert
                {
                    string insertSql = "INSERT INTO DichVu (MaDichVu, TenDichVu, DonGia) VALUES ('"
                        + id + "', N'" + name + "', " + price.ToString(System.Globalization.CultureInfo.InvariantCulture) + ")";
                    SqlCommand sqlThem = new SqlCommand(insertSql, conn);
                    sqlThem.ExecuteNonQuery();
                    MessageBox.Show("Thêm dịch vụ thành công!");
                    loadDichVu();
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ đã tồn tại, vui lòng nhập mã khác!");
                }
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaDichVu.Text)
                || string.IsNullOrWhiteSpace(textBoxTenDichVu.Text)
                || string.IsNullOrWhiteSpace(textBoxTien.Text))
                return;

            // kiểm tra giá tiền
            if (!decimal.TryParse(textBoxTien.Text, out decimal price))
            {
                MessageBox.Show("Giá tiền không hợp lệ.");
                return;
            }

            string id = textBoxMaDichVu.Text.Replace("'", "''");
            string name = textBoxTenDichVu.Text.Replace("'", "''");
            try {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "UPDATE DichVu SET " + " TenDichVu = N'" + name + "'" + ", DonGia = " +price.ToString(System.Globalization.CultureInfo.InvariantCulture) + " WHERE MaDichVu= '"+ id + "'";  
                SqlCommand cmd = new SqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) {
                    MessageBox.Show("Sửa dịch vụ thành công!");
                    loadDichVu();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy dịch vụ cần sửa, vui lòng kiểm tra lại mã dịch vụ!");
                }
                
            }catch (Exception ex) {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        finally {
                conn.Close();
            }
           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xoá dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes) { 
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if(string.IsNullOrWhiteSpace(textBoxMaDichVu.Text)) {
                return;
            }
            string id = textBoxMaDichVu.Text.Replace("'", "''");
            string sql = "DELETE FROM DichVu WHERE MaDichVu='" + id + "'";

                // Xóa dữ liệu ở bảng ChiTietHoaDon trước

             string sql1 = "DELETE FROM ChiTietHoaDon WHERE MaDichVu='" + id + "'";
             SqlCommand cmd1 = new SqlCommand(sql1, conn);
             cmd1.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();
            if(rows > 0)
            {
                MessageBox.Show("Xoá dịch vụ thành công!");
                loadDichVu();
            }
            else
            {
                MessageBox.Show("Xoá dịch vụ không thành công");
            }
            conn.Close();}
        }
    }
}
