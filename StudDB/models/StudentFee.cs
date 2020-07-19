using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudDB.models
{
    public class StudentFee
    {

        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime  PaidOn { get; set; }
        public int feepaid { get; set; }
    }
}