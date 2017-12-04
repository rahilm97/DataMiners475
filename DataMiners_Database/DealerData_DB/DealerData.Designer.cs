namespace DealerData_DB
{
    partial class DealerData
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
            this.searchCars = new System.Windows.Forms.Button();
            this.addCars = new System.Windows.Forms.Button();
            this.searchCustomers = new System.Windows.Forms.Button();
            this.addSale = new System.Windows.Forms.Button();
            this.searchService = new System.Windows.Forms.Button();
            this.addService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchCars
            // 
            this.searchCars.Location = new System.Drawing.Point(59, 12);
            this.searchCars.Name = "searchCars";
            this.searchCars.Size = new System.Drawing.Size(175, 27);
            this.searchCars.TabIndex = 0;
            this.searchCars.Text = "Search for cars";
            this.searchCars.UseVisualStyleBackColor = true;
            this.searchCars.Click += new System.EventHandler(this.searchCars_Click);
            // 
            // addCars
            // 
            this.addCars.Location = new System.Drawing.Point(59, 45);
            this.addCars.Name = "addCars";
            this.addCars.Size = new System.Drawing.Size(175, 27);
            this.addCars.TabIndex = 1;
            this.addCars.Text = "Add new cars";
            this.addCars.UseVisualStyleBackColor = true;
            this.addCars.Click += new System.EventHandler(this.addCars_Click);
            // 
            // searchCustomers
            // 
            this.searchCustomers.Location = new System.Drawing.Point(59, 78);
            this.searchCustomers.Name = "searchCustomers";
            this.searchCustomers.Size = new System.Drawing.Size(175, 27);
            this.searchCustomers.TabIndex = 2;
            this.searchCustomers.Text = "Search for customers";
            this.searchCustomers.UseVisualStyleBackColor = true;
            this.searchCustomers.Click += new System.EventHandler(this.searchCustomers_Click);
            // 
            // addSale
            // 
            this.addSale.Location = new System.Drawing.Point(59, 112);
            this.addSale.Name = "addSale";
            this.addSale.Size = new System.Drawing.Size(175, 23);
            this.addSale.TabIndex = 3;
            this.addSale.Text = "Add new sale";
            this.addSale.UseVisualStyleBackColor = true;
            this.addSale.Click += new System.EventHandler(this.addSale_Click);
            // 
            // searchService
            // 
            this.searchService.Location = new System.Drawing.Point(61, 141);
            this.searchService.Name = "searchService";
            this.searchService.Size = new System.Drawing.Size(173, 22);
            this.searchService.TabIndex = 4;
            this.searchService.Text = "Search service records";
            this.searchService.UseVisualStyleBackColor = true;
            this.searchService.Click += new System.EventHandler(this.searchService_Click);
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(59, 169);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(171, 23);
            this.addService.TabIndex = 5;
            this.addService.Text = "Add new service record";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // DealerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 310);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.searchService);
            this.Controls.Add(this.addSale);
            this.Controls.Add(this.searchCustomers);
            this.Controls.Add(this.addCars);
            this.Controls.Add(this.searchCars);
            this.Name = "DealerData";
            this.Text = "Dealer Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchCars;
        private System.Windows.Forms.Button addCars;
        private System.Windows.Forms.Button searchCustomers;
        private System.Windows.Forms.Button addSale;
        private System.Windows.Forms.Button searchService;
        private System.Windows.Forms.Button addService;
    }
}

