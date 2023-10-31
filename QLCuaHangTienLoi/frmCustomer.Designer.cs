namespace QLCuaHangTienLoi
{
    partial class frmCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.flpProductItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pickOrder = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lvCart = new System.Windows.Forms.ListView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.productId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // flpProductItem
            // 
            this.flpProductItem.AutoScroll = true;
            this.flpProductItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpProductItem.BackColor = System.Drawing.Color.PeachPuff;
            this.flpProductItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpProductItem.Location = new System.Drawing.Point(0, 0);
            this.flpProductItem.Name = "flpProductItem";
            this.flpProductItem.Padding = new System.Windows.Forms.Padding(20, 10, 10, 0);
            this.flpProductItem.Size = new System.Drawing.Size(688, 782);
            this.flpProductItem.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lvCart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(688, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 782);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 61);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửa hàng tiện lợi - Người dùng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.pickOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(565, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 61);
            this.panel3.TabIndex = 1;
            // 
            // pickOrder
            // 
            this.pickOrder.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pickOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pickOrder.Image = ((System.Drawing.Image)(resources.GetObject("pickOrder.Image")));
            this.pickOrder.Location = new System.Drawing.Point(0, 0);
            this.pickOrder.Name = "pickOrder";
            this.pickOrder.Size = new System.Drawing.Size(67, 61);
            this.pickOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickOrder.TabIndex = 0;
            this.pickOrder.TabStop = false;
            this.pickOrder.Click += new System.EventHandler(this.pickOrder_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "Lịch sử đơn hàng";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productId,
            this.productName,
            this.price,
            this.quantity,
            this.totalPrice});
            this.lvCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvCart.FullRowSelect = true;
            this.lvCart.GridLines = true;
            this.lvCart.HideSelection = false;
            this.lvCart.HoverSelection = true;
            this.lvCart.Location = new System.Drawing.Point(0, 61);
            this.lvCart.MultiSelect = false;
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(698, 581);
            this.lvCart.TabIndex = 1;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(67, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(66, 61);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "X";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // productId
            // 
            this.productId.Text = "Mã sản phẩm";
            this.productId.Width = 100;
            // 
            // productName
            // 
            this.productName.Text = "Tên sản phẩm";
            this.productName.Width = 150;
            // 
            // price
            // 
            this.price.Text = "Đơn giá";
            this.price.Width = 80;
            // 
            // quantity
            // 
            this.quantity.Text = "Số lượng";
            this.quantity.Width = 80;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Thành tiền";
            this.totalPrice.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(5, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng thanh toán:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTotalPrice.Location = new System.Drawing.Point(182, 667);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(260, 34);
            this.txtTotalPrice.TabIndex = 3;
            // 
            // btnPayment
            // 
            this.btnPayment.Enabled = false;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Location = new System.Drawing.Point(495, 667);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(146, 34);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(20, 736);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới cửa hàng";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpProductItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pickOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProductItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pickOrder;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ColumnHeader productId;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnRefresh;
    }
}