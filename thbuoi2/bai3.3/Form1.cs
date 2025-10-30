using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._3
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

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int ngay, thang, nam;
            if (!int.TryParse(txtNgay.Text, out ngay) ||
                !int.TryParse(txtThang.Text, out thang) ||
                !int.TryParse(txtNam.Text, out nam))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }

            bool hopLe = true;
            int soNgayTrongThang = 31;

            switch (thang)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    soNgayTrongThang = 30;
                    break;
                case 2:
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                        soNgayTrongThang = 29;
                    else
                        soNgayTrongThang = 28;
                    break;
                default:
                    if (thang < 1 || thang > 12)
                        hopLe = false;
                    break;
            }

            if (hopLe && (ngay < 1 || ngay > soNgayTrongThang))
                hopLe = false;

            if (hopLe)
                MessageBox.Show("Ngày hợp lệ!");
            else
                MessageBox.Show("Ngày KHÔNG hợp lệ!");
        }
    }
}
