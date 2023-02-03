using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollAdo.net
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }
        public char Gender { get; set; }

        public string EmpAddress { get; set; }
        public string Department { get; set; }

        public double Salary { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double Deductions { get; set; }

        public double BasicPay { get; set; }
        public double NetPay { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " Name:" + Name + " PhoneNumber: " + PhoneNumber+ " StartDate: " + StartDate
                + " Gender: " + Gender + " EmpAddress: " + EmpAddress+ " Department: " + Department
                + "Salary: " + Salary + " TAxablePay: " + TaxablePay + " IncomeTax: " + IncomeTax + 
                " Deductions: " + Deductions + " BasicPay: " + BasicPay + " NetPay: " + NetPay;
        }

    }
}
