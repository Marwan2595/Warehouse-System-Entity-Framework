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
    public partial class TransfareForm : Form
    {
        Entities entities = new Entities();
        Warehouse selectedFromWarhouse, selectedToWarhouse;
        public TransfareForm()
        {
            InitializeComponent();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {

            if (transfarePerID.Text != String.Empty)
            {
                
                int id = int.Parse(transfarePerID.Text);
                try
                {
                    var convert = (from d in entities.Converts
                                   where d.ConvertID == id
                                   select d).First();
                    if (convert != null)
                    {
                        using (AddCtegoriesForm importCat = new AddCtegoriesForm("Transfare", null, null, convert))
                        {
                            importCat.StartPosition = FormStartPosition.CenterParent;
                            importCat.ShowDialog();
                        }
                    }
                    else MessageBox.Show("Wrong Transfare permission id");
                }
                catch  { MessageBox.Show("Wrong Transfare permission id"); }

            }
            else MessageBox.Show("You Must Enter Transfare permission Id");
        }
        private void updateView()
        {
            fromWarehouse.Items.Clear();
            fromWarehouse.Text = "--Select From Warehouse--";
            toWarehouse.Items.Clear();
            toWarehouse.Text = "--Select To Warehouse--";

            var convertsData = entities.Converts;

            var WarehousesData = entities.Warehouses;
            DataTable dt = new DataTable();


            dt.Columns.Add("Permison ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("From Warehouse Name");
            dt.Columns.Add("To Warehouse Name");



            foreach (var d in convertsData)
            {
                dt.Rows.Add(d.ConvertID, d.Date, d.Warehouse.Name, d.Warehouse1.Name);
            }

            foreach (var d in WarehousesData)
            {
                fromWarehouse.Items.Add("ID : " + d.Id + " - Name:" + d.Name);
                toWarehouse.Items.Add("ID : " + d.Id + " - Name:" + d.Name);
            }
            dataGridView1.DataSource = dt;
            transfareDate.Value = transfareDate.MinDate;
            transfarePerID.Text = String.Empty;
            fromWarehouse.SelectedItem = null;
            toWarehouse.SelectedItem = null;
            selectedFromWarhouse = null;
            selectedToWarhouse = null;


        }

        private void fromWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse((fromWarehouse.Text).Split('-')[0].Split(':')[1]);

            var warehouse = (from d in entities.Warehouses
                             where d.Id == id
                             select d).First();
            if (warehouse != null)
            {
                selectedFromWarhouse = warehouse;
            }
        }

        private void toWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse((toWarehouse.Text).Split('-')[0].Split(':')[1]);

            var warehouse = (from d in entities.Warehouses
                             where d.Id == id
                             select d).First();
            if (warehouse != null)
            {
                selectedToWarhouse = warehouse;
            }

        }

        private void addImport_Click(object sender, EventArgs e)
        {
            if (selectedFromWarhouse != null && selectedToWarhouse != null && transfarePerID.Text != String.Empty)
            {

                int id = int.Parse(transfarePerID.Text);
                if (id > 0)
                {
                    if (selectedToWarhouse.Id == selectedFromWarhouse.Id) { MessageBox.Show("You can`t transfer to same warehouse "); }
                    else
                    {
                        try
                        {
                            Convert convert = new Convert();
                            convert.ConvertID = id;
                            convert.From_ID = selectedFromWarhouse.Id;
                            convert.Warehouse = selectedFromWarhouse;
                            convert.To_ID = selectedToWarhouse.Id;
                            convert.Warehouse1 = selectedToWarhouse;
                            convert.Date = transfareDate.Value.Date;

                            entities.Converts.Add(convert);
                            entities.SaveChanges();
                            MessageBox.Show("Transfer Permisoin is Added");
                            updateView();
                        }
                        catch { MessageBox.Show("Invalid Data"); }
                    }
                }
                else { MessageBox.Show("Wrong Permisoin Id"); }

            }
            else MessageBox.Show("Transfer permission Must have unique Id , Date , From and to Warehouse");
        }

        private void updateImport_Click(object sender, EventArgs e)
        {
            if (selectedFromWarhouse != null && selectedToWarhouse != null && transfarePerID.Text != String.Empty)
            {

                int id = int.Parse(transfarePerID.Text);
                if (id > 0)
                {
                    if (selectedToWarhouse.Id == selectedFromWarhouse.Id) { MessageBox.Show("You can`t transfer to same warehouse "); }
                    else
                    {
                        try
                        {
                            Convert convert = (from d in entities.Converts
                                               where d.ConvertID == id
                                               select d).First();
                            convert.ConvertID = id;
                            convert.From_ID = selectedFromWarhouse.Id;
                            convert.Warehouse = selectedFromWarhouse;
                            convert.To_ID = selectedToWarhouse.Id;
                            convert.Warehouse1 = selectedToWarhouse;
                            convert.Date = transfareDate.Value.Date;
                            entities.SaveChanges();
                            MessageBox.Show("Transfer Permisoin is Updated");
                            updateView();
                        }
                        catch { MessageBox.Show("Invalid Data"); }
                    }
                }
                else { MessageBox.Show("Wrong Permisoin Id"); }

            }
            else MessageBox.Show("Transfer permission Must have unique Id , Date , From and to Warehouse");
        }

        private void deleteImport_Click(object sender, EventArgs e)
        {
            if (transfarePerID.Text != String.Empty)
            {

                int id = int.Parse(transfarePerID.Text);
                if (id > 0)
                {
                    try
                    {
                        Convert convert = (from d in entities.Converts
                                           where d.ConvertID == id
                                           select d).First();
                        entities.Converts.Remove(convert);
                        entities.SaveChanges();
                        MessageBox.Show("Transfer Permission is deleted");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Id or Transfer permission has at least one Catagory"); }
                }
                else { MessageBox.Show("Wrong Id"); }

            }

            else MessageBox.Show("You Must Enter Transfer permission Id");
        }

        private void TransfareForm_Load(object sender, EventArgs e)
        {
            updateView();
            transfareDate.MinDate = new DateTime(2000, 1, 1);
            transfareDate.MaxDate = DateTime.Today;
        }
    }
}
