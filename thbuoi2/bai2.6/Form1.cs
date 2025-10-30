using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a= int.Parse(txtSo_A.Text);
            int b = int.Parse(txtSo__B.Text);
            int tong = a + b;
            btnTong.Text = (tong.ToString());
            MessageBox.Show(btnTong.Text);

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo_A.Text);
            int b = int.Parse(txtSo__B.Text);
            int hieu= a - b;
            btnHieu.Text = (hieu.ToString());
            MessageBox.Show(btnHieu.Text);
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo_A.Text);
            int b = int.Parse(txtSo__B.Text);
            int tich  = a * b;
            btnTich.Text = (tich.ToString());
            MessageBox.Show(btnTich.Text);
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo_A.Text);
            int b = int.Parse(txtSo__B.Text);
            int thuong = a + b;
            btnThuong.Text = (thuong.ToString());
            MessageBox.Show(btnThuong.Text);
        }
    }
}
