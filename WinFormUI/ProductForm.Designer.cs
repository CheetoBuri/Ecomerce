namespace WinFormUI
{
    partial class ProductForm
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(382, 118);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(341, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(382, 152);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(382, 186);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(371, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtItemName);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
    }
}