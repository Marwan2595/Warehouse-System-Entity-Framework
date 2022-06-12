namespace EF_Project.Forms
{
    partial class ReportsForm
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
            this.categoryReport = new System.Windows.Forms.Button();
            this.warehouseReport = new System.Windows.Forms.Button();
            this.reportButtonsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.catExpireReport = new System.Windows.Forms.Button();
            this.catTransfareReport = new System.Windows.Forms.Button();
            this.reportsPanel = new System.Windows.Forms.Panel();
            this.reportButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryReport
            // 
            this.categoryReport.AutoEllipsis = true;
            this.categoryReport.BackColor = System.Drawing.Color.Olive;
            this.categoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryReport.Location = new System.Drawing.Point(235, 3);
            this.categoryReport.Name = "categoryReport";
            this.categoryReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoryReport.Size = new System.Drawing.Size(170, 55);
            this.categoryReport.TabIndex = 1;
            this.categoryReport.Text = "Category Report";
            this.categoryReport.UseVisualStyleBackColor = false;
            this.categoryReport.Click += new System.EventHandler(this.categoryReport_Click);
            // 
            // warehouseReport
            // 
            this.warehouseReport.AutoEllipsis = true;
            this.warehouseReport.BackColor = System.Drawing.Color.Olive;
            this.warehouseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warehouseReport.Location = new System.Drawing.Point(36, 3);
            this.warehouseReport.Name = "warehouseReport";
            this.warehouseReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.warehouseReport.Size = new System.Drawing.Size(170, 55);
            this.warehouseReport.TabIndex = 4;
            this.warehouseReport.Text = "Warehouse Report";
            this.warehouseReport.UseVisualStyleBackColor = false;
            this.warehouseReport.Click += new System.EventHandler(this.warehouseReport_Click);
            // 
            // reportButtonsPanel
            // 
            this.reportButtonsPanel.Controls.Add(this.button1);
            this.reportButtonsPanel.Controls.Add(this.catExpireReport);
            this.reportButtonsPanel.Controls.Add(this.catTransfareReport);
            this.reportButtonsPanel.Controls.Add(this.categoryReport);
            this.reportButtonsPanel.Controls.Add(this.warehouseReport);
            this.reportButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.reportButtonsPanel.Name = "reportButtonsPanel";
            this.reportButtonsPanel.Size = new System.Drawing.Size(1259, 63);
            this.reportButtonsPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(875, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(199, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Categories With Time";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // catExpireReport
            // 
            this.catExpireReport.AutoEllipsis = true;
            this.catExpireReport.BackColor = System.Drawing.Color.Olive;
            this.catExpireReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catExpireReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catExpireReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catExpireReport.Location = new System.Drawing.Point(650, 3);
            this.catExpireReport.Name = "catExpireReport";
            this.catExpireReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.catExpireReport.Size = new System.Drawing.Size(199, 55);
            this.catExpireReport.TabIndex = 7;
            this.catExpireReport.Text = "Near Expire Categories Report";
            this.catExpireReport.UseVisualStyleBackColor = false;
            this.catExpireReport.Click += new System.EventHandler(this.catExpireReport_Click);
            // 
            // catTransfareReport
            // 
            this.catTransfareReport.AutoEllipsis = true;
            this.catTransfareReport.BackColor = System.Drawing.Color.Olive;
            this.catTransfareReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catTransfareReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTransfareReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catTransfareReport.Location = new System.Drawing.Point(429, 3);
            this.catTransfareReport.Name = "catTransfareReport";
            this.catTransfareReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.catTransfareReport.Size = new System.Drawing.Size(189, 55);
            this.catTransfareReport.TabIndex = 6;
            this.catTransfareReport.Text = "Categories Transfare Report";
            this.catTransfareReport.UseVisualStyleBackColor = false;
            this.catTransfareReport.Click += new System.EventHandler(this.catTransfareReport_Click);
            // 
            // reportsPanel
            // 
            this.reportsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportsPanel.Location = new System.Drawing.Point(0, 69);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.Size = new System.Drawing.Size(1259, 562);
            this.reportsPanel.TabIndex = 0;
            this.reportsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.reportsPanel_Paint);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 631);
            this.Controls.Add(this.reportButtonsPanel);
            this.Controls.Add(this.reportsPanel);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.reportButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button categoryReport;
        private System.Windows.Forms.Button warehouseReport;
        private System.Windows.Forms.Panel reportButtonsPanel;
        private System.Windows.Forms.Button catExpireReport;
        private System.Windows.Forms.Button catTransfareReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel reportsPanel;
    }
}