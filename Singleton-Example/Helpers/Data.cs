using Singleton_Example.Models;
using System.Collections.Generic;
//using LinkedList<> = LinealStructures.LinkedList<;

namespace Singleton_Example.Helpers
{
    public class Data
    {
        private static Data _instance = null;
        public static Data Instance
        {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }
        }

        //public List<Employee> Employees = new List<Employee>();
        public LinealStructures.LinkedList<Employee> Employees = new LinealStructures.LinkedList<Employee>();
    }
}