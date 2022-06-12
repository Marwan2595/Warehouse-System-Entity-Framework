namespace EF_Project.Forms
{
    partial class AddCtegoriesForm
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
            this.title = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addCategory = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.ComboBox();
            this.cat = new System.Windows.Forms.Label();
            this.productionDate = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.per = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productionDateList = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(47, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(74, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Import";
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.BackColor = System.Drawing.SystemColors.Control;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idText.Location = new System.Drawing.Point(319, 24);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(72, 26);
            this.idText.TabIndex = 1;
            this.idText.Text = "20365";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Permission ID : ";
            // 
            // addCategory
            // 
            this.addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory.Location = new System.Drawing.Point(157, 183);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(111, 36);
            this.addCategory.TabIndex = 38;
            this.addCategory.Text = "Add";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addImport_Click);
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(11, 120);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(197, 21);
            this.categories.TabIndex = 40;
            this.categories.SelectedIndexChanged += new System.EventHandler(this.categories_SelectedIndexChanged);
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.Location = new System.Drawing.Point(7, 81);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(85, 24);
            this.cat.TabIndex = 39;
            this.cat.Text = "Category";
            // 
            // productionDate
            // 
            this.productionDate.Location = new System.Drawing.Point(236, 120);
            this.productionDate.Name = "productionDate";
            this.productionDate.Size = new System.Drawing.Size(200, 20);
            this.productionDate.TabIndex = 43;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(216, 81);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(144, 24);
            this.name.TabIndex = 42;
            this.name.Text = "Production Date";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(449, 120);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(441, 25);
            this.quantity.TabIndex = 45;
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.per.Location = new System.Drawing.Point(445, 81);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(78, 24);
            this.per.TabIndex = 44;
            this.per.Text = "Quantity";
            this.per.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(480, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(410, 217);
            this.dataGridView1.TabIndex = 46;
            // 
            // update
            // 
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(354, 183);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 36);
            this.update.TabIndex = 38;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.UpdateImport_Click);
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(543, 183);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 36);
            this.delete.TabIndex = 38;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.deletImport_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(449, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(441, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productionDateList
            // 
            this.productionDateList.FormattingEnabled = true;
            this.productionDateList.Location = new System.Drawing.Point(220, 120);
            this.productionDateList.Name = "productionDateList";
            this.productionDateList.Size = new System.Drawing.Size(216, 21);
            this.productionDateList.TabIndex = 48;
            this.productionDateList.SelectedIndexChanged += new System.EventHandler(this.productionDateList_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 296);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(396, 217);
            this.dataGridView2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products In Warehouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Permission Data";
            // 
            // AddCtegoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 525);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.productionDateList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.per);
            this.Controls.Add(this.productionDate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "AddCtegoriesForm";
            this.Text = "Add Ctegory";
            this.Load += new System.EventHandler(this.AddCtegoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.Label cat;
        private System.Windows.Forms.DateTimePicker productionDate;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label per;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox productionDateList;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}