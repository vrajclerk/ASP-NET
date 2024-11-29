using RazorTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorTutorial.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository() {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id=1, Name="Vraj", Department=Dept.IT,
                    Email="vrajclerk04@gmail.com" ,PhotoPath="vraj.png"},
                new Employee() {Id=2, Name="Raj", Department=Dept.HR,
                    Email="raj@gmail.com" ,PhotoPath="raj.png"},
                new Employee() {Id=3, Name="abc", Department=Dept.Payroll,
                    Email="vrajclerk04@gmail.com" ,PhotoPath="vraj.png"},
                new Employee() {Id=4, Name="xyz", Department=Dept.HR,
                    Email="vrajclerk04@gmail.com" ,PhotoPath="vraj.png"}

            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        IEnumerable<Employee> IEmployeeRepository.GetAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
