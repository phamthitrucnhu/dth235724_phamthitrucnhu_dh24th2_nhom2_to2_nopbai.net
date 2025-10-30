using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2._1
{
    public partial class frmChuongTrinhThoiGian : Form
    {
        public frmChuongTrinhThoiGian()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "Xin chào, chúc một ngày vui vẻ ";
            lbl.Font = new Font("Arial  ", 16, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(50, 50);
            this.Controls.Add(lbl);


        }
    }
}
