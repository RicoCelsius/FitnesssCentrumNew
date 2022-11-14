using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;

namespace DAL
{
    public class dbconnection
    {
        private static Boolean isConnected = false;
        private static MySqlConnection connection = new MySqlConnection();

        public dbconnection()
        {
            this.connect();
        }
        private void connect()
        {
            try
            {
                string myConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=fitnessapp";
                connection = new MySqlConnection(myConnectionString);

                connection.Open();
                isConnected = true;

                Console.WriteLine("Connection to database succesfull");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                isConnected = false;

            }

        }

        public void InsertUpdateDelete(string query)
        {
            if (isConnected)
            {
                using (MySqlCommand sqlcomm = new MySqlCommand(query, connection))
                {
                    sqlcomm.ExecuteNonQuery();
                }
            }
        }
        public static DataTable Select(string query)
        {
            DataTable result = new DataTable();
            if (isConnected)
            {

                using (MySqlCommand sqlcomm = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = sqlcomm.ExecuteReader())
                    {
                        result.Load(reader);
                        return result;
                    }
                }
            }
            return result;
        }





    }



}


