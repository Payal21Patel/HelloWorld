using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Software : Disk
    {
        public string TypeSoft;
        public Software(string Type, string ID, string Desc, double Price, int Qty, string ReleaseDate, int NumDisks, int Size, 
            string TypeDisk, string TypeSoft) : base (Type, ID, Desc,Price, Qty, ReleaseDate, NumDisks, Size, TypeDisk)
        {
            this.TypeSoft = TypeSoft;
        }
        public string typesoft
        {
            get { return TypeSoft; }
            set { TypeSoft = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + TypeSoft;
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