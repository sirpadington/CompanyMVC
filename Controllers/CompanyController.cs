using InterviewPractice.Sites.MVC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace InterviewPractice.Sites.MVC.Controllers
{
    public class CompanyController : Controller
    {
        private ServiceReference1.CompanyServiceClient companyService = new ServiceReference1.CompanyServiceClient();

        [Route("Company/{id}")]
        public ActionResult Index(int id)
        {
            var employees = companyService.GetEmployeesForACompany(id);
            var employeeModel = new EmployeeModel();
            foreach (var e in employees)
            {
                employeeModel.Employees.Add(new Employee() { BirthDate = e.Birthday, FirstName = e.FirstName, Id=e.Id, LastName=e.LastName});
            }
            return View(employeeModel);
        }
    }
}
