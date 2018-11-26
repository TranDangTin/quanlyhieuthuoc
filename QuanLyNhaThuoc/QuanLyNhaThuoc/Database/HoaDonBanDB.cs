using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    class HoaDonBanDB
    {
        public DataSet getAll()
        {
            DataSet data = new DataSet();
            SqlConnection cnn = Database.getConnection();
            string query = "select * from HOADON_BAN";
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            adapter.Fill(data);
            cnn.Close();
            return data;
        }

        public void insert(HoaDonBan hoaDonBan)
        {
            string sql = "insert into HOADON_BAN ([NguoiMua], [TenThuoc], [MaThuoc], [SoLuong], [DonGia]) ";
                   sql += "values(@NguoiMua, @TenThuoc, @MaThuoc, @SoLuong, @DonGia)";
            SqlConnection cnn = Database.getConnection();
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@NguoiMua", hoaDonBan.nguoiMua);
                cmd.Parameters.AddWithValue("@TenThuoc", hoaDonBan.tenThuoc);
                cmd.Parameters.AddWithValue("@MaThuoc", hoaDonBan.maThuoc);
                cmd.Parameters.AddWithValue("@SoLuong", hoaDonBan.soLuong);
                cmd.Parameters.AddWithValue("@DonGia", hoaDonBan.donGia);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
