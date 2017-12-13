namespace DealerData_DB
{
    partial class CarSearch
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
            this.vinLabel = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchConfirm = new System.Windows.Forms.Button();
            this.vinButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.modelButton = new System.Windows.Forms.RadioButton();
            this.priceButton = new System.Windows.Forms.RadioButton();
            this.modelLabel = new System.Windows.Forms.Label();
            this.searchField2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchField3 = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.searchCarData = new System.Windows.Forms.DataGridView();
            this.featureButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchCarData)).BeginInit();
            this.SuspendLayout();
            // 
            // vinLabel
            // 
            this.vinLabel.AutoSize = true;
            this.vinLabel.Location = new System.Drawing.Point(347, 60);
            this.vinLabel.Name = "vinLabel";
            this.vinLabel.Size = new System.Drawing.Size(65, 13);
            this.vinLabel.TabIndex = 0;
            this.vinLabel.Text = "VIN Number";
            this.vinLabel.Visible = false;
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(418, 57);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(134, 20);
            this.searchField.TabIndex = 1;
            this.searchField.Visible = false;
            // 
            // searchConfirm
            // 
            this.searchConfirm.Location = new System.Drawing.Point(603, 91);
            this.searchConfirm.Name = "searchConfirm";
            this.searchConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchConfirm.Size = new System.Drawing.Size(75, 23);
            this.searchConfirm.TabIndex = 3;
            this.searchConfirm.Text = "Search";
            this.searchConfirm.UseVisualStyleBackColor = true;
            this.searchConfirm.Click += new System.EventHandler(this.searchConfirm_Click);
            // 
            // vinButton
            // 
            this.vinButton.AutoSize = true;
            this.vinButton.Location = new System.Drawing.Point(110, 56);
            this.vinButton.Name = "vinButton";
            this.vinButton.Size = new System.Drawing.Size(83, 17);
            this.vinButton.TabIndex = 4;
            this.vinButton.TabStop = true;
            this.vinButton.Text = "VIN Number";
            this.vinButton.UseVisualStyleBackColor = true;
            this.vinButton.CheckedChanged += new System.EventHandler(this.vinButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Type";
            // 
            // modelButton
            // 
            this.modelButton.AutoSize = true;
            this.modelButton.Location = new System.Drawing.Point(110, 93);
            this.modelButton.Name = "modelButton";
            this.modelButton.Size = new System.Drawing.Size(105, 17);
            this.modelButton.TabIndex = 6;
            this.modelButton.TabStop = true;
            this.modelButton.Text = "Make and Model";
            this.modelButton.UseVisualStyleBackColor = true;
            this.modelButton.CheckedChanged += new System.EventHandler(this.modelButton_CheckedChanged);
            // 
            // priceButton
            // 
            this.priceButton.AutoSize = true;
            this.priceButton.Location = new System.Drawing.Point(110, 131);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(96, 17);
            this.priceButton.TabIndex = 7;
            this.priceButton.TabStop = true;
            this.priceButton.Text = "Maximum Price";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.CheckedChanged += new System.EventHandler(this.priceButton_CheckedChanged);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(376, 60);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 8;
            this.modelLabel.Text = "Model";
            this.modelLabel.Visible = false;
            // 
            // searchField2
            // 
            this.searchField2.Location = new System.Drawing.Point(418, 93);
            this.searchField2.Name = "searchField2";
            this.searchField2.Size = new System.Drawing.Size(134, 20);
            this.searchField2.TabIndex = 9;
            this.searchField2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search Fields";
            // 
            // SearchField3
            // 
            this.SearchField3.Location = new System.Drawing.Point(418, 130);
            this.SearchField3.Name = "SearchField3";
            this.SearchField3.Size = new System.Drawing.Size(134, 20);
            this.SearchField3.TabIndex = 12;
            this.SearchField3.Visible = false;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(342, 96);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(70, 13);
            this.makeLabel.TabIndex = 11;
            this.makeLabel.Text = "Manufacturer";
            this.makeLabel.Visible = false;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(383, 133);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "Year";
            this.yearLabel.Visible = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(357, 60);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(55, 13);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Price Limit";
            this.priceLabel.Visible = false;
            // 
            // searchCarData
            // 
            this.searchCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchCarData.Location = new System.Drawing.Point(40, 270);
            this.searchCarData.Name = "searchCarData";
            this.searchCarData.Size = new System.Drawing.Size(700, 159);
            this.searchCarData.TabIndex = 16;
            // 
            // featureButton
            // 
            this.featureButton.AutoSize = true;
            this.featureButton.Location = new System.Drawing.Point(110, 169);
            this.featureButton.Name = "featureButton";
            this.featureButton.Size = new System.Drawing.Size(66, 17);
            this.featureButton.TabIndex = 17;
            this.featureButton.TabStop = true;
            this.featureButton.Text = "Features";
            this.featureButton.UseVisualStyleBackColor = true;
            this.featureButton.CheckedChanged += new System.EventHandler(this.vinButton_CheckedChanged);
            // 
            // CarSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.featureButton);
            this.Controls.Add(this.searchCarData);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.SearchField3);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchField2);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.modelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vinButton);
            this.Controls.Add(this.searchConfirm);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.vinLabel);
            this.Name = "CarSearch";
            this.Text = "Dealer Data - Search Cars";
            ((System.ComponentModel.ISupportInitialize)(this.searchCarData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vinLabel;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button searchConfirm;
        private System.Windows.Forms.RadioButton vinButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton modelButton;
        private System.Windows.Forms.RadioButton priceButton;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox searchField2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchField3;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.DataGridView searchCarData;
        private System.Windows.Forms.RadioButton featureButton;
    }
}