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

        public ActionResult EmployeeDetails()
        {
            Emplyee employee=new Emplyee()
            {
                EID=1,
                EmployeeName="Kasun",
                Gender="Male",
                City="Colombo"
            };
            return View(employee);
        }

    }
}
