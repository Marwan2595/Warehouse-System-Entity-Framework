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
    public partial class ImportForm : Form
    {
        Entities entities = new Entities();
        Warehouse selectedWarhouse;
        Supplier selectedSupplier;

        public ImportForm()
        {
            InitializeComponent();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            if (importPerID.Text != String.Empty)
            {
               
                int id = int.Parse(importPerID.Text);
                try
                {
                    var import = (from d in entities.Imports
                                  where d.Id == id
                                  select d).First();
                    if (import != null)
                    {
                        using (AddCtegoriesForm importCat = new AddCtegoriesForm("Import", import, null, null))
                        {
                            importCat.StartPosition = FormStartPosition.CenterParent;
                            importCat.ShowDialog();
                        }
                    }
                    else MessageBox.Show("Wrong Import permission id");
                }
                catch { MessageBox.Show("Wrong Import permission id"); }

            }
            else MessageBox.Show("You Must Enter Import permission Id");
        }

        private void updateView()
        {
            importWarehouse.Items.Clear();
            importWarehouse.Text = "--Select--";
            comboBox1.Items.Clear();
            comboBox1.Text = "--Select--";

            var Importsdata = entities.Imports;
            var SuppliersData = entities.Suppliers;
            var WarehousesData = entities.Warehouses;
            DataTable dt = new DataTable();


            dt.Columns.Add("Permison ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Warehouse Name");
            dt.Columns.Add("Supplier Name");



            foreach (var d in Importsdata)
            {
                dt.Rows.Add(d.Id, d.Date, d.Warehouse.Name, d.Supplier.Name);
            }
            foreach (var d in SuppliersData)
            {
                comboBox1.Items.Add("ID : " + d.Id + " - Name:" + d.Name);
            }
            foreach (var d in WarehousesData)
            {
                importWarehouse.Items.Add("ID : " + d.Id + " - Name:" + d.Name);
            }
            dataGridView1.DataSource = dt;
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            importPerID.Text = String.Empty;
            comboBox1.SelectedItem = null;
            importWarehouse.SelectedItem = null;
            selectedSupplier = null;
            selectedWarhouse = null;
        }
        private void ImportForm_Load(object sender, EventArgs e)
        {
            updateView();
            dateTimePicker1.MinDate = new DateTime(2000, 1, 1);
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void importWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse((importWarehouse.Text).Split('-')[0].Split(':')[1]);

            var warehouse = (from d in entities.Warehouses
                             where d.Id == id
                             select d).First();
            if (warehouse != null)
            {
                selectedWarhouse = warehouse;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse((comboBox1.Text).Split('-')[0].Split(':')[1]);

            var supplier = (from d in entities.Suppliers
                            where d.Id == id
                            select d).First();
            if (supplier != null)
            {
                selectedSupplier = supplier;
            }

        }

        private void addImport_Click(object sender, EventArgs e)
        {
            if (selectedSupplier != null && selectedWarhouse != null && importPerID.Text != String.Empty)
            {

                int id = int.Parse(importPerID.Text);
                if (id > 0)
                {
                    try
                    {
                        Import import = new Import();
                        import.Id = id;
                        import.Supplier = selectedSupplier;
                        import.Warehouse = selectedWarhouse;
                        import.SupplierId = selectedSupplier.Id;
                        import.WarehouseId = selectedWarhouse.Id;
                        import.Date = dateTimePicker1.Value.Date;

                        entities.Imports.Add(import);
                        entities.SaveChanges();
                        MessageBox.Show("Import Permisoin is Added");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Import permission Must have unique Id , Date , Supplier and Warehouse");
        }

        private void updateImport_Click(object sender, EventArgs e)
        {
            if (selectedSupplier != null && selectedWarhouse != null && importPerID.Text != String.Empty)
            {

                int id = int.Parse(importPerID.Text);
                if (id > 0)
                {
                    try
                    {
                        Import import = (from d in entities.Imports
                                         where d.Id == id
                                         select d).First();
                        import.Id = id;
                        import.Supplier = selectedSupplier;
                        import.Warehouse = selectedWarhouse;
                        import.SupplierId = selectedSupplier.Id;
                        import.WarehouseId = selectedWarhouse.Id;
                        import.Date = dateTimePicker1.Value.Date;
                        entities.SaveChanges();
                        MessageBox.Show("Import Permisoin is updated");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Import permission Must have unique Id , Date , Supplier and Warehouse");

        }

        private void deleteImport_Click(object sender, EventArgs e)
        {
            if (importPerID.Text != String.Empty)
            {

                int id = int.Parse(importPerID.Text);
                if (id > 0)
                {
                    try
                    {
                        Import import = (from d in entities.Imports
                                         where d.Id == id
                                         select d).First();
                        entities.Imports.Remove(import);
                        entities.SaveChanges();
                        MessageBox.Show("Import Permission is deleted");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Id or Import permission has at least one Catagory"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }

            else MessageBox.Show("You Must Enter Import permission Id");
        }
    }
}
