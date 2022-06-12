namespace EF_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.warhouseBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Olive;
            this.sidebar.Controls.Add(this.reportsBtn);
            this.sidebar.Controls.Add(this.transferBtn);
            this.sidebar.Controls.Add(this.exportBtn);
            this.sidebar.Controls.Add(this.importBtn);
            this.sidebar.Controls.Add(this.customerBtn);
            this.sidebar.Controls.Add(this.supplierBtn);
            this.sidebar.Controls.Add(this.warhouseBtn);
            this.sidebar.Controls.Add(this.categoryBtn);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(250, 643);
            this.sidebar.TabIndex = 0;
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.Olive;
            this.reportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportsBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.reportsBtn.Location = new System.Drawing.Point(0, 496);
            this.reportsBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(250, 55);
            this.reportsBtn.TabIndex = 9;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseMnemonic = false;
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // transferBtn
            // 
            this.transferBtn.BackColor = System.Drawing.Color.Olive;
            this.transferBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.transferBtn.FlatAppearance.BorderSize = 0;
            this.transferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transferBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.transferBtn.Location = new System.Drawing.Point(0, 441);
            this.transferBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(250, 55);
            this.transferBtn.TabIndex = 8;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = false;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.Olive;
            this.exportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exportBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exportBtn.Location = new System.Drawing.Point(0, 386);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(250, 55);
            this.exportBtn.TabIndex = 7;
            this.exportBtn.Text = "Export ";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.Olive;
            this.importBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.importBtn.FlatAppearance.BorderSize = 0;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.importBtn.Location = new System.Drawing.Point(0, 331);
            this.importBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(250, 55);
            this.importBtn.TabIndex = 6;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.Olive;
            this.customerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.customerBtn.Location = new System.Drawing.Point(0, 276);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(250, 55);
            this.customerBtn.TabIndex = 5;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.BackColor = System.Drawing.Color.Olive;
            this.supplierBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplierBtn.FlatAppearance.BorderSize = 0;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.supplierBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.supplierBtn.Location = new System.Drawing.Point(0, 221);
            this.supplierBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(250, 55);
            this.supplierBtn.TabIndex = 4;
            this.supplierBtn.Text = "Supplier";
            this.supplierBtn.UseVisualStyleBackColor = false;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // warhouseBtn
            // 
            this.warhouseBtn.BackColor = System.Drawing.Color.Olive;
            this.warhouseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.warhouseBtn.FlatAppearance.BorderSize = 0;
            this.warhouseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warhouseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warhouseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.warhouseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warhouseBtn.Location = new System.Drawing.Point(0, 166);
            this.warhouseBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.warhouseBtn.Name = "warhouseBtn";
            this.warhouseBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.warhouseBtn.Size = new System.Drawing.Size(250, 55);
            this.warhouseBtn.TabIndex = 3;
            this.warhouseBtn.Text = "Warehouse";
            this.warhouseBtn.UseMnemonic = false;
            this.warhouseBtn.UseVisualStyleBackColor = false;
            this.warhouseBtn.Click += new System.EventHandler(this.warhouseBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackColor = System.Drawing.Color.Olive;
            this.categoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryBtn.FlatAppearance.BorderSize = 0;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryBtn.Location = new System.Drawing.Point(0, 111);
            this.categoryBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.categoryBtn.Size = new System.Drawing.Size(250, 55);
            this.categoryBtn.TabIndex = 2;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = false;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 80);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(468, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(108, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Home";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(250, 80);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1154, 563);
            this.containerPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.BackgroundImage = global::EF_Project.Properties.Resources.cart3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 111);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 643);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button warhouseBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

