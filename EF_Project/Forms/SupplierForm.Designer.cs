namespace EF_Project.Forms
{
    partial class SupplierForm
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
            this.suppliers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.supplierWebsite = new System.Windows.Forms.TextBox();
            this.website = new System.Windows.Forms.Label();
            this.supplierFax = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.Label();
            this.supplierPhone = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.updateSupplier = new System.Windows.Forms.Button();
            this.deleteSupplier = new System.Windows.Forms.Button();
            this.addSupplier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierMail = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.supplierID = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliers
            // 
            this.suppliers.FormattingEnabled = true;
            this.suppliers.Location = new System.Drawing.Point(364, 192);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(394, 21);
            this.suppliers.TabIndex = 49;
            this.suppliers.SelectedIndexChanged += new System.EventHandler(this.suppliers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(639, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 48;
            // 
            // supplierWebsite
            // 
            this.supplierWebsite.Location = new System.Drawing.Point(382, 137);
            this.supplierWebsite.Multiline = true;
            this.supplierWebsite.Name = "supplierWebsite";
            this.supplierWebsite.Size = new System.Drawing.Size(298, 36);
            this.supplierWebsite.TabIndex = 47;
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website.Location = new System.Drawing.Point(378, 110);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(78, 24);
            this.website.TabIndex = 46;
            this.website.Text = "Website";
            // 
            // supplierFax
            // 
            this.supplierFax.Location = new System.Drawing.Point(48, 137);
            this.supplierFax.Multiline = true;
            this.supplierFax.Name = "supplierFax";
            this.supplierFax.Size = new System.Drawing.Size(298, 36);
            this.supplierFax.TabIndex = 45;
            // 
            // fax
            // 
            this.fax.AutoSize = true;
            this.fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fax.Location = new System.Drawing.Point(44, 111);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(42, 24);
            this.fax.TabIndex = 44;
            this.fax.Text = "Fax";
            // 
            // supplierPhone
            // 
            this.supplierPhone.Location = new System.Drawing.Point(843, 48);
            this.supplierPhone.Multiline = true;
            this.supplierPhone.Name = "supplierPhone";
            this.supplierPhone.Size = new System.Drawing.Size(228, 36);
            this.supplierPhone.TabIndex = 41;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(839, 21);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(66, 24);
            this.phone.TabIndex = 40;
            this.phone.Text = "Phone";
            // 
            // updateSupplier
            // 
            this.updateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSupplier.Location = new System.Drawing.Point(855, 135);
            this.updateSupplier.Name = "updateSupplier";
            this.updateSupplier.Size = new System.Drawing.Size(88, 38);
            this.updateSupplier.TabIndex = 39;
            this.updateSupplier.Text = "Update";
            this.updateSupplier.UseVisualStyleBackColor = true;
            this.updateSupplier.Click += new System.EventHandler(this.updateSupplier_Click);
            // 
            // deleteSupplier
            // 
            this.deleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSupplier.Location = new System.Drawing.Point(969, 135);
            this.deleteSupplier.Name = "deleteSupplier";
            this.deleteSupplier.Size = new System.Drawing.Size(87, 38);
            this.deleteSupplier.TabIndex = 38;
            this.deleteSupplier.Text = "Delete";
            this.deleteSupplier.UseVisualStyleBackColor = true;
            this.deleteSupplier.Click += new System.EventHandler(this.deleteSupplier_Click);
            // 
            // addSupplier
            // 
            this.addSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplier.Location = new System.Drawing.Point(739, 135);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(94, 38);
            this.addSupplier.TabIndex = 37;
            this.addSupplier.Text = "Add";
            this.addSupplier.UseVisualStyleBackColor = true;
            this.addSupplier.Click += new System.EventHandler(this.addSupplier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1142, 300);
            this.dataGridView1.TabIndex = 36;
            // 
            // supplierMail
            // 
            this.supplierMail.Location = new System.Drawing.Point(582, 48);
            this.supplierMail.Multiline = true;
            this.supplierMail.Name = "supplierMail";
            this.supplierMail.Size = new System.Drawing.Size(238, 36);
            this.supplierMail.TabIndex = 35;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(578, 21);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(44, 24);
            this.mail.TabIndex = 34;
            this.mail.Text = "Mail";
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(177, 48);
            this.supplierName.Multiline = true;
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(360, 36);
            this.supplierName.TabIndex = 33;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(173, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 24);
            this.name.TabIndex = 32;
            this.name.Text = "Name";
            // 
            // supplierID
            // 
            this.supplierID.Location = new System.Drawing.Point(48, 48);
            this.supplierID.Multiline = true;
            this.supplierID.Name = "supplierID";
            this.supplierID.Size = new System.Drawing.Size(107, 36);
            this.supplierID.TabIndex = 31;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(44, 21);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(27, 24);
            this.id.TabIndex = 30;
            this.id.Text = "ID";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 544);
            this.Controls.Add(this.suppliers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplierWebsite);
            this.Controls.Add(this.website);
            this.Controls.Add(this.supplierFax);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.supplierPhone);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.updateSupplier);
            this.Controls.Add(this.deleteSupplier);
            this.Controls.Add(this.addSupplier);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.supplierMail);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.supplierID);
            this.Controls.Add(this.id);
            this.Name = "SupplierForm";
            this.Text = "Supplier Manage";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox suppliers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supplierWebsite;
        private System.Windows.Forms.Label website;
        private System.Windows.Forms.TextBox supplierFax;
        private System.Windows.Forms.Label fax;
        private System.Windows.Forms.TextBox supplierPhone;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button updateSupplier;
        private System.Windows.Forms.Button deleteSupplier;
        private System.Windows.Forms.Button addSupplier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox supplierMail;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox supplierID;
        private System.Windows.Forms.Label id;
    }
}