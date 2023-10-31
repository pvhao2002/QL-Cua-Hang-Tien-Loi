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
    public partial class frmMnStaff : Form
    {
        private bool add = false;
        public frmMnStaff()
        {
            InitializeComponent();
        }

        private void resetText()
        {
            txtFullName.ResetText();
            txtPassword.ResetText();
            txtPhone.ResetText();
            txtUsername.ResetText();
            rtxtAddress.ResetText();
            cboGender.SelectedIndex = 0;
        }

        private void toggleTextbox(bool state)
        {
            txtFullName.Enabled = state;
            txtPassword.Enabled = state;
            txtPhone.Enabled = state;
            txtUsername.Enabled = state;
            rtxtAddress.Enabled = state;
            cboGender.Enabled = state;
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
                dgvStaff.DataSource = ctx.user_account
                    .Where(item => item.status.Equals("ACTIVE") && item.role_id == (int?)ROLE.STAFF)
                    .Select(item => new
                    {
                        item.user_id,
                        item.full_name,
                        item.username,
                        item.password,
                        item.gender,
                        item.age,
                        item.phone,
                        item.address
                    })
                    .ToList();
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtID.Text = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFullName.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUsername.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboGender.SelectedIndex = (dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("Nam") ? 1 : 2);
            nmrAge.Value = Convert.ToDecimal(dgvStaff.Rows[e.RowIndex].Cells[5].Value);
            txtPhone.Text = dgvStaff.Rows[e.RowIndex].Cells[6].Value.ToString();
            rtxtAddress.Text = dgvStaff.Rows[e.RowIndex].Cells[7].Value.ToString();


            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = false;
        }

        private void frmMnStaff_Load(object sender, EventArgs e)
        {
            btnReload_Click(sender, e);
            dgvStaff.Columns[0].HeaderText = "Mã nhân viên";
            dgvStaff.Columns[1].HeaderText = "Tên nhân viên";
            dgvStaff.Columns[2].HeaderText = "Tên đăng nhập";
            dgvStaff.Columns[3].HeaderText = "Mật khẩu";
            dgvStaff.Columns[4].HeaderText = "Giới tính";
            dgvStaff.Columns[5].HeaderText = "Tuổi";
            dgvStaff.Columns[6].HeaderText = "Số điện thoại";
            dgvStaff.Columns[7].HeaderText = "Địa chỉ";
        }
            
        private void btnReload_Click(object sender, EventArgs e)
        {
            resetText();
            disableButton();
            toggleTextbox(false);
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            toggleTextbox(true);
            resetText();
            enableButton();
            txtFullName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            add = false;
            toggleTextbox(true);
            txtUsername.Enabled = false;
            enableButton();
            txtFullName.Focus();
        }
        private bool isEmptyInput()
        {
            return string.IsNullOrEmpty(txtUsername.Text.Trim())
                || string.IsNullOrEmpty(txtPassword.Text.Trim())
                || string.IsNullOrEmpty(txtFullName.Text.Trim())
                || string.IsNullOrEmpty(txtPhone.Text.Trim())
                || string.IsNullOrEmpty(rtxtAddress.Text.Trim())
                || cboGender.SelectedIndex == 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEmptyInput())
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin nhập");
                return;
            }

            try
            {
                using (var ctx = new DBCONTEXT())
                {
                    if (add)
                    {
                        var user = new user_account
                        {
                            username = txtUsername.Text.Trim(),
                            password = txtPassword.Text.Trim(),
                            full_name = txtFullName.Text.Trim(),
                            phone = txtPhone.Text.Trim(),
                            age = Convert.ToInt32(nmrAge.Value),
                            address = rtxtAddress.Text.Trim(),
                            gender = cboGender.Text,
                            status = "ACTIVE",
                            role_id = (int?)ROLE.STAFF
                        };
                        var isExist = ctx.user_account
                            .FirstOrDefault(item => item.username.Equals(user.username));
                        if (isExist != null)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại");
                        }
                        else
                        {
                            ctx.user_account.Add(user);
                            ctx.SaveChanges();
                            MessageBox.Show("Thêm thành công");
                        }
                    }
                    else
                    {
                        var user_id = Convert.ToInt32(txtID.Text);
                        var _user = ctx.user_account
                            .FirstOrDefault(item => item.user_id == user_id);
                        if (_user != null)
                        {
                            _user.password = txtPassword.Text.Trim();
                            _user.full_name = txtFullName.Text.Trim();
                            _user.phone = txtPhone.Text.Trim();
                            _user.address = rtxtAddress.Text.Trim();
                            _user.gender = cboGender.Text;  
                            _user.age = Convert.ToInt32(nmrAge.Value);
                            ctx.SaveChanges();
                            MessageBox.Show("Chỉnh thông tin thành công");
                        }

                    }
                }
                btnReload_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var ctx = new DBCONTEXT())
                    {
                        var user_id = Convert.ToInt32(txtID.Text);
                        var user = ctx.user_account
                            .FirstOrDefault(item => item.user_id == user_id);
                        if (user != null)
                        {
                            user.status = "INACTIVE";
                            ctx.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy nhân viên này");
                        }
                    }
                    btnReload_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
    }
}
