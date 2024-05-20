using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo17_IEnumerable
{
    internal class Company : System.Collections.IEnumerable
    {
        public readonly string CompanyName;
        // private System.Collections.ArrayList _employees;             // needs boxing & unboxing
        private System.Collections.Generic.List<Employee> _employees;   // type-safe
        public int NumberOfEmployees { get; private set; }

        public Company(string companyName)
        {
            CompanyName = companyName;
            _employees = new List<Employee>();
            NumberOfEmployees = 0;
        }

        public Employee? this[int idToFind]
        {
            get
            {
                Employee? empFound = null;

                foreach(Employee emp in _employees)
                {
                    if(emp.EmployeeID == idToFind)
                    {
                        empFound = emp;
                    }
                }

                return empFound;
            }
        }

        public void AddEmployee(string nameOfNewEmployee)
        {
            Employee employee = new Employee(++NumberOfEmployees, nameOfNewEmployee);
            _employees.Add(employee);
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Employees of the Company: {0}", this.CompanyName);

            //for (int i = 0; _employees.Count > 0 && i < NumberOfEmployees; i++)
            //{
            //    Employee? emp = _employees[i] as Employee;
            //    if (emp != null)
            //    {
            //        // Console.WriteLine("{0} {1}", emp.EmployeeID, emp.EmployeeName);
            //        Console.WriteLine(emp);
            //    }
            //}

            foreach(Employee emp in _employees)
            {
                Console.WriteLine(emp);
            }
        }


        #region System.Collections.IEnumerable members

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < _employees.Count; i++)
            {
                yield return _employees[i];
            }
        }

        #endregion
    }
}
