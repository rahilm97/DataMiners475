namespace DealerData_DB
{
    partial class AddCars
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
            this.vinEntry = new System.Windows.Forms.TextBox();
            this.mileageEntry = new System.Windows.Forms.TextBox();
            this.trimEntry = new System.Windows.Forms.TextBox();
            this.colorEntry = new System.Windows.Forms.TextBox();
            this.dealerEntry = new System.Windows.Forms.TextBox();
            this.modelEntry = new System.Windows.Forms.TextBox();
            this.customerEntry = new System.Windows.Forms.TextBox();
            this.confirmAddCar = new System.Windows.Forms.Button();
            this.statusEntry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newCarData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.newCarData)).BeginInit();
            this.SuspendLayout();
            // 
            // vinEntry
            // 
            this.vinEntry.Location = new System.Drawing.Point(60, 32);
            this.vinEntry.Name = "vinEntry";
            this.vinEntry.Size = new System.Drawing.Size(100, 20);
            this.vinEntry.TabIndex = 1;
            // 
            // mileageEntry
            // 
            this.mileageEntry.Location = new System.Drawing.Point(321, 32);
            this.mileageEntry.Name = "mileageEntry";
            this.mileageEntry.Size = new System.Drawing.Size(100, 20);
            this.mileageEntry.TabIndex = 2;
            // 
            // trimEntry
            // 
            this.trimEntry.Location = new System.Drawing.Point(60, 80);
            this.trimEntry.Name = "trimEntry";
            this.trimEntry.Size = new System.Drawing.Size(100, 20);
            this.trimEntry.TabIndex = 4;
            // 
            // colorEntry
            // 
            this.colorEntry.Location = new System.Drawing.Point(446, 32);
            this.colorEntry.Name = "colorEntry";
            this.colorEntry.Size = new System.Drawing.Size(100, 20);
            this.colorEntry.TabIndex = 5;
            // 
            // dealerEntry
            // 
            this.dealerEntry.Location = new System.Drawing.Point(180, 80);
            this.dealerEntry.Name = "dealerEntry";
            this.dealerEntry.Size = new System.Drawing.Size(100, 20);
            this.dealerEntry.TabIndex = 6;
            // 
            // modelEntry
            // 
            this.modelEntry.Location = new System.Drawing.Point(446, 80);
            this.modelEntry.Name = "modelEntry";
            this.modelEntry.Size = new System.Drawing.Size(100, 20);
            this.modelEntry.TabIndex = 7;
            // 
            // customerEntry
            // 
            this.customerEntry.Location = new System.Drawing.Point(321, 80);
            this.customerEntry.Name = "customerEntry";
            this.customerEntry.Size = new System.Drawing.Size(100, 20);
            this.customerEntry.TabIndex = 8;
            // 
            // confirmAddCar
            // 
            this.confirmAddCar.Location = new System.Drawing.Point(229, 135);
            this.confirmAddCar.Name = "confirmAddCar";
            this.confirmAddCar.Size = new System.Drawing.Size(142, 44);
            this.confirmAddCar.TabIndex = 9;
            this.confirmAddCar.Text = "Add New Car";
            this.confirmAddCar.UseVisualStyleBackColor = true;
            this.confirmAddCar.Click += new System.EventHandler(this.confirmAddCar_Click);
            // 
            // statusEntry
            // 
            this.statusEntry.FormattingEnabled = true;
            this.statusEntry.Items.AddRange(new object[] {
            "Used",
            "New"});
            this.statusEntry.Location = new System.Drawing.Point(180, 32);
            this.statusEntry.Name = "statusEntry";
            this.statusEntry.Size = new System.Drawing.Size(121, 21);
            this.statusEntry.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mileage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Trim Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dealership Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Customer Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Model Id";
            // 
            // newCarData
            // 
            this.newCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newCarData.Location = new System.Drawing.Point(32, 208);
            this.newCarData.Name = "newCarData";
            this.newCarData.Size = new System.Drawing.Size(541, 169);
            this.newCarData.TabIndex = 19;
            // 
            // AddCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 402);
            this.Controls.Add(this.newCarData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusEntry);
            this.Controls.Add(this.confirmAddCar);
            this.Controls.Add(this.customerEntry);
            this.Controls.Add(this.modelEntry);
            this.Controls.Add(this.dealerEntry);
            this.Controls.Add(this.colorEntry);
            this.Controls.Add(this.trimEntry);
            this.Controls.Add(this.mileageEntry);
            this.Controls.Add(this.vinEntry);
            this.Name = "AddCars";
            this.Text = "AddCars";
            this.Load += new System.EventHandler(this.AddCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newCarData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox vinEntry;
        private System.Windows.Forms.TextBox mileageEntry;
        private System.Windows.Forms.TextBox trimEntry;
        private System.Windows.Forms.TextBox colorEntry;
        private System.Windows.Forms.TextBox dealerEntry;
        private System.Windows.Forms.TextBox modelEntry;
        private System.Windows.Forms.TextBox customerEntry;
        private System.Windows.Forms.Button confirmAddCar;
        private System.Windows.Forms.ComboBox statusEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView newCarData;
    }
}