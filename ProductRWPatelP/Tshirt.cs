using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Tshirt : Appreal
    {
        public string Size;
        public Tshirt(string Type, string ID, string Desc, double Price, int Qty, string Color, string Manufacturer, string Material, string Size) 
            : base(Type, ID, Desc, Price, Qty, Color, Manufacturer, Material)
        {
            this.Size = Size;
        }
        public string size
        {
            get { return Size; }
            set { Size = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + Size;
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