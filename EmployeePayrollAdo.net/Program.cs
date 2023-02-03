using System;

namespace EmployeePayrollAdo.net
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepository.GetAllEmployee();
            EmployeeModel model = new EmployeeModel();
            var emp = AddEmployeeData.AddEmpData(model);
            EmployeeRepository.AddEmployeeToDB(emp);

        }
    }
}
