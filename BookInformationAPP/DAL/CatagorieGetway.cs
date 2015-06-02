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
    class CatagorieGetway
    {

        string connection = ConfigurationManager.ConnectionStrings["BookconnString"].ConnectionString;
       // Catagorie aCatagorie=new Catagorie();


        public List<Catagorie> ShowAllBookCatagorie()
        {
            SqlConnection connections = new SqlConnection(connection);

            string query = "SELECT * FROM tbl_BookCatagorie";

            SqlCommand command = new SqlCommand(query, connections);

            connections.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Catagorie> catagories = new List<Catagorie>();

            while (reader.Read())
            {
                Catagorie aCatagorie = new Catagorie();
                aCatagorie.bookCatagorieId = int.Parse(reader["ID"].ToString());
                aCatagorie.bookCatagorieName = reader["BOOK_CATAGORIE"].ToString();


                catagories.Add(aCatagorie);
            }
            reader.Close();
            connections.Close();

            return catagories;
        }

        internal int Insert(Catagorie aCatagorie)
        {
            SqlConnection connections = new SqlConnection(connection);

            string query = "INSERT INTO tbl_BookCatagorie VALUES('" + aCatagorie.bookCatagorieName + "')";
            //insert student
            SqlCommand command = new SqlCommand(query, connections);

            connections.Open();

            int rowAffected = command.ExecuteNonQuery();

            connections.Close();

            return rowAffected;
        }
    }
}
