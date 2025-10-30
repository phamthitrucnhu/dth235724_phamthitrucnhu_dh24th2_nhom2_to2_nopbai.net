using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x, y = 0;
            if (!double.TryParse(txtX.Text, out x))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }

            if (x > 2)
                y = 8 * Math.Pow(x, 3) - 12 * Math.Pow(x, 2) + 11 * x - 3;
            else if (x >= 1 && x <= 2)
                y = Math.Pow(x, 2) - 6 * x - 19;
            else
                y = 7 * x;

            txtF.Text = y.ToString();
        }
    }
}
