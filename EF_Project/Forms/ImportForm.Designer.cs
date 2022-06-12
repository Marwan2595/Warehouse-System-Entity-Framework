namespace EF_Project.Forms
{
    partial class ImportForm
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
            this.unit = new System.Windows.Forms.Label();
            this.importPerID = new System.Windows.Forms.TextBox();
            this.per = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.importWarehouse = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.importSupplier = new System.Windows.Forms.Label();
            this.updateImport = new System.Windows.Forms.Button();
            this.deleteImport = new System.Windows.Forms.Button();
            this.addImport = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1019, 420);
            this.dataGridView1.TabIndex = 16;
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.Location = new System.Drawing.Point(504, 26);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(108, 24);
            this.unit.TabIndex = 14;
            this.unit.Text = "Warehouse";
            // 
            // importPerID
            // 
            this.importPerID.Location = new System.Drawing.Point(46, 59);
            this.importPerID.Multiline = true;
            this.importPerID.Name = "importPerID";
            this.importPerID.Size = new System.Drawing.Size(178, 36);
            this.importPerID.TabIndex = 11;
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.per.Location = new System.Drawing.Point(42, 26);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(125, 24);
            this.per.TabIndex = 10;
            this.per.Text = "Permission ID";
            this.per.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(261, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 24);
            this.name.TabIndex = 20;
            this.name.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // importWarehouse
            // 
            this.importWarehouse.FormattingEnabled = true;
            this.importWarehouse.Location = new System.Drawing.Point(508, 65);
            this.importWarehouse.Name = "importWarehouse";
            this.importWarehouse.Size = new System.Drawing.Size(197, 21);
            this.importWarehouse.TabIndex = 22;
            this.importWarehouse.SelectedIndexChanged += new System.EventHandler(this.importWarehouse_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(727, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // importSupplier
            // 
            this.importSupplier.AutoSize = true;
            this.importSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importSupplier.Location = new System.Drawing.Point(723, 26);
            this.importSupplier.Name = "importSupplier";
            this.importSupplier.Size = new System.Drawing.Size(80, 24);
            this.importSupplier.TabIndex = 23;
            this.importSupplier.Text = "Supplier";
            // 
            // updateImport
            // 
            this.updateImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateImport.Location = new System.Drawing.Point(1038, 279);
            this.updateImport.Name = "updateImport";
            this.updateImport.Size = new System.Drawing.Size(85, 36);
            this.updateImport.TabIndex = 27;
            this.updateImport.Text = "Update";
            this.updateImport.UseVisualStyleBackColor = true;
            this.updateImport.Click += new System.EventHandler(this.updateImport_Click);
            // 
            // deleteImport
            // 
            this.deleteImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteImport.Location = new System.Drawing.Point(1038, 336);
            this.deleteImport.Name = "deleteImport";
            this.deleteImport.Size = new System.Drawing.Size(88, 36);
            this.deleteImport.TabIndex = 26;
            this.deleteImport.Text = "Delete";
            this.deleteImport.UseVisualStyleBackColor = true;
            this.deleteImport.Click += new System.EventHandler(this.deleteImport_Click);
            // 
            // addImport
            // 
            this.addImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImport.Location = new System.Drawing.Point(1037, 219);
            this.addImport.Name = "addImport";
            this.addImport.Size = new System.Drawing.Size(86, 36);
            this.addImport.TabIndex = 25;
            this.addImport.Text = "Add";
            this.addImport.UseVisualStyleBackColor = true;
            this.addImport.Click += new System.EventHandler(this.addImport_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(955, 59);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(168, 38);
            this.categoryButton.TabIndex = 41;
            this.categoryButton.Text = "Add Imported Category";
            this.categoryButton.UseMnemonic = false;
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // ImportForm
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
            this.Controls.Add(this.importWarehouse);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.importPerID);
            this.Controls.Add(this.per);
            this.Name = "ImportForm";
            this.Text = "Import Manage";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox importPerID;
        private System.Windows.Forms.Label per;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox importWarehouse;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label importSupplier;
        private System.Windows.Forms.Button updateImport;
        private System.Windows.Forms.Button deleteImport;
        private System.Windows.Forms.Button addImport;
        private System.Windows.Forms.Button categoryButton;
    }
}