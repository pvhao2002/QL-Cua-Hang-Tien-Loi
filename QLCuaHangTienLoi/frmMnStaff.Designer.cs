namespace QLCuaHangTienLoi
{
    partial class frmMnStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrAge = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAge)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.rtxtAddress);
            this.panel1.Controls.Add(this.nmrAge);
            this.panel1.Controls.Add(this.cboGender);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 327);
            this.panel1.TabIndex = 0;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(0, 327);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1114, 398);
            this.dgvStaff.TabIndex = 1;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(170, 58);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(303, 30);
            this.txtID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(170, 108);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(303, 30);
            this.txtFullName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 159);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(303, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mật khẩu:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(303, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới tính:";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Chọn giới tính",
            "Nam",
            "Nữ"});
            this.cboGender.Location = new System.Drawing.Point(665, 53);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(306, 33);
            this.cboGender.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tuổi:";
            // 
            // nmrAge
            // 
            this.nmrAge.Location = new System.Drawing.Point(665, 111);
            this.nmrAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nmrAge.Name = "nmrAge";
            this.nmrAge.Size = new System.Drawing.Size(120, 30);
            this.nmrAge.TabIndex = 4;
            this.nmrAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(804, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "* Tuổi của nhân viên từ 18 trở lên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(669, 161);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(303, 30);
            this.txtPhone.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Địa chỉ:";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(669, 197);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(303, 45);
            this.rtxtAddress.TabIndex = 6;
            this.rtxtAddress.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(62, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 53);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(251, 268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 53);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(426, 268);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(154, 53);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(610, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 53);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(788, 268);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(154, 53);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmMnStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 725);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMnStaff";
            this.Text = "frmMnStaff";
            this.Load += new System.EventHandler(this.frmMnStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.NumericUpDown nmrAge;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}