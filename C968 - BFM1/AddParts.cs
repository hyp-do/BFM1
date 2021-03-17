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
    public partial class AddParts : Form
    {
        private bool allowPartAdd()
        {
            return (!(string.IsNullOrWhiteSpace(textBoxId.Text))) &&
                   (!(string.IsNullOrWhiteSpace(textBoxName.Text))) &&
                   (!(string.IsNullOrWhiteSpace(textBoxPrice.Text))) &&
                   (!(string.IsNullOrWhiteSpace(textBoxInventory.Text))) &&
                   (!(string.IsNullOrWhiteSpace(textBoxMax.Text))) &&
                   (!(string.IsNullOrWhiteSpace(textBoxMin.Text))) &&
                   ((!(string.IsNullOrWhiteSpace(textBoxSource.Text) || (Outsourced.isOutsourced && int.TryParse(textBoxSource.Text, out int number)))));
        }

        private bool allowSave()
        {
            bool isOkayToSave = false;
            bool isMinOkay = false;
            bool isMaxOkay = false;
            bool isInventoryOkay = false;
            bool isInventoryInteger = int.TryParse(textBoxInventory.Text, out int possiblInventoryeNumber);
            bool isMaxInteger = int.TryParse(textBoxMax.Text, out int possibleMaxNumber);
            bool isMinInteger = int.TryParse(textBoxMin.Text, out int possibleMinNumber);
            

            if (isInventoryInteger && isMaxInteger && isMinInteger)
            {
                if(!(Convert.ToInt32(textBoxMin.Text) < Convert.ToInt32(textBoxMax.Text)))
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

        public AddParts()
        {
            InitializeComponent();
            radioButtonInHouse.Checked = false;
            radioButtonOutsourced.Checked = false;
            textBoxInventory.Text = "0";
            textBoxMin.Text = "0";
            textBoxMax.Text = "0";
            textBoxPrice.Text = "0";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxSource.Text, out int possibleInteger);

            bool canSave = allowSave();

            if ((radioButtonInHouse.Checked == false) && (radioButtonOutsourced.Checked == false))
            {
                MessageBox.Show("In-House or Outsourced must be checked.");
            }
            else if (canSave == true)
            {
                if (InHouse.isInHouse == true && Outsourced.isOutsourced == false)
                {
                    Inventory.addPart(Convert.ToInt32(textBoxId.Text), textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxInventory.Text), Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text), Convert.ToInt32(textBoxSource.Text));

                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }

                else if (Outsourced.isOutsourced == true && InHouse.isInHouse == false)
                {
                    Inventory.addPart(Convert.ToInt32(textBoxId.Text), textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxInventory.Text), Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text), textBoxSource.Text);

                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }

            }
            

        }

    

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxSource.Text, out int possibleInteger);
            bool isFloat = float.TryParse(textBoxSource.Text, out float possibleFloat);

            if (string.IsNullOrWhiteSpace(textBoxSource.Text))
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else if (InHouse.isInHouse && !isInteger)
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else if ((Outsourced.isOutsourced && isFloat) || (Outsourced.isOutsourced && isInteger))
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else
            {
                textBoxSource.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowPartAdd();
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
            }
            else
            {
                textBoxMin.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowPartAdd();
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
            }
            else
            {
                textBoxMax.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowPartAdd();
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
            }
            else
            {
                textBoxInventory.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowPartAdd();
            }

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            bool isDecimal = decimal.TryParse(textBoxPrice.Text, out decimal possibleDecimal);

            if (string.IsNullOrWhiteSpace(textBoxPrice.Text) || (!isDecimal))
            {
                textBoxPrice.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            if (isDecimal)
            {
                buttonSave.Enabled = allowPartAdd();
                textBoxPrice.BackColor = System.Drawing.Color.White;
            }
            
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxName.Text, out int possibleInteger);
            bool isFloat = float.TryParse(textBoxName.Text, out float possibleFloat);

            if (string.IsNullOrWhiteSpace(textBoxName.Text) || (isInteger))
            {
                textBoxName.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else if (!(isInteger || isFloat))
            {
                buttonSave.Enabled = allowPartAdd();
                textBoxName.BackColor = System.Drawing.Color.White;
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxId.Text, out int possibleInteger);
            bool isFloat = float.TryParse(textBoxId.Text, out float possibleFloat);

            if (string.IsNullOrWhiteSpace(textBoxId.Text) || (!isInteger))
            {
                textBoxId.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = allowPartAdd();
                textBoxId.BackColor = System.Drawing.Color.White;
            }
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelSource.Text = "Company Name";
            Outsourced.isOutsourced = true;
            InHouse.isInHouse = false;
            buttonSave.Enabled = allowPartAdd();
            bool isInteger = int.TryParse(textBoxSource.Text, out int possibleInteger);
            bool isFloat = decimal.TryParse(textBoxSource.Text, out decimal possibleDecimal);

            if (string.IsNullOrWhiteSpace(textBoxSource.Text))
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else if (isInteger)
            {
                if ((Outsourced.isOutsourced && isFloat) || (Outsourced.isOutsourced && isInteger))
                {
                    textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                    buttonSave.Enabled = false;
                }
                else
                {
                    textBoxSource.BackColor = System.Drawing.Color.White;
                    buttonSave.Enabled = allowPartAdd();
                }
            }
            else
            {
                textBoxSource.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowPartAdd();
            }
        }

        private void radioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            labelSource.Text = "Machine ID";
            InHouse.isInHouse = true;
            Outsourced.isOutsourced = false;
            
            bool isInteger = int.TryParse(textBoxSource.Text, out int possibleInteger);

            if (string.IsNullOrWhiteSpace(textBoxSource.Text))
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else if (!isInteger)
            {
                if (InHouse.isInHouse && !isInteger)
                {
                    textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                    buttonSave.Enabled = false;
                }
                else
                {
                    textBoxSource.BackColor = System.Drawing.Color.White;
                    buttonSave.Enabled = allowPartAdd();
                }
            }
            else
            {
                textBoxSource.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowPartAdd();
            }
        }
    }
}
