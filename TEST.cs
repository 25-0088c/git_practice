using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double GetValidInput(string prompt)
            //getting the value
        {
            double value;

            while (true)
            {
                Console.Write(prompt);
                value = Convert.ToDouble(Console.ReadLine());

                if (value > 0)
                {
                    return value;
                }

                Console.WriteLine("Input a valid number.");
            }

        } 

        static double CalculateGrossPay(double hours, double rate)
            // getting the gross pay
        {
            Double grossPay;

            if (hours <= 40)
            {
                grossPay = hours * rate;
            }

            else
            {
                double OvertimeHours = hours - 40;
                grossPay = (40 * rate) + (OvertimeHours + rate * 1.5);

            }

            return grossPay;
        }

        static double CalculateTaxes(double grossPay)
            // getting taxes
        {

            double taxes = grossPay * 0.15;
            return taxes;

        }

        static void PrintPayStub(string name, double gross, double taxes, double net)
            // printing everything
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("               PAY SLIP                ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     Employee name : " + name);
            Console.WriteLine("     Gross Pay : P" + gross);
            Console.WriteLine("     Taxes (15%) : P" + taxes);
            Console.WriteLine("     Net pay : P" + net);
        
        }

        static void Main(string[] args)
            // input the values
        {

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            double hours = GetValidInput("Enter hours worked: ");
            double rate = GetValidInput("Enter hourly rate: ");

            double gross = CalculateGrossPay(hours, rate);
            double taxes = CalculateTaxes(gross);
            double net = gross - taxes;

            PrintPayStub(name, gross, taxes, net);


            Console.ReadLine();

        }

    }
}
