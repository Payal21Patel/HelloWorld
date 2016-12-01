using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class DressShirt : Appreal
    {
        public int Neck;
        public int Sleeve;

        public DressShirt(string Type, string ID, string Desc, double Price, int Qty, string Color, 
            string Manufacturer, string Material, int Neck, int Sleeve) :
            base(Type, ID, Desc, Price, Qty, Color, Manufacturer, Material)
        {
            this.Neck = Neck;
            this.Sleeve = Sleeve;
        }
        public int neck
        {
            get { return Neck; }
            set { Neck = value; }
        }
        public int sleeve
        {
            get { return Sleeve; }
            set { Sleeve = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + Neck + y + Sleeve;
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