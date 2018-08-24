using System;
using System.Data.Sql;
namespace SamapleEntity
{
    public class ReadStudents
    {
        public void ReadData()
        {
            string server = "localhost";
            string  database = "Sample";
            string  uid = "root";
            string  password = "admin";
           // string connStr = "server = localhost; uid = root; port = 3306; pwd = admin; database = sample; ";

            // "//server=localhost;user=root;database=Sample;password=admin;";

            string connectionString;
            connectionString = "SERVER=" + server + ";port = 3306;" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

             connection.Open();
            string query = "select * from students";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySql.Data.MySqlClient.MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader[0]);
            }

            connection.Close();
        }
    }
}
