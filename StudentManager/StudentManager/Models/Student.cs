using System;
using System.Collections.Generic;
namespace StudentManager.Models
{
    public struct lstStudnet
    {
        public string regNum { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

    }
    
    public static class Student
    {
        public static List<lstStudnet> studnets = new List<lstStudnet>();
    }
}
