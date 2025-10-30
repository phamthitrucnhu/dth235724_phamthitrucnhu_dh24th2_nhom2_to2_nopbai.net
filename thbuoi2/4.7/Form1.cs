using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._7
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
            if (!int.TryParse(txtN.Text, out n) || n < 0)
            {
                MessageBox.Show("Nhập n ≥ 0");
                return;
            }

            long S = 1;
            for (int i = 1; i <= n; i++)
                S *= i;

            txtKetqua.Text = S.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKetqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
