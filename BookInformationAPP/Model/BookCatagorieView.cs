using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationAPP.Model
{
    class BookCatagorieView
    {
        private int id;
        private string bookName;
        private string bookIsbn;
        private string bookAuther;
        private decimal bookPrice;
        public int bookCatagorieId { get; set; }
        public string bookCatagorieName { get; set; }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public string BookIsbn
        {
            get { return bookIsbn; }
            set
            {

                bookIsbn = value;
            }
        }

        public string BookAuther
        {
            get { return bookAuther; }
            set { bookAuther = value; }
        }

        public decimal BookPrice
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }
    }
}
