using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace appinion_add_on
{
    class ConnectionClass
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "appinion";
        private const String UID = "root";
        private const String PASSWORD = "";

        private static MySqlConnection dbConn;

        public String Gen_kod { get; private set; }

        public ConnectionClass(String gen_kod)
        {

            Gen_kod = gen_kod;

        }

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            String connString = builder.ToString();

            builder = null;

            dbConn = new MySqlConnection(connString);


        }

        public static List<ConnectionClass> GetPresentations()
        {
            List<ConnectionClass> prezentacije = new List<ConnectionClass>;

            String query = "SELECT * FROM prezentacije";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
            }

            dbConn.Close();


            return prezentacije;

        }

        public bool checkPresentations()
        {
            return false;
        }


    }
}
