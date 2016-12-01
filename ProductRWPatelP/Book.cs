using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Book : Media
    {
        public string Author;
        public int NumPages;
        public string Publisher;
        public Book(string Type, string ID, string Desc, double Price, int Qty, String ReleaseDate, int NumPages, string Author, string Publisher) 
            : base (Type, ID, Desc, Price, Qty, ReleaseDate)
        {
            this.Author = Author;
            this.NumPages = NumPages;
            this.Publisher = Publisher;
        }
        public string author
        {
            get { return Author; }
            set { Author = value; }
        }
        public int numPages
        {
            get { return NumPages; }
            set { NumPages = value; }
        }
        public string publisher
        {
            get { return Publisher; }
            set { Publisher = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + NumPages + y + Publisher + y + Author;
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