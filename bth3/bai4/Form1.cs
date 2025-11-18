using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtNhapht.Focus();
            }
            else
            {
                string hoten = txtHoTen.Text;
                if (this.rdoChuthuong.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                if (this.rdoChuhoa.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToUpper();
                }
            }

        }
    }
}
