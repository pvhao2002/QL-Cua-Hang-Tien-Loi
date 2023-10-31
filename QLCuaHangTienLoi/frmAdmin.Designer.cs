namespace QLCuaHangTienLoi
{
    partial class frmAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMnStaff = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 56);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1170, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ CỦA HÀNG TIỆN LỢI - QUẢN LÝ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(230, 56);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1170, 725);
            this.pnContent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.btnMnStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 781);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(3, 712);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(221, 57);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMnStaff
            // 
            this.btnMnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMnStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMnStaff.Location = new System.Drawing.Point(3, 90);
            this.btnMnStaff.Name = "btnMnStaff";
            this.btnMnStaff.Size = new System.Drawing.Size(221, 57);
            this.btnMnStaff.TabIndex = 0;
            this.btnMnStaff.Text = "Quản lý nhân viên";
            this.btnMnStaff.UseVisualStyleBackColor = true;
            this.btnMnStaff.Click += new System.EventHandler(this.btnMnStaff_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatistic.Location = new System.Drawing.Point(3, 183);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(221, 57);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "Thống kê đơn hàng";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 781);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMnStaff;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStatistic;
    }
}