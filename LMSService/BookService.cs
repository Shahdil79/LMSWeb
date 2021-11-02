using LMSService.Context;
using LMSService.Model;
using LMSService.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSService
{
    public class BookService
    {
        LibraryContext context = new LibraryContext();
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryConnection"].ConnectionString);
        //Get Books By Linq
        public List<Book> GetBooks()
        {
            return context.Books.ToList();
        }

        //Get Books By Store Procedure
        public List<Book> GetBooksBySP()
        {
            List<Book> lstBooks = new List<Book>();
            SqlCommand com = new SqlCommand("sp_GetBooks", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind EmpModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {
                lstBooks.Add(

                    new Book
                    {

                        bookId = Convert.ToInt32(dr["bookId"]),
                        name = Convert.ToString(dr["name"]),
                        authorName = Convert.ToString(dr["authorName"]),
                        categoryId = Convert.ToInt32(dr["categoryId"])

                    }
                    );
            }

            return lstBooks;
        }
    }
}
