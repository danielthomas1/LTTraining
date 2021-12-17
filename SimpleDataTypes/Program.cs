using System;

namespace SimpleDataTypes
{
    class Program
    {
        static void Main()
        {
            /*
            Console.Write("Enter the first number :");
            string strFirstNumber = Console.ReadLine();

            Console.Write("Enter the second number :");
            string strSecondNumber = Console.ReadLine();

            float totalTax = .30F;

            int firstNumber;
            int secondNumber;

            if (int.TryParse(strFirstNumber, out firstNumber)
                && int.TryParse(strSecondNumber, out secondNumber))
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            }
            else
                Console.WriteLine("One or more data is not a number");*/

            Console.Write("Enter your annual salary : ");
            string strAnnualSalary = Console.ReadLine();
            
            int annualSalary;
            if (int.TryParse(strAnnualSalary, out annualSalary))
            {
                float tax = 0.0F;

                if (annualSalary >= 200000 && annualSalary < 500000)
                    tax = .10F;
                else if (annualSalary >= 500000 && annualSalary < 700000)
                    tax = .20F;
                else if (annualSalary >= 700000)
                    tax = .30F;

                Console.WriteLine($"Your tax for {annualSalary} for the year is {annualSalary * tax}");

            }
            else
                Console.WriteLine("Please enter a valid value for the salary");

        }
    }
}
