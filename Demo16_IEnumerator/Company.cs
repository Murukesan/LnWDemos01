using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_IEnumerator
{
    internal class Company : System.Collections.IEnumerator
    {
        // public string CompanyName { get; private set; }
        public readonly string CompanyName;
        private System.Collections.ArrayList _employees;
        private int _countOfEmployees;

        public int CountOfEmployees
        {
            get
            {
                return _countOfEmployees;
            }
        }

        public Company(string companyName)
        {
            CompanyName = companyName;
            _countOfEmployees = 0;
            _employees = new System.Collections.ArrayList();
        }

        public void AddEmployee(string nameOfNewEmployee)
        {
            Employee newEmployee = new Employee(++_countOfEmployees, nameOfNewEmployee);
            _employees.Add(newEmployee);
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Employees of the Company: {0}", this.CompanyName);
            for(int i = 0; i < _countOfEmployees; i++)
            {
                Employee? emp = _employees[i] as Employee;
                if (emp != null)
                {
                    // Console.WriteLine("{0} {1}", emp.EmployeeID, emp.EmployeeName);
                    Console.WriteLine(emp);
                }
            }
        }

        #region System.Collections.IEnumerator members

        private int _currentPosition;

        public object Current
        {
            get
            {
                return this._employees[_currentPosition];
            }
        }

        public bool MoveNext()
        {
            // CurrentPosition is index oriented (meaning it is 0-based)
            // Count is 1-based.
            if (_currentPosition < _countOfEmployees - 1)
            {
                this._currentPosition++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this._currentPosition = -1;
        }

        #endregion
    }
}
