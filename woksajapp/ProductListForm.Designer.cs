
namespace woksajapp
{
    partial class ProductListForm
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
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.BTNback = new System.Windows.Forms.Button();
            this.BTNSave = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProducts
            // 
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(13, 13);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.Size = new System.Drawing.Size(552, 393);
            this.DGVProducts.TabIndex = 0;
            // 
            // BTNback
            // 
            this.BTNback.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNback.Location = new System.Drawing.Point(13, 412);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(80, 37);
            this.BTNback.TabIndex = 7;
            this.BTNback.Text = "Назад";
            this.BTNback.UseVisualStyleBackColor = true;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNSave.Location = new System.Drawing.Point(296, 412);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(269, 37);
            this.BTNSave.TabIndex = 8;
            this.BTNSave.Text = "Сохранить и рассчитать";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNDelete.Location = new System.Drawing.Point(99, 412);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(191, 37);
            this.BTNDelete.TabIndex = 9;
            this.BTNDelete.Text = "Удалить строку";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(577, 456);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.BTNback);
            this.Controls.Add(this.DGVProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductListForm";
            this.Text = "Перечень продуктов";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductListForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProductListForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.Button BTNback;
        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.Button BTNDelete;
    }
}