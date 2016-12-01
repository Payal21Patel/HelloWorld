using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Disk : Media
    {
        public int NumDisks;
        public int Size;
        public string TypeDisk;
        public Disk(string Type, string ID, string Desc, double Price, int Qty, string ReleaseDate, int NumDisks, int Size, string TypeDisk) : 
            base (Type, ID, Desc, Price, Qty, ReleaseDate)
        {
            this.NumDisks = NumDisks;
            this.Size = Size;
            this.TypeDisk = TypeDisk;
        }
        public int numdisks
        {
            get { return NumDisks; }
            set { NumDisks = value; }
        }
        public int size
        {
            get { return Size; }
            set { Size = value; }
        }
        public string typedisk
        {
            get { return TypeDisk; }
            set { TypeDisk = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + Size + y + NumDisks + y + TypeDisk;
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