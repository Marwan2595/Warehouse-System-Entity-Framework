namespace EF_Project.Forms
{
    partial class WarehouseReportForm
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
            this.warehouse2 = new System.Windows.Forms.ComboBox();
            this.warehouse = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showReportBtn
            // 
            this.showReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReportBtn.Location = new System.Drawing.Point(915, 63);
            this.showReportBtn.Name = "showReportBtn";
            this.showReportBtn.Size = new System.Drawing.Size(102, 35);
            this.showReportBtn.TabIndex = 51;
            this.showReportBtn.Text = "Show Report";
            this.showReportBtn.UseVisualStyleBackColor = true;
            this.showReportBtn.Click += new System.EventHandler(this.showReportBtn_Click);
            // 
            // warehouse2
            // 
            this.warehouse2.FormattingEnabled = true;
            this.warehouse2.Location = new System.Drawing.Point(32, 71);
            this.warehouse2.Name = "warehouse2";
            this.warehouse2.Size = new System.Drawing.Size(356, 21);
            this.warehouse2.TabIndex = 48;
            // 
            // warehouse
            // 
            this.warehouse.AutoSize = true;
            this.warehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouse.Location = new System.Drawing.Point(28, 32);
            this.warehouse.Name = "warehouse";
            this.warehouse.Size = new System.Drawing.Size(108, 24);
            this.warehouse.TabIndex = 47;
            this.warehouse.Text = "Warehouse";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1086, 484);
            this.dataGridView1.TabIndex = 42;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(652, 72);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(197, 20);
            this.endDate.TabIndex = 55;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "End Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(435, 72);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(197, 20);
            this.startDate.TabIndex = 53;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(444, 31);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(89, 24);
            this.name.TabIndex = 52;
            this.name.Text = "Start Date";
            // 
            // WarehouseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 610);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.showReportBtn);
            this.Controls.Add(this.warehouse2);
            this.Controls.Add(this.warehouse);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WarehouseReportForm";
            this.Text = "WarehouseReportForm";
            this.Load += new System.EventHandler(this.WarehouseReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showReportBtn;
        private System.Windows.Forms.ComboBox warehouse2;
        private System.Windows.Forms.Label warehouse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label name;
    }
}