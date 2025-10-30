using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtN.Text, out n) || n < 1)
            {
                MessageBox.Show("Nhập n > 0");
                return;
            }

            int S = 0;
            for (int i = 1; i <= n; i++)
                S += 2 * i;

            txtKetqua.Text = S.ToString();
        }
    }
}
