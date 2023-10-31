namespace QLCuaHangTienLoi
{
    partial class frmMyorder
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
            this.dgvMyOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyOrder
            // 
            this.dgvMyOrder.AllowUserToAddRows = false;
            this.dgvMyOrder.AllowUserToDeleteRows = false;
            this.dgvMyOrder.AllowUserToResizeColumns = false;
            this.dgvMyOrder.AllowUserToResizeRows = false;
            this.dgvMyOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvMyOrder.MultiSelect = false;
            this.dgvMyOrder.Name = "dgvMyOrder";
            this.dgvMyOrder.ReadOnly = true;
            this.dgvMyOrder.RowHeadersWidth = 51;
            this.dgvMyOrder.RowTemplate.Height = 24;
            this.dgvMyOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyOrder.Size = new System.Drawing.Size(1220, 693);
            this.dgvMyOrder.TabIndex = 0;
            // 
            // frmMyorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 693);
            this.Controls.Add(this.dgvMyOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMyorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn mua hàng của tôi";
            this.Load += new System.EventHandler(this.frmMyorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyOrder;
    }
}