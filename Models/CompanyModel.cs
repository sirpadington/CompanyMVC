using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewPractice.Sites.MVC.Models
{
    public class CompanyModel
    {
        public CompanyModel()
        {
            Companies = new List<Company>();
        }
        public List<Company> Companies { get; set; }
    }

    public class Company
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}