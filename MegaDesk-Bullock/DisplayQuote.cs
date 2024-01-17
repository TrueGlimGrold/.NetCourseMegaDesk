using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Bullock
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string name, string width, string debth, string drawerNum, string material, string shipping)
        {
            InitializeComponent();
            this.Name = name;
            this.Width = width;
            this.Debth = debth;
            this.DrawerNum = drawerNum;
            this.Material = material;
            this.Shipping = shipping;
        }

        // repeat? 
        public string Name { get; set; }
        public string Width { get; set; }
        public string Debth { get; set; }
        public string DrawerNum { get; set; }
        public string Material { get; set; }
        public string Shipping { get; set; }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            nameOutput.Text = Name;
            widthOutput.Text = Width + " Inches";
            debthOutput.Text = Debth + " Inches";
            drawersOutput.Text = DrawerNum;
            materialOutput.Text = Material;
            shippingOutput.Text = Shipping;

            // Get the date 
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString();

            dateLabel.Text = date;

            // baseOutput


            //areaOutput
            int surfaceArea = Int32.Parse(Width) * Int32.Parse(Debth);
            int areaPrice = 0;

            if (surfaceArea > 1000)
                areaPrice = surfaceArea;

            areaOutput.Text = areaPrice + " $";

            // drawerPriceOutput
            int drawers = Int32.Parse(DrawerNum);

            int drawersPrice = drawers * 50;

            drawersPriceOutput.Text = drawersPrice + " $";

            // materialPriceOutput
            int materialPrice = 0;

            if (Material == "Oak")
            {
                materialPrice = 200;
            } else if (Material == "Laminate")
            {
                materialPrice = 100;
            } else if (Material == "Pine")
            {
                materialPrice = 50;
            } else if (Material == "Rosewood")
            {
                materialPrice = 300;
            } else if (Material == "Veneer")
            {
                materialPrice = 125;
            }

            materialPriceOutput.Text = materialPrice + " $";

            // shippingPriceOutput

            int shippingPrice = 0;

            if (Shipping == "3 Day")
            {
                if (surfaceArea < 1000)
                {
                    shippingPrice = 60;
                } else if ((surfaceArea >= 1000) && (surfaceArea <= 2000))
                {
                    shippingPrice = 70;
                } else if (surfaceArea > 2000)
                {
                    shippingPrice = 80;
                }
            } else if (Shipping == "5 Day")
            {
                if (surfaceArea < 1000)
                {
                    shippingPrice = 40;
                }
                else if ((surfaceArea >= 1000) && (surfaceArea <= 2000))
                {
                    shippingPrice = 50;
                }
                else if (surfaceArea > 2000)
                {
                    shippingPrice = 60;
                }
            } else if (Shipping == "7 Day")
            {
                if (surfaceArea < 1000)
                {
                    shippingPrice = 30;
                }
                else if ((surfaceArea >= 1000) && (surfaceArea <= 2000))
                {
                    shippingPrice = 35;
                }
                else if (surfaceArea > 2000)
                {
                    shippingPrice = 40;
                }
            }

            shippingPriceOutput.Text = shippingPrice + " $";

            // totalOuput

            int total = areaPrice + drawersPrice + materialPrice + shippingPrice + 200; // 200 is the base value

            totalOutput.Text = total + " $";

        }
    }
}
