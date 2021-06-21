using QL_BanHang.Control;
using QL_BanHang.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using QL_BanHang.View;
using System.Text;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }
        NhanVienCtrl NhanVienCtrl = new NhanVienCtrl();

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void CheckNull()
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please fill your information", "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienObj ob = new NhanVienObj();
            CheckNull();
            if (NhanVienCtrl.Login(ob))
            {
                Form1 gotos = new Form1();
                this.Hide();
                gotos.Show();
            }
            else
            {
                MessageBox.Show("Faild to Login. Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("Do you want to exit program ?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mess = DialogResult.Yes)
            {

            }
        }
    }
}
