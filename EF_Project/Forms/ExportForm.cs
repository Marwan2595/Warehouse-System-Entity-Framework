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
    public partial class ExportForm : Form
    {
        Entities entities = new Entities();
        Warehouse selectedWarhouse;
        Client selectedCustomer;
        public ExportForm()
        {
            InitializeComponent();
        }



        private void categoryButton_Click(object sender, EventArgs e)
        {
           
            if (exportPerID.Text != String.Empty)
            {
                int id = int.Parse(exportPerID.Text);
                try
                {
                    var export = (from d in entities.Exports
                                  where d.Id == id
                                  select d).First();
                    if (export != null)
                    {
                        using (AddCtegoriesForm importCat = new AddCtegoriesForm("Export", null, export, null))
                        {
                            importCat.StartPosition = FormStartPosition.CenterParent;
                            importCat.ShowDialog();
                        }
                    }
                    
                }
                catch { MessageBox.Show("Wrong Export permission id");  }

            }
            else MessageBox.Show("You Must Enter Export permission Id");
        }
        private void updateView()
        {
            exportCustomer.Items.Clear();
            exportCustomer.Text = "--Select--";
            comboBox1.Items.Clear();
            comboBox1.Text = "--Select--";

            var Exportsdata = entities.Exports;
            var CustomerData = entities.Clients;
            var WarehousesData = entities.Warehouses;
            DataTable dt = new DataTable();


            dt.Columns.Add("Permison ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Warehouse Name");
            dt.Columns.Add("Customer Name");



            foreach (var d in Exportsdata)
            {
                dt.Rows.Add(d.Id, d.Date, d.Warehouse.Name, d.Client.Name);
            }
            foreach (var d in CustomerData)
            {
                exportCustomer.Items.Add("ID : " + d.Id + " - Name:" + d.Name);
            }
            foreach (var d in WarehousesData)
            {
                comboBox1.Items.Add("ID : " + d.Id + " - Name:" + d.Name);
            }
            dataGridView1.DataSource = dt;
            exportDate.Value = exportDate.MinDate;
            exportPerID.Text = String.Empty;
            comboBox1.SelectedItem = null;
            exportCustomer.SelectedItem = null;
            selectedCustomer = null;
            selectedWarhouse = null;
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            updateView();
            exportDate.MinDate = new DateTime(2000, 1, 1);
            exportDate.MaxDate = DateTime.Today;
        }

        private void addImport_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null && selectedWarhouse != null && exportPerID.Text != String.Empty)
            {

                int id = int.Parse(exportPerID.Text);
                if (id > 0)
                {
                    try
                    {
                        Export export = new Export();
                        export.Id = id;
                        export.Client = selectedCustomer;
                        export.Warehouse = selectedWarhouse;
                        export.ClientId = selectedCustomer.Id;
                        export.WarehouseId = selectedWarhouse.Id;
                        export.Date = exportDate.Value.Date;

                        entities.Exports.Add(export);
                        entities.SaveChanges();
                        MessageBox.Show("Export Permisoin is Added");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Export permission Must have unique Id , Date , Customer and Warehouse");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse((comboBox1.Text).Split('-')[0].Split(':')[1]);

            var warehouse = (from d in entities.Warehouses
                             where d.Id == id
                             select d).First();
            if (warehouse != null)
            {
                selectedWarhouse = warehouse;
            }
        }

        private void exportCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse((exportCustomer.Text).Split('-')[0].Split(':')[1]);

            var client = (from d in entities.Clients
                            where d.Id == id
                            select d).First();
            if (client != null)
            {
                selectedCustomer = client;
            }
        }

        private void updateImport_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null && selectedWarhouse != null && exportPerID.Text != String.Empty)
            {

                int id = int.Parse(exportPerID.Text);
                if (id > 0)
                {
                    try
                    {
                        Export export = (from d in entities.Exports
                                         where d.Id == id
                                         select d).First();
                        export.Id = id;
                        export.Client = selectedCustomer;
                        export.Warehouse = selectedWarhouse;
                        export.ClientId = selectedCustomer.Id;
                        export.WarehouseId = selectedWarhouse.Id;
                        export.Date = exportDate.Value.Date;
                        entities.SaveChanges();
                        MessageBox.Show("Export Permisoin is updated");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Export permission Must have unique Id , Date , Customer and Warehouse");
        }

        private void deleteImport_Click(object sender, EventArgs e)
        {
            if (exportPerID.Text != String.Empty)
            {

                int id = int.Parse(exportPerID.Text);
                if (id > 0)
                {
                    try
                    {
                        Export export = (from d in entities.Exports
                                         where d.Id == id
                                         select d).First();
                        entities.Exports.Remove(export);
                        entities.SaveChanges();
                        MessageBox.Show("Export Permission is deleted");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Id or Export permission has at least one Catagory"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }

            else MessageBox.Show("You Must Enter Export permission Id");
        }
    }
}
