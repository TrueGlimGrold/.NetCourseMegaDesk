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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNavAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuote addQuote = new AddQuote();
            addQuote.ShowDialog();
            this.Close();
        }

        private void btnNavVeiw_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.ShowDialog();
            this.Close();
        }

        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.ShowDialog();
            this.Close();
        }
    }
}
