namespace DealerData_DB
{
    partial class AddSale
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
            this.saleID = new System.Windows.Forms.TextBox();
            this.vinNum = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.dealershipID = new System.Windows.Forms.TextBox();
            this.custIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addSaleRecord = new System.Windows.Forms.Button();
            this.viewNewSale = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewNewSale)).BeginInit();
            this.SuspendLayout();
            // 
            // saleID
            // 
            this.saleID.Location = new System.Drawing.Point(67, 30);
            this.saleID.Name = "saleID";
            this.saleID.Size = new System.Drawing.Size(171, 20);
            this.saleID.TabIndex = 0;
            // 
            // vinNum
            // 
            this.vinNum.Location = new System.Drawing.Point(266, 30);
            this.vinNum.Name = "vinNum";
            this.vinNum.Size = new System.Drawing.Size(151, 20);
            this.vinNum.TabIndex = 1;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(67, 86);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(170, 20);
            this.price.TabIndex = 2;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(264, 83);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(152, 20);
            this.date.TabIndex = 3;
            // 
            // dealershipID
            // 
            this.dealershipID.Location = new System.Drawing.Point(67, 148);
            this.dealershipID.Name = "dealershipID";
            this.dealershipID.Size = new System.Drawing.Size(169, 20);
            this.dealershipID.TabIndex = 4;
            // 
            // custIDBox
            // 
            this.custIDBox.Location = new System.Drawing.Point(263, 150);
            this.custIDBox.Name = "custIDBox";
            this.custIDBox.Size = new System.Drawing.Size(152, 20);
            this.custIDBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sale id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "VIN Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dealership ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer ID";
            // 
            // addSaleRecord
            // 
            this.addSaleRecord.Location = new System.Drawing.Point(197, 187);
            this.addSaleRecord.Name = "addSaleRecord";
            this.addSaleRecord.Size = new System.Drawing.Size(126, 48);
            this.addSaleRecord.TabIndex = 12;
            this.addSaleRecord.Text = "Add new sale record";
            this.addSaleRecord.UseVisualStyleBackColor = true;
            this.addSaleRecord.Click += new System.EventHandler(this.addSaleRecord_Click);
            // 
            // viewNewSale
            // 
            this.viewNewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewNewSale.Location = new System.Drawing.Point(441, 30);
            this.viewNewSale.Name = "viewNewSale";
            this.viewNewSale.Size = new System.Drawing.Size(250, 188);
            this.viewNewSale.TabIndex = 13;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 324);
            this.Controls.Add(this.viewNewSale);
            this.Controls.Add(this.addSaleRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custIDBox);
            this.Controls.Add(this.dealershipID);
            this.Controls.Add(this.date);
            this.Controls.Add(this.price);
            this.Controls.Add(this.vinNum);
            this.Controls.Add(this.saleID);
            this.Name = "AddSale";
            this.Text = "AddSale";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewNewSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saleID;
        private System.Windows.Forms.TextBox vinNum;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox dealershipID;
        private System.Windows.Forms.TextBox custIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addSaleRecord;
        private System.Windows.Forms.DataGridView viewNewSale;
    }
}