namespace WinFormUI
{
    partial class ItemReportForm
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
            this.cmbAgents = new System.Windows.Forms.ComboBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnShowBestItems = new System.Windows.Forms.Button();
            this.btnShowAgentItems = new System.Windows.Forms.Button();
            this.btnShowAgentPurchases = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAgents
            // 
            this.cmbAgents.FormattingEnabled = true;
            this.cmbAgents.Location = new System.Drawing.Point(253, 48);
            this.cmbAgents.Name = "cmbAgents";
            this.cmbAgents.Size = new System.Drawing.Size(121, 21);
            this.cmbAgents.TabIndex = 0;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(185, 75);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(240, 150);
            this.dgvReport.TabIndex = 1;
            // 
            // btnShowBestItems
            // 
            this.btnShowBestItems.Location = new System.Drawing.Point(248, 231);
            this.btnShowBestItems.Name = "btnShowBestItems";
            this.btnShowBestItems.Size = new System.Drawing.Size(126, 23);
            this.btnShowBestItems.TabIndex = 2;
            this.btnShowBestItems.Text = "Show Best Items";
            this.btnShowBestItems.UseVisualStyleBackColor = true;
            this.btnShowBestItems.Click += new System.EventHandler(this.btnShowBestItems_Click);
            // 
            // btnShowAgentItems
            // 
            this.btnShowAgentItems.Location = new System.Drawing.Point(248, 260);
            this.btnShowAgentItems.Name = "btnShowAgentItems";
            this.btnShowAgentItems.Size = new System.Drawing.Size(126, 23);
            this.btnShowAgentItems.TabIndex = 3;
            this.btnShowAgentItems.Text = "Show Agent Items";
            this.btnShowAgentItems.UseVisualStyleBackColor = true;
            this.btnShowAgentItems.Click += new System.EventHandler(this.btnShowAgentItems_Click);
            // 
            // btnShowAgentPurchases
            // 
            this.btnShowAgentPurchases.Location = new System.Drawing.Point(248, 289);
            this.btnShowAgentPurchases.Name = "btnShowAgentPurchases";
            this.btnShowAgentPurchases.Size = new System.Drawing.Size(126, 23);
            this.btnShowAgentPurchases.TabIndex = 4;
            this.btnShowAgentPurchases.Text = "Show Agent Purchases";
            this.btnShowAgentPurchases.UseVisualStyleBackColor = true;
            this.btnShowAgentPurchases.Click += new System.EventHandler(this.btnShowAgentPurchases_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agents";
            // 
            // ItemReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAgentPurchases);
            this.Controls.Add(this.btnShowAgentItems);
            this.Controls.Add(this.btnShowBestItems);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.cmbAgents);
            this.Name = "ItemReportForm";
            this.Text = "ItemReportForm";
            this.Load += new System.EventHandler(this.ItemReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAgents;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnShowBestItems;
        private System.Windows.Forms.Button btnShowAgentItems;
        private System.Windows.Forms.Button btnShowAgentPurchases;
        private System.Windows.Forms.Label label1;
    }
}