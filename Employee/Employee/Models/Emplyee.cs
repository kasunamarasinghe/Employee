using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    [Table("Employee")]
    public class Emplyee
    {
        [Key] 
        public int EID { get; set; }
        public String EmployeeName{ get; set; }
        public String  Gender{ get; set; }
        public String City{ get; set; }
    }
}