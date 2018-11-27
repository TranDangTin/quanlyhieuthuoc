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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtNguoiMua.Text == "" 
                || txtTenThuoc.Text == "" 
                || txtMaThuoc.Text == ""
                || txtSoLuong.Text == ""
                || txtDonGia.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }

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

        private void btcCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNguoiMua.Text == ""
                || txtTenThuoc.Text == ""
                || txtMaThuoc.Text == ""
                || txtSoLuong.Text == ""
                || txtDonGia.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }

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

        private void btnXoa_Click(object sender, EventArgs e)
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text != "")
            {
                DataSet ds = hoaDonBanDB.getByNguoiMua(txtTimkiem.Text);
                dataGridView1.DataSource = ds.Tables[0];
            } else
            {
                loadDB();
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < this.dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = this.dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            try
            {
                workbook.SaveAs("c:\\hoadonban.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            } catch (Exception ex)
            {

            }
        }
    }
}
