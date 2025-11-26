namespace GearPoint_POS_SYSTEM.Cards
{
    partial class ItemCards
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
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            this.LabelItemStocks = new System.Windows.Forms.Label();
            this.LabelItemPrice = new System.Windows.Forms.Label();
            this.LabelItemCode = new System.Windows.Forms.Label();
            this.LabelNameItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemPicture
            // 
            this.ItemPicture.Location = new System.Drawing.Point(72, 17);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(100, 100);
            this.ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemPicture.TabIndex = 10;
            this.ItemPicture.TabStop = false;
            // 
            // LabelItemStocks
            // 
            this.LabelItemStocks.AutoSize = true;
            this.LabelItemStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelItemStocks.Location = new System.Drawing.Point(89, 228);
            this.LabelItemStocks.Name = "LabelItemStocks";
            this.LabelItemStocks.Size = new System.Drawing.Size(69, 16);
            this.LabelItemStocks.TabIndex = 9;
            this.LabelItemStocks.Text = "Item Stock";
            this.LabelItemStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelItemPrice
            // 
            this.LabelItemPrice.AutoSize = true;
            this.LabelItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelItemPrice.Location = new System.Drawing.Point(73, 200);
            this.LabelItemPrice.Name = "LabelItemPrice";
            this.LabelItemPrice.Size = new System.Drawing.Size(99, 22);
            this.LabelItemPrice.TabIndex = 8;
            this.LabelItemPrice.Text = "Item Price";
            this.LabelItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelItemCode
            // 
            this.LabelItemCode.AutoSize = true;
            this.LabelItemCode.Location = new System.Drawing.Point(86, 159);
            this.LabelItemCode.Name = "LabelItemCode";
            this.LabelItemCode.Size = new System.Drawing.Size(68, 16);
            this.LabelItemCode.TabIndex = 7;
            this.LabelItemCode.Text = "Item Code";
            this.LabelItemCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNameItem
            // 
            this.LabelNameItem.AutoSize = true;
            this.LabelNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameItem.Location = new System.Drawing.Point(77, 129);
            this.LabelNameItem.Name = "LabelNameItem";
            this.LabelNameItem.Size = new System.Drawing.Size(90, 20);
            this.LabelNameItem.TabIndex = 6;
            this.LabelNameItem.Text = "Name Item";
            this.LabelNameItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ItemPicture);
            this.Controls.Add(this.LabelItemStocks);
            this.Controls.Add(this.LabelItemPrice);
            this.Controls.Add(this.LabelItemCode);
            this.Controls.Add(this.LabelNameItem);
            this.Name = "ItemCards";
            this.Size = new System.Drawing.Size(245, 260);
            this.Load += new System.EventHandler(this.ItemCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ItemPicture;
        private System.Windows.Forms.Label LabelItemStocks;
        private System.Windows.Forms.Label LabelItemPrice;
        private System.Windows.Forms.Label LabelItemCode;
        private System.Windows.Forms.Label LabelNameItem;
    }
}
