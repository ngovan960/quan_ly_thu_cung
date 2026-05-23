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
            conn = new SqlConnection(chuoiKetNoi);
            string layDichVu = "SELECT * FROM DichVu";
            SqlDataAdapter dichVu = new SqlDataAdapter(layDichVu, conn);
            DataTable dtDichVu = new DataTable();
            dichVu.Fill(dtDichVu);
            dataGridView1.DataSource = dtDichVu;
        }

        private void layData(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0 )
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxMaDichVu.Text = row.Cells["MaDichVu"].Value.ToString();
            }
            
        }
    }
}
