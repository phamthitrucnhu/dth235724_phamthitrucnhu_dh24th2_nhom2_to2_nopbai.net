using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void txtTong_Click(object sender, EventArgs e)
        {
            int tong = int.Parse(txtSoa.Text) + int.Parse(txtSob.Text);
            txtTong.Text = tong.ToString();
            MessageBox.Show(txtTong.Text);
        }
    }
}
