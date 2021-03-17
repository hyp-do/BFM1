namespace C968___BFM1
{
    partial class AddProducts
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
            this.labelAddPRoduct = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelPartsAssosciated = new System.Windows.Forms.Label();
            this.labelPartsAvailable = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvTempParts = new System.Windows.Forms.DataGridView();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.buttonProductAdd = new System.Windows.Forms.Button();
            this.buttonPartAssosciatedDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxProductSearch = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempParts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddPRoduct
            // 
            this.labelAddPRoduct.AutoSize = true;
            this.labelAddPRoduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPRoduct.Location = new System.Drawing.Point(12, 9);
            this.labelAddPRoduct.Name = "labelAddPRoduct";
            this.labelAddPRoduct.Size = new System.Drawing.Size(130, 25);
            this.labelAddPRoduct.TabIndex = 0;
            this.labelAddPRoduct.Text = "Add Product";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(45, 106);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 145);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(14, 184);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 3;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(32, 225);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(36, 268);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 5;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(160, 268);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "Min";
            // 
            // labelPartsAssosciated
            // 
            this.labelPartsAssosciated.AutoSize = true;
            this.labelPartsAssosciated.Location = new System.Drawing.Point(411, 312);
            this.labelPartsAssosciated.Name = "labelPartsAssosciated";
            this.labelPartsAssosciated.Size = new System.Drawing.Size(172, 13);
            this.labelPartsAssosciated.TabIndex = 7;
            this.labelPartsAssosciated.Text = "Parts Assosciated with this Product";
            // 
            // labelPartsAvailable
            // 
            this.labelPartsAvailable.AutoSize = true;
            this.labelPartsAvailable.Location = new System.Drawing.Point(411, 65);
            this.labelPartsAvailable.Name = "labelPartsAvailable";
            this.labelPartsAvailable.Size = new System.Drawing.Size(95, 13);
            this.labelPartsAvailable.TabIndex = 8;
            this.labelPartsAvailable.Text = "All candidate Parts";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(414, 81);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(495, 181);
            this.dgvParts.TabIndex = 9;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            this.dgvParts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            // 
            // dgvTempParts
            // 
            this.dgvTempParts.AllowUserToAddRows = false;
            this.dgvTempParts.AllowUserToDeleteRows = false;
            this.dgvTempParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTempParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempParts.Location = new System.Drawing.Point(414, 328);
            this.dgvTempParts.MultiSelect = false;
            this.dgvTempParts.Name = "dgvTempParts";
            this.dgvTempParts.ReadOnly = true;
            this.dgvTempParts.RowHeadersVisible = false;
            this.dgvTempParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTempParts.Size = new System.Drawing.Size(495, 181);
            this.dgvTempParts.TabIndex = 10;
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Location = new System.Drawing.Point(675, 49);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(60, 23);
            this.buttonProductSearch.TabIndex = 11;
            this.buttonProductSearch.Text = "Search";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // buttonProductAdd
            // 
            this.buttonProductAdd.Location = new System.Drawing.Point(856, 268);
            this.buttonProductAdd.Name = "buttonProductAdd";
            this.buttonProductAdd.Size = new System.Drawing.Size(53, 23);
            this.buttonProductAdd.TabIndex = 12;
            this.buttonProductAdd.Text = "Add";
            this.buttonProductAdd.UseVisualStyleBackColor = true;
            this.buttonProductAdd.Click += new System.EventHandler(this.buttonProductAdd_Click);
            // 
            // buttonPartAssosciatedDelete
            // 
            this.buttonPartAssosciatedDelete.Location = new System.Drawing.Point(856, 515);
            this.buttonPartAssosciatedDelete.Name = "buttonPartAssosciatedDelete";
            this.buttonPartAssosciatedDelete.Size = new System.Drawing.Size(53, 23);
            this.buttonPartAssosciatedDelete.TabIndex = 13;
            this.buttonPartAssosciatedDelete.Text = "Delete";
            this.buttonPartAssosciatedDelete.UseVisualStyleBackColor = true;
            this.buttonPartAssosciatedDelete.Click += new System.EventHandler(this.buttonPartAssosciatedDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(779, 553);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(50, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(856, 553);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(53, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(69, 103);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(147, 20);
            this.textBoxId.TabIndex = 16;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 142);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 20);
            this.textBoxName.TabIndex = 17;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Location = new System.Drawing.Point(69, 181);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(147, 20);
            this.textBoxInventory.TabIndex = 18;
            this.textBoxInventory.TextChanged += new System.EventHandler(this.textBoxInventory_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(69, 222);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(147, 20);
            this.textBoxPrice.TabIndex = 19;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(69, 265);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(73, 20);
            this.textBoxMax.TabIndex = 20;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            // 
            // textBoxProductSearch
            // 
            this.textBoxProductSearch.Location = new System.Drawing.Point(762, 52);
            this.textBoxProductSearch.Name = "textBoxProductSearch";
            this.textBoxProductSearch.Size = new System.Drawing.Size(147, 20);
            this.textBoxProductSearch.TabIndex = 21;
            this.textBoxProductSearch.TextChanged += new System.EventHandler(this.textBoxProductSearch_TextChanged);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(190, 265);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(73, 20);
            this.textBoxMin.TabIndex = 23;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 588);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxProductSearch);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPartAssosciatedDelete);
            this.Controls.Add(this.buttonProductAdd);
            this.Controls.Add(this.buttonProductSearch);
            this.Controls.Add(this.dgvTempParts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.labelPartsAvailable);
            this.Controls.Add(this.labelPartsAssosciated);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelAddPRoduct);
            this.Name = "AddProducts";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPRoduct;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelPartsAssosciated;
        private System.Windows.Forms.Label labelPartsAvailable;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvTempParts;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.Button buttonProductAdd;
        private System.Windows.Forms.Button buttonPartAssosciatedDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxProductSearch;
        private System.Windows.Forms.TextBox textBoxMin;
    }
}