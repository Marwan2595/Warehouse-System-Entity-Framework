namespace EF_Project.Forms
{
    partial class CategoryAfterPeriodForm
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
            this.timePeriod = new System.Windows.Forms.TextBox();
            this.period = new System.Windows.Forms.Label();
            this.showReportBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.warehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timePeriod
            // 
            this.timePeriod.Location = new System.Drawing.Point(465, 50);
            this.timePeriod.Multiline = true;
            this.timePeriod.Name = "timePeriod";
            this.timePeriod.Size = new System.Drawing.Size(402, 36);
            this.timePeriod.TabIndex = 63;
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(461, 5);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(65, 24);
            this.period.TabIndex = 62;
            this.period.Text = "Period";
            this.period.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.period.Click += new System.EventHandler(this.period_Click);
            // 
            // showReportBtn
            // 
            this.showReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReportBtn.Location = new System.Drawing.Point(918, 51);
            this.showReportBtn.Name = "showReportBtn";
            this.showReportBtn.Size = new System.Drawing.Size(102, 35);
            this.showReportBtn.TabIndex = 61;
            this.showReportBtn.Text = "Show Report";
            this.showReportBtn.UseVisualStyleBackColor = true;
            this.showReportBtn.Click += new System.EventHandler(this.showReportBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1110, 451);
            this.dataGridView1.TabIndex = 60;
            // 
            // warehouse
            // 
            this.warehouse.FormattingEnabled = true;
            this.warehouse.Location = new System.Drawing.Point(21, 50);
            this.warehouse.Name = "warehouse";
            this.warehouse.Size = new System.Drawing.Size(390, 21);
            this.warehouse.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Warehouse";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            // 
            // CategoryAfterPeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 565);
            this.Controls.Add(this.warehouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePeriod);
            this.Controls.Add(this.period);
            this.Controls.Add(this.showReportBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CategoryAfterPeriodForm";
            this.Text = "CategoryAfterPeriodForm";
            this.Load += new System.EventHandler(this.CategoryAfterPeriodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timePeriod;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Button showReportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox warehouse;
        private System.Windows.Forms.Label label1;
    }
}