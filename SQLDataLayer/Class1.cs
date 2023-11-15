using System;
using System.Data.SqlClient;


namespace SQLDataLayer
{

    public class SQLConn
    {
        private SqlConnection conn;

        public SQLConn ()
        {
            conn = new SqlConnection ();
            conn.ConnectionString = "Server=sql.cs.luc.edu;uid=;pwd=";
            conn.Open ();

        }


    }
}
