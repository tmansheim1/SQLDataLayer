using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace TestSqlConn
{
    internal class TestPlacementProgram
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "sql.cs.luc.edu";
                builder.UserID = "tmansheim";
                builder.Password = "p40901";
                builder.InitialCatalog = "Cocktail Flight";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nSignup! Enter uid:");
                    string id = Console.ReadLine();
                    Random r = new Random();
                    int uid = r.Next();

                    Console.WriteLine("\nEnter email:");
                    string email = Console.ReadLine();

                    Console.WriteLine("\nEnter username:");
                    string userName= Console.ReadLine();

                    Console.WriteLine("\nEnter password:");
                    string pass = Console.ReadLine();

                    Console.WriteLine("\nEnter date of birth (YYYY-MM-DD):");
                    string dob = Console.ReadLine();
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "insert into userAccounts(uid, password, userEmail, username, userBirthDate)\r\nvalues\r\n("+uid+", '"+pass+"', '"+email+"', '"+userName+"', '"+dob+"')";

                    Console.WriteLine(connection.ToString());

                    SqlCommand command = new SqlCommand(sql, connection);

                    SqlDataReader reader = command.ExecuteReader();
                       
                    connection.Close();
                        
                    

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }


            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
        }
    }
}*/
