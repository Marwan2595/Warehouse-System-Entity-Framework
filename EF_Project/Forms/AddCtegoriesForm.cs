using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project.Forms
{
    public partial class AddCtegoriesForm : Form
    {
        string referanceTable;
        Category selectedCategory = null;
        int referanceID;
        Import importObj;
        Export exportObj;
        Convert convertObj;
        int staute = 0;
        const int importStaute = 1;
        const int exportStaute = 2;
        const int convertStaute = 3;
        Entities entities = new Entities();
        string productionDateExport;
        ObjectResult<warehouse_data_Result> DataCategories;
        private warehouse_data_Result neededitem;

        public AddCtegoriesForm(String str, Import import, Export export, Convert convert)
        {
            this.referanceTable = str;
            if (str == "Import")
            {
                this.referanceID = import.Id;
                staute = importStaute;
            }
            else if (str == "Export")
            {
                this.referanceID = export.Id;
                staute = exportStaute;
            }
            else if (str == "Transfare")
            {
                this.referanceID = convert.ConvertID;
                staute = convertStaute;
            }
            importObj = import;
            exportObj = export;
            convertObj = convert;

            InitializeComponent();
            hideInput();

        }
        private void hideInput()
        {

            if (this.referanceTable == "Import")
            {

                productionDateList.Visible = false;
                productionDate.Visible = true;
            }
            else
            {
                productionDateList.Visible = true;
                productionDate.Visible = false;
            }
        }
        private void AddCtegoriesForm_Load(object sender, EventArgs e)
        {
            this.title.Text = this.referanceTable;
            this.idText.Text = this.referanceID.ToString();
            updateView();
            productionDate.MinDate = new DateTime(2000, 1, 1);
            productionDate.MaxDate = DateTime.Today;
        }
        public void updateView()
        {
            int id;
            if (staute == importStaute) { id = importObj.WarehouseId; }
            else if (staute == exportStaute) { id = exportObj.WarehouseId; }
            else { id = convertObj.From_ID; }
            categories.Items.Clear();
            categories.Text = "--Select Category--";
            comboBox1.Items.Clear();
            comboBox1.Text = "--Select Category Index--";

            var categoriesData = entities.warehouse_data(id);


            DataTable dt = new DataTable();

            dt.Columns.Add("Index");
            dt.Columns.Add("Category Code");
            dt.Columns.Add("Category Name");
            dt.Columns.Add("Produaction Date");
            dt.Columns.Add("Quantity");
            int i = 1;

            foreach (var d in categoriesData)
            {
                var CategoriesDataByCode = (from c in entities.Categories
                                            where c.Code == d.Code
                                            select c).First();
                if (categories.FindString("Code : " + d.Code + " - Name:" + d.Name) < 0)
                {
                    categories.Items.Add("Code : " + d.Code + " - Name:" + d.Name);
                }
                dt.Rows.Add(i, d.Code, CategoriesDataByCode.Name, d.Production_Date, d.Quantity);
            }
            //foreach (var d in categoriesData)
            //{
            //    categories.Items.Add("Code : " + d.Code + " - Name:" + d.Name);
            //}

            dataGridView1.DataSource = dt;
            productionDate.Value = productionDate.MinDate;
            quantity.Text = String.Empty;
            comboBox1.SelectedItem = null;
            categories.SelectedItem = null;
            DataTable dt2 = new DataTable();
            if (staute == importStaute)
            {

                var import_CategoriesData = (from d in entities.Import_Categories
                                             where d.ImportId == importObj.Id
                                             select d);


                dt2.Columns.Add("Index");
                dt2.Columns.Add("Category Code");
                dt2.Columns.Add("Category Name");
                dt2.Columns.Add("Produaction Date");
                dt2.Columns.Add("Quantity");
                i = 1;

                foreach (var d in import_CategoriesData)
                {
                    dt2.Rows.Add(i, d.CategoryCode, d.Category.Name, d.Production_Date, d.Quantity);
                    comboBox1.Items.Add(i++);
                }


                dataGridView2.DataSource = dt2;

            }
            else if (staute == exportStaute)
            {
                var export_CategoriesData = (from d in entities.Export_Categories
                                             where d.ExportId == exportObj.Id
                                             select d);


                dt2.Columns.Add("Index");
                dt2.Columns.Add("Category Code");
                dt2.Columns.Add("Category Name");
                dt2.Columns.Add("Produaction Date");
                dt2.Columns.Add("Quantity");
                i = 1;

                foreach (var d in export_CategoriesData)
                {
                    dt2.Rows.Add(i, d.CategoryCode, d.Category.Name, d.Production_Date, d.Quantity);
                    comboBox1.Items.Add(i++);
                }
                //foreach (var d in categoriesData)
                //{
                //    categories.Items.Add("Code : " + d.Code + " - Name:" + d.Name);
                //}

                dataGridView2.DataSource = dt2;
            }


            else
            {
                var convert_CategoriesData = (from d in entities.Convert_Categories
                                             where d.ConvertId == convertObj.ConvertID
                                             select d);


                dt2.Columns.Add("Index");
                dt2.Columns.Add("Category Code");
                dt2.Columns.Add("Category Name");
                dt2.Columns.Add("Produaction Date");
                dt2.Columns.Add("Quantity");
                i = 1;

                foreach (var d in convert_CategoriesData)
                {
                    dt2.Rows.Add(i, d.CategoryCode, d.Category.Name, d.Production_Date, d.Quantity);
                    comboBox1.Items.Add(i++);
                }
                //foreach (var d in categoriesData)
                //{
                //    categories.Items.Add("Code : " + d.Code + " - Name:" + d.Name);
                //}

                dataGridView2.DataSource = dt2;

            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (staute == importStaute)
            {
                int index = int.Parse(comboBox1.Text);
                var import_CategoriesData = (from d in entities.Import_Categories
                                             where d.ImportId == importObj.Id
                                             select d);
                var category = import_CategoriesData.ToArray()[index - 1];
                categories.Text = ("Code : " + category.CategoryCode + " - Name:" + category.Category.Name);
                productionDate.Value = category.Production_Date;
                quantity.Text = category.Quantity.ToString();
            }
            if (staute == exportStaute)
            {
                int index = int.Parse(comboBox1.Text);
                var import_CategoriesData = (from d in entities.Export_Categories
                                             where d.ExportId == exportObj.Id
                                             select d);
                var category = import_CategoriesData.ToArray()[index - 1];
                categories.Text = ("Code : " + category.CategoryCode + " - Name:" + category.Category.Name);
                quantity.Text = category.Quantity.ToString();
            }
            if (staute == convertStaute)
            {
                int index = int.Parse(comboBox1.Text);
                var convert_CategoriesData = (from d in entities.Convert_Categories
                                             where d.ConvertId ==convertObj.ConvertID
                                             select d);
                var category = convert_CategoriesData.ToArray()[index - 1];
                categories.Text = ("Code : " + category.CategoryCode + " - Name:" + category.Category.Name);
                quantity.Text = category.Quantity.ToString();
            }
        }

        private void categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (staute == importStaute)
            {
                string code = (categories.Text).Split('-')[0].Split(':')[1].Remove(0, 1);
                selectedCategory = (from d in entities.Categories
                                    where d.Code == code
                                    select d).First();
            }
            else
            {
                string code = (categories.Text).Split('-')[0].Split(':')[1].Remove(0, 1);
                selectedCategory = (from d in entities.Categories
                                    where d.Code == code
                                    select d).First();
                int id;
                if (staute == exportStaute) { id = exportObj.WarehouseId; }
                else { id = convertObj.From_ID; }


                DataCategories = entities.warehouse_data(id);
                productionDateList.Items.Clear();
                productionDateList.Text = "--Select Category Produaction Date--";
                foreach (var item in DataCategories)
                {

                    if (item.Code.Trim().ToString() == code.Trim().ToString())
                    {
                        productionDateList.Items.Add(item.Production_Date.ToString());
                    }
                    else { }
                }
                productionDateList.SelectedItem = null;

            }


        }
        private void addImport_Click(object sender, EventArgs e)
        {
            if (staute == importStaute)
            {
                if (quantity.Text != String.Empty && selectedCategory != null)
                {
                    try
                    {

                        Import_Categories import_Categories = new Import_Categories();
                        import_Categories.Quantity = int.Parse(quantity.Text);
                        import_Categories.Production_Date = productionDate.Value;
                        import_Categories.ImportId = importObj.Id;
                        import_Categories.CategoryCode = selectedCategory.Code;
                        entities.Import_Categories.Add(import_Categories);
                        entities.SaveChanges();
                        updateView();
                        MessageBox.Show("Category is Added ");
                    }

                    catch
                    {
                        MessageBox.Show("Invalid Data");
                    }
                }
                else MessageBox.Show("You Must Chosse Category - produaction date - quantity ");
            }
            else
            {
                if (quantity.Text != String.Empty && selectedCategory != null && productionDateList != null)
                {
                    string code = (categories.Text).Split('-')[0].Split(':')[1].Remove(0, 1);
                    int id = exportObj == null ? convertObj.From_ID : exportObj.WarehouseId;

                    DataCategories = entities.warehouse_data(id);
                    foreach (var item in DataCategories)
                    {
                        if (item.Production_Date.ToString() == productionDateExport && item.Code.Trim().ToString() == code.Trim().ToString())
                        { neededitem = item; break; }
                    }

                    if (int.Parse(quantity.Text) > neededitem.Quantity)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        try
                        {
                            if (staute == exportStaute)
                            {

                                Export_Categories export_Categories = new Export_Categories();
                                export_Categories.Quantity = int.Parse(quantity.Text);
                                export_Categories.Production_Date = neededitem.Production_Date;
                                export_Categories.ExportId = exportObj.Id;
                                export_Categories.CategoryCode = selectedCategory.Code;
                                entities.Export_Categories.Add(export_Categories);
                                entities.SaveChanges();
                            }
                            else if (staute == convertStaute)
                            {
                                Convert_Categories convert_Categories = new Convert_Categories();
                                convert_Categories.Quantity = int.Parse(quantity.Text);
                                convert_Categories.Production_Date = neededitem.Production_Date;
                                convert_Categories.ConvertId = convertObj.ConvertID;
                                convert_Categories.CategoryCode = selectedCategory.Code;
                                entities.Convert_Categories.Add(convert_Categories);
                                entities.SaveChanges();
                            }
                            updateView();
                            MessageBox.Show("Category is Added ");
                        }

                        catch
                        {
                            MessageBox.Show("Invalid Data");
                        }
                    }
                }
                else MessageBox.Show("You Must Chosse Category - produaction date - quantity ");
            }
        }

        private void UpdateImport_Click(object sender, EventArgs e)
        {
            if (staute == importStaute)
            {
                if (quantity.Text != String.Empty && selectedCategory != null)
                {
                    try
                    {

                        var import_Categories = (from d in entities.Import_Categories
                                                 where d.CategoryCode == selectedCategory.Code && d.Production_Date == productionDate.Value && d.ImportId == importObj.Id
                                                 select d).First();
                        import_Categories.Quantity = int.Parse(quantity.Text);
                        import_Categories.Production_Date = productionDate.Value;
                        import_Categories.ImportId = importObj.Id;
                        import_Categories.CategoryCode = selectedCategory.Code;
                        entities.SaveChanges();
                        updateView();
                        MessageBox.Show("Category is Updated");
                    }

                    catch
                    {
                        MessageBox.Show("Invalid Data");
                    }
                }
                else MessageBox.Show("You Must Chosse Category - produaction date - quantity ");
            }
            else
            {
                if (quantity.Text != String.Empty && selectedCategory != null && productionDateList != null)
                {
                    int id = exportObj == null ? convertObj.From_ID : exportObj.WarehouseId;

                    DataCategories = entities.warehouse_data(id);
                    string code = (categories.Text).Split('-')[0].Split(':')[1].Remove(0, 1);
                    foreach (var item in DataCategories)
                    {
                        if (item.Production_Date.ToString() == productionDateExport && item.Code.Trim().ToString() == code.Trim().ToString())
                        { neededitem = item; break; }
                    }


                    try
                    {
                        if (staute == exportStaute)
                        {
                            var export_Categories = (from d in entities.Export_Categories
                                                     where d.ExportId == exportObj.Id && d.CategoryCode == code && d.Production_Date == neededitem.Production_Date
                                                     select d).First();
                            int Quantity = int.Parse(quantity.Text);
                            if (Quantity > export_Categories.Quantity + neededitem.Quantity) { MessageBox.Show("Error"); }
                            else
                            {
                                export_Categories.Quantity = Quantity;
                                export_Categories.Production_Date = neededitem.Production_Date;
                                export_Categories.ExportId = exportObj.Id;
                                export_Categories.CategoryCode = selectedCategory.Code;

                                entities.SaveChanges();
                                updateView();
                                MessageBox.Show("Category is Updated");
                            }
                        }
                        else if (staute == convertStaute)
                        {
                            var convert_Categories = (from d in entities.Convert_Categories
                                                      where d.ConvertId == convertObj.ConvertID && d.CategoryCode == code && d.Production_Date == neededitem.Production_Date
                                                      select d).First();
                            int Quantity = int.Parse(quantity.Text);
                            if (Quantity > convert_Categories.Quantity + neededitem.Quantity) { MessageBox.Show("Error"); }
                            else
                            {
                                convert_Categories.Quantity = Quantity;
                                convert_Categories.Production_Date = neededitem.Production_Date;
                                convert_Categories.ConvertId = convertObj.ConvertID;
                                convert_Categories.CategoryCode = selectedCategory.Code;
                                entities.SaveChanges();
                                updateView();
                                MessageBox.Show("Category is Updated");
                            }


                        }
                    }

                    catch
                    {
                        MessageBox.Show("Invalid Data");
                    }

                }
                else MessageBox.Show("You Must Chosse Category - produaction date - quantity ");
            }
        }



        private void deletImport_Click(object sender, EventArgs e)
        {
            if (staute == importStaute)
            {
                if (selectedCategory != null)
                {
                    try
                    {

                        var import_Categories = (from d in entities.Import_Categories
                                                 where d.CategoryCode == selectedCategory.Code && d.Production_Date == productionDate.Value && d.ImportId == importObj.Id
                                                 select d).First();

                        entities.Import_Categories.Remove(import_Categories);
                        entities.SaveChanges();
                        updateView();
                        MessageBox.Show("Category is Deleted");
                    }

                    catch
                    {
                        MessageBox.Show("Invalid Data");
                    }
                }
                else MessageBox.Show("You Must Chosse Category - produaction date ");
            }
            else
            {
                if (selectedCategory != null && productionDateList != null)
                {
                    string code = (categories.Text).Split('-')[0].Split(':')[1].Remove(0, 1);
                    int id = exportObj == null ? convertObj.From_ID : exportObj.WarehouseId;
                    DataCategories = entities.warehouse_data(id);
                    foreach (var item in DataCategories)
                    {
                        if (item.Production_Date.ToString() == productionDateExport && item.Code.Trim().ToString() == code.Trim().ToString())
                        { neededitem = item; break; }
                    }


                    try
                    {
                        if (staute == exportStaute)
                        {

                            var export_Categories = (from d in entities.Export_Categories
                                                     where d.ExportId == exportObj.Id && d.CategoryCode == code && d.Production_Date == neededitem.Production_Date
                                                     select d).First();
                            entities.Export_Categories.Remove(export_Categories);
                            entities.SaveChanges();
                            updateView();
                            MessageBox.Show("Category is Deleted");
                        }
                        else if (staute == convertStaute)
                        {
                            var convert_Categories = (from d in entities.Convert_Categories
                                                      where d.ConvertId == convertObj.ConvertID && d.CategoryCode == code && d.Production_Date == neededitem.Production_Date
                                                      select d).First();
                            entities.Convert_Categories.Remove(convert_Categories);
                            entities.SaveChanges();
                            updateView();
                            MessageBox.Show("Category is Deleted");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Invalid Data");
                    }

                }
                else MessageBox.Show("You Must Chosse Category - produaction date");
            }
        }

        private void productionDateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            productionDateExport = productionDateList.Text;
        }
    }
}
