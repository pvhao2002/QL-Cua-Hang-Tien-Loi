using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangTienLoi
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lbMessage.Text = "";
            lbMessage.BackColor = this.BackColor;
            lbRegister.Links.Clear();
            lbRegister.Links.Add(23, 12);
            lbRegister.LinkColor = Color.Green;
        }

        private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmRegister().ShowDialog();
            this.Show();
        }
        private void showMessage(string text, Color color)
        {
            lbMessage.Text = text;
            lbMessage.BackColor = color;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var ctx = new DBCONTEXT())
            {
                var user = ctx.user_account.FirstOrDefault(item => item.username.Equals(txtUsername.Text.Trim()));

                if (user != null)
                {
                    if (user.password.Equals(txtPassword.Text.Trim()))
                    {
                        this.Hide();
                        if (user.role_id == (int?)ROLE.CUSTOMER)
                        {
                            new frmCustomer(user).ShowDialog();
                        }
                        else if (user.role_id == (int?)ROLE.STAFF)
                        {
                            new frmStaff().ShowDialog();
                        }
                        else
                        {
                            new frmAdmin().ShowDialog();
                        }
                        lbMessage.Text = "";
                        lbMessage.BackColor = this.BackColor;
                        this.Show();
                    }
                    else
                    {
                        showMessage("Tên đăng nhập hoặc mật khẩu không đúng!", Color.MistyRose);
                    }
                }
                else
                {
                    showMessage("Tên đăng nhập hoặc mật khẩu không đúng!", Color.MistyRose);

                }
            }
        }
    }
}
