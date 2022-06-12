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
    public partial class CategoryAfterPeriodForm : Form
    {
        Entities entities = new Entities();
        public CategoryAfterPeriodForm()
        {
            InitializeComponent();
        }

        private void period_Click(object sender, EventArgs e)
        {

        }

        private void showReportBtn_Click(object sender, EventArgs e)
        {
            if (warehouse.SelectedItem != null && timePeriod.Text != String.Empty)
            {
                int period;
                bool parseCheck = int.TryParse(timePeriod.Text.Split('-')[0].Trim().ToString(), out period);
                int warehouseID = int.Parse(warehouse.Text.Split('-')[0].Trim().ToString());
                if (parseCheck)
                {
                    //MessageBox.Show(warehouseID.ToString()+"  -  "+period.ToString());
                    try
                    {
                        var reportData = entities.warehouse_data_with_Period(warehouseID,period);
                        DataTable dt = new DataTable();

                        dt.Columns.Add("Code");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Unit");
                        dt.Columns.Add("Production Date");
                        dt.Columns.Add("Expired period");
                        dt.Columns.Add("Quantity");


    

                        foreach (var row in reportData)
                        {

                            dt.Rows.Add(
                                row.Code,
                                row.Name,
                                row.Unit,
                                row.Production_Date,
                                row.Expired_period,
                                row.Quantity
                                );
                        }
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception)
                    {

                      MessageBox.Show("Something Wrong Happend Please Try Again");
                    }
                }else MessageBox.Show("Please Enter The Period in Numbers !");

            }
            else MessageBox.Show("Please Fill All Form Fields ..");

        }

        private void CategoryAfterPeriodForm_Load(object sender, EventArgs e)
        {
            warehouse.Items.Clear();
            warehouse.Text = "--Select--";
            warehouse.SelectedItem = null;
            var warehousesData = entities.Warehouses;
            foreach (var row in warehousesData)
            {
                warehouse.Items.Add(row.Id.ToString() + "-" + row.Name);
            }
        }
    }
}
