using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }
    }
    public enum Department
    {None,
        It,
        PayRoll,
        Admin
    }


}
