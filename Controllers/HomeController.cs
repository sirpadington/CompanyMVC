using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewPractice.Sites.MVC.Helpers;
using System.ServiceModel;
using InterviewPractice.Sites.MVC.Models;
namespace InterviewPractice.Sites.MVC.Controllers
{
    public class HomeController : Controller
    {
        private ServiceReference1.CompanyServiceClient companyService = new ServiceReference1.CompanyServiceClient();

        public ActionResult Index()
        {
            
            var allCompanies = companyService.GetAllCompanies();

            var companyModel = new CompanyModel();
            foreach (var company in allCompanies)
            {
                companyModel.Companies.Add(new Company { City = company.City, Id = company.Id, Name = company.Name, State = company.State });
            }


            return View(companyModel);
        }
    }
}