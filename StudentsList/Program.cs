using System;

namespace StudentsList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Students studentsList = new Students();
            strStudent nStud = new strStudent();
            nStud.Number = 100; nStud.Name = "Tarun";nStud.Gender = sex.male;
            studentsList.AddStudent(nStud);

            nStud.Number = 101; nStud.Name = "Barath"; nStud.Gender = sex.male;
            studentsList.AddStudent(nStud);

            nStud.Number = 102; nStud.Name = "Mumar"; nStud.Gender = sex.male;
            studentsList.AddStudent(nStud);

            nStud.Number = 103; nStud.Name = "Radha"; nStud.Gender = sex.femail;
            studentsList.AddStudent(nStud);

            studentsList.ShowStudent(100);

        }
    }
}
