using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo1.Models
{
   public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        void Save(Employee employee);
        List<Employee> GetEmployees();
    }
}
