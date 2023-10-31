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
    public partial class ucItemProduct : UserControl
    {
        product p = null;
        public ucItemProduct(product item)
        {
            InitializeComponent();
            p = item;
        }

        private void ucItemProduct_Load(object sender, EventArgs e)
        {
            try
            {
                picProduct.Image = new Bitmap(p.image);
            }
            catch (Exception)
            {
                picProduct.Image = picProduct.ErrorImage;
            }
            lbDes.Text = $"{p.product_name} - {p.price}VND";
        }
    }
}
