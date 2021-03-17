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
    public partial class Form1 : Form
    {
        public static int currentPartIndex;

        public static int currentProductIndex;

        public Form1()
        {
            InitializeComponent();
            currentPartIndex = -1; 
            currentProductIndex = -1;
            
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvParts.DataSource = Inventory.AllParts;
            dgvParts.Columns["PartID"].HeaderText = "Part ID";
            dgvParts.Columns["Name"].HeaderText = "Part Name";
            dgvParts.Columns["Instock"].HeaderText = "Inventory";
            dgvParts.Columns["Price"].HeaderText = "Price";
            dgvParts.Columns["Max"].HeaderText = "Max";
            dgvParts.Columns["Min"].HeaderText = "Min";

            dgvParts.Rows[0].Selected = true;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.DataSource = Inventory.Products;
            dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
            dgvProducts.Columns["Name"].HeaderText = "Product Name";
            dgvProducts.Columns["Instock"].HeaderText = "Inventory";
            dgvProducts.Columns["Price"].HeaderText = "Price";
            dgvProducts.Columns["Max"].HeaderText = "Max";
            dgvProducts.Columns["Min"].HeaderText = "Min";

            dgvProducts.Rows[0].Selected = true;
        }


        private void buttonAddPartsMainScreen_Click(object sender, EventArgs e)
        {
            AddParts addParts = new AddParts();
            this.Hide();
            addParts.Show();
        }

        private void buttonSearchParts_Click(object sender, EventArgs e)
        {
            BindingList<Part> PartsSearch = new BindingList<Part>();
            
            bool partsFound = false;

            if (textBoxPartsSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(textBoxPartsSearch.Text.ToUpper()))
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

        private void buttonSearchProducts_Click(object sender, EventArgs e)
        {
            BindingList<Product> ProductsSearch = new BindingList<Product>();

            bool productsFound = false;

            if (textBoxProductsSearch.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(textBoxProductsSearch.Text.ToUpper()))
                    {
                        ProductsSearch.Add(Inventory.Products[i]);
                        productsFound = true;
                    }
                }
            }
            if (productsFound)
            {
                dgvProducts.DataSource = ProductsSearch;
            }
            if (!productsFound)
            {
                MessageBox.Show("No results found.");
                dgvProducts.DataSource = Inventory.Products;
            }
        }

        private void textBoxProductsSearch_TextChanged(object sender, EventArgs e)
        {
            BindingList<Product> ProductsSearch = new BindingList<Product>();

            bool productsFound = false;

            if (textBoxProductsSearch.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(textBoxProductsSearch.Text.ToUpper()))
                    {
                        ProductsSearch.Add(Inventory.Products[i]);
                        productsFound = true;
                    }
                }
            }
            if (productsFound)
            {
                dgvProducts.DataSource = ProductsSearch;
            }
            if (!productsFound)
            {
                dgvProducts.DataSource = Inventory.Products;
            }
        }

        private void buttonModifyParts_Click(object sender, EventArgs e)
        {
            if (currentPartIndex >= 0)
            {
                ModifyParts modifyParts = new ModifyParts();
                this.Hide();
                modifyParts.Show();
               
            }
            else
            {
                MessageBox.Show("Please select something to modify.");
            }
        }

        private void buttonDeleteParts_Click(object sender, EventArgs e)
        {

            if (Inventory.PartsCurrentIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Part?", "Confirm Part Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    Inventory.deletePart(Inventory.CurrentPart);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            this.Hide();
            addProducts.Show();
        }

        private void buttonModifyProducts_Click(object sender, EventArgs e)
        {
            ModifyProduct modifyProducts = new ModifyProduct();
            this.Hide();
            modifyProducts.Show();
        }

        private void buttonDeleteProducts_Click(object sender, EventArgs e)
        {
            if (currentProductIndex >= 0 && (Inventory.CurrentProduct.AssosciatedParts.Count <= 0))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Product", "Confirm Product Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    Inventory.removeProduct(currentProductIndex);
                }

            }
            else if (Inventory.CurrentProduct.AssosciatedParts.Count >= 0)
            {
                MessageBox.Show("Cannot delete a Product with Associated Parts. Please Modify the Product First and Remove All Associated Parts.");
            }
            else
            {
                MessageBox.Show("Select a row");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            currentProductIndex = dgvProducts.CurrentCell.RowIndex;
            Inventory.CurrentProductId = (int)dgvProducts.Rows[currentProductIndex].Cells[0].Value;
            Inventory.CurrentProduct = Inventory.lookupProduct(Inventory.CurrentProductId);
            
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvParts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;

            currentPartIndex = dgvParts.CurrentCell.RowIndex;
            Inventory.CurrentPartId = (int)dgvParts.Rows[currentPartIndex].Cells[0].Value;
            Inventory.CurrentPart = Inventory.lookupPart(Inventory.CurrentPartId);
        }

        private void textBoxPartsSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BindingList<Part> PartsSearch = new BindingList<Part>();

                bool partsFound = false;

                if (textBoxPartsSearch.Text != "")
                {
                    for (int i = 0; i < Inventory.AllParts.Count; i++)
                    {
                        if (Inventory.AllParts[i].Name.ToUpper().Contains(textBoxPartsSearch.Text.ToUpper()))
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
        }

        private void textBoxProductsSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BindingList<Product> ProductsSearch = new BindingList<Product>();

                bool productsFound = false;

                if (textBoxProductsSearch.Text != "")
                {
                    for (int i = 0; i < Inventory.Products.Count; i++)
                    {
                        if (Inventory.Products[i].Name.ToUpper().Contains(textBoxProductsSearch.Text.ToUpper()))
                        {
                            ProductsSearch.Add(Inventory.Products[i]);
                            productsFound = true;
                        }
                    }
                }
                if (productsFound)
                {
                    dgvProducts.DataSource = ProductsSearch;
                }
                if (!productsFound)
                {
                    dgvProducts.DataSource = Inventory.Products;
                }
            }
        }

        private void textBoxPartsSearch_TextChanged(object sender, EventArgs e)
        {
            BindingList<Part> PartsSearch = new BindingList<Part>();

            bool partsFound = false;

            if (textBoxPartsSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(textBoxPartsSearch.Text.ToUpper()))
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
    }
}
