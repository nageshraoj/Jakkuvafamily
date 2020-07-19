using System.Collections.Generic;

namespace StudDB.models
{
  
   public class ExamDetails
    {
        public int Id { get; set; }
        public string ExamName { get; set; }
        public List<Marks> marks { get; set; }
    }
}