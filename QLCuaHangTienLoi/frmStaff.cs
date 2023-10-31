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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            frmMnProduct frm = new frmMnProduct();
            frm.TopLevel = false;
            pnContent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnMnProduct_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();

            frmMnProduct frm = new frmMnProduct();
            frm.TopLevel = false;
            pnContent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnMnOrder_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();

            frmMnOrrder frm = new frmMnOrrder();
            frm.TopLevel = false;
            pnContent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
