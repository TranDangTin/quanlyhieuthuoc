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
    public partial class HoaDonBanThuocFrm : Form
    {
        private HoaDonBanDB hoaDonBanDB;
        private string id;
        public HoaDonBanThuocFrm()
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
            hoaDonBan.nguoiMua = txtNguoiMua.Text;
            hoaDonBan.tenThuoc = txtTenThuoc.Text;
            hoaDonBan.maThuoc = txtMaThuoc.Text;
            hoaDonBan.soLuong = Int32.Parse(txtSoLuong.Text);
            hoaDonBan.donGia = Int32.Parse(txtDonGia.Text);
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
            hoaDonBan.id = long.Parse(id);
            hoaDonBan.nguoiMua = txtNguoiMua.Text;
            hoaDonBan.tenThuoc = txtTenThuoc.Text;
            hoaDonBan.maThuoc = txtMaThuoc.Text;
            hoaDonBan.soLuong = Int32.Parse(txtSoLuong.Text);
            hoaDonBan.donGia = Int32.Parse(txtDonGia.Text);
            hoaDonBanDB.update(hoaDonBan);
            loadDB();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                txtNguoiMua.Text = row.Cells[1].Value.ToString();
                txtTenThuoc.Text = row.Cells[2].Value.ToString();
                txtMaThuoc.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
                txtDonGia.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoaDonBan hoaDonBan = new HoaDonBan();
            hoaDonBan.id = long.Parse(id);
            hoaDonBanDB.delete(hoaDonBan);
            txtNguoiMua.Text = "";
            txtTenThuoc.Text = "";
            txtMaThuoc.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            loadDB();
        }
    }
}
