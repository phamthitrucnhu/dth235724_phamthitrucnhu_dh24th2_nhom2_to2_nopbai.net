using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTong.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tong = int.Parse(txtsoa.Text) + int.Parse(txtsob.Text)   ;
            txtTong.Text=tong.ToString();
        }
    }
}
