using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRWPatelP
{
    public class Music : Entertainment
    {
        public string Artist;
        public string Genre;
        public string Label;
        public Music(string Type, string ID, string Desc, double Price, int Qty, string ReleaseDate, int NumDisks, int Size, 
            string TypeDisk, TimeSpan runTime, string Artist, string Genre, string Label) : 
            base (Type, ID, Desc, Price, Qty, ReleaseDate, NumDisks, Size, TypeDisk, runTime)
        {
            this.Artist = Artist;
            this.Genre = Genre;
            this.Label = Label;
        }
        public string artist
        {
            get { return Artist; }
            set { Artist = value; }
        }
        public string genre
        {
            get { return Genre; }
            set { Genre = value; }
        }
        public string label
        {
            get { return Label; }
            set { Label = value; }
        }
        public override string getDisplayText(string y)
        {
            return base.getDisplayText(y) + y + Artist + y + Genre + y + Label;
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