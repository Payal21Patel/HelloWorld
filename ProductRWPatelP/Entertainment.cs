using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Entertainment : Disk
    {
        public TimeSpan runTime;
        public Entertainment(string Type, string ID, string Desc, double Price, int Qty, string ReleaseDate, int NumDisks, int Size, 
            string TypeDisk, TimeSpan runTime) : base (Type, ID, Desc, Price, Qty, ReleaseDate, NumDisks, Size, TypeDisk)
        {
            this.runTime = runTime;
        }
        public TimeSpan runtime
        {
            get { return runTime; }
            set { runTime = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + runTime;
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