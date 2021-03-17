namespace C968___BFM1
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
            this.labelMainScreen = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.labelPartsMainScreen = new System.Windows.Forms.Label();
            this.labelProductsMainScreen = new System.Windows.Forms.Label();
            this.buttonSearchParts = new System.Windows.Forms.Button();
            this.buttonSearchProducts = new System.Windows.Forms.Button();
            this.textBoxPartsSearch = new System.Windows.Forms.TextBox();
            this.textBoxProductsSearch = new System.Windows.Forms.TextBox();
            this.buttonAddParts = new System.Windows.Forms.Button();
            this.buttonDeleteParts = new System.Windows.Forms.Button();
            this.buttonModifyParts = new System.Windows.Forms.Button();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.buttonModifyProducts = new System.Windows.Forms.Button();
            this.buttonDeleteProducts = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMainScreen
            // 
            this.labelMainScreen.AutoSize = true;
            this.labelMainScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainScreen.Location = new System.Drawing.Point(12, 9);
            this.labelMainScreen.Name = "labelMainScreen";
            this.labelMainScreen.Size = new System.Drawing.Size(314, 26);
            this.labelMainScreen.TabIndex = 0;
            this.labelMainScreen.Text = "Inventory Management System";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParts.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvParts.Location = new System.Drawing.Point(29, 132);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(482, 316);
            this.dgvParts.TabIndex = 1;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            this.dgvParts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProducts.Location = new System.Drawing.Point(558, 132);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(472, 316);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.TabStop = false;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // labelPartsMainScreen
            // 
            this.labelPartsMainScreen.AutoSize = true;
            this.labelPartsMainScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartsMainScreen.Location = new System.Drawing.Point(25, 109);
            this.labelPartsMainScreen.Name = "labelPartsMainScreen";
            this.labelPartsMainScreen.Size = new System.Drawing.Size(51, 20);
            this.labelPartsMainScreen.TabIndex = 3;
            this.labelPartsMainScreen.Text = "Parts";
            // 
            // labelProductsMainScreen
            // 
            this.labelProductsMainScreen.AutoSize = true;
            this.labelProductsMainScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductsMainScreen.Location = new System.Drawing.Point(554, 109);
            this.labelProductsMainScreen.Name = "labelProductsMainScreen";
            this.labelProductsMainScreen.Size = new System.Drawing.Size(80, 20);
            this.labelProductsMainScreen.TabIndex = 4;
            this.labelProductsMainScreen.Text = "Products";
            // 
            // buttonSearchParts
            // 
            this.buttonSearchParts.Location = new System.Drawing.Point(282, 100);
            this.buttonSearchParts.Name = "buttonSearchParts";
            this.buttonSearchParts.Size = new System.Drawing.Size(54, 23);
            this.buttonSearchParts.TabIndex = 5;
            this.buttonSearchParts.Text = "Search";
            this.buttonSearchParts.UseVisualStyleBackColor = true;
            this.buttonSearchParts.Click += new System.EventHandler(this.buttonSearchParts_Click);
            // 
            // buttonSearchProducts
            // 
            this.buttonSearchProducts.Location = new System.Drawing.Point(796, 100);
            this.buttonSearchProducts.Name = "buttonSearchProducts";
            this.buttonSearchProducts.Size = new System.Drawing.Size(58, 23);
            this.buttonSearchProducts.TabIndex = 6;
            this.buttonSearchProducts.Text = "Search";
            this.buttonSearchProducts.UseVisualStyleBackColor = true;
            this.buttonSearchProducts.Click += new System.EventHandler(this.buttonSearchProducts_Click);
            // 
            // textBoxPartsSearch
            // 
            this.textBoxPartsSearch.Location = new System.Drawing.Point(353, 100);
            this.textBoxPartsSearch.Name = "textBoxPartsSearch";
            this.textBoxPartsSearch.Size = new System.Drawing.Size(158, 20);
            this.textBoxPartsSearch.TabIndex = 7;
            this.textBoxPartsSearch.TextChanged += new System.EventHandler(this.textBoxPartsSearch_TextChanged);
            this.textBoxPartsSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartsSearch_KeyPress);
            // 
            // textBoxProductsSearch
            // 
            this.textBoxProductsSearch.Location = new System.Drawing.Point(872, 100);
            this.textBoxProductsSearch.Name = "textBoxProductsSearch";
            this.textBoxProductsSearch.Size = new System.Drawing.Size(158, 20);
            this.textBoxProductsSearch.TabIndex = 8;
            this.textBoxProductsSearch.TextChanged += new System.EventHandler(this.textBoxProductsSearch_TextChanged);
            // 
            // buttonAddParts
            // 
            this.buttonAddParts.Location = new System.Drawing.Point(337, 454);
            this.buttonAddParts.Name = "buttonAddParts";
            this.buttonAddParts.Size = new System.Drawing.Size(54, 23);
            this.buttonAddParts.TabIndex = 9;
            this.buttonAddParts.Text = "Add";
            this.buttonAddParts.UseVisualStyleBackColor = true;
            this.buttonAddParts.Click += new System.EventHandler(this.buttonAddPartsMainScreen_Click);
            // 
            // buttonDeleteParts
            // 
            this.buttonDeleteParts.Location = new System.Drawing.Point(457, 454);
            this.buttonDeleteParts.Name = "buttonDeleteParts";
            this.buttonDeleteParts.Size = new System.Drawing.Size(54, 23);
            this.buttonDeleteParts.TabIndex = 10;
            this.buttonDeleteParts.Text = "Delete";
            this.buttonDeleteParts.UseVisualStyleBackColor = true;
            this.buttonDeleteParts.Click += new System.EventHandler(this.buttonDeleteParts_Click);
            // 
            // buttonModifyParts
            // 
            this.buttonModifyParts.Location = new System.Drawing.Point(397, 454);
            this.buttonModifyParts.Name = "buttonModifyParts";
            this.buttonModifyParts.Size = new System.Drawing.Size(54, 23);
            this.buttonModifyParts.TabIndex = 11;
            this.buttonModifyParts.Text = "Modify";
            this.buttonModifyParts.UseVisualStyleBackColor = true;
            this.buttonModifyParts.Click += new System.EventHandler(this.buttonModifyParts_Click);
            // 
            // buttonAddProducts
            // 
            this.buttonAddProducts.Location = new System.Drawing.Point(856, 454);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(54, 23);
            this.buttonAddProducts.TabIndex = 12;
            this.buttonAddProducts.Text = "Add";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            this.buttonAddProducts.Click += new System.EventHandler(this.buttonAddProducts_Click);
            // 
            // buttonModifyProducts
            // 
            this.buttonModifyProducts.Location = new System.Drawing.Point(916, 454);
            this.buttonModifyProducts.Name = "buttonModifyProducts";
            this.buttonModifyProducts.Size = new System.Drawing.Size(54, 23);
            this.buttonModifyProducts.TabIndex = 13;
            this.buttonModifyProducts.Text = "Modify";
            this.buttonModifyProducts.UseVisualStyleBackColor = true;
            this.buttonModifyProducts.Click += new System.EventHandler(this.buttonModifyProducts_Click);
            // 
            // buttonDeleteProducts
            // 
            this.buttonDeleteProducts.Location = new System.Drawing.Point(976, 454);
            this.buttonDeleteProducts.Name = "buttonDeleteProducts";
            this.buttonDeleteProducts.Size = new System.Drawing.Size(54, 23);
            this.buttonDeleteProducts.TabIndex = 14;
            this.buttonDeleteProducts.Text = "Delete";
            this.buttonDeleteProducts.UseVisualStyleBackColor = true;
            this.buttonDeleteProducts.Click += new System.EventHandler(this.buttonDeleteProducts_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(976, 505);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(54, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 540);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDeleteProducts);
            this.Controls.Add(this.buttonModifyProducts);
            this.Controls.Add(this.buttonAddProducts);
            this.Controls.Add(this.buttonModifyParts);
            this.Controls.Add(this.buttonDeleteParts);
            this.Controls.Add(this.buttonAddParts);
            this.Controls.Add(this.textBoxProductsSearch);
            this.Controls.Add(this.textBoxPartsSearch);
            this.Controls.Add(this.buttonSearchProducts);
            this.Controls.Add(this.buttonSearchParts);
            this.Controls.Add(this.labelProductsMainScreen);
            this.Controls.Add(this.labelPartsMainScreen);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.labelMainScreen);
            this.Name = "Form1";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainScreen;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label labelPartsMainScreen;
        private System.Windows.Forms.Label labelProductsMainScreen;
        private System.Windows.Forms.Button buttonSearchParts;
        private System.Windows.Forms.Button buttonSearchProducts;
        private System.Windows.Forms.TextBox textBoxPartsSearch;
        private System.Windows.Forms.TextBox textBoxProductsSearch;
        private System.Windows.Forms.Button buttonAddParts;
        private System.Windows.Forms.Button buttonDeleteParts;
        private System.Windows.Forms.Button buttonModifyParts;
        private System.Windows.Forms.Button buttonAddProducts;
        private System.Windows.Forms.Button buttonModifyProducts;
        private System.Windows.Forms.Button buttonDeleteProducts;
        private System.Windows.Forms.Button buttonExit;
    }
}

