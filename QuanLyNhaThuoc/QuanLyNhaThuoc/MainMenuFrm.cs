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
    public partial class MainMenuFrm : Form
    {
        public MainMenuFrm()
        {
            InitializeComponent();
        }

        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            new HoaDonBanThuocFrm().Show();
        }

        private void btnNhapThuoc_Click(object sender, EventArgs e)
        {
            new HoaDonNhapThuocFrm().Show();
        }
    }
}
