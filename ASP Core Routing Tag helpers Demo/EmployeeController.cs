using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDemo1.Models;

namespace MVCDemo1.Controllers
{
 
  //  [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }
     //  [Route("Index")]
      // [Route("Employee")]
      //[Route("[action]")]
        public IActionResult Index()
        {
            return View(_employeeRepository.GetEmployees());
        }

       // [Route("Details")]
       //[Route("[action]")]
        public IActionResult Details(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            return View(employee);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            _employeeRepository.Save(emp);
            return View("Index",_employeeRepository.GetEmployees());
        }
    }
}
