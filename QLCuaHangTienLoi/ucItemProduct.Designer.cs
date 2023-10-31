namespace QLCuaHangTienLoi
{
    partial class ucItemProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lbDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // picProduct
            // 
            this.picProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProduct.Location = new System.Drawing.Point(0, 0);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(200, 75);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // lbDes
            // 
            this.lbDes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDes.Location = new System.Drawing.Point(0, 75);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(200, 25);
            this.lbDes.TabIndex = 1;
            this.lbDes.Text = "label1";
            this.lbDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.picProduct);
            this.Name = "ucItemProduct";
            this.Size = new System.Drawing.Size(200, 100);
            this.Load += new System.EventHandler(this.ucItemProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDes;
        public System.Windows.Forms.PictureBox picProduct;
    }
}
