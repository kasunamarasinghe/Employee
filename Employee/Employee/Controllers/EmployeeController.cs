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

        public ActionResult Index()
        {
            EmployeeContext employeecontext = new EmployeeContext();
            List<Emplyee> employees = employeecontext.Employees.ToList();
            return View(employees);
        }

        public ActionResult EmployeeDetails(int id)
        {
            EmployeeContext employeecontext=new EmployeeContext();
           Emplyee employee= employeecontext.Employees.Single(emp => emp.EID == id);
            return View(employee);
        }

    }
}
