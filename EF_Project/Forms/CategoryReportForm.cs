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
    public partial class CategoryReportForm : Form
    {
        Entities entities = new Entities();
        bool dateChanged = false;
        public CategoryReportForm()
        {
            InitializeComponent();
        }

       

        private void showReportBtn_Click(object sender, EventArgs e)
        {
            if (category.SelectedItem != null)
            {
                string catCode = category.Text.Split('-')[0];
                DateTime stDate = startDate.Value.Date;
                DateTime eDate = endDate.Value.Date;
                try
                { 
                    if (dateChanged)
                    {
                        var reportData = entities.catogoryReportWithDate(catCode, stDate, eDate);
                        DataTable dt = new DataTable();

                        dt.Columns.Add("Code");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Unit");
                        dt.Columns.Add("Production Date");
                        dt.Columns.Add("Expired period");
                        dt.Columns.Add("Warehouse");
                        dt.Columns.Add("Quantity");




                        foreach (var row in reportData)
                        {

                            dt.Rows.Add(
                                row.Code,
                                row.Name,
                                row.Unit,
                                row.Production_Date,
                                row.Expired_period,
                                row.WarehouseId,
                                row.Quantity

                                );
                        }
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                       var reportData = entities.catogoryReport(catCode);
                        DataTable dt = new DataTable();

                        dt.Columns.Add("Code");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Unit");
                        dt.Columns.Add("Production Date");
                        dt.Columns.Add("Expired period");
                        dt.Columns.Add("Warehouse");
                        dt.Columns.Add("Quantity");




                        foreach (var row in reportData)
                        {

                            dt.Rows.Add(
                                row.Code,
                                row.Name,
                                row.Unit,
                                row.Production_Date,
                                row.Expired_period,
                                row.WarehouseId,
                                row.Quantity

                                );
                        }
                        dataGridView1.DataSource = dt;
                    }
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Something Wrong Happend Please Try Again");
                }
            }
            else MessageBox.Show("Please Select a Category ..");
        }

        private void CategoryReportForm_Load(object sender, EventArgs e)
        {
            category.Items.Clear();
            category.Text = "--Select--";
            category.SelectedItem = null;
            var categorysData = entities.Categories;
            foreach (var row in categorysData)
            {
                category.Items.Add(row.Code.ToString() + "-" + row.Name);
            }
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
        }
    }
}
