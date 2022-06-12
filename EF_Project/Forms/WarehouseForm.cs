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
    public partial class WarehouseForm : Form
    {
        Entities entities = new Entities();

        public WarehouseForm()
        {
            InitializeComponent();
        }
        private void updateView()
        {
            warhouses.Items.Clear();
            warhouses.Text = "--Select--";

            var warhouses_Data = entities.Warehouses;
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("Responsible Person Name");



            foreach (var warehouse in warhouses_Data)
            {

                dt.Rows.Add(warehouse.Id, warehouse.Name, warehouse.Address, warehouse.Responsible_Person);
                warhouses.Items.Add(warehouse.Id.ToString());
            }
            dataGridView1.DataSource = dt;
            warehouseName.Text = warhouseID.Text = warhouseResPerson.Text = warhouseAddress.Text = String.Empty;
            warhouses.SelectedItem = null;

        }



        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            updateView();
        }

        private void warhouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(warhouses.Text);
            var warehouse = (from d in entities.Warehouses
                            where d.Id == id
                            select d).First();
            if (warehouse != null)
            {
                warehouseName.Text = warehouse.Name;
                warhouseID.Text = warehouse.Id.ToString();
                warhouseResPerson.Text = warehouse.Responsible_Person;
                warhouseAddress.Text = warehouse.Address;
            }
        }

        private void addWarehouse_Click(object sender, EventArgs e)
        {
            if (warhouseAddress.Text!= String.Empty && warhouseID.Text != String.Empty && warehouseName.Text != String.Empty && warhouseResPerson.Text!=String.Empty)
            {

                string name = warehouseName.Text;
                string person = warhouseResPerson.Text;
                string address = warhouseAddress.Text;
                int id = int.Parse(warhouseID.Text);
                if (id > 0)
                {
                    try
                    {
                        Warehouse warehouse = new Warehouse();
                        warehouse.Name = name;
                        warehouse.Id = id;
                        warehouse.Responsible_Person = person;
                        warehouse.Address = address;
                       
                        entities.Warehouses.Add(warehouse);
                        entities.SaveChanges();
                        MessageBox.Show("Warehouse is Added");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Warehouse Must have unique Id ,name , Address and Ressponsible person");
        }

        private void updateWarehouse_Click(object sender, EventArgs e)
        {
            if (warhouseAddress.Text != String.Empty && warhouseID.Text != String.Empty && warehouseName.Text != String.Empty && warhouseResPerson.Text != String.Empty)
            {

                string name = warehouseName.Text;
                string person = warhouseResPerson.Text;
                string address = warhouseAddress.Text;
                int id = int.Parse(warhouseID.Text);
                if (id > 0)
                {
                    try
                    {
                        var warehouse = (from d in entities.Warehouses
                                        where d.Id == id
                                        select d).First();
                        warehouse.Name = name;
                        warehouse.Id = id;
                        warehouse.Responsible_Person = person;
                        warehouse.Address = address;
                        entities.SaveChanges();
                        MessageBox.Show("Warehouse is Updated");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }
            else MessageBox.Show("Warehouse Must have unique Id ,name , Address and Ressponsible person");
        }

        private void deleteWarehouse_Click(object sender, EventArgs e)
        {
            if (warhouseID.Text != String.Empty)
            {
                int id = int.Parse(warhouseID.Text);

                try
                {
                    var warehouse = (from d in entities.Warehouses
                                    where d.Id == id
                                    select d).First();
                    entities.Warehouses.Remove(warehouse);
                    entities.SaveChanges();
                    MessageBox.Show("Warehouse is Deleated");

                    updateView();
                }
                catch { MessageBox.Show("Invalid Data"); }


            }
            else MessageBox.Show("You Must Enter Warehouse Id");
        }
    }
}
