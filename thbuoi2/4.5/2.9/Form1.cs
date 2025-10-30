using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._9
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
            int chuvi  = (int.Parse(txtsoa.Text) + int.Parse(txtsob.Text))*2;
            txtketqua.Text =chuvi.ToString();
        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dientich= int.Parse(txtsoa.Text) * int.Parse(txtsob.Text);
            txtketqua.Text = dientich.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtsoa.Text);
            double b= double.Parse(txtsob.Text);
            double duongcheo = Math.Sqrt(a*a + b*b);
            txtketqua.Text = duongcheo.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

