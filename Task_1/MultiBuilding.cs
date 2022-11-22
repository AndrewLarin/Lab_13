using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    sealed class MultiBuilding : Building
    {
        double floors;
        public MultiBuilding(string adress, double lenqth, double width, double hight, double floors)
        :base(adress, lenqth, width, hight)
        {
            this.floors = floors;
        }
        public string Print()
        {
            string result = base.Print();
            result += $",{floors}";
            return result;
        }
    }
}
