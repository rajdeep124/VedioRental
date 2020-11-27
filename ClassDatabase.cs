using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedioRental
{
    public class ClassDatabase
    {
//code to connect the SQL Server Database with the Visual studio
        private SqlConnection Obj_Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader Data_Reader;
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString;

        //code of customerid to declare variable as integer
        public int CustomerID, MovieID;

        //code to connect the SQL Server Database with the Visual studio
        public ClassDatabase()
        {
            string ConnString = @"Data Source=LAPTOP-II78TMAS\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }

//code to fill the customer data by using select query
        public DataTable FillCustomer_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Customer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

//code to fill the movies data by using select query
        public DataTable FillMovies_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Movies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

//code to fill the rental data by using select query
        public DataTable FillRent_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From RentedMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

//code to fill the customer data by using insert query
        public string CustomerInsert(string FName, string LName, string Phone, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Phone)";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Phone", Phone);
                Cmd.CommandText = QueryString;
//connection opened
                Obj_Conn.Open();
// Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Details are filled completely";
            }
            catch (Exception ex)
            {
// code to show error Message
                return ex.Message;
            }
            finally
            {
// close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

//code to update the customer data by using insert query
        public string CustomerUpdate(string FName, string LName, string Phone, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "update Customer set FirstName = @FirstName,LastName = @LastName,Address = @Address, Phone = @Phone where CustID =@CustID";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Phone", Phone);
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.CommandText = QueryString;
//connection opened
                Obj_Conn.Open();
// Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Details Updated Completly";
            }
            catch (Exception ex)
            {
// code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

//code to delete the customer data by using insert query
        public string CustomerDelete()
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Delete from Customer where CustID =@CustID";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.CommandText = QueryString;
//connection opened
                Obj_Conn.Open();
// Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Details Deleted Completely";
            }
            catch (Exception ex)
            {
// code to show error Message
                return ex.Message;
            }
            finally
            {
// code to close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        //code to fill the movie data by using insert query
        public string MovieInsert(string rating, string title, string year, string Rental_Cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Movies(Rating,Title,Year,Rental_Cost,Copies,Plot,Genre) Values(@Rating,@Title,@Year,@Rental_Cost,@Copies,@Plot,@Genre)";
                Cmd.Parameters.AddWithValue("@Rating", rating);
                Cmd.Parameters.AddWithValue("@Title", title);
                Cmd.Parameters.AddWithValue("@Year", year);
                Cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Cmd.Parameters.AddWithValue("@Copies", copies);
                Cmd.Parameters.AddWithValue("@Plot", plot);
                Cmd.Parameters.AddWithValue("@Genre", genre);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies Details are filled completely";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

       
        //code to fill the customer data by using update query
        public string MovieUpdate(string rating, string title, string year, string Rental_Cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "update Movies set rating=@rating,title=@title,year=@year,rental_cost=@rental_cost,copies=@copies,plot=@plot,genre=@genre where MovieID=@MovieID";
                Cmd.Parameters.AddWithValue("@rating", rating);
                Cmd.Parameters.AddWithValue("@title", title);
                Cmd.Parameters.AddWithValue("@year", year);
                Cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Cmd.Parameters.AddWithValue("@Copies", copies);
                Cmd.Parameters.AddWithValue("@Plot", plot);
                Cmd.Parameters.AddWithValue("@Genre", genre);
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies Details are updated completely";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        //code to fill the customer data by using delete query
        public string MovieDelete()
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Delete from Movies where MovieID =@MovieID";
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movie Details Deleted Completely";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // code to close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public DataTable AllMovies()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From AllMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

//code to add the view and to display the data of rented out movies which does not had the return date of the movie
        public DataTable RentedOut_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From RentedOut";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        //code to fill the movie data by using insert query
        public string IssueMovie(DateTime Issue_date)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into RentedMovies(MovieIDFK,CustIDFK,DateRented,DateReturned) values(@MovieID,@CustID,@Issue_date,NULL)";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.Parameters.AddWithValue("@MovieID",MovieID);
                Cmd.Parameters.AddWithValue("@Issue_date", Issue_date);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies issued to customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        //code to fill the customer data by using update query
        public string ReturnMovie(string rating, string title, string year, string Rental_Cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "update Movies set rating=@rating,title=@title,year=@year,rental_cost=@rental_cost,copies=@copies,plot=@plot,genre=@genre where MovieID=@MovieID";
                Cmd.Parameters.AddWithValue("@rating", rating);
                Cmd.Parameters.AddWithValue("@title", title);
                Cmd.Parameters.AddWithValue("@year", year);
                Cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Cmd.Parameters.AddWithValue("@Copies", copies);
                Cmd.Parameters.AddWithValue("@Plot", plot);
                Cmd.Parameters.AddWithValue("@Genre", genre);
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies Details are updated completely";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

    }
}
