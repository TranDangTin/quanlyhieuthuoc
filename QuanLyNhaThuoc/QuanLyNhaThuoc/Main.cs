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
            hoaDonBan.nguoiMua = "Trần Đăng Tín Tín Tín";
            hoaDonBan.tenThuoc = "Tín Tín Tín";
            hoaDonBan.maThuoc = "DCE - update";
            hoaDonBan.soLuong = 11;
            hoaDonBan.donGia = 110000;
            hoaDonBanDB.insert(hoaDonBan);
            loadDB();
        }

        private void loadDB()
        {
            DataSet ds = hoaDonBanDB.getAll();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoaDonBan hoaDonBan = new HoaDonBan();
            hoaDonBan.id = 2;
            hoaDonBan.nguoiMua = "Trần Đăng Tín Tín Tín";
            hoaDonBan.tenThuoc = "Decalgen Tín - update";
            hoaDonBan.maThuoc = "DCE - update";
            hoaDonBan.soLuong = 11;
            hoaDonBan.donGia = 11000;
            hoaDonBanDB.update(hoaDonBan);
            loadDB();
        }
    }
}
