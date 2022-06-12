using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class Form1 : Form
    {
        private Button selectedButton;
        private Form openedForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonActiveColor(object btnSender ) {
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
            foreach (Control panelButton in sidebar.Controls)
            {
                panelButton.BackColor = Color.FromKnownColor(KnownColor.Olive);
                panelButton.ForeColor = Color.White;
            }
        }

        private void ChildForm(Form childForm , object btnSender)
        {
            if (openedForm != null)
            {
                openedForm.Close();
            }
            ButtonActiveColor(btnSender);
            openedForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;   
            childForm.TopLevel = false; 
            this.containerPanel.Controls.Add(childForm);
            this.containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            title.Text = childForm.Text;
        }
        private void categoryBtn_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.CategoryForm(),sender);
        }

        private void warhouseBtn_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.WarehouseForm(),sender);
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.SupplierForm(),sender);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.CustomerForm(), sender);
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.ImportForm(),sender);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.ExportForm(),sender);
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.TransfareForm(),sender);
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            ChildForm(new Forms.ReportsForm(),sender);
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
