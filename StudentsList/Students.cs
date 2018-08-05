using System;
using System.Collections.Generic;

namespace StudentsList
{
    public struct strStudent
    {
        public int Number;
        public string Name;
        public sex Gender;
    }

    public enum sex
    {
        male,
        femail
    }

   


    public class Students
    {
        public List<strStudent> lstStudents = new List<strStudent>();
       
        public void AddStudent(strStudent nStudent)
        {
            lstStudents.Add(nStudent);
        }

        public void ShowStudent(int sno)
        {
            List<strStudent> slist = new List<strStudent>() { lstStudents.Find(x => x.Number == sno) };
            foreach (var slst in slist)
            {
                Console.WriteLine(slst.Name);
            }

        }
    }
}
