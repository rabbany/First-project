using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BookInformationAPP.BLL;
using BookInformationAPP.Model;

namespace BookInformationAPP.UI
{
    public partial class BookInformationUI : Form
    {
        public BookInformationUI()
        {
            InitializeComponent();
        }

         BookManager aBookManager = new BookManager();
         Book book = new Book();
         CatagorieManager aCatagorieManager=new CatagorieManager();


        public void saveButton_Click_1(object sender, EventArgs e)
        {
            if (bookNameTextBox.Text == "" || bookIsbnTextBox.Text == "" || bookAutherTextBox.Text == "" ||
                bookPriceTextBox.Text == "" || bookCatagorieComboBox.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {

                book.BookName = bookNameTextBox.Text;
                book.BookIsbn = bookIsbnTextBox.Text;
                book.BookAuther = bookAutherTextBox.Text;
                book.BookPrice = Convert.ToDecimal(bookPriceTextBox.Text);
                book.bookCatagorieId = int.Parse(bookCatagorieComboBox.SelectedValue.ToString());

                MessageBox.Show(aBookManager.Save(book));
        }

            ShowAllBooks();

            AllTextBookClear();
        }

        private void ShowAllBooks()
        {

            List<Book> booksList = aBookManager.ShowAll(); // eta amader likhte hobe 



            bookListView.Items.Clear();

            foreach (var index in booksList)
            {
                ListViewItem listViewItem = new ListViewItem(index.Id.ToString());
                listViewItem.SubItems.Add(index.BookName);
                listViewItem.SubItems.Add(index.BookIsbn);
                listViewItem.SubItems.Add(index.BookAuther);
                listViewItem.SubItems.Add(index.BookPrice.ToString());
                listViewItem.SubItems.Add(index.bookCatagorieId.ToString());

                bookListView.Items.Add(listViewItem);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                ShowAllBooks();
            }
            else
            {
                string bookisbn = searchTextBox.Text;


                List<Book> books = aBookManager.GetbookBybookisbn(bookisbn);

                LoadListViewBybooks(books);
                
            }

              AllTextBookClear();
        }

        private void LoadListViewBybooks(List<Book> books)
        {

            bookListView.Items.Clear();
            foreach (var book in books)
            {
                ListViewItem item = new ListViewItem(book.Id.ToString());
                item.SubItems.Add(book.BookName);
                item.SubItems.Add(book.BookIsbn);
                item.SubItems.Add(book.BookAuther);
                item.SubItems.Add(book.BookPrice.ToString());


                bookListView.Items.Add(item);
            }
        }
         
        private List<Book> abook = new List<Book>();

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleateMathod();
           
        }

        private void DeleateMathod()
        {
            book.BookName = bookNameTextBox.Text;
            book.BookIsbn = bookIsbnTextBox.Text;
            book.BookAuther = bookAutherTextBox.Text;
            book.BookPrice = Convert.ToDecimal(bookPriceTextBox.Text);

            MessageBox.Show(aBookManager.delete(book));
            ShowAllBooks();
            AllTextBookClear();
        }

        private void bookListView_DoubleClick(object sender, EventArgs e)
        {
            bookList_DoubleClick();
           

           
        }

        private void bookList_DoubleClick()
        {
            if (bookListView.SelectedItems.Count > 0)
            {
             
                ListViewItem firstSelectedItem = bookListView.SelectedItems[0];
                string bookid = firstSelectedItem.Text;

                Book book = aBookManager.GetbookBybookId(bookid);

                bookNameTextBox.Text = book.BookName;
                bookIsbnTextBox.Text = book.BookIsbn;
                bookAutherTextBox.Text = book.BookAuther;
                bookPriceTextBox.Text = Convert.ToDecimal(book.BookPrice).ToString();


            }


        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            UpdateMathod();
           
        }

        private void UpdateMathod()
        {

            book.BookName = bookNameTextBox.Text;
            book.BookIsbn = bookIsbnTextBox.Text;
            book.BookAuther = bookAutherTextBox.Text;
            book.BookPrice = Convert.ToDecimal(bookPriceTextBox.Text.ToString());

            List<Book> abook = aBookManager.Update(book);

            bookListView.Items.Clear();

            foreach (var index in abook)
            {
                ListViewItem listViewItem = new ListViewItem(index.Id.ToString());
                listViewItem.SubItems.Add(index.BookName);
                listViewItem.SubItems.Add(index.BookIsbn);
                listViewItem.SubItems.Add(index.BookAuther);
                listViewItem.SubItems.Add(index.BookPrice.ToString());

                bookListView.Items.Add(listViewItem);


            }
            ShowAllBooks();
            AllTextBookClear();
        }

        public void AllTextBookClear()
        {
            bookNameTextBox.Text = "";
            bookIsbnTextBox.Text = "";
            bookAutherTextBox.Text = "";
            bookPriceTextBox.Text = "";
        }

        private void BookiNformationUI_Load(object sender, EventArgs e)
        {
            ShowAllBookCatagorie();
            
            
            ShowAllBooks();
        }

        private void ShowAllBookCatagorie()
        {
            List<Catagorie> catagories = aCatagorieManager.ShowAllBookCatagorie();

            bookCatagorieComboBox.DisplayMember = "bookCatagorieName";
            bookCatagorieComboBox.ValueMember = "bookCatagorieId";
            bookCatagorieComboBox.DataSource = null;

            bookCatagorieComboBox.DataSource = catagories;




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bookListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookCatagorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookList_DoubleClick();
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookList_DoubleClick();
            DeleateMathod();
        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }


}

