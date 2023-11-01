namespace Assignment7 {
 class ContractBasisEmployee : Employee
    {
        public DateTime ContractStartDate { get; set; }
        public int ContractDurationInMonths { get; set; }
        public decimal ContractCharges { get; set; }
        public DateTime JoiningDate { get; set; }
        public int ExperienceInYears { get; set; }
        public decimal BasicSalary { get; set; }

        public decimal CalculateNetSalary_ContractBasisEmployee()
        {
            decimal DA, HRA, PF;

            if (ExperienceInYears > 10)
            {
                DA = 0.10m * BasicSalary;
                HRA = 0.085m * BasicSalary;
                PF = 6200;
            }
            else if (ExperienceInYears > 7)
            {
                DA = 0.07m * BasicSalary;
                HRA = 0.065m * BasicSalary;
                PF = 4100;
            }
            else if (ExperienceInYears > 5)
            {
                DA = 0.041m * BasicSalary;
                HRA = 0.038m * BasicSalary;
                PF = 1800;
            }
            else
            {
                DA = 0.019m * BasicSalary;
                HRA = 0.020m * BasicSalary;
                PF = 1200;
            }

            return BasicSalary + DA + HRA - PF;
        }
        public ContractBasisEmployee(int employeeID, string employeeName, string reportingManager)
            : base(employeeID, employeeName, reportingManager)
        {
        }
    }
}