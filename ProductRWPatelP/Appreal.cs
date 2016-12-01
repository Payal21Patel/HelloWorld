using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Appreal : Product
    {
        public string Color;
        public string Manufacturer;
        public string Material;

        public Appreal(string Type, string ID, string Desc, double Price, int Qty, string Material, string Color, string Manufacturer):
            base(Type, ID, Desc,Price, Qty)
        {
            this.Color = Color;
            this.Manufacturer = Manufacturer;
            this.Material = Material;
        }
        public string color
        {
            get { return Color; }
            set { Color = value; }
        }
        public string manufacturer
        {
            get { return Manufacturer; }
            set { Manufacturer = value; }
        }
        public string material
        {
            get { return Material; }
            set { Material = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + Material + y + Color + y + Manufacturer;

        }
        public override string ToCSV()
        {
            return getDisplayText(",");
        }
        public override string ToString()
        {
            return getDisplayText("\r\n");
        }
    }
}