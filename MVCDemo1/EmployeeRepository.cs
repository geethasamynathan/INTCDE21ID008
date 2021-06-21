using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo1.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> employees = new List<Employee>();
        public EmployeeRepository()
        {
            Employee emp1 = new Employee(){ Id=1, Name="Saahil",Department="HR"};
            Employee emp2 = new Employee() { Id = 2, Name = "Asritha", Department = "Accounts" };
            Employee emp3 = new Employee() { Id = 3, Name = "Akansha", Department = "IT" };
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
        }
        public Employee GetEmployeeById(int id)
        {
            Employee emp= employees.Find(e => e.Id==id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void Save(Employee employee)
        {
           // throw new NotImplementedException();
        }
    }
}
