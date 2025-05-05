namespace WinFormUI
{
    partial class OrderReportForm
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
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnShowDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(290, 63);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details";
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(252, 246);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 4;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(209, 90);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(240, 150);
            this.dgvOrderDetails.TabIndex = 5;
            this.dgvOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellContentClick);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(336, 246);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(75, 23);
            this.btnShowDetails.TabIndex = 6;
            this.btnShowDetails.Text = "Show Detail";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // OrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrder);
            this.Name = "OrderReportForm";
            this.Text = "OrderReportForm";
            this.Load += new System.EventHandler(this.OrderReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnShowDetails;
    }
}