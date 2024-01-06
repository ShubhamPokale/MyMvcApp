using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMvcApp100.Models;
namespace MyMvcApp100.Controllers
{
    public class EmployeesController : Controller
    {
        List<Employee> employees;

        public EmployeesController() {

            employees = new List<Employee>()
            {

                new Employee() {EmployeeFirstName="Jennifer", EmployeeLastName="Lawrence",  EmployeeDesignation="Brand Amasedor" },
                   new Employee() {EmployeeFirstName="Phineas", EmployeeLastName="Fletcher",  EmployeeDesignation="Team Lead" },
                      new Employee() {EmployeeFirstName="Baljit", EmployeeLastName="Sharma",  EmployeeDesignation="Programmer" },



            };

        

        }


        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List() {


            return View("List", employees );



        }

    }
}