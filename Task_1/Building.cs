using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Building
    {
        string adress;
        double lenqth;
        double width;
        double hight;

        public Building(string adress, double lenqth, double width, double hight)
        {
            this.adress = adress;
            this.lenqth = lenqth;
            this.width = width;
            this.hight = hight;
        }
        public string Print()
        {
            return $"{adress},{lenqth},{width},{hight}";
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public double Lenqth
        {
            get { return lenqth; }
            set { lenqth = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Hight
        {
            get { return hight; }
            set { hight = value; }
        }
    }
}
