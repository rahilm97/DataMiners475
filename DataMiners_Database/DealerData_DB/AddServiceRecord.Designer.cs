namespace DealerData_DB
{
    partial class AddServiceRecord
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
            this.viewRecords = new System.Windows.Forms.DataGridView();
            this.addService = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.customerId = new System.Windows.Forms.TextBox();
            this.vinNum = new System.Windows.Forms.TextBox();
            this.serviceId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.viewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // viewRecords
            // 
            this.viewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewRecords.Location = new System.Drawing.Point(386, 34);
            this.viewRecords.Name = "viewRecords";
            this.viewRecords.Size = new System.Drawing.Size(743, 188);
            this.viewRecords.TabIndex = 27;
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(131, 190);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(142, 48);
            this.addService.TabIndex = 26;
            this.addService.Text = "Add new service record";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "VIN Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Service ID";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(12, 152);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(169, 20);
            this.type.TabIndex = 18;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(227, 90);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(135, 20);
            this.cost.TabIndex = 17;
            // 
            // customerId
            // 
            this.customerId.Location = new System.Drawing.Point(12, 90);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(170, 20);
            this.customerId.TabIndex = 16;
            // 
            // vinNum
            // 
            this.vinNum.Location = new System.Drawing.Point(211, 34);
            this.vinNum.Name = "vinNum";
            this.vinNum.Size = new System.Drawing.Size(151, 20);
            this.vinNum.TabIndex = 15;
            // 
            // serviceId
            // 
            this.serviceId.Location = new System.Drawing.Point(12, 34);
            this.serviceId.Name = "serviceId";
            this.serviceId.Size = new System.Drawing.Size(171, 20);
            this.serviceId.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "$";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(211, 152);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(151, 20);
            this.date.TabIndex = 29;
            // 
            // AddServiceRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 271);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.viewRecords);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.vinNum);
            this.Controls.Add(this.serviceId);
            this.Name = "AddServiceRecord";
            this.Text = "AddServiceRecord";
            this.Load += new System.EventHandler(this.AddServiceRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewRecords;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.TextBox vinNum;
        private System.Windows.Forms.TextBox serviceId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
    }
}