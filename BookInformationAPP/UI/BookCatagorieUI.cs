using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookInformationAPP.BLL;
using BookInformationAPP.Model;

namespace BookInformationAPP.UI
{
    public partial class BookCatagorieUI : Form
    {
        public BookCatagorieUI()
        {
            InitializeComponent();
        }
        CatagorieManager aCatagorieManager=new CatagorieManager();

        public void bookCatagoriesaveButton_Click(object sender, EventArgs e)
        {
            string name = bookCatagorieTextBox.Text;

            Catagorie aCatagorie = new Catagorie() ;

          //  aCatagorie.bookCatagorieName = name;

            if (bookCatagorieTextBox.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }


            else


            {
                aCatagorie.bookCatagorieName = name;
               // (aCatagorieManager.Insert(aCatagorie))
                MessageBox.Show(aCatagorieManager.Insert(aCatagorie).ToString());
            }

        }
    }
}
