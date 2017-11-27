using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using FOE.Models;
using MySql.Data.MySqlClient;

namespace FOE.DataAccess
{
    class PatientService
    {
        // read db configurations
        private static String dbname = ConfigurationManager.AppSettings["database.dbname"];
        private static String host = ConfigurationManager.AppSettings["database.host"];
        private static String username = ConfigurationManager.AppSettings["database.username"];
        private static String password = ConfigurationManager.AppSettings["database.password"];
        private static String charset = ConfigurationManager.AppSettings["database.charset"];

        public static Patient GetPatientByPhone(String searchphone)
        {
            Patient p = null;
            // try to load patient from db
            MySqlConnectionStringBuilder connection = new MySqlConnectionStringBuilder();
            connection.Server = host;
            connection.UserID = username;
            connection.Password = password;
            connection.Database = dbname;

            // build connection string
            String connectionString = connection.ToString();
            connection = null;

            Console.WriteLine(connectionString);

            using (MySqlConnection dbConnection = new MySqlConnection(connectionString))
            {
                String query = "select * from yaf_patient where phone = " + searchphone;
                MySqlCommand command = new MySqlCommand(query, dbConnection);
                dbConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = 0;
                    Int32.TryParse(reader["id"].ToString(), out id);
                    String name = reader["name"].ToString();
                    String phone = reader["phone"].ToString();
                    String gender = reader["gender"].ToString();

                    p = new Patient(id, name, phone, gender);
                }
            }

            return p;
        }

        public static void CreatePatient(Patient p)
        {
            MySqlConnectionStringBuilder connection = new MySqlConnectionStringBuilder();
            connection.Server = host;
            connection.UserID = username;
            connection.Password = password;
            connection.Database = dbname;

            // build connection string
            String connectionString = connection.ToString();
            connection = null;

            Console.WriteLine(connectionString);

            using (MySqlConnection dbConnection = new MySqlConnection(connectionString))
            {
                String query = "insert into yaf_patient(name, phone, gender) values";
                query += "('" + p.name + "',";
                query += "'" + p.phone + "',";
                query += "'" + p.gender + "')";

                Console.WriteLine(query);

                MySqlCommand command = new MySqlCommand(query, dbConnection);
                dbConnection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
