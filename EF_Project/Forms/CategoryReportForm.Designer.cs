namespace EF_Project.Forms
{
    partial class CategoryReportForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.showReportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1068, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(26, 49);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(261, 21);
            this.category.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Category";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(332, 50);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(197, 20);
            this.startDate.TabIndex = 36;
            this.startDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(341, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(89, 24);
            this.name.TabIndex = 35;
            this.name.Text = "Start Date";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(574, 50);
            this.endDate.MaxDate = new System.DateTime(2023, 12, 21, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(197, 20);
            this.endDate.TabIndex = 40;
            this.endDate.Value = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "End Date";
            // 
            // showReportBtn
            // 
            this.showReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReportBtn.Location = new System.Drawing.Point(847, 41);
            this.showReportBtn.Name = "showReportBtn";
            this.showReportBtn.Size = new System.Drawing.Size(102, 35);
            this.showReportBtn.TabIndex = 41;
            this.showReportBtn.Text = "Show Report";
            this.showReportBtn.UseVisualStyleBackColor = true;
            this.showReportBtn.Click += new System.EventHandler(this.showReportBtn_Click);
            // 
            // CategoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 607);
            this.Controls.Add(this.showReportBtn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CategoryReportForm";
            this.Text = "CategoryReportForm";
            this.Load += new System.EventHandler(this.CategoryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showReportBtn;
    }
}