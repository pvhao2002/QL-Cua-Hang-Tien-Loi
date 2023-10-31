using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTienLoi
{
    public partial class frmMnProduct : Form
    {
        private bool add;
        public frmMnProduct()
        {
            InitializeComponent();
        }

        private void toggleText(bool state)
        {
            txtName.Enabled = state;
            nmrPrice.Enabled = state;
            nmrStock.Enabled = state;
            btnChoose.Enabled = state;
        }

        private void resetText()
        {
            txtName.ResetText();
            txtImage.ResetText();
            nmrStock.Value = 0;
            nmrPrice.Value = 0;
            picProduct.Image = null;
        }

        private void disableButton()
        {
            btnAdd.Enabled = true;

            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void enableButton()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            btnSave.Enabled = true;
        }
        private void loadData()
        {
            using (var ctx = new DBCONTEXT())
            {
                dgvProduct.DataSource = ctx.products
                    .Where(item => item.status.Equals("ACTIVE"))
                    .Select(item => new
                    {
                        item.product_id,
                        item.product_name,
                        item.price,
                        item.stock,
                        item.image
                    })
                    .ToList();
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtId.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                nmrPrice.Value = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells[2].Value);
                nmrStock.Value = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells[3].Value);
                txtImage.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                try
                {
                    picProduct.Image = new Bitmap(txtImage.Text);
                }
                catch (Exception)
                {
                    picProduct.Image = null;    
                }

                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            resetText();
            toggleText(false);
            disableButton();
            loadData();
        }

        private bool validInput()
        {
            return !string.IsNullOrEmpty(txtName.Text.Trim())
                || nmrPrice.Value > 0
                || nmrStock.Value > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validInput())
            {
                try
                {
                    using (var ctx = new DBCONTEXT())
                    {
                        if (add)
                        {
                            var item = new product
                            {
                                product_name = txtName.Text.Trim(),
                                image = txtImage.Text.Trim(),
                                price = Convert.ToDouble(nmrPrice.Value),
                                stock = Convert.ToInt32(nmrStock.Value),
                                status = "ACTIVE"
                            };
                            ctx.products.Add(item);
                            ctx.SaveChanges();
                        }
                        else
                        {
                            var pId = Convert.ToInt32(txtId.Text);
                            var product = ctx.products.FirstOrDefault(item => item.product_id == pId);
                            product.price = Convert.ToDouble(nmrPrice.Value);
                            product.stock = Convert.ToInt32(nmrStock.Value);
                            product.product_name = txtName.Text.Trim();
                            product.image = txtImage.Text.Trim();
                            ctx.SaveChanges();
                        }
                    }
                    showMessage($"Thành công", "Thông báo", MessageBoxIcon.Information, MessageBoxButtons.OK);
                    btnReload_Click(sender, e);
                }
                catch (Exception ex)
                {
                    showMessage($"Lỗi: {ex.Message}", "Thông báo", MessageBoxIcon.Information, MessageBoxButtons.OK);
                }
            }
            else
            {
                showMessage("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxIcon.Information, MessageBoxButtons.OK);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                showMessage("Vui lòng chọn sản phẩm để xóa", "Thông báo", MessageBoxIcon.Information, MessageBoxButtons.OK);
                return;
            }
            if (showMessage("Bạn có muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var ctx = new DBCONTEXT())
                {
                    var pId = Convert.ToInt32(txtId.Text.Trim());
                    var p = ctx.products.FirstOrDefault(item => item.product_id == pId);
                    if (p == null)
                    {
                        showMessage("Không tìm thấy sản phẩm", "Thông báo", MessageBoxIcon.Information, MessageBoxButtons.OK);
                    }
                    else
                    {
                        p.status = "INACTIVE";
                        ctx.SaveChanges();
                    }
                }
                btnReload_Click(sender, e);
            }
        }
        private DialogResult showMessage(string text, string title, MessageBoxIcon icon, MessageBoxButtons button)
        {
            return MessageBox.Show(text, title, button, icon);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            add = false;
            toggleText(true);
            enableButton();
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            resetText();
            toggleText(true);
            enableButton();
            txtName.Focus();
        }

        private void frmMnProduct_Load(object sender, EventArgs e)
        {
            btnReload_Click(sender, e);

            dgvProduct.Columns[0].HeaderText = "Mã sản phẩm";
            dgvProduct.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns[2].HeaderText = "Giá";
            dgvProduct.Columns[3].HeaderText = "Số lượng trong kho";
            dgvProduct.Columns[4].HeaderText = "Hình ảnh";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog open = new OpenFileDialog())
                {
                    // image filters  
                    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy đường dẫn của tệp được chọn
                        string selectedImagePath = open.FileName;

                        // root path (QLCuaHangTienLoi)
                        string path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

                        // Tạo một đường dẫn mới để lưu bản sao vào thư mục ./images/
                        string destinationPath = Path.Combine(
                                            path,
                                            "images",
                                            Path.GetFileName(selectedImagePath));

                        if (!File.Exists(destinationPath))
                        {
                            // Sao chép tệp hình ảnh vào thư mục ./images/
                            File.Copy(selectedImagePath, destinationPath, true);
                        }
                        // Cập nhật đường dẫn tương đối trong txtImage.Text
                        txtImage.Text = destinationPath;
                        // Hiển thị hình ảnh trong pictureBox
                        picProduct.Image = new Bitmap(destinationPath);
                    }
                }
            }
            catch (Exception ex)
            {
                showMessage($"Lỗi: {ex.Message}", "Lỗi", MessageBoxIcon.Error, MessageBoxButtons.OK);
                txtName.Text = ex.Message;
            }

        }
    }
}
