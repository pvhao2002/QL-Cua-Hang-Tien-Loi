using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTienLoi
{
    public partial class frmMyorder : Form
    {
        user_account currentUser;
        public frmMyorder(user_account user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void frmMyorder_Load(object sender, EventArgs e)
        {
            using (var ctx = new DBCONTEXT())
            {
                var list = ctx.orders
                    .Where(item => item.user_id == currentUser.user_id).ToList();


                dgvMyOrder.DataSource = list.Select(item => new
                {
                    item.order_id,
                    item.buy_date,
                    price = string.Format("{0:N0} VNĐ", item.total_price),
                    status = translateStatusOrder(item.status)
                }).ToList();
            }
            dgvMyOrder.Columns[0].HeaderText = "Mã đơn hàng";
            dgvMyOrder.Columns[1].HeaderText = "Ngày mua";
            dgvMyOrder.Columns[2].HeaderText = "Giá tiền";
            dgvMyOrder.Columns[3].HeaderText = "Trạng thái";
        }
        public string translateStatusOrder(string status)
        {
            switch (status)
            {
                case "COMPLETED":
                    return "Hoàn thành đơn order";
                case "REJECTED":
                    return "Bị từ chối";
                case "IN PROGRESS":
                    return "Đang chuẩn bị đơn order";
                default:
                    return "Chờ xác nhận";
            }
        }
    }
}
