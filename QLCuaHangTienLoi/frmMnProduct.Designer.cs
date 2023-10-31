namespace QLCuaHangTienLoi
{
    partial class frmMnProduct
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.picProduct);
            this.panel1.Controls.Add(this.nmrStock);
            this.panel1.Controls.Add(this.nmrPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtImage);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 348);
            this.panel1.TabIndex = 0;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 348);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1085, 342);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(212, 79);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(467, 30);
            this.txtId.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(467, 30);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá:";
            // 
            // nmrPrice
            // 
            this.nmrPrice.Location = new System.Drawing.Point(212, 151);
            this.nmrPrice.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(120, 30);
            this.nmrPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng trong kho:";
            // 
            // nmrStock
            // 
            this.nmrStock.Location = new System.Drawing.Point(212, 187);
            this.nmrStock.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nmrStock.Name = "nmrStock";
            this.nmrStock.Size = new System.Drawing.Size(120, 30);
            this.nmrStock.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đường dẫn hình ảnh:";
            // 
            // txtImage
            // 
            this.txtImage.Enabled = false;
            this.txtImage.Location = new System.Drawing.Point(212, 223);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(422, 30);
            this.txtImage.TabIndex = 22;
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(792, 115);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(246, 138);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 4;
            this.picProduct.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(787, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hình ảnh sản phẩm:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(70, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(239, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 47);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(413, 281);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(140, 47);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(577, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 47);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(751, 281);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(140, 47);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.Location = new System.Drawing.Point(664, 218);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(122, 35);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // frmMnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 690);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMnProduct";
            this.Text = "frmMnProduct";
            this.Load += new System.EventHandler(this.frmMnProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.NumericUpDown nmrStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnChoose;
    }
}