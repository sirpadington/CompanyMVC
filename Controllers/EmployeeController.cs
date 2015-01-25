using InterviewPractice.Sites.MVC.Models;
using System;
using System.Web.Mvc;

namespace InterviewPractice.Sites.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private ServiceReference1.CompanyServiceClient companyService = new ServiceReference1.CompanyServiceClient();
        [Route("Employee/{id}")]
        public ActionResult Index(int id)
        {
            var employee = companyService.GetEmployee(id);
            var employeeModel = new Employee() { Id = employee.Id, LastName = employee.LastName, FirstName = employee.FirstName, BirthDate =employee.Birthday};
            return View(employeeModel);
        }
    }
}
