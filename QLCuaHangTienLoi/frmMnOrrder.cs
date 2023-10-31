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
    public partial class frmMnOrrder : Form
    {
        public frmMnOrrder()
        {
            InitializeComponent();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var status = dgvOrder.Rows[e.RowIndex].Cells["status"].Value as string;
                btnAccept.Text = status.Equals("PENDING") ? "Xác nhận" : "Hoàn thành";
                btnReject.Enabled = status.Equals("PENDING");
                btnAccept.Enabled = true;

                var orderId = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["order_id"].Value);
                using(var ctx= new DBCONTEXT())
                {
                    var list = ctx.order_item
                        .Where(item => item.order_id == orderId)
                        .ToList();
                    lvOrderDetail.Items.Clear();
                    list.ForEach(item =>
                    {
                        ListViewItem lvItem = new ListViewItem(item.product_id.ToString());
                        lvItem.SubItems.Add(item.product.product_name);
                        lvItem.SubItems.Add(string.Format("{0:N0} VNĐ", item.product.price)); // Định dạng đơn giá
                        lvItem.SubItems.Add(item.quantity.ToString());
                        lvItem.SubItems.Add(string.Format("{0:N0} VNĐ", item.total_price_item)); // Định dạng thành tiền
                        lvOrderDetail.Items.Add(lvItem);
                    });
                }
            }
        }

        void loadDGV()
        {
            using (var ctx = new DBCONTEXT())
            {
                var list = ctx.orders
                    .Where(item => item.status.Equals("PENDING") || item.status.Equals("IN PROGRESS"))
                    .ToList();
                dgvOrder.DataSource = list
                    .Select(item => new
                    {
                        item.order_id,
                        item.user_id,
                        item.user_account.username,
                        item.user_account.full_name,
                        item.buy_date,
                        price = string.Format("{0:N0} VNĐ", item.total_price),
                        item.status
                    })
                    .ToList();
            }
            lvOrderDetail.Items.Clear();
            btnReject.Enabled = false;
            btnAccept.Enabled = false;
        }

        private void frmMnOrrder_Load(object sender, EventArgs e)
        {


            loadDGV();
            dgvOrder.Columns[0].HeaderText = "Mã đơn hàng";
            dgvOrder.Columns[1].HeaderText = "Mã khách hàng";
            dgvOrder.Columns[2].HeaderText = "Khách hàng";
            dgvOrder.Columns[3].HeaderText = "Họ tên khách hàng";
            dgvOrder.Columns[4].HeaderText = "Ngày mua";
            dgvOrder.Columns[5].HeaderText = "Giá tiền";
            dgvOrder.Columns[5].HeaderText = "Trạng thái";

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                var orderId = Convert.ToInt32(dgvOrder.CurrentRow.Cells["order_id"].Value);
                using (var ctx = new DBCONTEXT())
                {
                    var order = ctx.orders.FirstOrDefault(item => item.order_id == orderId);
                    if (order != null)
                    {
                        order.status = btnAccept.Text.Equals("Xác nhận") ? "IN PROGRESS" : "COMPLETED";
                        ctx.SaveChanges();
                    }
                }
                loadDGV();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if(dgvOrder.SelectedRows.Count > 0)
            {
                var orderId = Convert.ToInt32(dgvOrder.CurrentRow.Cells["order_id"].Value);
                using(var ctx = new DBCONTEXT())
                {
                    var order = ctx.orders.FirstOrDefault(item => item.order_id == orderId);
                    if(order != null)
                    {
                        order.status = "REJECTED";
                        ctx.SaveChanges();
                    }
                }
                loadDGV();
            }
        }
    }
}
