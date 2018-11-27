using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class HoaDonNhapThuocFrm : Form
    {
        private HoaDonNhapDB hoaDonNhapDB;
        private string id;
        public HoaDonNhapThuocFrm()
        {
            hoaDonNhapDB = new HoaDonNhapDB();
            InitializeComponent();
        }

        private void HoaDonNhapThuocFrm_Load(object sender, EventArgs e)
        {
            loadDB();
        }
        private void loadDB()
        {
            DataSet ds = hoaDonNhapDB.getAll();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDonNhap hoaDonNhap  = new HoaDonNhap();
            hoaDonNhap.tenThuoc = txtTenThuoc.Text;
            hoaDonNhap.hanSuDung = txtHanSuDung.Text;
            hoaDonNhapDB.insert(hoaDonNhap);
            loadDB();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDonNhap hoaDonNhap = new HoaDonNhap();
            hoaDonNhap.id = long.Parse(id);
            hoaDonNhapDB.delete(hoaDonNhap);
            txtTenThuoc.Text = "";
            txtHanSuDung.Text = "";
            loadDB();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HoaDonNhap hoaDonNhap = new HoaDonNhap();
            hoaDonNhap.id = long.Parse(id);
            hoaDonNhap.tenThuoc = txtTenThuoc.Text;
            hoaDonNhap.hanSuDung = txtHanSuDung.Text;
            hoaDonNhapDB.update(hoaDonNhap);
            loadDB();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                txtTenThuoc.Text = row.Cells[1].Value.ToString();
                txtHanSuDung.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
