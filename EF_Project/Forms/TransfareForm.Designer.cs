namespace EF_Project.Forms
{
    partial class TransfareForm
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
            this.categoryButton = new System.Windows.Forms.Button();
            this.updateImport = new System.Windows.Forms.Button();
            this.deleteImport = new System.Windows.Forms.Button();
            this.addImport = new System.Windows.Forms.Button();
            this.toWarehouse = new System.Windows.Forms.ComboBox();
            this.importSupplier = new System.Windows.Forms.Label();
            this.fromWarehouse = new System.Windows.Forms.ComboBox();
            this.transfareDate = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.transfarePerID = new System.Windows.Forms.TextBox();
            this.per = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 407);
            this.dataGridView1.TabIndex = 16;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(973, 50);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(168, 38);
            this.categoryButton.TabIndex = 52;
            this.categoryButton.Text = "Add Transfared Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // updateImport
            // 
            this.updateImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateImport.Location = new System.Drawing.Point(1053, 275);
            this.updateImport.Name = "updateImport";
            this.updateImport.Size = new System.Drawing.Size(85, 36);
            this.updateImport.TabIndex = 51;
            this.updateImport.Text = "Update";
            this.updateImport.UseVisualStyleBackColor = true;
            this.updateImport.Click += new System.EventHandler(this.updateImport_Click);
            // 
            // deleteImport
            // 
            this.deleteImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteImport.Location = new System.Drawing.Point(1053, 331);
            this.deleteImport.Name = "deleteImport";
            this.deleteImport.Size = new System.Drawing.Size(88, 36);
            this.deleteImport.TabIndex = 50;
            this.deleteImport.Text = "Delete";
            this.deleteImport.UseVisualStyleBackColor = true;
            this.deleteImport.Click += new System.EventHandler(this.deleteImport_Click);
            // 
            // addImport
            // 
            this.addImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImport.Location = new System.Drawing.Point(1052, 217);
            this.addImport.Name = "addImport";
            this.addImport.Size = new System.Drawing.Size(86, 36);
            this.addImport.TabIndex = 49;
            this.addImport.Text = "Add";
            this.addImport.UseVisualStyleBackColor = true;
            this.addImport.Click += new System.EventHandler(this.addImport_Click);
            // 
            // toWarehouse
            // 
            this.toWarehouse.FormattingEnabled = true;
            this.toWarehouse.Location = new System.Drawing.Point(702, 56);
            this.toWarehouse.Name = "toWarehouse";
            this.toWarehouse.Size = new System.Drawing.Size(197, 21);
            this.toWarehouse.TabIndex = 48;
            this.toWarehouse.SelectedIndexChanged += new System.EventHandler(this.toWarehouse_SelectedIndexChanged);
            // 
            // importSupplier
            // 
            this.importSupplier.AutoSize = true;
            this.importSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importSupplier.Location = new System.Drawing.Point(698, 20);
            this.importSupplier.Name = "importSupplier";
            this.importSupplier.Size = new System.Drawing.Size(33, 24);
            this.importSupplier.TabIndex = 47;
            this.importSupplier.Text = "To";
            // 
            // fromWarehouse
            // 
            this.fromWarehouse.FormattingEnabled = true;
            this.fromWarehouse.Location = new System.Drawing.Point(483, 56);
            this.fromWarehouse.Name = "fromWarehouse";
            this.fromWarehouse.Size = new System.Drawing.Size(197, 21);
            this.fromWarehouse.TabIndex = 46;
            this.fromWarehouse.SelectedIndexChanged += new System.EventHandler(this.fromWarehouse_SelectedIndexChanged);
            // 
            // transfareDate
            // 
            this.transfareDate.Location = new System.Drawing.Point(254, 57);
            this.transfareDate.Name = "transfareDate";
            this.transfareDate.Size = new System.Drawing.Size(200, 20);
            this.transfareDate.TabIndex = 45;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(250, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 24);
            this.name.TabIndex = 44;
            this.name.Text = "Date";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.Location = new System.Drawing.Point(479, 20);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(55, 24);
            this.unit.TabIndex = 43;
            this.unit.Text = "From";
            // 
            // transfarePerID
            // 
            this.transfarePerID.Location = new System.Drawing.Point(35, 50);
            this.transfarePerID.Multiline = true;
            this.transfarePerID.Name = "transfarePerID";
            this.transfarePerID.Size = new System.Drawing.Size(178, 36);
            this.transfarePerID.TabIndex = 42;
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.per.Location = new System.Drawing.Point(31, 20);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(111, 24);
            this.per.TabIndex = 41;
            this.per.Text = "Transfare ID";
            this.per.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransfareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 544);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.updateImport);
            this.Controls.Add(this.deleteImport);
            this.Controls.Add(this.addImport);
            this.Controls.Add(this.toWarehouse);
            this.Controls.Add(this.importSupplier);
            this.Controls.Add(this.fromWarehouse);
            this.Controls.Add(this.transfareDate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.transfarePerID);
            this.Controls.Add(this.per);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TransfareForm";
            this.Text = "Transfare Manage";
            this.Load += new System.EventHandler(this.TransfareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button updateImport;
        private System.Windows.Forms.Button deleteImport;
        private System.Windows.Forms.Button addImport;
        private System.Windows.Forms.ComboBox toWarehouse;
        private System.Windows.Forms.Label importSupplier;
        private System.Windows.Forms.ComboBox fromWarehouse;
        private System.Windows.Forms.DateTimePicker transfareDate;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox transfarePerID;
        private System.Windows.Forms.Label per;
    }
}