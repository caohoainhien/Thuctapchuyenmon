using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHangHoa hanghoa = new frmHangHoa();
            hanghoa.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHoaDon hoaDon = new frmHoaDon();
            hoaDon.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKhachHang khachHang = new frmKhachHang();
            khachHang.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanVien = new frmNhanVien();
            nhanVien.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mess = MessageBox.Show("Do you want to exit program", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mess == DialogResult.Yes)
            {
                Environment.Exit(-1);
            }
        }
    }
}
