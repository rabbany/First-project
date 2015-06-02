using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookInformationAPP.DAL;
using BookInformationAPP.Model;

namespace BookInformationAPP.BLL
{
   public class BookManager
    {
        BookGetway aBookGetway =new BookGetway();
        Book book = new Book();


       public string Save(Book book)
       {


           Book isRegNoExist = IsBookIsbnExists(book.BookIsbn);

           if (isRegNoExist != null)
           {
               return "Isbn number  already exist" ;
           }


           if (aBookGetway.Save(book)>0)
           {
               return "save successfully";
           }
           else
           {
               return "unsuccessfull";
           }
       }


         // exist 

       public Book IsBookIsbnExists(string bookIsbn)
       {

           return aBookGetway.IsBookIsbnExists(bookIsbn);

       }

       internal List<Book> ShowAll()
       {
           return aBookGetway.ShowAll();
       }

       internal List<Book> GetbookBybookisbn(string bookisbn)
       {
           return aBookGetway.GetbookBybookisbn(bookisbn);

         
          // return searchedbook ;                                                                     
       }

       internal string delete(Book book)
       {
           if (aBookGetway.delete(book)> 0)
           {
               return "delete successfull ";
           }
           else
           {
               return "delete unseccessfull ";
           }
       }

       public List<Book> Update (Book book1)
       {
           
           
              //MessageBox.Show("updete successfull ");
               return aBookGetway.Update(book1);
       }

       public Book GetbookBybookId(string bookid)
       {
           return aBookGetway.GetbookBybookId(bookid);
       }
    }

    }

