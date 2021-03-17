namespace C968___BFM1
{
    partial class ModifyParts
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPriceCost = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.radioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.radioButtonInHouse = new System.Windows.Forms.RadioButton();
            this.labelAddPart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(430, 418);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(327, 418);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(169, 325);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(121, 20);
            this.textBoxSource.TabIndex = 35;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(356, 274);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(121, 20);
            this.textBoxMin.TabIndex = 34;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(169, 276);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(121, 20);
            this.textBoxMax.TabIndex = 33;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(169, 227);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 32;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Location = new System.Drawing.Point(169, 181);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(121, 20);
            this.textBoxInventory.TabIndex = 31;
            this.textBoxInventory.TextChanged += new System.EventHandler(this.textBoxInventory_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 134);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 30;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(169, 86);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(121, 20);
            this.textBoxId.TabIndex = 29;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.Location = new System.Drawing.Point(35, 325);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(90, 20);
            this.labelSource.TabIndex = 28;
            this.labelSource.Text = "Machine ID";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(311, 276);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(34, 20);
            this.labelMin.TabIndex = 27;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(104, 274);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(38, 20);
            this.labelMax.TabIndex = 26;
            this.labelMax.Text = "Max";
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceCost.Location = new System.Drawing.Point(53, 227);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(89, 20);
            this.labelPriceCost.TabIndex = 25;
            this.labelPriceCost.Text = "Price / Cost";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventory.Location = new System.Drawing.Point(68, 181);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(74, 20);
            this.labelInventory.TabIndex = 24;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(91, 134);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(116, 86);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "ID";
            // 
            // radioButtonOutsourced
            // 
            this.radioButtonOutsourced.AutoSize = true;
            this.radioButtonOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOutsourced.Location = new System.Drawing.Point(292, 8);
            this.radioButtonOutsourced.Name = "radioButtonOutsourced";
            this.radioButtonOutsourced.Size = new System.Drawing.Size(110, 24);
            this.radioButtonOutsourced.TabIndex = 21;
            this.radioButtonOutsourced.TabStop = true;
            this.radioButtonOutsourced.Text = "Outsourced";
            this.radioButtonOutsourced.UseVisualStyleBackColor = true;
            this.radioButtonOutsourced.CheckedChanged += new System.EventHandler(this.radioButtonOutsourced_CheckedChanged);
            this.radioButtonOutsourced.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioButtonOutsourced_CheckedChanged);
            // 
            // radioButtonInHouse
            // 
            this.radioButtonInHouse.AutoSize = true;
            this.radioButtonInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInHouse.Location = new System.Drawing.Point(166, 7);
            this.radioButtonInHouse.Name = "radioButtonInHouse";
            this.radioButtonInHouse.Size = new System.Drawing.Size(93, 24);
            this.radioButtonInHouse.TabIndex = 20;
            this.radioButtonInHouse.TabStop = true;
            this.radioButtonInHouse.Text = "In-House";
            this.radioButtonInHouse.UseVisualStyleBackColor = true;
            this.radioButtonInHouse.CheckedChanged += new System.EventHandler(this.radioButtonInHouse_CheckedChanged);
            // 
            // labelAddPart
            // 
            this.labelAddPart.AutoSize = true;
            this.labelAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPart.Location = new System.Drawing.Point(4, 5);
            this.labelAddPart.Name = "labelAddPart";
            this.labelAddPart.Size = new System.Drawing.Size(88, 20);
            this.labelAddPart.TabIndex = 19;
            this.labelAddPart.Text = "Modify Part";
            // 
            // ModifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPriceCost);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.radioButtonOutsourced);
            this.Controls.Add(this.radioButtonInHouse);
            this.Controls.Add(this.labelAddPart);
            this.Name = "ModifyParts";
            this.Text = "ModifyParts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelPriceCost;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.RadioButton radioButtonOutsourced;
        private System.Windows.Forms.RadioButton radioButtonInHouse;
        private System.Windows.Forms.Label labelAddPart;
    }
}