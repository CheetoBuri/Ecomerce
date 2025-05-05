namespace WinFormUI
{
    partial class MainForm
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
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnAgents = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(273, 52);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(288, 60);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnAgents
            // 
            this.btnAgents.Location = new System.Drawing.Point(273, 118);
            this.btnAgents.Name = "btnAgents";
            this.btnAgents.Size = new System.Drawing.Size(288, 60);
            this.btnAgents.TabIndex = 1;
            this.btnAgents.Text = "Agents";
            this.btnAgents.UseVisualStyleBackColor = true;
            this.btnAgents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(273, 184);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(288, 60);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(273, 250);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(288, 60);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnAgents);
            this.Controls.Add(this.btnProducts);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnAgents;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
    }
}