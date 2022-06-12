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
    public partial class CustomerForm : Form
    {
        Entities entities = new Entities();
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void updateView()
        {
            customers.Items.Clear();
            customers.Text = "--Select--";

            var customer_Data = entities.Clients;
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Mail");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Fax");
            dt.Columns.Add("Website");


            foreach (var customer in customer_Data)
            {

                dt.Rows.Add(customer.Id, customer.Name, customer.Mail, customer.Phone, customer.Fax, customer.WebSite);
                customers.Items.Add(customer.Id.ToString());
            }
            dataGridView1.DataSource = dt;
            customerName.Text = customerPhone.Text = customerMail.Text = customerWebsite.Text = customerFax.Text = customerID.Text = String.Empty;
            customers.SelectedItem = null;




        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            updateView();
        }



        private void customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(customers.Text);
            var customer = (from d in entities.Clients
                            where d.Id == id
                            select d).First();
            if (customer != null)
            {
                customerName.Text = customer.Name;
                customerPhone.Text = customer.Phone;
                customerMail.Text = customer.Mail;
                customerWebsite.Text = customer.WebSite;
                customerFax.Text = customer.Fax;
                customerID.Text = customer.Id.ToString();
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (customerName.Text != String.Empty && customerPhone.Text != String.Empty && customerID.Text != String.Empty)
            {
                string phone = customerPhone.Text;
                string name = customerName.Text;
                string website = customerWebsite.Text;
                string fax = customerFax.Text;
                string mail = customerMail.Text;
                int id = int.Parse(customerID.Text);
                if (id > 0)
                {
                    try
                    {
                        Client client = new Client();
                        client.Fax = fax;
                        client.Name = name;
                        client.Phone = phone;
                        client.Mail = mail;
                        client.WebSite = website;
                        client.Id = id;
                        entities.Clients.Add(client);
                        entities.SaveChanges();
                        MessageBox.Show("Client is Added");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Client Must have unique Id and name and phone at least");

        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {


            if (customerName.Text != String.Empty && customerPhone.Text != String.Empty && customerID.Text != String.Empty)
            {
                string phone = customerPhone.Text;
                string name = customerName.Text;
                string website = customerWebsite.Text;
                string fax = customerFax.Text;
                string mail = customerMail.Text;
                int id = int.Parse(customerID.Text);
                if (id > 0)
                {
                    try
                    {
                        var client = (from d in entities.Clients
                                      where d.Id == id
                                      select d).First();
                        client.Fax = fax;
                        client.Name = name;
                        client.Phone = phone;
                        client.Mail = mail;
                        client.WebSite = website;
                        client.Id = id;
                        entities.SaveChanges();
                        MessageBox.Show("Client is Updated");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Client Must have unique Id and name and phone at least");
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if (customerID.Text != String.Empty)
            {
                int id = int.Parse(customerID.Text);

                try
                {
                    var client = (from d in entities.Clients
                                  where d.Id == id
                                  select d).First();
                    entities.Clients.Remove(client);
                    entities.SaveChanges();
                    MessageBox.Show("Client is Deleated");
                    updateView();
                }
                catch { MessageBox.Show("Invalid Data"); }


            }
            else MessageBox.Show("You Must Enter Client Id");
        }
    }
}
