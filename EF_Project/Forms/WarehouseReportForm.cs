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
    public partial class WarehouseReportForm : Form
    {
        Entities entities = new Entities();
        bool dateChanged = false;
        public WarehouseReportForm()
        {
            InitializeComponent();
        }

        private void WarehouseReportForm_Load(object sender, EventArgs e)
        {
            warehouse2.Items.Clear();
            warehouse2.Text = "--Select--";
            warehouse2.SelectedItem = null;
            var warehouse2sData = entities.Warehouses;
            foreach (var row in warehouse2sData)
            {
                warehouse2.Items.Add(row.Id.ToString() + "-" + row.Name);
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
        }

        private void showReportBtn_Click(object sender, EventArgs e)
        {
            if (warehouse2.SelectedItem != null)
            {
                int warID = int.Parse(warehouse2.Text.Split('-')[0].Trim().ToString());
                DateTime stDate = startDate.Value.Date;
                DateTime eDate = endDate.Value.Date;
                try
                {





                    if (dateChanged)
                    {
                        var reportData = entities.warehouse_data_startDate_endDate(warID, stDate, eDate);
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
                    else
                    {
                        var reportData = entities.warehouse_data(warID);
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

                }
                catch (Exception)
                {

                    MessageBox.Show("Something Wrong Happend Please Try Again");
                }
            }
            else MessageBox.Show("Please Select a warehouse ..");
        }
    }
}
