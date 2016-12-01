using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Movie : Entertainment
    {
        public string Director;
        public string Producer;
        public Movie(string Type, string ID, string Desc, double Price, int Qty, string ReleaseDate, int NumDisks, int Size, string TypeDisk, 
            TimeSpan runTime, string Director, string Producer) : base (Type, ID, Desc, Price, Qty, ReleaseDate, NumDisks, Size, TypeDisk, runTime)
        {
            this.Director = Director;
            this.Producer = Producer;
        }
        public string director
        {
            get { return Director; }
            set { Director = value; }
        }
        public string producer
        {
            get { return Producer; }
            set { Producer = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + Director + y + Producer;
        }
        public override string ToString()
        {
            return getDisplayText("\r\n");
        }
        public override string ToCSV()
        {
            return getDisplayText(",");
        }
    }
}