using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWPatelP
{
    class ProductList : List<Product>
    {
          public void writeToFile(string file)
        {
            StreamWriter write = new StreamWriter(file);
            foreach (Product p in this)
            {
                write.WriteLine(p.ToCSV());
            }
            write.Close();
        }
        public void readFile(string file)
        {
            StreamReader read = new StreamReader(file);
            string[] container;

            string line;
            while ((line = read.ReadLine()) != null)
            {
                container = line.Split(',');
                Add(container); 

            }
            read.Close();
        }
      
        public void writeBin(string file)
        {
            BinaryWriter binOutput = new BinaryWriter(new FileStream(file, FileMode.Create, FileAccess.Write));
            foreach (Product product in this)
            {
                binOutput.Write(product.ToCSV() + Environment.NewLine);
            }
            binOutput.Close();
        }

        public void readBin(string fileName)
        {
            BinaryReader binaryReader = new BinaryReader((Stream)new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read));
            string[] box;
            while (binaryReader.PeekChar() != -1)
            {
                box = null;
                box = binaryReader.ReadString().Split(',');
                Add(box);
            }
            binaryReader.Close();
        }
        public void Add(string[] item)
        {
            if (item[0] == "DressShirt") { dressShirt(item); }
            else if (item[0] == "Pants") { pants(item); }
            else if (item[0] == "TShirt") { tshirt(item); }
            else if (item[0] == "Book") { book(item); }
            else if (item[0] == "Software") { software(item); }
            else if (item[0] == "Movie") { movie(item); }
            else if (item[0] == "Music") { music(item); }
        }
        public void dressShirt(string[] items)
        {
            Add(new DressShirt(items[0], items[1], items[2], double.Parse(items[3]),
                int.Parse(items[4]), items[5], items[6], items[7], int.Parse(items[8]),
                int.Parse(items[9])));
        }
        public void pants(string[] items)
        {
            Add(new Pants(items[0], items[1], items[2],
            double.Parse(items[3]), int.Parse(items[4]), items[5], items[6], items[7], int.Parse(items[8]),
            int.Parse(items[9])));
        }
        public void tshirt(string[] items)
        {
            Add(new Tshirt(items[0], items[1], items[2], double.Parse(items[3]),
            int.Parse(items[4]), items[5], items[6], items[7], items[8]));
        }
        public void book(string[] items)
        {
            Add((new Book(items[0], items[1], items[2], double.Parse(items[3]),
            int.Parse(items[4]), items[5], int.Parse(items[6]), items[7], items[8])));
        }
        public void software(string[] items)
        {
            Add(new Software(items[0], items[1], items[2],
            double.Parse(items[3]), int.Parse(items[4]), items[5], int.Parse(items[6]), int.Parse(items[7]),
            items[8], items[9]));
        }
        public void movie(string[] items)
        {
            Add(new Movie(items[0], items[1], items[2],
            double.Parse(items[3]), int.Parse(items[4]), items[5], int.Parse(items[6]), int.Parse(items[7]),
            items[8], TimeSpan.Parse(items[9]), items[10], items[11]));
        }
        public void music(string[] items)
        {
            Add(new Music(items[0], items[1], items[2], double.Parse(items[3]),
            int.Parse(items[4]), items[5], int.Parse(items[6]), int.Parse(items[7]), items[8],
            TimeSpan.Parse(items[9]), items[10], items[11], items[12]));
        }
        public override string ToString()
        {
            string str = "";
            foreach (Product p in (List<Product>)this)
                str = str + p.ToString() + "\r\n\r\n";
            return str;
        }
        public string ToCSV()
        {
            string str = "";
            foreach (Product p in (List<Product>)this)
                str = str + p.ToCSV() + "\r\n";
            return str;
        }
    }
}
