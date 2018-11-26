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

namespace QuanLyNhaThuoc
{
    public partial class Main : Form
    {
        private HoaDonBanDB hoaDonBanDB;
        public Main()
        {
            hoaDonBanDB = new HoaDonBanDB();
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonBan hoaDonBan = new HoaDonBan();
            hoaDonBan.nguoiMua = "Le Thi Lanh";
            hoaDonBan.tenThuoc = "Decalgen";
            hoaDonBan.maThuoc = "DCE";
            hoaDonBan.soLuong = 10;
            hoaDonBan.donGia = 10000;
            hoaDonBanDB.insert(hoaDonBan);
            loadDB();
        }

        private void loadDB()
        {
            DataSet ds = hoaDonBanDB.getAll();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.DataMember = "HOADON_BAN";
        }
    }
}
