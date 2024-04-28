using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EDP___Hospital_IS
{
    internal class Database
    {
        static readonly string server = "localhost";
        static readonly string user = "root";
        static readonly string password = "1234";
        static readonly string database = "hospital";
        public static string connection_string = "server= '" + server + "'; user='" + user + "'; password= '" + password + "'; database='" + database + "'";
        public MySqlConnection mySqlConnection = new MySqlConnection(connection_string);
        public bool connect_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false; 
            }
        }
        public bool close_db()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
