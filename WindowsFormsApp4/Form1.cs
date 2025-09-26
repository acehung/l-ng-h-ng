using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Frmbai2 : Form
    {
        public Frmbai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            string hoten = this.txtHoTen.Text.Trim();
            if (this.rad1.Checked == true)
                txtKq.Text = hoten.ToLower();
            if (this.rad2.Checked == true)
                txtKq.Text = hoten.ToUpper();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.btnKetqua.Text = string.Empty;
            this.rad1.Checked = true;
            this.txtHoTen.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
