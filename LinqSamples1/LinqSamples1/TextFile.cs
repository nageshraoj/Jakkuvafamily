using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples1
{
    public class TextFile
    {
        public struct Student
        {
            public string num;
            public string Fname;
            public string Lname;

        }

        public List<Student> students = new List<Student>();

        public void AddData()
        {
            String Sfile = "/users/nagesh_mac/documents/students.txt";

            using (StreamWriter sr = File.AppendText(Sfile))
            {
                sr.WriteLine("A104,Meghana,Jakkuva");
                sr.WriteLine("A105,Teja,Jakkuva");
                sr.WriteLine("A106,Harika,Jakkuva");
                sr.WriteLine("A107,Lucky,Jakkuva");
                sr.WriteLine("A108,Kushi,Jakkuva");

                sr.Close();

               // Console.WriteLine(File.ReadAllText(Sfile));

            }

        }
        public void ShowData()
        {
            String Sfile = "/users/nagesh_mac/documents/students.txt";

            using (StreamReader sr = File.OpenText(Sfile))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    students.Add(new Student(){num=s.Split(',')[0],Fname= s.Split(',')[1], Lname= s.Split(',')[2] });
                   // Console.WriteLine(s);
                }
            }
        }

        public void ListData(string Sname)
        {

            var stud = from LStud in students where LStud.Fname.Contains("a") select LStud;

            foreach (var lstud in stud)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-30}", lstud.num, lstud.Fname,lstud.Lname);
            }
        }
    }
}
