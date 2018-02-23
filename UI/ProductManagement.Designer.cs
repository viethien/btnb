namespace UI
{
    partial class ProductManagement
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
            this.txtQPU = new System.Windows.Forms.TextBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.numROL = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numUIS = new System.Windows.Forms.NumericUpDown();
            this.numUOO = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtList = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNewCate = new System.Windows.Forms.Button();
            this.btnNewSup = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gbDiscontinued = new System.Windows.Forms.GroupBox();
            this.rdContinued = new System.Windows.Forms.RadioButton();
            this.rdDiscontinued = new System.Windows.Forms.RadioButton();
            this.epPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epQpu = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSearch = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUOO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            this.gbDiscontinued.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epQpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQPU
            // 
            this.txtQPU.Location = new System.Drawing.Point(125, 77);
            this.txtQPU.Name = "txtQPU";
            this.txtQPU.Size = new System.Drawing.Size(143, 20);
            this.txtQPU.TabIndex = 0;
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(125, 130);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(143, 21);
            this.cbSupplier.TabIndex = 1;
            // 
            // cbCate
            // 
            this.cbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(125, 103);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(143, 21);
            this.cbCate.TabIndex = 2;
            // 
            // numROL
            // 
            this.numROL.Location = new System.Drawing.Point(440, 104);
            this.numROL.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numROL.Name = "numROL";
            this.numROL.Size = new System.Drawing.Size(120, 20);
            this.numROL.TabIndex = 3;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(440, 16);
            this.numPrice.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 4;
            // 
            // numUIS
            // 
            this.numUIS.Location = new System.Drawing.Point(440, 47);
            this.numUIS.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numUIS.Name = "numUIS";
            this.numUIS.Size = new System.Drawing.Size(120, 20);
            this.numUIS.TabIndex = 5;
            // 
            // numUOO
            // 
            this.numUOO.Location = new System.Drawing.Point(440, 75);
            this.numUOO.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numUOO.Name = "numUOO";
            this.numUOO.Size = new System.Drawing.Size(120, 20);
            this.numUOO.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(599, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantity Per Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Units In Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Units On Order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Reorder Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Discontinued";
            // 
            // dtList
            // 
            this.dtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clName,
            this.clCate,
            this.clSupplier,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtList.Location = new System.Drawing.Point(0, 228);
            this.dtList.Name = "dtList";
            this.dtList.Size = new System.Drawing.Size(866, 370);
            this.dtList.TabIndex = 20;
            this.dtList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtList_CellClick);
            // 
            // clId
            // 
            this.clId.HeaderText = "Product ID";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clId.Width = 50;
            // 
            // clName
            // 
            this.clName.HeaderText = "Product Name";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clCate
            // 
            this.clCate.HeaderText = "Category";
            this.clCate.Name = "clCate";
            this.clCate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clSupplier
            // 
            this.clSupplier.HeaderText = "Supplier";
            this.clSupplier.Name = "clSupplier";
            this.clSupplier.ReadOnly = true;
            this.clSupplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantity Per Unit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Units In Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Units On Order";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Reorder Level";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Discontinued";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Product ID";
            // 
            // btnNewCate
            // 
            this.btnNewCate.Location = new System.Drawing.Point(274, 102);
            this.btnNewCate.Name = "btnNewCate";
            this.btnNewCate.Size = new System.Drawing.Size(39, 23);
            this.btnNewCate.TabIndex = 22;
            this.btnNewCate.Text = "New";
            this.btnNewCate.UseVisualStyleBackColor = true;
            this.btnNewCate.Click += new System.EventHandler(this.btnNewCate_Click);
            // 
            // btnNewSup
            // 
            this.btnNewSup.Location = new System.Drawing.Point(274, 130);
            this.btnNewSup.Name = "btnNewSup";
            this.btnNewSup.Size = new System.Drawing.Size(39, 23);
            this.btnNewSup.TabIndex = 23;
            this.btnNewSup.Text = "New";
            this.btnNewSup.UseVisualStyleBackColor = true;
            this.btnNewSup.Click += new System.EventHandler(this.btnNewSup_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(611, 67);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 24;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gbDiscontinued
            // 
            this.gbDiscontinued.Controls.Add(this.rdContinued);
            this.gbDiscontinued.Controls.Add(this.rdDiscontinued);
            this.gbDiscontinued.Location = new System.Drawing.Point(440, 133);
            this.gbDiscontinued.Name = "gbDiscontinued";
            this.gbDiscontinued.Size = new System.Drawing.Size(96, 54);
            this.gbDiscontinued.TabIndex = 25;
            this.gbDiscontinued.TabStop = false;
            // 
            // rdContinued
            // 
            this.rdContinued.AutoSize = true;
            this.rdContinued.Location = new System.Drawing.Point(6, 30);
            this.rdContinued.Name = "rdContinued";
            this.rdContinued.Size = new System.Drawing.Size(73, 17);
            this.rdContinued.TabIndex = 1;
            this.rdContinued.TabStop = true;
            this.rdContinued.Text = "Continued";
            this.rdContinued.UseVisualStyleBackColor = true;
            // 
            // rdDiscontinued
            // 
            this.rdDiscontinued.AutoSize = true;
            this.rdDiscontinued.Location = new System.Drawing.Point(6, 7);
            this.rdDiscontinued.Name = "rdDiscontinued";
            this.rdDiscontinued.Size = new System.Drawing.Size(87, 17);
            this.rdDiscontinued.TabIndex = 0;
            this.rdDiscontinued.TabStop = true;
            this.rdDiscontinued.Text = "Discontinued";
            this.rdDiscontinued.UseVisualStyleBackColor = true;
            // 
            // epPrice
            // 
            this.epPrice.ContainerControl = this;
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epQpu
            // 
            this.epQpu.ContainerControl = this;
            // 
            // epSearch
            // 
            this.epSearch.ContainerControl = this;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(125, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(744, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(611, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(781, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 599);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.gbDiscontinued);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnNewSup);
            this.Controls.Add(this.btnNewCate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numUOO);
            this.Controls.Add(this.numUIS);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numROL);
            this.Controls.Add(this.cbCate);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.txtQPU);
            this.Name = "ProductManagement";
            this.Text = "Product";
            this.Activated += new System.EventHandler(this.ProductManagement_Activated);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUOO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            this.gbDiscontinued.ResumeLayout(false);
            this.gbDiscontinued.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epQpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQPU;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.NumericUpDown numROL;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numUIS;
        private System.Windows.Forms.NumericUpDown numUOO;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNewCate;
        private System.Windows.Forms.Button btnNewSup;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox gbDiscontinued;
        private System.Windows.Forms.RadioButton rdContinued;
        private System.Windows.Forms.RadioButton rdDiscontinued;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.ErrorProvider epPrice;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epQpu;
        private System.Windows.Forms.ErrorProvider epSearch;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
    }
}