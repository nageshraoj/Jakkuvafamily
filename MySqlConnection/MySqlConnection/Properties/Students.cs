using System;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MySqlConnection
{
    public struct StudentInfo
    {
        public string StudReg;
        public string StudName;
        public DateTime StudDOB;
    }

    public class Students
    {
       public void DisplayStudents()
        {
            string connStr = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;
            var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            conn.Open();
            MySqlCommand mycommand = new MySqlCommand("select * from StudentMaster", conn);
            Console.WriteLine("\n\n----------------------------------------------------------------------------");
            Console.WriteLine("Student Number       |            Student Name        |    Date of Birth");
            Console.WriteLine("------------------------------------------------------------------------------");

            MySqlDataReader myData = mycommand.ExecuteReader();

            while (myData.Read())
            {
                Console.WriteLine("{0,-20} | {1,-30} | {2,-20} ", myData[0], myData[1], myData[2]);
            }
            Console.WriteLine("\n\n------------------------------------------------------------------------------");

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();

            myData.Close();
            conn.Close(); ;
        }

        public void AddStudnet()
        {
            string connStr = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;
            var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            conn.Open();
           
            StudentInfo info = new StudentInfo();
            info = ReadStudent();
            String query = "INSERT INTO StudentMaster (studno,studname,studdob) VALUES (@studname, @studname, @dob)";
            MySqlCommand mycommand = new MySqlCommand(query, conn);

            mycommand.Parameters.AddWithValue("@studno", info.StudReg);
            mycommand.Parameters.AddWithValue("@studname", info.StudName);
            mycommand.Parameters.AddWithValue("@dob", info.StudDOB);

            mycommand.ExecuteNonQuery();
            conn.Close();

        }

        public StudentInfo ReadStudent()
        {
            StudentInfo studentInfo = new StudentInfo();
            Console.Clear();
            Console.SetCursorPosition(8, 10); Console.Write("Student Number :");
            studentInfo.StudReg = Console.ReadLine();

            Console.SetCursorPosition(9, 11); Console.Write("Student Name :");
            studentInfo.StudName = Console.ReadLine();

            Console.SetCursorPosition(10, 12); Console.Write("Student Date of Birth :");
            studentInfo.StudDOB = Convert.ToDateTime( Console.ReadLine());

            return studentInfo;
        }
    }
}
