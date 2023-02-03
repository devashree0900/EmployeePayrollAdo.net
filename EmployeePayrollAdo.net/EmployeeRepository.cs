using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeePayrollAdo.net
{
    public class EmployeeRepository
    {
        public static string ConnectionString = @"Data Source=G4LV91T3E;Initial Catalog=Payroll_Service;Integrated Security =True;";

        public static SqlConnection sqlConnection;
        public static EmployeeModel model = new EmployeeModel();

        public static void GetAllEmployee()
        {
            using(sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("GetAllEmployee",sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        model.Id = Convert.ToInt32(reader["Id"]);
                        model.Name = reader["Name"].ToString();
                        model.PhoneNumber = Convert.ToInt64(reader["PhoneNumber"] == DBNull.Value ? default : reader["PhoneNumber"]);
                        model.StartDate = Convert.ToDateTime(reader["StartDate"] == DBNull.Value ? default : reader["StartDate"]);
                        model.Gender = Convert.ToChar(reader["Gender"] == DBNull.Value ? default : reader["Gender"]);
                        model.EmpAddress = (reader["EmpAddress"] == DBNull.Value ? default : reader["EmpAddress"]).ToString();
                        model.Department = reader["Department"].ToString();
                        model.Salary = Convert.ToDouble(reader["Salary"] == DBNull.Value ? default : reader["Salary"]);
                        model.BasicPay = Convert.ToDouble(reader["BasicPay"] == DBNull.Value ? default : reader["BasicPay"]);
                        model.TaxablePay = Convert.ToDouble(reader["TaxablePay"] == DBNull.Value ? default : reader["TaxablePay"]);
                        model.IncomeTax = Convert.ToDouble(reader["IncomeTax"] == DBNull.Value ? default : reader["IncomeTax"]);
                        model.Deductions = Convert.ToDouble(reader["Deductions"] == DBNull.Value ? default : reader["Deductions"]);
                        model.NetPay = Convert.ToDouble(reader["NetPay"] == DBNull.Value ? default : reader["NetPay"]);
                        Console.WriteLine(model);
                    }
                }
                sqlConnection.Close();
            }
        }

        public static void AddEmployeeToDB(EmployeeModel employee)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("AddEmployeeNew", sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;  //go to stored procedure section and search there
            cmd.Parameters.AddWithValue("@Name", employee.Name);
            cmd.Parameters.AddWithValue("@Salary", employee.Salary);
            cmd.Parameters.AddWithValue("@StartDate", employee.StartDate);
            cmd.Parameters.AddWithValue("@Gender", employee.Gender);
            cmd.Parameters.AddWithValue("@Department", employee.Department);
            cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
            cmd.Parameters.AddWithValue("@EmpAddress", employee.EmpAddress);
            cmd.Parameters.AddWithValue("@Deductions", employee.Deductions);
            cmd.Parameters.AddWithValue("@TaxablePay", employee.TaxablePay);
            cmd.Parameters.AddWithValue("@IncomeTax", employee.IncomeTax);
            cmd.Parameters.AddWithValue("@NetPay", employee.NetPay);
            cmd.Parameters.AddWithValue("@BasicPay", employee.BasicPay);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery(); //for crud operation we get op as one row affected
            if(result !=0 )
            {
                Console.WriteLine("Data Added Successfully");
            }
            else
            {
                Console.WriteLine("Data not added");
            }

        }

    }
}
