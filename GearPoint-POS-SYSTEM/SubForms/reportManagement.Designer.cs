namespace GearPoint_POS_SYSTEM.SubForms
{
    partial class reportManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderItems = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderedPayment = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderTime = new System.Windows.Forms.TextBox();
            this.txtOrderItem = new System.Windows.Forms.TextBox();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.txtOrderPayment = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Time";
            // 
            // txtOrderItems
            // 
            this.txtOrderItems.AutoSize = true;
            this.txtOrderItems.Location = new System.Drawing.Point(21, 144);
            this.txtOrderItems.Name = "txtOrderItems";
            this.txtOrderItems.Size = new System.Drawing.Size(92, 16);
            this.txtOrderItems.TabIndex = 3;
            this.txtOrderItems.Text = "Ordered Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ordered Amount";
            // 
            // txtOrderedPayment
            // 
            this.txtOrderedPayment.AutoSize = true;
            this.txtOrderedPayment.Location = new System.Drawing.Point(21, 260);
            this.txtOrderedPayment.Name = "txtOrderedPayment";
            this.txtOrderedPayment.Size = new System.Drawing.Size(113, 16);
            this.txtOrderedPayment.TabIndex = 4;
            this.txtOrderedPayment.Text = "Ordered Payment";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(156, 25);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(179, 22);
            this.txtOrderID.TabIndex = 5;
            // 
            // txtOrderTime
            // 
            this.txtOrderTime.Location = new System.Drawing.Point(156, 83);
            this.txtOrderTime.Name = "txtOrderTime";
            this.txtOrderTime.Size = new System.Drawing.Size(179, 22);
            this.txtOrderTime.TabIndex = 6;
            // 
            // txtOrderItem
            // 
            this.txtOrderItem.Location = new System.Drawing.Point(156, 141);
            this.txtOrderItem.Name = "txtOrderItem";
            this.txtOrderItem.Size = new System.Drawing.Size(179, 22);
            this.txtOrderItem.TabIndex = 7;
            // 
            // txtOrderAmount
            // 
            this.txtOrderAmount.Location = new System.Drawing.Point(156, 199);
            this.txtOrderAmount.Name = "txtOrderAmount";
            this.txtOrderAmount.Size = new System.Drawing.Size(179, 22);
            this.txtOrderAmount.TabIndex = 8;
            // 
            // txtOrderPayment
            // 
            this.txtOrderPayment.Location = new System.Drawing.Point(156, 257);
            this.txtOrderPayment.Name = "txtOrderPayment";
            this.txtOrderPayment.Size = new System.Drawing.Size(179, 22);
            this.txtOrderPayment.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(394, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(521, 538);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(43, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(212, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 36);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // reportManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtOrderPayment);
            this.Controls.Add(this.txtOrderAmount);
            this.Controls.Add(this.txtOrderItem);
            this.Controls.Add(this.txtOrderTime);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtOrderedPayment);
            this.Controls.Add(this.txtOrderItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "reportManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtOrderItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtOrderedPayment;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtOrderTime;
        private System.Windows.Forms.TextBox txtOrderItem;
        private System.Windows.Forms.TextBox txtOrderAmount;
        private System.Windows.Forms.TextBox txtOrderPayment;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}