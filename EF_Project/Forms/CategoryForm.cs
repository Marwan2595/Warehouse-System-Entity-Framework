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
    public partial class CategoryForm : Form
    {
        Entities entities = new Entities();

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void updateView() {
            categories.Items.Clear();
            categories.Text = "--Select--";

            var categories_Data = entities.Categories;
            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Code");
            dt.Columns.Add("Expired period by months");
            dt.Columns.Add("Unit");


            foreach (var cat in categories_Data)
            {

                dt.Rows.Add(cat.Name, cat.Code, cat.Expired_period, cat.Unit);
                categories.Items.Add(cat.Code.ToString());
            }
            dataGridView1.DataSource = dt;
            categoryCode.Text = categoryName.Text = categoryUnit.Text = categoryPeriod.Text=String.Empty;
            categories.SelectedItem = null;



        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            updateView();
        }

        private void categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = categories.Text;
            var category = (from d in entities.Categories
                       where d.Code == code
                       select d).First();
            if (category != null)
            {
                categoryCode.Text = category.Code.ToString();
                categoryName.Text = category.Name.ToString();
                categoryUnit.Text = category.Unit.ToString();
                categoryPeriod.Text=category.Expired_period.ToString();
            }
        }

        private void addCategory_Click(object sender, EventArgs e)
        {

            if (categoryCode.Text != String.Empty && categoryName.Text != String.Empty && categoryUnit.Text != String.Empty && categoryPeriod.Text != String.Empty)
            {
                string code = categoryCode.Text;
                string name = categoryName.Text;
                string unit = categoryUnit.Text;
                int peroid = int.Parse(categoryPeriod.Text);
                if (peroid > 0)
                {
                   try
                    {
                        Category newCategory = new Category();
                        newCategory.Code = code;
                        newCategory.Name = name;
                        newCategory.Unit = unit;
                        newCategory.Expired_period = peroid;
                        entities.Categories.Add(newCategory);
                        entities.SaveChanges();
                        MessageBox.Show("Category is Added");
                        updateView();
                   }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Peroid Must be Postive Integer Number"); }

            }
            else MessageBox.Show("You Must Enter The inputs ");


        }

        private void updateCategory_Click(object sender, EventArgs e)
        {
            if (categoryCode.Text != String.Empty && categoryName.Text != String.Empty && categoryUnit.Text != String.Empty && categoryPeriod.Text != String.Empty)
            {
                string code = categoryCode.Text;
                string name = categoryName.Text;
                string unit = categoryUnit.Text;
                int peroid = int.Parse(categoryPeriod.Text);
                if (peroid > 0)
                {
                    try
                    {
                        var category = (from d in entities.Categories
                                        where d.Code == code
                                        select d).First();
                        category.Name = name;
                        category.Unit = unit;
                        category.Expired_period = peroid;
                        entities.SaveChanges();
                        MessageBox.Show("Category is Updated");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                }
                else { MessageBox.Show("Peroid Must be Postive Integer Number"); }

            }
            else MessageBox.Show("You Must Enter The inputs");
        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            if (categoryCode.Text != String.Empty)
            {
                string code = categoryCode.Text;
              
                    try
                    {
                        var category = (from d in entities.Categories
                                        where d.Code == code
                                        select d).First();
                        entities.Categories.Remove(category);
                        entities.SaveChanges();
                        MessageBox.Show("Category is Deleated");
                        updateView();
                    }
                    catch { MessageBox.Show("Invalid Data"); }
                

            }
            else MessageBox.Show("You Must Enter The Category code");
        }

    }
    }

