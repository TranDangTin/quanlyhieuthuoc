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
            if (txtTenThuoc.Text == ""
                || txtHanSuDung.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
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
            if (txtTenThuoc.Text == ""
                || txtHanSuDung.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
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
                string hanSuDung = row.Cells[2].Value.ToString();
                string[] hanSuDungArr = hanSuDung.Split('-');
                int year = Int32.Parse(hanSuDungArr[2]);
                int month = Int32.Parse(hanSuDungArr[1]); ;
                int day = Int32.Parse(hanSuDungArr[0]); ;
                txtHanSuDung.Value = new DateTime(year, month, day);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "" && !cbkHetHanSuDung.Checked)
            {
                loadDB();
            }
            else
            {
                DataSet ds = hoaDonNhapDB.getByTenThuoc(txtTimkiem.Text, cbkHetHanSuDung.Checked);
                dataGridView1.DataSource = ds.Tables[0];
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
                workbook.SaveAs("c:\\hoadonnhap.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ex)
            {

            }
            app.Quit();
        }
    }
}
