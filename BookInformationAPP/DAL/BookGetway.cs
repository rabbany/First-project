using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookInformationAPP.Model;

namespace BookInformationAPP.DAL
{
   public class BookGetway
    {
        string connection = ConfigurationManager.ConnectionStrings["BookconnString"].ConnectionString;
        Book book = new Book();

       public int Save(Book book)
       {
           SqlConnection connections = new SqlConnection(connection);

           string query = "INSERT INTO tbl_Books VALUES('" + book.BookName + "','" + book.BookIsbn + "','" +
                          book.BookAuther + "','" + book.BookPrice + "','"+book.bookCatagorieId+"')";

           SqlCommand command = new SqlCommand(query, connections);

           connections.Open();

          int rowAffacted= command.ExecuteNonQuery() ;

           connections.Close();
           return rowAffacted;

       }

       //exist

       public Book IsBookIsbnExists(string bookIsbn)
       {
           SqlConnection connections = new SqlConnection(connection);

           string query = "SELECT * FROM tbl_Books WHERE BOOK_ISBN = '" +bookIsbn + "'";

           SqlCommand command = new SqlCommand(query, connections);

           connections.Open();
           SqlDataReader reader = command.ExecuteReader();

           

           Book book = null;
           while (reader.Read())
           {


               if (book == null)
               {
                   book = new Book();
               }

               book.Id = int.Parse(reader["ID"].ToString());
               book.BookName = reader["BOOK_NAME"].ToString();
               book.BookIsbn = reader["BOOK_ISBN"].ToString();
               book.BookAuther = reader["BOOK_AUTHER"].ToString();
               book.BookPrice = int.Parse(reader["BOOK_PRICE"].ToString());

           }
           reader.Close();
           connections.Close();

           return book ;

       }

       internal List<Book> ShowAll()
       {
          
       
           SqlConnection sqlConnection = new SqlConnection(connection);

           string query = "SELECT * FROM tbl_Books ";

           SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

           sqlConnection.Open();

           SqlDataReader aReader = sqlCommand.ExecuteReader();

           List<Book> booksList = new List<Book>();

           while (aReader.Read())
           {
               Book book = new Book();

               book.Id = int.Parse(aReader["ID"].ToString());
               book.BookName = aReader["BOOK_NAME"].ToString();
               book.BookIsbn =(aReader["BOOK_ISBN"].ToString());
               book.BookAuther = aReader["BOOK_AUTHER"].ToString();
               book.BookPrice = decimal.Parse(aReader["BOOK_PRICE"].ToString());
               book.bookCatagorieId = aReader["BOOKCATAGORE_ID"].ToString() == "" ? (int?)null : int.Parse(aReader["BOOKCATAGORE_ID"].ToString());
              // student.DepartmentId = reader["DepartmentId"].ToString() == "" ? (int?)null : int.Parse(reader["DepartmentId"].ToString());
               booksList.Add(book);
           }

           aReader.Close();
           sqlConnection.Close();
           return booksList ;
       }

       internal List<Book> GetbookBybookisbn(string bookisbn)
       {
           SqlConnection connections = new SqlConnection(connection);

           string query = "SELECT * FROM tbl_Books WHERE BOOK_ISBN = '" + bookisbn + "' ";

           SqlCommand command = new SqlCommand(query, connections);

           connections.Open();

           SqlDataReader reader = command.ExecuteReader();

           List<Book> books = new List<Book>();

           if (reader.Read())
           {
              
               book.Id = int.Parse(reader["ID"].ToString());
               book.BookName = reader["BOOK_NAME"].ToString();
               book.BookIsbn = reader["BOOK_ISBN"].ToString();
               book.BookAuther = reader["BOOK_AUTHER"].ToString();
               book.BookPrice =Convert.ToDecimal( reader["BOOK_PRICE"].ToString());

               books.Add(book);
           }

           reader.Close();
           connections.Close();

           return books;
       }

       internal int delete( Book book)
       {
           SqlConnection connections = new SqlConnection(connection);
           
           string query = "DELETE FROM tbl_Books WHERE BOOK_ISBN ='" + book.BookIsbn + "'";

           SqlCommand command = new SqlCommand(query, connections);

           connections.Open();

           int rowAffacted = command.ExecuteNonQuery();

           connections.Close();
           return rowAffacted;
           
       }
       
       public List<Book> Update(Book book1)
       {

           SqlConnection connections = new SqlConnection(connection);

           string query = "UPDATE  tbl_Books set BOOK_NAME ='" + book1.BookName + "', BOOK_AUTHER ='" + book1.BookAuther + "',BOOK_PRICE ='" + book1.BookPrice + "'where BOOK_ISBN='"+book1.BookIsbn+"'";

           SqlCommand command = new SqlCommand(query, connections);

           connections.Open();

           SqlDataReader aReader = command.ExecuteReader();

           List<Book> booksList = new List<Book>();

           while (aReader.Read())
           {
               Book book = new Book();

               book.Id = int.Parse(aReader["ID"].ToString());
               book.BookName = aReader["BOOK_NAME"].ToString();
               book.BookIsbn = (aReader["BOOK_ISBN"].ToString());
               book.BookAuther = aReader["BOOK_AUTHER"].ToString();
               book.BookPrice = decimal.Parse(aReader["BOOK_PRICE"].ToString());
               booksList.Add(book);
           }
           aReader.Close();
           connections.Close();
           return booksList;
           
       }

       internal Book GetbookBybookId(string bookId)
       {
           
           SqlConnection connections = new SqlConnection(connection);

           string query = "SELECT * FROM tbl_Books WHERE ID = '" + bookId + "'";

           SqlCommand command = new SqlCommand(query, connections);

           connections.Open();
           SqlDataReader reader = command.ExecuteReader();

           Book book = null;


           while (reader.Read())
           {

               if (book == null)
               {
                   book = new Book();
               }

               book.Id = int.Parse(reader["ID"].ToString());
               book.BookName = reader["BOOK_NAME"].ToString();
               book.BookIsbn = reader["BOOK_ISBN"].ToString();
               book.BookAuther = reader["BOOK_AUTHER"].ToString();
               book.BookPrice = Convert.ToDecimal(reader["BOOK_PRICE"].ToString());
           }

           reader.Close();
           connections.Close();

           return book;
       }

     
    }
}
