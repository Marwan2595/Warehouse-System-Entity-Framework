namespace EF_Project.Forms
{
    partial class CustomerForm
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
            this.updateCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerMail = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.customerPhone = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.customerFax = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerWebsite = new System.Windows.Forms.TextBox();
            this.website = new System.Windows.Forms.Label();
            this.customers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateCustomer
            // 
            this.updateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCustomer.Location = new System.Drawing.Point(859, 121);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(88, 38);
            this.updateCustomer.TabIndex = 19;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomer.Location = new System.Drawing.Point(973, 121);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(87, 38);
            this.deleteCustomer.TabIndex = 18;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer.Location = new System.Drawing.Point(743, 121);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(94, 38);
            this.addCustomer.TabIndex = 17;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1148, 309);
            this.dataGridView1.TabIndex = 16;
            // 
            // customerMail
            // 
            this.customerMail.Location = new System.Drawing.Point(571, 49);
            this.customerMail.Multiline = true;
            this.customerMail.Name = "customerMail";
            this.customerMail.Size = new System.Drawing.Size(238, 36);
            this.customerMail.TabIndex = 15;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(567, 22);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(44, 24);
            this.mail.TabIndex = 14;
            this.mail.Text = "Mail";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(170, 49);
            this.customerName.Multiline = true;
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(360, 36);
            this.customerName.TabIndex = 13;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(166, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 24);
            this.name.TabIndex = 12;
            this.name.Text = "Name";
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(41, 49);
            this.customerID.Multiline = true;
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(107, 36);
            this.customerID.TabIndex = 11;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(37, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(27, 24);
            this.id.TabIndex = 10;
            this.id.Text = "ID";
            // 
            // customerPhone
            // 
            this.customerPhone.Location = new System.Drawing.Point(832, 49);
            this.customerPhone.Multiline = true;
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(228, 36);
            this.customerPhone.TabIndex = 21;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(828, 22);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(66, 24);
            this.phone.TabIndex = 20;
            this.phone.Text = "Phone";
            // 
            // customerFax
            // 
            this.customerFax.Location = new System.Drawing.Point(41, 121);
            this.customerFax.Multiline = true;
            this.customerFax.Name = "customerFax";
            this.customerFax.Size = new System.Drawing.Size(318, 36);
            this.customerFax.TabIndex = 25;
            // 
            // fax
            // 
            this.fax.AutoSize = true;
            this.fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fax.Location = new System.Drawing.Point(37, 94);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(42, 24);
            this.fax.TabIndex = 24;
            this.fax.Text = "Fax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 28;
            // 
            // customerWebsite
            // 
            this.customerWebsite.Location = new System.Drawing.Point(385, 121);
            this.customerWebsite.Multiline = true;
            this.customerWebsite.Name = "customerWebsite";
            this.customerWebsite.Size = new System.Drawing.Size(318, 36);
            this.customerWebsite.TabIndex = 27;
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website.Location = new System.Drawing.Point(381, 94);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(78, 24);
            this.website.TabIndex = 26;
            this.website.Text = "Website";
            // 
            // customers
            // 
            this.customers.FormattingEnabled = true;
            this.customers.Location = new System.Drawing.Point(359, 190);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(394, 21);
            this.customers.TabIndex = 29;
            this.customers.SelectedIndexChanged += new System.EventHandler(this.customers_SelectedIndexChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 544);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerWebsite);
            this.Controls.Add(this.website);
            this.Controls.Add(this.customerFax);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.customerPhone);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customerMail);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.id);
            this.Name = "CustomerForm";
            this.Text = "Customer Manage";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox customerMail;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox customerPhone;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox customerFax;
        private System.Windows.Forms.Label fax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerWebsite;
        private System.Windows.Forms.Label website;
        private System.Windows.Forms.ComboBox customers;
    }
}