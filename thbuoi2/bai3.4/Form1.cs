using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c;

            // Kiểm tra nhập liệu
            if (!double.TryParse(txtA.Text, out a) ||
                !double.TryParse(txtB.Text, out b) ||
                !double.TryParse(txtC.Text, out c))
            {
                MessageBox.Show("Vui lòng nhập các hệ số hợp lệ!");
                return;
            }

            string ketQua = "";

            if (a == 0)
            {
                // Phương trình bậc nhất: bx + c = 0
                if (b == 0)
                {
                    if (c == 0)
                        ketQua = "Phương trình vô số nghiệm";
                    else
                        ketQua = "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -c / b;
                    ketQua = $"Phương trình có 1 nghiệm: x = {x:F2}";
                }
            }
            else
            {
                // Phương trình bậc 2
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    ketQua = "Phương trình vô nghiệm thực";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    ketQua = $"Phương trình có nghiệm kép: x1 = x2 = {x:F2}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ketQua = $"Phương trình có 2 nghiệm:\n x1 = {x1:F2}, x2 = {x2:F2}";
                }
            }

            txtKetqua.Text = ketQua;
        }
    }
}
