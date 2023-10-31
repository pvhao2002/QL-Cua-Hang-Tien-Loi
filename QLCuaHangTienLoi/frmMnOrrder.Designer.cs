namespace QLCuaHangTienLoi
{
    partial class frmMnOrrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvOrderDetail = new System.Windows.Forms.ListView();
            this.productId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hóa đơn cần xác nhận";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dgvOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn:";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrder.Location = new System.Drawing.Point(3, 22);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(1079, 296);
            this.dgvOrder.TabIndex = 3;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvOrderDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1085, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn:";
            // 
            // lvOrderDetail
            // 
            this.lvOrderDetail.AllowDrop = true;
            this.lvOrderDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productId,
            this.productName,
            this.price,
            this.quantity,
            this.totalPrice});
            this.lvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lvOrderDetail.GridLines = true;
            this.lvOrderDetail.HideSelection = false;
            this.lvOrderDetail.Location = new System.Drawing.Point(3, 26);
            this.lvOrderDetail.MultiSelect = false;
            this.lvOrderDetail.Name = "lvOrderDetail";
            this.lvOrderDetail.Size = new System.Drawing.Size(1079, 221);
            this.lvOrderDetail.TabIndex = 0;
            this.lvOrderDetail.UseCompatibleStateImageBehavior = false;
            this.lvOrderDetail.View = System.Windows.Forms.View.Details;
            // 
            // productId
            // 
            this.productId.Text = "Mã sản phẩm";
            this.productId.Width = 120;
            // 
            // productName
            // 
            this.productName.Text = "Tên sản phẩm";
            this.productName.Width = 300;
            // 
            // price
            // 
            this.price.Text = "Đơn giá";
            this.price.Width = 120;
            // 
            // quantity
            // 
            this.quantity.Text = "Số lượng";
            this.quantity.Width = 120;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Thành tiền";
            this.totalPrice.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 67);
            this.panel1.TabIndex = 4;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(214, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(168, 58);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Location = new System.Drawing.Point(525, 3);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(168, 58);
            this.btnReject.TabIndex = 0;
            this.btnReject.Text = "Từ chối";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // frmMnOrrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMnOrrder";
            this.Text = "frmMnOrrder";
            this.Load += new System.EventHandler(this.frmMnOrrder_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvOrderDetail;
        private System.Windows.Forms.ColumnHeader productId;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
    }
}