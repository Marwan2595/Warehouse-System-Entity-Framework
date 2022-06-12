namespace EF_Project.Forms
{
    partial class ExportForm
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
            this.updateImport = new System.Windows.Forms.Button();
            this.deleteImport = new System.Windows.Forms.Button();
            this.addImport = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.importSupplier = new System.Windows.Forms.Label();
            this.exportCustomer = new System.Windows.Forms.ComboBox();
            this.exportDate = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unit = new System.Windows.Forms.Label();
            this.exportPerID = new System.Windows.Forms.TextBox();
            this.per = new System.Windows.Forms.Label();
            this.categoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateImport
            // 
            this.updateImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateImport.Location = new System.Drawing.Point(1058, 286);
            this.updateImport.Name = "updateImport";
            this.updateImport.Size = new System.Drawing.Size(85, 36);
            this.updateImport.TabIndex = 39;
            this.updateImport.Text = "Update";
            this.updateImport.UseVisualStyleBackColor = true;
            this.updateImport.Click += new System.EventHandler(this.updateImport_Click);
            // 
            // deleteImport
            // 
            this.deleteImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteImport.Location = new System.Drawing.Point(1058, 216);
            this.deleteImport.Name = "deleteImport";
            this.deleteImport.Size = new System.Drawing.Size(88, 36);
            this.deleteImport.TabIndex = 38;
            this.deleteImport.Text = "Delete";
            this.deleteImport.UseVisualStyleBackColor = true;
            this.deleteImport.Click += new System.EventHandler(this.deleteImport_Click);
            // 
            // addImport
            // 
            this.addImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImport.Location = new System.Drawing.Point(1058, 354);
            this.addImport.Name = "addImport";
            this.addImport.Size = new System.Drawing.Size(86, 36);
            this.addImport.TabIndex = 37;
            this.addImport.Text = "Add";
            this.addImport.UseVisualStyleBackColor = true;
            this.addImport.Click += new System.EventHandler(this.addImport_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(503, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // importSupplier
            // 
            this.importSupplier.AutoSize = true;
            this.importSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importSupplier.Location = new System.Drawing.Point(499, 37);
            this.importSupplier.Name = "importSupplier";
            this.importSupplier.Size = new System.Drawing.Size(108, 24);
            this.importSupplier.TabIndex = 35;
            this.importSupplier.Text = "Warehouse";
            // 
            // exportCustomer
            // 
            this.exportCustomer.FormattingEnabled = true;
            this.exportCustomer.Location = new System.Drawing.Point(733, 77);
            this.exportCustomer.Name = "exportCustomer";
            this.exportCustomer.Size = new System.Drawing.Size(197, 21);
            this.exportCustomer.TabIndex = 34;
            this.exportCustomer.SelectedIndexChanged += new System.EventHandler(this.exportCustomer_SelectedIndexChanged);
            // 
            // exportDate
            // 
            this.exportDate.Location = new System.Drawing.Point(266, 78);
            this.exportDate.Name = "exportDate";
            this.exportDate.Size = new System.Drawing.Size(200, 20);
            this.exportDate.TabIndex = 33;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(262, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 24);
            this.name.TabIndex = 32;
            this.name.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1031, 384);
            this.dataGridView1.TabIndex = 31;
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.Location = new System.Drawing.Point(729, 37);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(91, 24);
            this.unit.TabIndex = 30;
            this.unit.Text = "Customer";
            // 
            // exportPerID
            // 
            this.exportPerID.Location = new System.Drawing.Point(62, 71);
            this.exportPerID.Multiline = true;
            this.exportPerID.Name = "exportPerID";
            this.exportPerID.Size = new System.Drawing.Size(178, 36);
            this.exportPerID.TabIndex = 29;
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.per.Location = new System.Drawing.Point(58, 37);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(125, 24);
            this.per.TabIndex = 28;
            this.per.Text = "Permission ID";
            this.per.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(961, 71);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(168, 38);
            this.categoryButton.TabIndex = 40;
            this.categoryButton.Text = "Add Exported Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 544);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.updateImport);
            this.Controls.Add(this.deleteImport);
            this.Controls.Add(this.addImport);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.importSupplier);
            this.Controls.Add(this.exportCustomer);
            this.Controls.Add(this.exportDate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.exportPerID);
            this.Controls.Add(this.per);
            this.Name = "ExportForm";
            this.Text = "Export Manage";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateImport;
        private System.Windows.Forms.Button deleteImport;
        private System.Windows.Forms.Button addImport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label importSupplier;
        private System.Windows.Forms.ComboBox exportCustomer;
        private System.Windows.Forms.DateTimePicker exportDate;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox exportPerID;
        private System.Windows.Forms.Label per;
        private System.Windows.Forms.Button categoryButton;
    }
}