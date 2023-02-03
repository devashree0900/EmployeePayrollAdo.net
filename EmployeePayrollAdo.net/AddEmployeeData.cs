using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollAdo.net
{
    public class AddEmployeeData
    {
        public static EmployeeModel AddEmpData(EmployeeModel employee)
        {
            Console.WriteLine("Enter Name: ");
            employee.Name= Console.ReadLine();
            Console.WriteLine("Enter Salary");
            employee.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter StartDate:");
            employee.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Gender:");
            employee.Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Department:");
            employee.Department = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            employee.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter : Address");
            employee.EmpAddress = Console.ReadLine();
            Console.WriteLine("Enter Deductions: ");
            employee.Deductions = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter TaxablePay: ");
            employee.TaxablePay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter IncomeTax: ");
            employee.IncomeTax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter NetPay: ");
            employee.NetPay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter BasicPay: ");
            employee.BasicPay = Convert.ToDouble(Console.ReadLine());
            return employee;
        }
    }
}
