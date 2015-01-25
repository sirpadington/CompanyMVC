using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewPractice.Sites.MVC.Models
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}