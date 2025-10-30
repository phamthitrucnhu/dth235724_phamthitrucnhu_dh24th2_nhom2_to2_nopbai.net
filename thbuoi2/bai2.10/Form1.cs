using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chuvi = (int.Parse(txtsoa.Text) + int.Parse(txtsob.Text)) * 2;
            button1.Text = chuvi.ToString();
            MessageBox.Show("chuvi: " + button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dientich= (int.Parse(txtsoa.Text) *int.Parse(txtsob.Text)) * 2;
            button2.Text = dientich.ToString();
            MessageBox.Show("dientich: " + button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtsoa.Text);
            double b = double.Parse(txtsob.Text);
            double duongcheo = Math.Sqrt(a * a + b * b);
            button3.Text = duongcheo.ToString();
            MessageBox.Show("duongcheo: " + button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
