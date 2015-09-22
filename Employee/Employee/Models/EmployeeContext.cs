using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Emplyee> Employees { get; set; }
    }
}