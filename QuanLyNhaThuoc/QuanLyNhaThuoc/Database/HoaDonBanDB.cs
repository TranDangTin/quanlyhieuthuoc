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
            string sql = "insert into HOADON_BAN ([NguoiMua], [TenThuoc], [MaThuoc], [SoLuong], [DonGia], [NgayBan]) ";
                   sql += "values(@NguoiMua, @TenThuoc, @MaThuoc, @SoLuong, @DonGia, @NgayBan)";
            SqlConnection cnn = Database.getConnection();
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@NguoiMua", hoaDonBan.nguoiMua);
                cmd.Parameters.AddWithValue("@TenThuoc", hoaDonBan.tenThuoc);
                cmd.Parameters.AddWithValue("@MaThuoc", hoaDonBan.maThuoc);
                cmd.Parameters.AddWithValue("@SoLuong", hoaDonBan.soLuong);
                cmd.Parameters.AddWithValue("@DonGia", hoaDonBan.donGia);
                cmd.Parameters.AddWithValue("@NgayBan", hoaDonBan.ngayBan);
                cmd.ExecuteNonQuery();
            }
        }

        public void update(HoaDonBan hoaDonBan)
        {
            string sql = "update HOADON_BAN set ";
            sql += "NguoiMua =N'" + hoaDonBan.nguoiMua + "',";
            sql += "TenThuoc=N'" + hoaDonBan.tenThuoc + "',";
            sql += "MaThuoc='" + hoaDonBan.maThuoc + "',";
            sql += "SoLuong=" + hoaDonBan.soLuong + ",";
            sql += "DonGia=" + hoaDonBan.donGia + ", ";
            sql += "NgayBan='" + hoaDonBan.ngayBan + "' ";
            sql += "where id=" + hoaDonBan.id;
            SqlConnection cnn = Database.getConnection();
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void delete(HoaDonBan hoaDonBan)
        {
            string sql = "delete from HOADON_BAN where id=" + hoaDonBan.id;
            SqlConnection cnn = Database.getConnection();
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public DataSet getByNguoiMua(string nguoiMua)
        {
            DataSet data = new DataSet();
            SqlConnection cnn = Database.getConnection();
            string query = "select * from HOADON_BAN where NguoiMua Like N'%" + nguoiMua + "%'";
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            adapter.Fill(data);
            cnn.Close();
            return data;
        }
    }
}
