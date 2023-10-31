using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCuaHangTienLoi
{
    public partial class frmCustomer : Form
    {
        user_account currentUser = null;
        public frmCustomer(user_account currentUser)
        {
            InitializeComponent();
            _order = new Dictionary<product, int>();
            this.currentUser = currentUser;
        }

        Dictionary<product, int> _order;


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void loadProductItem()
        {
            flpProductItem.Controls.Clear();

            using (var ctx = new DBCONTEXT())
            {
                var list = ctx.products
                      .Where(item => item.status.Equals("ACTIVE") && item.stock > 0)
                      .ToList();
                if(list.Count > 0)
                {
                    list.ForEach(item =>
                     {
                         var ucItem = new ucItemProduct(item);
                         ucItem.picProduct.Tag = item;
                         ucItem.picProduct.Click += PicProduct_Click;
                         ucItem.Click += UcItem_Click;
                         flpProductItem.Controls.Add(ucItem);
                     });
                }
                else
                {
                    Label label = new Label(); 
                    label.Width = 600;
                    label.Height = 200;
                    label.Font = new Font("tahoma", 16, FontStyle.Italic);
                    label.ForeColor = Color.Red;
                    label.Text = "Hiện tại các sản phẩm đã ngưng cung cấp dịch vụ";
                    flpProductItem.Controls.Add(label);
                }
            }
        }

        private void PicProduct_Click(object sender, EventArgs e)
        {
            var uc = sender as PictureBox;
            var tag = uc.Tag as product;
            if(_order.ContainsKey(tag))
            {
                _order[tag]++;
            }
            else
            {
                _order.Add(tag, 1);
            }
            loadCart();
        }
        decimal totalCartPrice = decimal.Zero;
        private void loadCart()
        {
            lvCart.Items.Clear();
            var total = decimal.Zero;
            foreach (var pair in _order)
            {
                product product = pair.Key;
                int quantity = pair.Value;

                // Tính toán thành tiền
                decimal totalPrice = Convert.ToDecimal(product.price * quantity);
                total += totalPrice;

                // Tạo một ListViewItem mới
                ListViewItem item = new ListViewItem(product.product_id.ToString());
                item.SubItems.Add(product.product_name);
                item.SubItems.Add(string.Format("{0:N0} VNĐ", product.price)); // Định dạng đơn giá
                item.SubItems.Add(quantity.ToString());
                item.SubItems.Add(string.Format("{0:N0} VNĐ", totalPrice)); // Định dạng thành tiền

                // Thêm item vào ListView
                lvCart.Items.Add(item);
            }
            totalCartPrice = total;
            txtTotalPrice.Text = string.Format("{0:N0} VNĐ", totalCartPrice);
            btnPayment.Enabled = true;
        }

        private void UcItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pickOrder, "Lịch sử đơn hàng");
            loadProductItem();
            loadCart();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProductItem();
            _order.Clear();
            loadCart();
            btnPayment.Enabled = false;
            totalCartPrice = 0;
            txtTotalPrice.Text = string.Format("{0:N0} VNĐ", totalCartPrice);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            using (var ctx = new DBCONTEXT())
            {
                // Tạo một bản ghi đơn hàng
                var newOrder = new order
                {
                    user_id = currentUser.user_id,  
                    buy_date = DateTime.Now,   
                    total_price = Convert.ToDouble(totalCartPrice),
                    status = "PENDING"
                };
                ctx.orders.Add(newOrder);
                ctx.SaveChanges();

                // Lấy mã đơn hàng sau khi thêm vào cơ sở dữ liệu
                int orderID = newOrder.order_id;

                foreach (var entry in _order)
                {
                    var product = entry.Key; 
                    int quantity = entry.Value;  

                    var orderItem = new order_item
                    {
                        order_id = orderID,  
                        product_id = product.product_id,  
                        quantity = quantity,  
                        total_price_item = product.price * quantity  
                    };
                    ctx.order_item.Add(orderItem);
                }
                ctx.SaveChanges();
            }
            btnRefresh_Click(sender, e);
        }

        private void pickOrder_Click(object sender, EventArgs e)
        {
            new frmMyorder(currentUser).ShowDialog();
        }
    }
}
