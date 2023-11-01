using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Employee
    {
        public int EmployeeID { get; }
        public string EmployeeName { get; set; }
        public string ReportingManager { get; set; }

        public Employee(int employeeID, string employeeName, string reportingManager)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            ReportingManager = reportingManager;
        }
        
    }
}
