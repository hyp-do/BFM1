using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___BFM1
{
    public partial class ModifyProduct : Form
    {
        private bool allowSave()
        {
            bool isOkayToSave = false;
            bool isInventoryInteger = int.TryParse(textBoxInventory.Text, out int possiblInventoryeNumber);
            bool isMaxInteger = int.TryParse(textBoxMax.Text, out int possibleMaxNumber);
            bool isMinInteger = int.TryParse(textBoxMin.Text, out int possibleMinNumber);

            if (isInventoryInteger && isMaxInteger && isMinInteger)
            {
                if (!(Convert.ToInt32(textBoxMin.Text) < Convert.ToInt32(textBoxMax.Text)))
                {
                    DialogResult result = MessageBox.Show("Min must be less than Max", "Min, Max Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxMin.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMax.BackColor = System.Drawing.Color.White;
                    textBoxInventory.BackColor = System.Drawing.Color.White;

                }
                else if (!(Convert.ToInt32(textBoxMax.Text) > Convert.ToInt32(textBoxMin.Text)))
                {
                    DialogResult result = MessageBox.Show("Max must be more than Min", "Max, Min Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxMax.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMin.BackColor = System.Drawing.Color.White;
                    textBoxInventory.BackColor = System.Drawing.Color.White;

                }
                else if (!(Convert.ToInt32(textBoxInventory.Text) <= Convert.ToInt32(textBoxMax.Text)))
                {
                    DialogResult result = MessageBox.Show("Inventory must be less than or equal to Max", "Inventory, Max Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxInventory.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMax.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMin.BackColor = System.Drawing.Color.White;
                }
                else if (!(Convert.ToInt32(textBoxInventory.Text) >= Convert.ToInt32(textBoxMin.Text)))
                {
                    DialogResult result = MessageBox.Show("Inventory must be more than or equal to Min", "Inventory, Min Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxInventory.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMin.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMax.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    isOkayToSave = true;
                }
            }
            return isOkayToSave;
        }

        private bool allowProductModify()
        {
            return (!(string.IsNullOrWhiteSpace(textBoxId.Text))) &&
                   (!string.IsNullOrWhiteSpace(textBoxName.Text)) &&
                   (!string.IsNullOrWhiteSpace(textBoxPrice.Text)) &&
                   (!string.IsNullOrWhiteSpace(textBoxInventory.Text)) &&
                   (!(string.IsNullOrWhiteSpace(textBoxMax.Text))) &&
                   (!(string.IsNullOrWhiteSpace(textBoxMin.Text)));
        }

        BindingList<Part> TemporaryModifyPartList = new BindingList<Part>();

        public ModifyProduct()
        {
            InitializeComponent();
                        
            textBoxId.Text = Inventory.CurrentProduct.ProductID.ToString();
            textBoxId.Enabled = false;
            textBoxName.Text = Inventory.CurrentProduct.Name;
            textBoxInventory.Text = Inventory.CurrentProduct.Instock.ToString();
            textBoxPrice.Text = Inventory.CurrentProduct.Price.ToString();
            textBoxMin.Text = Inventory.CurrentProduct.Min.ToString();
            textBoxMax.Text = Inventory.CurrentProduct.Max.ToString();

            dgvParts.DataSource = Inventory.AllParts;

            dgvParts.Columns["PartID"].HeaderText = "Part ID";
            dgvParts.Columns["Name"].HeaderText = "Part Name";
            dgvParts.Columns["Instock"].HeaderText = "Inventory";
            dgvParts.Columns["Price"].HeaderText = "Price";
            dgvParts.Columns["Max"].Visible = false;
            dgvParts.Columns["Min"].Visible = false;

            dgvParts.Rows[0].Selected = true;

            dgvAssociatedParts.DataSource = TemporaryModifyPartList;

            dgvAssociatedParts.Columns["PartID"].HeaderText = "Part ID";
            dgvAssociatedParts.Columns["Name"].HeaderText = "Part Name";
            dgvAssociatedParts.Columns["Instock"].HeaderText = "Inventory";
            dgvAssociatedParts.Columns["Price"].HeaderText = "Price";
            dgvAssociatedParts.Columns["Max"].Visible = false;
            dgvAssociatedParts.Columns["Min"].Visible = false;

            foreach (Part part in Inventory.CurrentProduct.AssosciatedParts)
            {
                TemporaryModifyPartList.Add(part);
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxId.Text, out int possibleInteger);

            if (string.IsNullOrWhiteSpace(textBoxId.Text) || (!isInteger))
            {
                textBoxId.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else
            {
                textBoxId.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = true;
            }
            buttonSave.Enabled = allowProductModify();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxName.Text, out int possibleInteger);

            if (string.IsNullOrWhiteSpace(textBoxName.Text) || (isInteger))
            {
                textBoxName.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else
            {
                textBoxName.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = true;
            }
            buttonSave.Enabled = allowProductModify();
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            textBoxMin.Enabled = false;
            textBoxMax.Enabled = false;
            buttonSave.Enabled = true;

            bool isInventoryInteger = int.TryParse(textBoxInventory.Text, out int possiblInventoryeNumber);
            bool isMaxInteger = int.TryParse(textBoxMax.Text, out int possibleMaxNumber);
            bool isMinInteger = int.TryParse(textBoxMin.Text, out int possibleMinNumber);

            if (string.IsNullOrWhiteSpace(textBoxInventory.Text) || (!isInventoryInteger))
            {
                textBoxInventory.BackColor = System.Drawing.Color.LightSalmon;

                buttonSave.Enabled = false;
            }
            else if (isInventoryInteger)
            {
                if (isMaxInteger && isMinInteger)
                {
                    if (Convert.ToInt32(textBoxInventory.Text) < (Convert.ToInt32(textBoxMin.Text)))
                    {
                        textBoxInventory.BackColor = System.Drawing.Color.LightSalmon;
                        buttonSave.Enabled = false;
                    }

                    else if (Convert.ToInt32(textBoxInventory.Text) > Convert.ToInt32(textBoxMax.Text))
                    {
                        textBoxInventory.BackColor = System.Drawing.Color.LightSalmon;
                        buttonSave.Enabled = false;
                    }
                    else
                    {
                        textBoxInventory.BackColor = System.Drawing.Color.White;
                        textBoxMin.Enabled = true;
                        textBoxMax.Enabled = true;
                        buttonSave.Enabled = true;
                    }
                }
                else
                {
                    buttonSave.Enabled = allowProductModify();
                }
             }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            bool isDecimal = decimal.TryParse(textBoxPrice.Text, out decimal possibleDecimal);

            if (string.IsNullOrWhiteSpace(textBoxPrice.Text) || (!isDecimal))
            {
                textBoxPrice.BackColor = System.Drawing.Color.LightSalmon;
            }
            else
            {
                textBoxPrice.BackColor = System.Drawing.Color.White;

            }
            buttonSave.Enabled = allowProductModify();
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            textBoxMax.Enabled = false;
            textBoxInventory.Enabled = false;
            buttonSave.Enabled = true;

            bool isInteger = int.TryParse(textBoxMin.Text, out int possibleNumber);

            if (string.IsNullOrWhiteSpace(textBoxMin.Text) || (!isInteger))
            {
                textBoxMin.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else if (isInteger)
            {
                if ((Convert.ToInt32(textBoxMin.Text) > Convert.ToInt32(textBoxInventory.Text)) || (Convert.ToInt32(textBoxMin.Text) <= 0))
                {
                    textBoxMin.BackColor = System.Drawing.Color.LightSalmon;
                    buttonSave.Enabled = false;
                }
                else
                {
                    textBoxMin.BackColor = System.Drawing.Color.White;
                    textBoxMax.Enabled = true;
                    textBoxInventory.Enabled = true;
                    buttonSave.Enabled = true;
                }
            }
            else
            {
                buttonSave.Enabled = allowProductModify();
            }
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            bool isMaxInteger = int.TryParse(textBoxMax.Text, out int possibleMaxNumber);

            textBoxMin.Enabled = false;
            textBoxInventory.Enabled = false;
            buttonSave.Enabled = true;

            if ((string.IsNullOrWhiteSpace(textBoxMax.Text)) || (!isMaxInteger)) 
            {
                buttonSave.Enabled = false;
                textBoxMax.BackColor = System.Drawing.Color.LightSalmon;
            }
            else if (isMaxInteger)
            {
                if ((Convert.ToInt32(textBoxMax.Text) < Convert.ToInt32(textBoxMin.Text)) || ((Convert.ToInt32(textBoxMax.Text) < Convert.ToInt32(textBoxInventory.Text))))
                {
                    textBoxMax.BackColor = System.Drawing.Color.LightSalmon;
                    buttonSave.Enabled = false;
                }
                else
                {
                    textBoxMax.BackColor = System.Drawing.Color.White;
                    textBoxMin.Enabled = true;
                    textBoxInventory.Enabled = true;
                    buttonSave.Enabled = true;
                }
            }
            else
            {
                textBoxMax.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowProductModify();
            }
        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> PartsSearch = new BindingList<Part>();

            bool partsFound = false;

            if (textBoxProductSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(textBoxProductSearch.Text.ToUpper()))
                    {
                        PartsSearch.Add(Inventory.AllParts[i]);
                        partsFound = true;
                    }
                }
            }
            if (partsFound)
            {
                dgvParts.DataSource = PartsSearch;
            }
            if (!partsFound)
            {
                MessageBox.Show("No results found.");
                dgvParts.DataSource = Inventory.AllParts;
            }
        }

        private void textBoxProductSearch_TextChanged(object sender, EventArgs e)
        {
            BindingList<Part> PartsSearch = new BindingList<Part>();

            bool partsFound = false;

            if (textBoxProductSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(textBoxProductSearch.Text.ToUpper()))
                    {
                        PartsSearch.Add(Inventory.AllParts[i]);
                        partsFound = true;
                    }
                }
            }
            if (partsFound)
            {
                dgvParts.DataSource = PartsSearch;
            }
            if (!partsFound)
            {
                dgvParts.DataSource = Inventory.AllParts;
            }
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            Part temporaryPart = Inventory.lookupPart(Inventory.CurrentPartId);
            TemporaryModifyPartList.Add(temporaryPart);
        }

        private void buttonPartAssosciatedDelete_Click(object sender, EventArgs e)
        {
            bool isDeleteOkay = false;

            if (TemporaryModifyPartList.Count <= 0)
            {
                MessageBox.Show("Please add a part in order to delete it. Otherwise, press cancel and delete this product from the main screen.");
            }
            else if (isDeleteOkay == false)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Associated Part?", "Confirm Part Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    isDeleteOkay = true;
                    if ((TemporaryModifyPartList.Count > 0) && (isDeleteOkay == true))
                    {
                        TemporaryModifyPartList.Remove(TemporaryModifyPartList[Product.CurrentAssociatedPartIndexLower]);
                    }
                }
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool canSave = allowSave();

            if (canSave == true)
            {
                Product product = new Product(Convert.ToInt32(textBoxId.Text), textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxInventory.Text), Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text));
                Inventory.updateProduct(product);

                foreach (Part part in TemporaryModifyPartList)
                {
                    product.addAssosciatedPart(part);
                }
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product.CurrentAssociatedPartIndexUpper = e.RowIndex;
                Inventory.CurrentPartId = (int)dgvParts.Rows[Product.CurrentAssociatedPartIndexUpper].Cells[0].Value;

            }
        }

        private void dgvAssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product.CurrentAssociatedPartIndexLower = e.RowIndex;

            }
        }
    }
}
