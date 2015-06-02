using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInformationAPP.UI
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookInformationUI aBookInformationUi= new BookInformationUI();
             aBookInformationUi.Show();
              
        }

        private void bookCatagorieButton_Click(object sender, EventArgs e)
        {
            BookCatagorieUI aBookCatagorieUi = new BookCatagorieUI();
            aBookCatagorieUi.Show();
        }
    }
}
