using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class frmTinh : Form
    {
        public frmTinh()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            txtSo1.Focus();
        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {
            txtSo2.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (txtSo1.Text == "" || txtSo2.Text == "") return;

            double so1 = double.Parse(txtSo1.Text);
            double so2 = double.Parse(txtSo2.Text);
            double kq = 0;

            if (rad1.Checked) kq = so1 + so2;
            else if (rad2.Checked) kq = so1 - so2;
            else if (rad3.Checked) kq = so1 * so2;
            else if (rad4.Checked) kq = so1 / so2;
            txtKetqua.Text = kq.ToString();
        }

        private void txtKetqua_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKetqua_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text == "" || txtSo2.Text == "") return;

            double so1 = double.Parse(txtSo1.Text);
            double so2 = double.Parse(txtSo2.Text);
            double kq = 0;
            txtKetqua.Text = (so1+ so2 ).ToString();
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text == "" || txtSo2.Text == "") return;

            double so1 = double.Parse(txtSo1.Text);
            double so2 = double.Parse(txtSo2.Text);
            double kq = 0;
            txtKetqua.Text = (so1 - so2).ToString();

        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text == "" || txtSo2.Text == "") return;

            double so1 = double.Parse(txtSo1.Text);
            double so2 = double.Parse(txtSo2.Text);
            double kq = 0;
            txtKetqua.Text = (so1 * so2).ToString();
        }

        private void rad4_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text == "" || txtSo2.Text == "") return;

            double so1 = double.Parse(txtSo1.Text);
            double so2 = double.Parse(txtSo2.Text);
            double kq = 0;
            txtKetqua.Text = (so1 / so2).ToString();
        }
    }
}
