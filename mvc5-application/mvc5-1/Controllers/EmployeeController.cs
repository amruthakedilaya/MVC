using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc5_1.Models;

namespace mvc5_1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Emplyee
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }

        public ActionResult Index(int departmentid)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp => emp.DepartmentId == departmentid).ToList();
            return View(employees);
        }
    }
}