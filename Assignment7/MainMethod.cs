using Assignment7;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter ContractEmployeeId Details:");
        int contractEmployeeID = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter ContractEmployeeName Details:");
        string contractEmployeeName = Console.ReadLine();
        Console.WriteLine("Enter ContractReprtingManager Details:");
        string contractReportingManager = Console.ReadLine();

        ContractBasisEmployee contractEmployee = new ContractBasisEmployee(contractEmployeeID, contractEmployeeName, contractReportingManager);
        Console.WriteLine("Enter ContractStartDetails");
        contractEmployee.ContractStartDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter DurationInMonth Details:");
        contractEmployee.ContractDurationInMonths = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter ContractCharge Details:");
        contractEmployee.ContractCharges = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Payroll Employee Id Details:");
        int payrollEmployeeID = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Payroll Employee Name Details:");
        string payrollEmployeeName = Console.ReadLine();
        Console.WriteLine("Enter Payroll ReportingManager Details:");
        string payrollReportingManager = Console.ReadLine();

        PayrollEmployee payrollEmployee = new PayrollEmployee(payrollEmployeeID, payrollEmployeeName, payrollReportingManager);
        Console.WriteLine("Enter Payroll Joining Details:");
        payrollEmployee.JoiningDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter Payroll Experience Details:");
        payrollEmployee.ExperienceInYears = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Payroll Basic Salary Details:");
        payrollEmployee.BasicSalary = decimal.Parse(Console.ReadLine());

        // Display employee details
        Console.WriteLine("Contract Basis Employee Details are");
        Console.WriteLine($"ID: {contractEmployee.EmployeeID}");
        Console.WriteLine($"Name: {contractEmployee.EmployeeName}");
        Console.WriteLine($"Reporting Manager: {contractEmployee.ReportingManager}");
        Console.WriteLine($"Contract Start Date: {contractEmployee.ContractStartDate}");
        Console.WriteLine($"Contract Duration (in months): {contractEmployee.ContractDurationInMonths}");
        Console.WriteLine($"Contract Charges: {contractEmployee.ContractCharges:C}");
        Console.WriteLine($"Net Salary: {contractEmployee.CalculateNetSalary_ContractBasisEmployee():C}");

        Console.WriteLine("Payroll Employee Details are");
        Console.WriteLine($"ID: {payrollEmployee.EmployeeID}");
        Console.WriteLine($"Basic Salary: {payrollEmployee.BasicSalary:C}");
        Console.WriteLine($"Net Salary: {payrollEmployee.CalculateNetSalary_PayrollEmployee():C}");
    }
}
