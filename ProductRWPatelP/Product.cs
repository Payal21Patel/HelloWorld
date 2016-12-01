using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Product
    {
        public string Desc;
        public string ID;
        public double Price;
        public int Qty;
        public string Type;

        public Product(string Type, string ID, string Desc, double Price, int Qty)
        {
            this.Desc = Desc;
            this.ID = ID;
            this.Price = Price;
            this.Qty = Qty;
            this.Type = Type;
        }

        public string desc
        {
            get { return Desc; }
            set { Desc = value; }
        }
        public string Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public double price
        {
            get { return Price; }
            set { Price = value; }
        }
        public int qty
        {
            get { return Qty; }
            set { Qty = value; }
        }
        public string type
        {
            get { return Type; }
            set { Type = value; }
        }
        public virtual string getDisplayText(string y)
        {
            return Type + y + ID + y + Desc + y + Price + y + Qty;

        }
        public override string ToString()
        {
            return this.getDisplayText("\r\n");
        }

        public virtual string ToCSV()
        {
            return this.getDisplayText(",");
        }
    }
}