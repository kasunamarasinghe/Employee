using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.Models;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult EmployeeDetails(int id)
        {
            EmployeeContext employeecontext=new EmployeeContext();
           Emplyee employee= employeecontext.Employees.Single(emp => emp.EID == id);
           
           
            return View(employee);
        }

    }
}
