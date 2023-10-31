using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTienLoi
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            frmMnStaff frm = new frmMnStaff();
            frm.TopLevel = false;
            pnContent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnMnStaff_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();

            frmMnStaff frm = new frmMnStaff();
            frm.TopLevel = false;
            pnContent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
            frmMnStatistic frm = new frmMnStatistic();
            frm.TopLevel = false;
            pnContent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
