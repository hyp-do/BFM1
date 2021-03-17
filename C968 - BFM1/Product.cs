using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___BFM1
{
    class Product
    {
        public BindingList<Part> AssosciatedParts = new BindingList<Part>(){};

        public Product(int ProductID, string Name, decimal Price, int Instock, int Min, int Max)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.Instock = Instock;
            this.Min = Min;
            this.Max = Max;
        }

        public static int CurrentAssociatedPartIndex { get; set; } 
        public static int CurrentAssociatedPartIndexUpper { get; set; }
        public static int CurrentAssociatedPartIndexLower { get; set; }

        public int ProductID
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public decimal Price
        {
            get; set;
        }

        public int Instock
        {
            get; set;
        }

        public int Min
        {
            get; set;
        }

        public int Max
        {
            get; set;
        }

        public void addAssosciatedPart(Part part)
        {
            AssosciatedParts.Add(part);
        }

        public bool removeAssosciatedPart(int partId)
        {
            bool isDeleteOk = false;

            try
            {
                AssosciatedParts.Remove(lookupAssosciatedPart(partId));
                isDeleteOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return isDeleteOk;
        
        }

        public Part lookupAssosciatedPart(int partId)
        {
            for (int i = 0; i < AssosciatedParts.Count; i++)
            {
                if (AssosciatedParts[i].PartID.Equals(partId))
                {
                    Inventory.PartsCurrentIndex = i;
                    return AssosciatedParts[i];
                }
            }
            Inventory.PartsCurrentIndex = -1;
            return null;
        }
    }
}
