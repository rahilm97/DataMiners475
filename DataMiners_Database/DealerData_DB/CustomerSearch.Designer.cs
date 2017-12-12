namespace DealerData_DB
{
    partial class CustomerSearch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.custID = new System.Windows.Forms.TextBox();
            this.btnCustID = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataminersDealerDataDataSet = new DealerData_DB.dataminersDealerDataDataSet();
            this.cUSTOMERTableAdapter = new DealerData_DB.dataminersDealerDataDataSetTableAdapters.CUSTOMERTableAdapter();
            this.dataminersDealerDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.custFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custLname = new System.Windows.Forms.TextBox();
            this.custNameSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataminersDealerDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataminersDealerDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // custID
            // 
            this.custID.Location = new System.Drawing.Point(84, 15);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(145, 20);
            this.custID.TabIndex = 1;
            // 
            // btnCustID
            // 
            this.btnCustID.Location = new System.Drawing.Point(257, 9);
            this.btnCustID.Name = "btnCustID";
            this.btnCustID.Size = new System.Drawing.Size(85, 30);
            this.btnCustID.TabIndex = 2;
            this.btnCustID.Text = "Search by ID";
            this.btnCustID.UseVisualStyleBackColor = true;
            this.btnCustID.Click += new System.EventHandler(this.btnCustID_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(310, 127);
            this.dataGridView1.TabIndex = 3;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dataminersDealerDataDataSet;
            // 
            // dataminersDealerDataDataSet
            // 
            this.dataminersDealerDataDataSet.DataSetName = "dataminersDealerDataDataSet";
            this.dataminersDealerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // dataminersDealerDataDataSetBindingSource
            // 
            this.dataminersDealerDataDataSetBindingSource.DataSource = this.dataminersDealerDataDataSet;
            this.dataminersDealerDataDataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // custFname
            // 
            this.custFname.Location = new System.Drawing.Point(84, 47);
            this.custFname.Name = "custFname";
            this.custFname.Size = new System.Drawing.Size(143, 20);
            this.custFname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // custLname
            // 
            this.custLname.Location = new System.Drawing.Point(85, 77);
            this.custLname.Name = "custLname";
            this.custLname.Size = new System.Drawing.Size(143, 20);
            this.custLname.TabIndex = 7;
            // 
            // custNameSearch
            // 
            this.custNameSearch.Location = new System.Drawing.Point(254, 68);
            this.custNameSearch.Name = "custNameSearch";
            this.custNameSearch.Size = new System.Drawing.Size(88, 37);
            this.custNameSearch.TabIndex = 8;
            this.custNameSearch.Text = "Search by name";
            this.custNameSearch.UseVisualStyleBackColor = true;
            this.custNameSearch.Click += new System.EventHandler(this.custNameSearch_Click);
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 335);
            this.Controls.Add(this.custNameSearch);
            this.Controls.Add(this.custLname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.custFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCustID);
            this.Controls.Add(this.custID);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSearch";
            this.Text = "CustomerSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataminersDealerDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataminersDealerDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.Button btnCustID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dataminersDealerDataDataSet dataminersDealerDataDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private dataminersDealerDataDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.BindingSource dataminersDealerDataDataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custLname;
        private System.Windows.Forms.Button custNameSearch;
    }
}