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
    public partial class ReportsForm : Form
    {
        private Button selectedButton;
        private Form openedReport;
        public ReportsForm()
        {
            InitializeComponent();
        }
        private void ReportButtonActive(object btnSender)
        {
            if (btnSender != null)
            {
                if ((Button)btnSender != selectedButton)
                {
                    DisablePrevButton();
                    selectedButton = (Button)btnSender;
                    selectedButton.BackColor = Color.FromKnownColor(KnownColor.LightYellow);
                    selectedButton.ForeColor = Color.Black;

                }
            }
        }
        private void DisablePrevButton()
        {
            foreach (Control panelButton in reportButtonsPanel.Controls)
            {
                panelButton.BackColor = Color.FromKnownColor(KnownColor.Olive);
                panelButton.ForeColor = Color.White;
            }
        }
        private void ChildForm(Form childForm, object btnSender)
        {
            if (openedReport != null)
            {
                openedReport.Close();
            }
            ReportButtonActive(btnSender);
            openedReport = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            this.reportsPanel.Controls.Add(childForm);
            this.reportsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void code_Click(object sender, EventArgs e)
        {

        }

        private void reportsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryReport_Click(object sender, EventArgs e)
        {
            /* report about catogory with catogory code*/
            /* report about catogory with catogory code and date*/
            ChildForm(new Forms.CategoryReportForm(), sender);
        }

        private void warehouseReport_Click(object sender, EventArgs e)
        {
            /* to select categories from warehouse by warehouse id  */
            /* report about warehouse in peroid  */
            ChildForm(new Forms.WarehouseReportForm(), sender);
        }

        private void catTransfareReport_Click(object sender, EventArgs e)
        {
            /* report about catogory movement with warehouse id*/
            ChildForm(new Forms.CategoryTransfareReportForm(), sender);
        }

      

        private void catExpireReport_Click(object sender, EventArgs e)
        {
            /* report about catogory expire date with period  */
            ChildForm(new Forms.ExpireCategoryReportForm(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* report about catogory stord peroid equal or more than  */
            ChildForm(new Forms.CategoryAfterPeriodForm(), sender);
        }
    }
}
