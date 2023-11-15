using System;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using SQLDataLayer;

namespace TestSqlConn
{
    class TestAccessProgram
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
                    Console.WriteLine("\nEnter Username:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT * FROM userAccounts";
                    Console.WriteLine(connection.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //returns true while there are more lines to read
                            while (reader.Read())
                            {
                                //Console.WriteLine("UID: "+reader.GetInt64(0)+" password: "+reader.GetString(1)+" email: "+reader.GetString(2));
                                if (reader.GetString(3)==userName)
                                {
                                    Console.WriteLine("UID: " + reader.GetInt64(0) + " password: " + reader.GetString(1) + " email: " + reader.GetString(2));
                                }
                            }
                            connection.Close();
                        }
                    }
                    
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
} 