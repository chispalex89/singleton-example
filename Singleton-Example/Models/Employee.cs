using Singleton_Example.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Singleton_Example.Models
{
    public class Employee
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public static void Save(Employee employee)
        {
            Data.Instance.Employees.Add(employee);
        }
    }
}