using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtketqua.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int tong = int.Parse(txtsoa.Text) + int.Parse(txtsob.Text);
            txtketqua.Text = tong.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hieu = int.Parse(txtsoa.Text) - int.Parse(txtsob.Text);
            txtketqua.Text = hieu.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tich = int.Parse(txtsoa.Text) * int.Parse(txtsob.Text);
            txtketqua.Text = tich.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int thuong = int.Parse(txtsoa.Text) / int.Parse(txtsob.Text);
            txtketqua.Text = thuong.ToString();
        }
    }
}
