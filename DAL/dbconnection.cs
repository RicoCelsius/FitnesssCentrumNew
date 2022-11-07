using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class dbconnection
    {
        private Boolean isConnected = false;
        private MySqlConnection connection = new MySqlConnection();

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

            }

        }

        public void query(string query)
        {
            if (isConnected)
            {
                using (MySqlCommand sqlcomm = new MySqlCommand(query, connection))
                {
                    sqlcomm.ExecuteNonQuery();
                }
            }
        }




    }



}


