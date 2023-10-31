namespace QLCuaHangTienLoi
{
    partial class frmStaff
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMnOrder = new System.Windows.Forms.Button();
            this.btnMnProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMnOrder);
            this.panel1.Controls.Add(this.btnMnProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 762);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Lavender;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Indigo;
            this.btnLogout.Location = new System.Drawing.Point(13, 668);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 51);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMnOrder
            // 
            this.btnMnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMnOrder.ForeColor = System.Drawing.Color.Indigo;
            this.btnMnOrder.Location = new System.Drawing.Point(13, 228);
            this.btnMnOrder.Name = "btnMnOrder";
            this.btnMnOrder.Size = new System.Drawing.Size(187, 51);
            this.btnMnOrder.TabIndex = 0;
            this.btnMnOrder.Text = "Quản lý đơn hàng";
            this.btnMnOrder.UseVisualStyleBackColor = true;
            this.btnMnOrder.Click += new System.EventHandler(this.btnMnOrder_Click);
            // 
            // btnMnProduct
            // 
            this.btnMnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMnProduct.ForeColor = System.Drawing.Color.Indigo;
            this.btnMnProduct.Location = new System.Drawing.Point(13, 116);
            this.btnMnProduct.Name = "btnMnProduct";
            this.btnMnProduct.Size = new System.Drawing.Size(187, 51);
            this.btnMnProduct.TabIndex = 0;
            this.btnMnProduct.Text = "Quản lý sản phẩm";
            this.btnMnProduct.UseVisualStyleBackColor = true;
            this.btnMnProduct.Click += new System.EventHandler(this.btnMnProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 72);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG TIỆN LỢI - NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(215, 72);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1085, 690);
            this.pnContent.TabIndex = 2;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 762);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMnProduct;
        private System.Windows.Forms.Button btnMnOrder;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnContent;
    }
}