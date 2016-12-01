using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Pants : Appreal
    {
        public int Inseam;
        public int Waist;
        public Pants(string Type, string ID, string Desc, double Price, int Qty, string Color, string Manufacturer, string Material, 
            int Inseam, int Waist) : base(Type, ID, Desc, Price, Qty, Color, Manufacturer, Material)
        {
            this.Inseam = Inseam;
            this.Waist = Waist;
        }
        public int inseam
        {
            get { return Inseam; }
            set { Inseam = value; }
        }
        public int waist
        {
            get { return Waist; }
            set { Waist = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + Inseam + y + Waist;

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