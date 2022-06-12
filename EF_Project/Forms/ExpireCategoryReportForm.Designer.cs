namespace EF_Project.Forms
{
    partial class ExpireCategoryReportForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportPeriod = new System.Windows.Forms.TextBox();
            this.period = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showReportBtn
            // 
            this.showReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReportBtn.Location = new System.Drawing.Point(648, 76);
            this.showReportBtn.Name = "showReportBtn";
            this.showReportBtn.Size = new System.Drawing.Size(102, 35);
            this.showReportBtn.TabIndex = 57;
            this.showReportBtn.Text = "Show Report";
            this.showReportBtn.UseVisualStyleBackColor = true;
            this.showReportBtn.Click += new System.EventHandler(this.showReportBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1125, 420);
            this.dataGridView1.TabIndex = 52;
            // 
            // reportPeriod
            // 
            this.reportPeriod.AccessibleDescription = "";
            this.reportPeriod.Location = new System.Drawing.Point(61, 75);
            this.reportPeriod.Multiline = true;
            this.reportPeriod.Name = "reportPeriod";
            this.reportPeriod.Size = new System.Drawing.Size(402, 36);
            this.reportPeriod.TabIndex = 59;
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(57, 33);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(65, 24);
            this.period.TabIndex = 58;
            this.period.Text = "Period";
            this.period.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.period.Click += new System.EventHandler(this.period_Click);
            // 
            // ExpireCategoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 567);
            this.Controls.Add(this.reportPeriod);
            this.Controls.Add(this.period);
            this.Controls.Add(this.showReportBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExpireCategoryReportForm";
            this.Text = "ExpireCategoryReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showReportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox reportPeriod;
        private System.Windows.Forms.Label period;
    }
}