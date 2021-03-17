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
    public partial class AddProducts : Form
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

                    textBoxMax.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMin.BackColor = System.Drawing.Color.White;
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
        private bool allowProductAdd()
        {
            return (!(string.IsNullOrWhiteSpace(textBoxId.Text))) &&
                     (!string.IsNullOrWhiteSpace(textBoxName.Text)) &&
                     (!string.IsNullOrWhiteSpace(textBoxPrice.Text)) &&
                     (!string.IsNullOrWhiteSpace(textBoxInventory.Text)) &&
                     (!(string.IsNullOrWhiteSpace(textBoxMax.Text))) &&
                     (!(string.IsNullOrWhiteSpace(textBoxMin.Text)));
        }

        BindingList<Part> TemporaryAddPartList = new BindingList<Part>();

        public AddProducts()
        {
            InitializeComponent();

            dgvParts.DataSource = Inventory.AllParts;

            dgvParts.Rows[0].Selected = true;

            dgvTempParts.DataSource = TemporaryAddPartList;

            buttonSave.Enabled = allowSave();

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxId.Text, out int possibleInteger);

            if (string.IsNullOrWhiteSpace(textBoxId.Text) || (!isInteger))
            {
                textBoxId.BackColor = System.Drawing.Color.LightSalmon;
     
            }
            else if (isInteger)
            {
                buttonSave.Enabled = allowProductAdd();
                textBoxId.BackColor = System.Drawing.Color.White;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxName.Text, out int possibleInteger);

            if (string.IsNullOrWhiteSpace(textBoxName.Text) || (isInteger))
            {
                textBoxName.BackColor = System.Drawing.Color.LightSalmon;
            }
            else
            {
                buttonSave.Enabled = allowProductAdd();
                textBoxName.BackColor = System.Drawing.Color.White;
            }
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            bool isInventoryInteger = int.TryParse(textBoxInventory.Text, out int possiblInventoryeNumber);
            bool isMaxInteger = int.TryParse(textBoxMax.Text, out int possibleMaxNumber);
            bool isMinInteger = int.TryParse(textBoxMin.Text, out int possibleMinNumber);

            if (string.IsNullOrWhiteSpace(textBoxInventory.Text) || (!isInventoryInteger))
            {
                textBoxInventory.BackColor = System.Drawing.Color.LightSalmon;


            }
            else if (isInventoryInteger)
            {
                textBoxInventory.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowProductAdd();
            }
            else
            {
                buttonSave.Enabled = allowProductAdd();
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            bool isDecimal = decimal.TryParse(textBoxPrice.Text, out decimal possibleDecimal);

            if (string.IsNullOrWhiteSpace(textBoxPrice.Text) || (!isDecimal))
            {
                textBoxPrice.BackColor = System.Drawing.Color.LightSalmon;
   
            }
            else if (isDecimal)
            {
                buttonSave.Enabled = allowProductAdd();
                textBoxPrice.BackColor = System.Drawing.Color.White;
            }
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            bool isInventoryInteger = int.TryParse(textBoxInventory.Text, out int possiblInventoryeNumber);
            bool isMaxInteger = int.TryParse(textBoxMax.Text, out int possibleMaxNumber);
            bool isMinInteger = int.TryParse(textBoxMin.Text, out int possibleMinNumber);

            if (string.IsNullOrWhiteSpace(textBoxMax.Text) || (!isMaxInteger))
            {
                textBoxMax.BackColor = System.Drawing.Color.LightSalmon;


            }
            else if (isMaxInteger)
            {
                textBoxMax.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowProductAdd();

            }
            else
                {
                    buttonSave.Enabled = allowProductAdd();
                }
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            bool isInventoryInteger = int.TryParse(textBoxInventory.Text, out int possiblInventoryeNumber);
            bool isMaxInteger = int.TryParse(textBoxMax.Text, out int possibleMaxNumber);
            bool isMinInteger = int.TryParse(textBoxMin.Text, out int possibleMinNumber);

            if (string.IsNullOrWhiteSpace(textBoxMin.Text) || (!isMinInteger))
            {
                textBoxMin.BackColor = System.Drawing.Color.LightSalmon;


            }
            else if (isMinInteger)
            {
                textBoxMin.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowProductAdd();
            }
            else
            {
                buttonSave.Enabled = allowProductAdd();
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
            TemporaryAddPartList.Add(temporaryPart);
        }

        private void buttonPartAssosciatedDelete_Click(object sender, EventArgs e)
        {
            bool isDeleteOkay = false;

            if (TemporaryAddPartList.Count <= 0)
            {
                MessageBox.Show("Please add a part in order to delete it. Otherwise, press cancel and delete this product from the main screen.");
            }
            else if (isDeleteOkay == false)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Associated Part?", "Confirm Part Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    isDeleteOkay = true;
                    if ((TemporaryAddPartList.Count > 0) && (isDeleteOkay == true))
                    {
                        TemporaryAddPartList.Remove(TemporaryAddPartList[Product.CurrentAssociatedPartIndexLower]);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool saveIt = allowSave();

            if (saveIt)
            {
                Product product = new Product(Convert.ToInt32(textBoxId.Text), textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxInventory.Text), Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text));
                Inventory.updateProduct(product);

                foreach (Part part in TemporaryAddPartList)
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
            Product.CurrentAssociatedPartIndexUpper = e.RowIndex;
            Inventory.CurrentPartId = (int)dgvParts.Rows[Product.CurrentAssociatedPartIndexUpper].Cells[0].Value;

        }
    }
}
