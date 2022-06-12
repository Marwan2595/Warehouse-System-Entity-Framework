namespace EF_Project.Forms
{
    partial class CategoryTransfareReportForm
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
            this.showReportBtn = new System.Windows.Forms.Button();
            this.warehouses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showReportBtn
            // 
            this.showReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReportBtn.Location = new System.Drawing.Point(510, 67);
            this.showReportBtn.Name = "showReportBtn";
            this.showReportBtn.Size = new System.Drawing.Size(102, 35);
            this.showReportBtn.TabIndex = 51;
            this.showReportBtn.Text = "Show Report";
            this.showReportBtn.UseVisualStyleBackColor = true;
            this.showReportBtn.Click += new System.EventHandler(this.showReportBtn_Click);
            // 
            // warehouses
            // 
            this.warehouses.FormattingEnabled = true;
            this.warehouses.Location = new System.Drawing.Point(39, 75);
            this.warehouses.Name = "warehouses";
            this.warehouses.Size = new System.Drawing.Size(390, 21);
            this.warehouses.TabIndex = 44;
            this.warehouses.SelectedIndexChanged += new System.EventHandler(this.warehouses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Warehouse";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1105, 429);
            this.dataGridView1.TabIndex = 42;
            // 
            // CategoryTransfareReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 553);
            this.Controls.Add(this.showReportBtn);
            this.Controls.Add(this.warehouses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CategoryTransfareReportForm";
            this.Text = "CategoryTransfareReportForm";
            this.Load += new System.EventHandler(this.CategoryTransfareReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showReportBtn;
        private System.Windows.Forms.ComboBox warehouses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}