using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project.Forms
{
    public partial class SupplierForm : Form
    {
        Entities entities = new Entities();

        public SupplierForm()
        {
            InitializeComponent();
        }
        private void updateView()
        {
            suppliers.Items.Clear();
            suppliers.Text = "--Select--";

            var supplier_Data = entities.Suppliers;
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Mail");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Fax");
            dt.Columns.Add("Website");


            foreach (var supplier in supplier_Data)
            {

                dt.Rows.Add(supplier.Id, supplier.Name, supplier.Mail, supplier.Phone, supplier.Fax, supplier.WebSite);
                suppliers.Items.Add(supplier.Id.ToString());
            }
            dataGridView1.DataSource = dt;
            supplierName.Text = supplierPhone.Text = supplierMail.Text = supplierWebsite.Text = supplierFax.Text = supplierID.Text = String.Empty;
            suppliers.SelectedItem = null;
        }


        private void SupplierForm_Load(object sender, EventArgs e)
        {
            updateView();
        }

        private void suppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = int.Parse(suppliers.Text);
            var supplier = (from d in entities.Suppliers
                            where d.Id == id
                            select d).First();
            if (supplier != null)
            {
                supplierName.Text = supplier.Name;
                supplierPhone.Text = supplier.Phone;
                supplierMail.Text = supplier.Mail;
                supplierWebsite.Text = supplier.WebSite;
                supplierFax.Text = supplier.Fax;
                supplierID.Text = supplier.Id.ToString();
            }
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            if (supplierName.Text != String.Empty && supplierPhone.Text != String.Empty && supplierID.Text != String.Empty)
            {
                string phone = supplierPhone.Text;
                string name = supplierName.Text;
                string website = supplierWebsite.Text;
                string fax = supplierFax.Text;
                string mail = supplierMail.Text;
                int id = int.Parse(supplierID.Text);
                if (id > 0)
                {
                    try
                    {
                        Supplier supplier = new Supplier();
                        supplier.Fax = fax;
                        supplier.Name = name;
                        supplier.Phone = phone;
                        supplier.Mail = mail;
                        supplier.WebSite = website;
                        supplier.Id = id;
                        entities.Suppliers.Add(supplier);
                        entities.SaveChanges();
                        MessageBox.Show("Supplier is Added");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Supplier Must have unique Id and name and phone at least");
        }

        private void updateSupplier_Click(object sender, EventArgs e)
        {

            if (supplierName.Text != String.Empty && supplierPhone.Text != String.Empty && supplierID.Text != String.Empty)
            {
                string phone = supplierPhone.Text;
                string name = supplierName.Text;
                string website = supplierWebsite.Text;
                string fax = supplierFax.Text;
                string mail = supplierMail.Text;
                int id = int.Parse(supplierID.Text);
                if (id > 0)
                {
                    try
                    {
                        var supplier = (from d in entities.Suppliers
                                      where d.Id == id
                                      select d).First();
                        supplier.Fax = fax;
                        supplier.Name = name;
                        supplier.Phone = phone;
                        supplier.Mail = mail;
                        supplier.WebSite = website;
                        supplier.Id = id;
                        entities.SaveChanges();
                        MessageBox.Show("Supplier is Updated");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Supplier Must have unique Id and name and phone at least");
        }

        private void deleteSupplier_Click(object sender, EventArgs e)
        {
            if (supplierID.Text != String.Empty)
            {
                int id = int.Parse(supplierID.Text);

                try
                {
                    var supplier = (from d in entities.Suppliers
                                  where d.Id == id
                                  select d).First();
                    entities.Suppliers.Remove(supplier);
                    entities.SaveChanges();
                    MessageBox.Show("Supplier is Deleated");
                    
                    updateView();
                }
                catch { MessageBox.Show("Invalid Data"); }


            }
            else MessageBox.Show("You Must Enter Supplier Id");
        }
    }
}
