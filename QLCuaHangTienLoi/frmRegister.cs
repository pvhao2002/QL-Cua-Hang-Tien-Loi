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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLCuaHangTienLoi
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            lbMessage.BackColor = this.BackColor;
            lbMessage.Text = string.Empty;
            cboGender.SelectedIndex = 0;
        }


        public bool checkEmptyInput()
        {
            return string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text);
        }

        private void showMessage(string text, Color color)
        {
            lbMessage.Text = text;
            lbMessage.BackColor = color;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (checkEmptyInput())
            {
                showMessage("Thông tin không hợp lệ!", Color.MistyRose);
                return;
            }
            if (cboGender.SelectedIndex == 0)
            {
                showMessage("Vui lòng chọn giới tính!", Color.MistyRose);
                return;
            }
            using (var ctx = new DBCONTEXT())
            {
                var isExist = ctx.user_account.FirstOrDefault(item => item.username.Equals(txtUsername.Text.Trim()));
                if (isExist != null)
                {
                    showMessage("Tên đăng nhập đã tồn tại!", Color.MistyRose);
                    return;
                }

                var newUser = new user_account
                {
                    username = txtUsername.Text.Trim(),
                    password = txtPassword.Text.Trim(),
                    full_name = txtFullname.Text.Trim(),
                    gender = cboGender.Text,
                    age = Convert.ToInt32(nmrAge.Value),
                    phone = txtPhone.Text.Trim(),
                    address = rtxtAddress.Text.Trim(),
                    role_id = (int?)ROLE.CUSTOMER,
                    status = "ACTIVE"
                };
                ctx.user_account.Add(newUser);
                ctx.SaveChanges();
            }
            showMessage($"Đăng ký tài khoản thành công", Color.LightGreen);
            await Task.Delay(1500);
            btnCancel_Click(sender, e);
        }
    }
}
