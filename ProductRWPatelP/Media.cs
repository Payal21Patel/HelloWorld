using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Media : Product
    {
        public DateTime ReleaseDate;
        public Media(string Type, string ID, string Desc, double Price, int Qty, string ReleaseDate)
            : base(Type, ID, Desc, Price, Qty)
        {
            releaseDate = ReleaseDate;
        }
        public string releaseDate
        {
            get { return ReleaseDate.ToShortDateString(); }
            set { ReleaseDate = Convert.ToDateTime(value); }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + ReleaseDate;
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