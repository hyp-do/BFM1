using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___BFM1
{
    class InHouse : Part
    {

        public InHouse(int PartID, string Name, decimal Price, int InStock, int Min, int Max, int MachineID) : base(PartID, Name, Price, InStock, Min, Max)
        {
            this.MachineID = MachineID;
        }
        public int MachineID
        {
            get; set;
        }

        public static bool isInHouse;
    }
}
