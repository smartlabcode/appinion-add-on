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

        public bool checkPresentations(String userInputId)
        {

            int i = 0;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            string connString = builder.ToString();

            builder = null;

            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                dbConn = new MySqlConnection(connString);
                dbConn.Open();

                string stm = "SELECT * FROM prezentacije WHERE gen_kod='" + userInputId + "'";

                cmd = new MySqlCommand(stm, dbConn);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    i++;
                }
                
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: {0}", ex.ToString());
            }

            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                if( dbConn != null)
                {
                    dbConn.Close();
                }
            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<object> getPresentations(String userInputId)
        {

            var retList = new List<object>();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            string connString = builder.ToString();

            builder = null;

            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                dbConn = new MySqlConnection(connString);
                dbConn.Open();

                string stm = "SELECT pitanje FROM pitanja WHERE id_prezentacije='" + userInputId + "'";

                cmd = new MySqlCommand(stm, dbConn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pitanje p = new Pitanje();

                    p.pitanje = reader.GetString("pitanje");

                    retList.Add(p);
                }

            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: {0}", ex.ToString());
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (dbConn != null)
                {
                    dbConn.Close();
                }
            }

            return retList;

        }

        public List<List<string>> getAnswers(String Pitanje)
        {
            var retList = new List<List<string>> ();
            var odgovori = new List<string>();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            string connString = builder.ToString();

            builder = null;

            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                dbConn = new MySqlConnection(connString);
                dbConn.Open();

                string stm = "SELECT * FROM pitanja WHERE pitanje='" + Pitanje + "'";

                cmd = new MySqlCommand(stm, dbConn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    odgovori.Add(reader.GetString("odgovor1"));
                    odgovori.Add(reader.GetString("odgovor2"));
                    if(reader.GetString("odgovor3") != null){
                        odgovori.Add(reader.GetString("odgovor3"));
                    }
                    if (reader.GetString("odgovor4") != null)
                    {
                        odgovori.Add(reader.GetString("odgovor4"));
                    }

                    retList.Add(odgovori);
                }

            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: {0}", ex.ToString());
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (dbConn != null)
                {
                    dbConn.Close();
                }
            }

            return retList;
        }

    }

    public class Pitanje
    {
        public string pitanje;

        public override string ToString()
        {
            return string.Format(pitanje);
        }
    }

}
