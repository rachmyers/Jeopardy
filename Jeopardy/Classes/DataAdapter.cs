using JeopardyGame.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyGame.Classes
{
    /// <summary>
    /// This class is to connect to the database and add and retrieve data from the database
    /// </summary>
    class DataAdapter
    {
        //Connection string
        static SqlConnection oConn = new SqlConnection("Data Source=cis2.ckwia8qkgyyj.us-east-1.rds.amazonaws.com;Initial Catalog=rm0909685;User ID=rm0909685;Password=909685");

        /// <summary>
        /// This method is used to connect to the database
        /// </summary>
        public static void Connect()
        {
            try
            {
                oConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This method disconnects from the database
        /// </summary>
        public static void Disconnect()
        {
            try
            {
                oConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// This method inserts data into the database.  The name of the table it uses is Jeopardy.  
        /// Records has two columns, an id and Data.  Data is designed to hold a serialized blob
        /// </summary>
        /// <param name="data">A blob of serialized data</param>
        public static void Insert(string data)
        {
            //SQL Insert statement
            string sqlIns = "INSERT INTO Jeopardy(Game) VALUES(@data)";

            try
            {
                //Connect to the db and insert the serialized object
                Connect();

                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                cmdIns.Parameters.AddWithValue("@data", data);
                cmdIns.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Disconnect from the db
                Disconnect();
            }
        }

        /// <summary>
        /// This method retrieves all serialized data from the database table Invoices.
        /// </summary>
        public static void Get()
        {
            //SQL statement to retrieve everything the Jeopardy table
            string sql = "SELECT * FROM Jeopardy";

            SqlCommand cmd = new SqlCommand(sql, oConn);

            try
            {
                //Connect to the db
                Connect();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Get records from the db and deserialize them
                    Serializer.DeSerializeNow(reader["Packages"].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Disconnect from the db
                Disconnect();

            }

        }

        /// <summary>
        /// This method returns a list of all the invoices in a List<Invoice>
        /// </summary>
        public static List<Game> GetGameResults()
        {
            //SQL statement to retrieve everything the Jeopardy table
            string sql = "SELECT * FROM Jeopardy";
            List<Game> games = new List<Game>();
            SqlCommand cmd = new SqlCommand(sql, oConn);

            try
            {
                //Connect to the db
                Connect();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Get records from the db and deserialize them
                    games = Serializer.DeSerializeNow(reader["Game"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Disconnect from the db
                Disconnect();

            }
            return games;
        }

    }
}
