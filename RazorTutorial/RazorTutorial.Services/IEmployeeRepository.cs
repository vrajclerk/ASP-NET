using RazorTutorial.Models;
using System;
using System.Collections.Generic;

namespace RazorTutorial.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
