using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Indexer
{
    internal class Company
    {

        // public string? CompanyName { get; set; };
        // public string CompanyName { get; set; } = string.Empty;
        public string CompanyName { get; set; }

        private System.Collections.ArrayList _employees;


        #region Indexer

        // INDEXER
        // - Always instance member
        // - Always have the name "this"
        // - Has to have a return type, and at least one parameter
        public Employee? this[string nameToFind]
        { 
            // public Employee? FindEmployee(string nameToFind) { ... }
            get 
            {
                Employee? empFound = null;
                foreach(Employee employee in _employees)
                {
                    if(employee.Name == nameToFind)
                    {
                        empFound = employee;
                        break;
                    }
                }
                return empFound;
            }
        }

        #endregion


        // CONSTRUCTOR (Parameterless / Default)
        // Purpose - initialize all instance members of the type (struct/class)
        public Company()
        {
            CompanyName = string.Empty;
            _employees = new System.Collections.ArrayList();
        }

        // CONSTRUCTOR (Parameterized)
        // Purpose - initialize all instance members of the type (struct/class)
        public Company(string companyName)
        {
            CompanyName = companyName;
            _employees = new System.Collections.ArrayList();
        }


        public Company(string companyName, Employee firstEmployee)
        {
            CompanyName = companyName;

            //_employees = new System.Collections.ArrayList();
            //_employees.Add(firstEmployee);
            _employees = new System.Collections.ArrayList() { firstEmployee };
        }

        public Company(string companyName, Employee[] employees)
        {
            CompanyName = companyName;

            //_employees = new System.Collections.ArrayList();
            //_employees.Add(firstEmployee);
            _employees = new System.Collections.ArrayList();
            for(int i = 0; i < employees.Length; i++)
            {
                _employees.Add(employees[i]);
            }
        }

        // METHOD
        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);        // boxing
        }

        // METHOD
        public void DisplayInfo()
        {
            Console.WriteLine("Employees of {0}", CompanyName);
            for(int i = 0; i < _employees.Count; i++)
            {
                Employee? emp = _employees[i] as Employee;       // unboxing
                if (emp is not null)
                {
                    Console.WriteLine("ID = {0}, Name = {1}, Designation = {2}",
                        emp.Id, emp.Name, emp.Designation);
                }
            }
        }
    }
}
