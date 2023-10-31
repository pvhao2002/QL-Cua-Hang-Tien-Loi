namespace QLCuaHangTienLoi
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmrAge = new System.Windows.Forms.NumericUpDown();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAge)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 517);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(659, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng ký tài khoản khách hàng";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtUsername.Location = new System.Drawing.Point(750, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(363, 34);
            this.txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPassword.Location = new System.Drawing.Point(750, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(363, 34);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtFullname.Location = new System.Drawing.Point(750, 202);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(363, 34);
            this.txtFullname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính:";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Chọn giới tính",
            "Nam",
            "Nữ"});
            this.cboGender.Location = new System.Drawing.Point(750, 242);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(363, 33);
            this.cboGender.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tuổi:";
            // 
            // nmrAge
            // 
            this.nmrAge.Location = new System.Drawing.Point(750, 281);
            this.nmrAge.Name = "nmrAge";
            this.nmrAge.Size = new System.Drawing.Size(120, 30);
            this.nmrAge.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPhone.Location = new System.Drawing.Point(750, 317);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(363, 34);
            this.txtPhone.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Địa chỉ:";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(750, 357);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(363, 79);
            this.rtxtAddress.TabIndex = 6;
            this.rtxtAddress.Text = "";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(750, 442);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(161, 53);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Location = new System.Drawing.Point(952, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 53);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.Color.MistyRose;
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(750, 84);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(363, 35);
            this.lbMessage.TabIndex = 9;
            this.lbMessage.Text = "Tên đăng nhập đã tồn tại";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 517);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.nmrAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmrAge;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMessage;
    }
}