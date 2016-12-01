using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductRWPatelP
{
    public partial class Form1 : Form
    {
        ProductList product1 = new ProductList();
        int index = 0;
        Product p;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            product1.Clear();
            product1.readFile("Products.csv");
            drawProduct();
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;
            btnWriteBin.Enabled = true;
            btnWrite.Enabled = true;
            MessageBox.Show("The file has been read.", "Read file");
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            product1.writeToFile("Product Output.csv");
            MessageBox.Show("Written file successfully, Check Debug Folder", "File written");
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            if (index == 1)
            {
                index = index - 1;
                drawProduct();
                btnPrevious.Enabled = false;
            }
            else
            {
                index += -1;
                p = product1.ElementAt(index);
                drawProduct();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            if (index + 1 == product1.Count - 1)
            {
                index += 1;
                p = product1.ElementAt(index);
                drawProduct();
                btnNext.Enabled = false;
            }
            else
            {
                index += 1;
                p = product1.ElementAt(index);
                drawProduct();
            }
        }
        private void btnReadBin_Click(object sender, EventArgs e)
        {
            product1.Clear();
            index = 0;
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;
            btnWriteBin.Enabled = true;
            btnWrite.Enabled = true;
            product1.readBin("ProductBinary.bin");
        
            drawProduct();
        }
        private void btnWriteBin_Click(object sender, EventArgs e)
        {
            product1.writeBin("ProductBinary.bin");
            MessageBox.Show("Written Bin file successfully, Check Debug Folder", "File written");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawSet(false, false, false, false, false, false, false, false);
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnWrite.Enabled = false;
            btnWriteBin.Enabled = false;
        }
        public void drawSet(bool dis1, bool dis2, bool dis3, bool dis4, bool dis5, bool dis6, bool dis7, bool dis8)
        {
            lblVar1.Visible = dis1;
            txtVar1.Visible = dis1;
            lblVar2.Visible = dis2;
            txtVar2.Visible = dis2;
            lblVar3.Visible = dis3;
            txtVar3.Visible = dis3;
            lblVar4.Visible = dis4;
            txtVar4.Visible = dis4;
            lblVar5.Visible = dis5;
            txtVar5.Visible = dis5;
            lblVar6.Visible = dis6;
            txtVar6.Visible = dis6;
            lblVar7.Visible = dis7;
            txtVar7.Visible = dis7;
            lblVar8.Visible = dis8;
            txtVar8.Visible = dis8;
        }
        public void drawBook()
        {
            Book b = (Book)p;
            drawSet(true, true, true, true, false, false, false, false);
            drawMedia();
            lblVar2.Text = "Author";
            txtVar2.Text = b.Author;
            lblVar3.Text = "Pages";
            txtVar3.Text = b.NumPages.ToString();
            lblVar4.Text = "Publisher";
            txtVar4.Text = b.Publisher;
        }
        public void drawMedia()
        {
            Media m = (Media)p;
            lblVar1.Text = "Release Date";
            txtVar1.Text = m.releaseDate;
        }
        public void drawEntertainment()
        {
            Entertainment p = (Entertainment)this.p;
            this.drawDisk();
            this.lblVar5.Text = "Runtime";
            this.txtVar5.Text = p.runTime.ToString();
        }
        public void drawMovie()
        {
            Movie p = (Movie)this.p;
            drawSet(true, true, true, true, true, true, true, false);
            drawEntertainment();
            lblVar6.Text = "Director";
            txtVar6.Text = p.Director;
            lblVar7.Text = "Producer";
            txtVar7.Text = p.Producer;
        }
        public void drawMusic()
        {
            Music p = (Music)this.p;
            drawSet(true, true, true, true, true, true, true, true);
            drawEntertainment();
            lblVar6.Text = "Artist";
            txtVar6.Text = p.Artist;
            lblVar7.Text = "Label";
            txtVar7.Text = p.Label;
            lblVar8.Text = "Genre";
            txtVar8.Text = p.Genre;
        }
        public void drawSoftware()
        {
            Software p = (Software)this.p;
            drawSet(true, true, true, true, true, false, false, false);
            drawDisk();
            lblVar5.Text = "Type Software";
            txtVar5.Text = p.TypeSoft;
        }
        public void drawDisk()
        {
            Disk p = (Disk)this.p;
            drawMedia();
            lblVar2.Text = "Number of Disks";
            txtVar2.Text = p.NumDisks.ToString();
            lblVar3.Text = "Data Size";
            txtVar3.Text = p.Size.ToString();
            lblVar4.Text = "Type Disk";
            txtVar4.Text = p.TypeDisk;
        }
        public void drawPants()
        {
            Pants p = (Pants)this.p;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel();
            lblVar4.Text = "Waist";
            txtVar4.Text = p.Waist.ToString();
            lblVar5.Text = "Inseam";
            txtVar5.Text = p.Inseam.ToString();
        }
        public void drawApparel()
        {
            Appreal p = (Appreal)this.p;
            lblVar1.Text = "Color";
            txtVar1.Text = p.Color;
            lblVar2.Text = "Manufacturer";
            txtVar2.Text = p.Manufacturer;
            lblVar3.Text = "Material";
            txtVar3.Text = p.Material;
        }
        public void drawDressShirt()
        {
            DressShirt p = (DressShirt)this.p;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel();
            lblVar4.Text = "Neck";
            txtVar4.Text = p.Neck.ToString();
            lblVar5.Text = "Sleeve";
            txtVar5.Text = p.Sleeve.ToString();
        }
        public void drawTShirt()
        {
            Tshirt p = (Tshirt)this.p;
            drawSet(true, true, true, true, false, false, false, false);
            drawApparel();
            lblVar4.Text = "Size";
            txtVar4.Text = p.Size.ToString();
        }
        public void drawProduct()
        {
            if (index >= 0 && index < product1.Count)
            {
                p = product1.ElementAt(index);
                txtType.Text = p.Type;
                txtID.Text = p.ID;
                txtDescription.Text = p.Desc;
                txtPrice.Text = p.Price.ToString("C");
                txtQuantity.Text = p.Qty.ToString();

                if (p.type == "Book")
                    drawBook();
                else if (p.type == "Software")
                    drawSoftware();
                else if (p.type == "Music")
                    drawMusic();
                else if (p.type == "Movie")
                    drawMovie();
                else if (p.type == "Pants")
                    drawPants();
                else if (p.type == "TShirt")
                    drawTShirt();
                else if (p.type == "DressShirt")
                    drawDressShirt();
            }
        }
    }
}
