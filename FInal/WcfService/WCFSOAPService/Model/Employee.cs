using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFSOAPService.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
    }
}