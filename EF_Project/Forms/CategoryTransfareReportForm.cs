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
    public partial class CategoryTransfareReportForm : Form
    {
        Entities entities = new Entities();
        public CategoryTransfareReportForm()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showReportBtn_Click(object sender, EventArgs e)
        {

            if (warehouses.SelectedItem != null)
            {
                int warehouseID = int.Parse(warehouses.Text.Split('-')[0].Trim().ToString());
                try
                {
                    var reportData = entities.ReportAboutCatogoriesMovement(warehouseID);
                    DataTable dt = new DataTable();

                    dt.Columns.Add("Code");
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Unit");
                    dt.Columns.Add("Production Date");
                    dt.Columns.Add("Expired period");
                    dt.Columns.Add("Imported Quantity");
                    dt.Columns.Add("Exported Quantity");
                    dt.Columns.Add("Transfared In Quantity");
                    dt.Columns.Add("Transfared Out Quantity");



                    foreach (var row in reportData)
                    {

                        dt.Rows.Add(
                            row.Code,
                            row.Name,
                            row.Unit,
                            row.Production_Date,
                            row.Expired_period,
                            row.ImportedQuantity,
                            row.ExportedQuantity,
                            row.ConvertedInQuantity,
                            row.ConvertedOutQuantity
                            );
                    }
                    dataGridView1.DataSource = dt;
                }
                catch (Exception)
                {

                    MessageBox.Show("Something Wrong Happend Please Try Again");
                }
            }
            else MessageBox.Show("Please Select a Warehouse ..");
        }

        private void CategoryTransfareReportForm_Load(object sender, EventArgs e)
        {
            warehouses.Items.Clear();
            warehouses.Text = "--Select--";
            warehouses.SelectedItem = null;
            var warehousesData = entities.Warehouses;
            foreach (var row in warehousesData)
            {
                warehouses.Items.Add(row.Id.ToString() + "-" + row.Name);
            }
        }

        private void warehouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
