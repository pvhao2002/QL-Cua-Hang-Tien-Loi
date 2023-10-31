using DataLayer;
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
    public partial class frmMnStatistic : Form
    {
        public frmMnStatistic()
        {
            InitializeComponent();
        }

        private void frmMnStatistic_Load(object sender, EventArgs e)
        {
            using (var ctx = new DBCONTEXT())
            {
                var list = ctx.orders
                    .Where(item => item.status.Equals("IN PROGRESS") || item.status.Equals("COMPLETED"))
                    .ToList();
                dgvOrder.DataSource = list
                    .Select(item => new
                    {
                        item.order_id,
                        item.user_account.username,
                        item.buy_date,
                        total = string.Format("{0:N0} VNĐ", item.total_price)
                    })
                    .ToList();
                var total = Decimal.Zero;
                list.ForEach(item =>
                {
                    total += Convert.ToDecimal(item.total_price);
                });
                txtTotal.Text = string.Format("{0:N0} VNĐ", total);
            }
        }
    }
}
