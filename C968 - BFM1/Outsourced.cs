using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___BFM1
{
    class Outsourced : Part
    {

        public Outsourced(int PartID, string Name, decimal Price, int InStock, int Min, int Max, string CompanyName) : base(PartID, Name, Price, InStock, Min, Max)
        {
            this.CompanyName = CompanyName;
        }

        public string CompanyName
        {
            get; set;
        }

        public static bool isOutsourced;
    }
}
