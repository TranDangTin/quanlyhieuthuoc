using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    class HoaDonNhapDB
    {
        public DataSet getAll()
        {
            DataSet data = new DataSet();
            SqlConnection cnn = Database.getConnection();
            string query = "select * from HOADON_NHAP";
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            adapter.Fill(data);
            cnn.Close();
            return data;
        }

        public void insert(HoaDonNhap hoaDonNhap)
        {
            string sql = "insert into HOADON_NHAP ([TenThuoc], [HanSuDung]) ";
            sql += "values(@TenThuoc, @HanSuDung)";
            SqlConnection cnn = Database.getConnection();
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@TenThuoc", hoaDonNhap.tenThuoc);
                cmd.Parameters.AddWithValue("@HanSuDung", hoaDonNhap.hanSuDung);
                cmd.ExecuteNonQuery();
            }
        }

        public void update(HoaDonNhap hoaDonNhap)
        {
            string sql = "update HOADON_NHAP set ";
            sql += "TenThuoc=N'" + hoaDonNhap.tenThuoc + "',";
            sql += "HanSuDung='" + hoaDonNhap.hanSuDung + "' ";
            sql += "where id=" + hoaDonNhap.id;
            SqlConnection cnn = Database.getConnection();
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void delete(HoaDonNhap hoaDonNhap)
        {
            string sql = "delete from HOADON_NHAP where id=" + hoaDonNhap.id;
            SqlConnection cnn = Database.getConnection();
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
