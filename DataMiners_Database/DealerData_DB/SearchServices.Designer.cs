namespace DealerData_DB
{
    partial class SearchServices
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
            this.labelVIN = new System.Windows.Forms.Label();
            this.textboxVIN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelFName = new System.Windows.Forms.Label();
            this.textboxFName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textboxLName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.checkBoxVIN = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVIN
            // 
            this.labelVIN.AutoSize = true;
            this.labelVIN.Location = new System.Drawing.Point(13, 33);
            this.labelVIN.Name = "labelVIN";
            this.labelVIN.Size = new System.Drawing.Size(65, 13);
            this.labelVIN.TabIndex = 1;
            this.labelVIN.Text = "VIN Number";
            // 
            // textboxVIN
            // 
            this.textboxVIN.Location = new System.Drawing.Point(84, 30);
            this.textboxVIN.Name = "textboxVIN";
            this.textboxVIN.Size = new System.Drawing.Size(153, 20);
            this.textboxVIN.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(316, 33);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(57, 13);
            this.labelFName.TabIndex = 4;
            this.labelFName.Text = "First Name";
            // 
            // textboxFName
            // 
            this.textboxFName.Location = new System.Drawing.Point(382, 29);
            this.textboxFName.Name = "textboxFName";
            this.textboxFName.Size = new System.Drawing.Size(153, 20);
            this.textboxFName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 57);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textboxLName
            // 
            this.textboxLName.Location = new System.Drawing.Point(382, 55);
            this.textboxLName.Name = "textboxLName";
            this.textboxLName.Size = new System.Drawing.Size(153, 20);
            this.textboxLName.TabIndex = 7;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(316, 59);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(58, 13);
            this.labelLName.TabIndex = 8;
            this.labelLName.Text = "Last Name";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(628, 30);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(216, 20);
            this.dateFrom.TabIndex = 9;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(592, 33);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "From";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(628, 55);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(216, 20);
            this.dateTo.TabIndex = 11;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(602, 58);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 12;
            this.labelTo.Text = "To";
            // 
            // checkBoxVIN
            // 
            this.checkBoxVIN.AutoSize = true;
            this.checkBoxVIN.Location = new System.Drawing.Point(16, 7);
            this.checkBoxVIN.Name = "checkBoxVIN";
            this.checkBoxVIN.Size = new System.Drawing.Size(95, 17);
            this.checkBoxVIN.TabIndex = 14;
            this.checkBoxVIN.Text = "Search by VIN";
            this.checkBoxVIN.UseVisualStyleBackColor = true;
            this.checkBoxVIN.CheckedChanged += new System.EventHandler(this.checkBoxVIN_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(319, 6);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(108, 17);
            this.checkBoxName.TabIndex = 15;
            this.checkBoxName.Text = "Search by Owner";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(628, 6);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(100, 17);
            this.checkBoxDate.TabIndex = 16;
            this.checkBoxDate.Text = "Search by Date";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // SearchServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 391);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxVIN);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.textboxLName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textboxFName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textboxVIN);
            this.Controls.Add(this.labelVIN);
            this.Name = "SearchServices";
            this.Text = "SearchServices";
            this.Load += new System.EventHandler(this.SearchServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVIN;
        private System.Windows.Forms.TextBox textboxVIN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textboxFName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textboxLName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.CheckBox checkBoxVIN;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxDate;
    }
}