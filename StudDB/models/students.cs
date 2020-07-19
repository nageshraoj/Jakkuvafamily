namespace StudDB.models
{
    public class students
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public StudentMarks Marks { get; set; }

        public StudentFee Fee { get; set; }
    }
}