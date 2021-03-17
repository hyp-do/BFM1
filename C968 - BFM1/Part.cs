using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___BFM1
{
    abstract class Part
    { 
        public Part(int PartID, string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.PartID = PartID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }

        public Part ()
        {
           
        }

        public int PartID
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

        public int InStock
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
    }
}
