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
    public partial class ExpireCategoryReportForm : Form
    {
        Entities entities = new Entities();
        public ExpireCategoryReportForm()
        {
            InitializeComponent();
        }

        private void period_Click(object sender, EventArgs e)
        {

        }

        private void showReportBtn_Click(object sender, EventArgs e)
        {

            if (reportPeriod.Text != null)
            {
                try
                {
                    int period;
                    bool parseCheck = int.TryParse(reportPeriod.Text.Split('-')[0].Trim().ToString(), out period);

                    if (parseCheck)
                    {
                        var reportData = entities.catagoriesExpiredPeroid(period);
                        DataTable dt = new DataTable();

                        dt.Columns.Add("Code");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Unit");
                        dt.Columns.Add("Production Date");
                        dt.Columns.Add("Expired period");
                        dt.Columns.Add("Warehouse");
                        dt.Columns.Add("Expired After Months");
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
                                row.expiredAfterMonths,
                                row.Quantity
                                );
                        }
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter The Period in Numbers !");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Something Wrong Happend Please Try Again");

                }
            }
            else MessageBox.Show("Please Select a Warehouse ..");
        }
    }
}
