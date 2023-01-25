/* PROGRAM DESCRIPTION:
AUTHOR: Caitlyn Smith
DATE: 01/25/2023
EMAIL: c-smith54@hvcc.edu

PROGRAM OBJECTIVE:
Write a program that calculates and prints take-home pay information 
for a person on a sales plan (i.e. earns comissions on sales). 

1) Use a variable called empName for the employee's name and set the name (compile time) to your name.
2) For this assignment, all monetary fields should be decimal data type. 
3) Employees earn 7% of their total sales as comission.
4) Employees pay a 18% federal tax rate. 
   Employees pay a 3.1% state tax rate. 
5) Employees have a mandatory retrirement contribution of 10%. 
6) Employees pay 6% to social security. 
7) Assume (hard code) that the employee has 100,000.00 in sales. 
8) Produce output that shows the following (in this order):
 a) Employee Name
 b) Sales
 c) Gross pay (sales * commission rate)
 d) Federal Taxes ( Gross Pay * Federal Tax Rate)
 e) State Taxes (Gross Pay * State Tax Rate)
 f) Social Security Taxes (Gross Pay * Social Security rate)
 g) Retirement Contribution (Gross Pay * Retirement Rate)
 h) A series of dashs (i.e. a seperator), e.g. "-----------------------------------"
 i) The total of the deductions  (d + e + f + g)
 j) Net take home pay (Gross pay minus the summary produced in i )
9) Formatting: The final take home pay and total sales figure should be formatted with currency. 
All other values should not have $ signs. All values should have thousands seperators. 
The output should show the descriptive text (e.g. Employee Name:) left aligned and the value 
(e.g. "John Thompson") right aligned. 
All of the values should be aligned (i.e. a column). */

using System;
using static System.Console;

namespace Ch2 {
    class Chapter2 {
        static void Main(string[] args) {
            //Variables
            string empName = "Caitlyn Smith";
            const decimal SALES_COMMISSION = 0.07M;
            const decimal FEDERAL_TAX_RATE = 0.18M;
            const decimal STATE_RAX_RATE = 0.031M;
            const decimal RETIREMENT_RATE = 0.10M;
            const decimal SOCIAL_SECURITY_RATE = 0.06M;
            decimal sales = 100000.00M;

            //Variables from calculations
            decimal grossPay = sales * SALES_COMMISSION;
            decimal federalTaxes = grossPay * FEDERAL_TAX_RATE;
            decimal stateTaxes = grossPay * STATE_RAX_RATE;
            decimal socialSecurityTaxes = grossPay * SOCIAL_SECURITY_RATE;
            decimal retirement = grossPay * RETIREMENT_RATE;
            decimal totalDeductions = federalTaxes + stateTaxes + socialSecurityTaxes + retirement;
            decimal takeHomePay = grossPay - totalDeductions;

            //Output
            WriteLine("{0,-26}{1,8:C}", "Employee Name:", empName);
            WriteLine("{0,-26}{1,8:C}", "Total Sales:", sales);
            WriteLine("{0,-26}{1,8:C}", "Gross Pay:", grossPay);
            WriteLine("{0,-26}{1,8:C}", "Federal Taxes:", federalTaxes);
            WriteLine("{0,-25}{1,8:C}", "State Taxes:", stateTaxes);
            WriteLine("{0,-25}{1,8:C}", "Social Security Taxes:", socialSecurityTaxes);
            WriteLine("{0,-25}{1,8:C}", "Retirement Contribution:", retirement);
            WriteLine("---------------------------------------");
            WriteLine("{0,-26}{1,8:C}", "Total Deducations:", totalDeductions);
            WriteLine("{0,-26}{1,8:C}", "Take Home Pay:", takeHomePay);
        }
    }
}