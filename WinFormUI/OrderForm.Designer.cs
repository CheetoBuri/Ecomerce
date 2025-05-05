namespace WinFormUI
{
    partial class OrderForm
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
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.nameItems = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitAmount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAgent
            // 
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(269, 12);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(121, 21);
            this.cmbAgent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(179, 142);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(240, 150);
            this.dgvOrderDetails.TabIndex = 2;
            // 
            // nameItems
            // 
            this.nameItems.AutoSize = true;
            this.nameItems.Location = new System.Drawing.Point(216, 45);
            this.nameItems.Name = "nameItems";
            this.nameItems.Size = new System.Drawing.Size(32, 13);
            this.nameItems.TabIndex = 3;
            this.nameItems.Text = "Items";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(219, 298);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(300, 298);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrder.TabIndex = 5;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(269, 42);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(269, 72);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtUnitAmount
            // 
            this.txtUnitAmount.AutoSize = true;
            this.txtUnitAmount.Location = new System.Drawing.Point(212, 111);
            this.txtUnitAmount.Name = "txtUnitAmount";
            this.txtUnitAmount.Size = new System.Drawing.Size(43, 13);
            this.txtUnitAmount.TabIndex = 9;
            this.txtUnitAmount.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUnitAmount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.nameItems);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAgent);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label nameItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label txtUnitAmount;
        private System.Windows.Forms.TextBox textBox1;
    }
}