using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___BFM1
{
    public partial class ModifyParts : Form
    {
        private bool allowPartModify()
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
            bool isMinInventoryOkay = false;
            bool isMaxInventoryOkay = false;
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
                    isMaxOkay = true;
                }
                else if (!(Convert.ToInt32(textBoxMax.Text) > Convert.ToInt32(textBoxMin.Text)))
                {
                    DialogResult result = MessageBox.Show("Max must be more than Min", "Max, Min Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxMax.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMin.BackColor = System.Drawing.Color.White;
                    textBoxInventory.BackColor = System.Drawing.Color.White;
                    isMinOkay = true;
                }
                else if (!(Convert.ToInt32(textBoxInventory.Text) <= Convert.ToInt32(textBoxMax.Text)))
                {
                    DialogResult result = MessageBox.Show("Inventory must be less than or equal to Max", "Inventory, Max Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxInventory.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMax.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMin.BackColor = System.Drawing.Color.White;
                    isMinInventoryOkay = true;
                }
                else if (!(Convert.ToInt32(textBoxInventory.Text) >= Convert.ToInt32(textBoxMin.Text)))
                {
                    DialogResult result = MessageBox.Show("Inventory must be more than or equal to Min", "Inventory, Min Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxInventory.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMin.BackColor = System.Drawing.Color.LightSalmon;
                    textBoxMax.BackColor = System.Drawing.Color.White;
                    isMaxInventoryOkay = true;
                }
                else
                {
                    isOkayToSave = true;
                }
            }
            return isOkayToSave;
        }

        private void checkRadioButtons()
        {
            bool isInteger = int.TryParse(textBoxSource.Text, out int possibleNumber);

            if (string.IsNullOrWhiteSpace(textBoxSource.Text) || (Outsourced.isOutsourced && isInteger))
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else if (InHouse.isInHouse && !isInteger)
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else
            {
                textBoxSource.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = true;
            }
            buttonSave.Enabled = allowPartModify();
        }

        public ModifyParts()
        {
            InitializeComponent();

            textBoxId.Text = Inventory.CurrentPart.PartID.ToString();
            textBoxId.Enabled = false;
            textBoxName.Text = Inventory.CurrentPart.Name;
            textBoxInventory.Text = Inventory.CurrentPart.InStock.ToString();
            textBoxPrice.Text = Inventory.CurrentPart.Price.ToString();
            textBoxMin.Text = Inventory.CurrentPart.Min.ToString();
            textBoxMax.Text = Inventory.CurrentPart.Max.ToString();

            if (Inventory.CurrentPart.GetType() == typeof(InHouse))
            {
                InHouse tempInHouse = (InHouse)Inventory.CurrentPart;
                textBoxSource.Text = tempInHouse.MachineID.ToString();
                Outsourced.isOutsourced = false;
                InHouse.isInHouse = true;
                radioButtonInHouse.Checked = true;
            }
            if (Inventory.CurrentPart.GetType() == typeof(Outsourced))
            {
                Outsourced tempOutsourced = (Outsourced)Inventory.CurrentPart;
                textBoxSource.Text = tempOutsourced.CompanyName;
                InHouse.isInHouse = false;
                Outsourced.isOutsourced = true;
                radioButtonOutsourced.Checked = true;
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
                    buttonSave.Enabled = allowPartModify();
                }
            }
            else
            {
                textBoxSource.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowPartModify();
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
            buttonSave.Enabled = allowPartModify();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxName.Text, out int possibleInteger);

            if (string.IsNullOrWhiteSpace(textBoxName.Text) || isInteger)
            {
                textBoxName.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else
            {
                textBoxName.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = true;
            }
            buttonSave.Enabled = allowPartModify();
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
                    buttonSave.Enabled = allowPartModify();
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
            buttonSave.Enabled = allowPartModify();
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            textBoxMin.Enabled = false;
            textBoxInventory.Enabled = false;
            buttonSave.Enabled = true;

            bool isMaxInteger = int.TryParse(textBoxMax.Text, out int possibleMaxNumber);

            if (string.IsNullOrWhiteSpace(textBoxMax.Text) || (!isMaxInteger))
            {
                textBoxMax.BackColor = System.Drawing.Color.LightSalmon;

                buttonSave.Enabled = false;
            }
            else if (isMaxInteger)
            {
                if (Convert.ToInt32(textBoxMax.Text) < Convert.ToInt32(textBoxMin.Text) || (Convert.ToInt32(textBoxMax.Text) < Convert.ToInt32(textBoxInventory.Text)))
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
                buttonSave.Enabled = allowPartModify();
            }
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
                buttonSave.Enabled = allowPartModify();
            }
         }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxSource.Text, out int possibleInteger);

            if (string.IsNullOrWhiteSpace(textBoxSource.Text))
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else if ((radioButtonInHouse.Checked == true && (!isInteger)) || (radioButtonOutsourced.Checked == true && (isInteger)))
            {
                textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                buttonSave.Enabled = false;
            }
            else
            {
                textBoxSource.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = true;

            }
            buttonSave.Enabled = allowPartModify();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelSource.Text = "Company Name";
            Outsourced.isOutsourced = true;
            InHouse.isInHouse = false;
            buttonSave.Enabled = allowPartModify();
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
                    buttonSave.Enabled = allowPartModify();
                }
            }
            else
            {
                textBoxSource.BackColor = System.Drawing.Color.White;
                buttonSave.Enabled = allowPartModify();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(textBoxSource.Text, out int possibleInteger);

            bool canSave = allowSave();

            if (canSave == true)
            {
                if ((Inventory.CurrentPart is InHouse) && (radioButtonOutsourced.Checked == true))
                {
                    if (!isInteger)
                    {
                        Inventory.deletePart(Inventory.CurrentPart);
                        Part outSourcedPart = new Outsourced(Convert.ToInt32(textBoxId.Text), textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxInventory.Text), Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text), textBoxSource.Text);
                        Inventory.updatePart(outSourcedPart);

                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();

                    }
                    else
                    {
                        textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                        MessageBox.Show("Company Name should not be a number");
                    }

                }
                else if ((Inventory.CurrentPart is Outsourced) && (radioButtonInHouse.Checked == true))
                {
                    if (isInteger)
                    {
                        Inventory.deletePart(Inventory.CurrentPart);
                        Part inHousePart = new InHouse(Convert.ToInt32(textBoxId.Text), textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxInventory.Text), Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text), Convert.ToInt32(textBoxSource.Text));
                        Inventory.updatePart(inHousePart);
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();

                    }
                    else
                    {
                        textBoxSource.BackColor = System.Drawing.Color.LightSalmon;
                        MessageBox.Show("MachineID should be a number");
                    }
                }
                else if (InHouse.isInHouse == true && Outsourced.isOutsourced == false)
                {
                    Part inHousePart = new InHouse(Convert.ToInt32(textBoxId.Text), textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxInventory.Text), Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text), Convert.ToInt32(textBoxSource.Text));
                    Inventory.updatePart(inHousePart);
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }

                else if (Outsourced.isOutsourced == true && InHouse.isInHouse == false)
                {
                    Part outSourcedPart = new Outsourced(Convert.ToInt32(textBoxId.Text), textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxInventory.Text), Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text), textBoxSource.Text);
                    Inventory.updatePart(outSourcedPart);
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

    }
}
