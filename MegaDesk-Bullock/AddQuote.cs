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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void submitQuote_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string width = textWidth.Text;
            string debth = textDebth.Text; 
            string drawerNum = textDrawers.Text;
            string material = comboMaterial.Text;
            string shipping = comboRushOrder.Text;

            int numWidth = 0;
            int numDebth = 0;

            try
            {
                numWidth = Int32.Parse(width);
                warningLabel.Text = "";
            }
            catch (Exception a)
            {
                warningLabel.Text = "Width needs to be a whole number.";
            }

            try
            {
                numDebth = Int32.Parse(debth);
                warningLabel.Text = "";
            }
            catch (Exception a)
            {
                warningLabel.Text = "Debth needs to be a whole number.";
            }

            if (numWidth < 24 || numWidth > 96)
            {
                warningLabel.Text = "Width needs to be within 24 - 96 inches";
            }
            else if (numDebth < 12 || numDebth > 48)
            {
                warningLabel.Text = "Debth needs to be within 12 - 48 inches";
            }
            else
            {
                warningLabel.Text = "";
            }

            if (warningLabel.Text == "")
            {
                // Switch to display the quote
                this.Hide();
                // send values to DisplayQuote
                DisplayQuote displayQuote = new DisplayQuote(name, width, debth, drawerNum, material, shipping);
                displayQuote.ShowDialog();
                this.Close();
            }
        }

        private void textDebth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                warningLabel.Text = "Debth only takes whole number values";
            }
            else
            {
                warningLabel.Text = "";
            }
        }

        private void textWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                warningLabel.Text = "Width only takes whole number values";
            }
            else
            {
                warningLabel.Text = "";
            }
        }
    }
}
