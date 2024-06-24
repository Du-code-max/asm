using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the customer's name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter last month's water meter readings: ");
            int Watermasslastmonth = GetMeterReading();
            Console.Write("Enter this month's water meter readings: ");
            int Waterblockthismonth = GetMeterReading();
            while (Waterblockthismonth < Watermasslastmonth)
            {
                Console.WriteLine("Invalid input value. Please re-enter.");
                Waterblockthismonth = GetMeterReading();
            }
            int customertype = GetCustomertype();

            int numberOfPeople = 0;
            if (customertype == 1)
            {
                numberOfPeople = GetNumberOfPeople();
            }
            int consumption = CalculateConsumption(Watermasslastmonth, Waterblockthismonth);
            double amount = CalculateWaterBill(consumption, customertype, numberOfPeople);
            PrintBill(customerName, Watermasslastmonth, Waterblockthismonth, consumption, amount);
        }

        static int GetMeterReading()
        {
            int meterReading;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out meterReading) && meterReading > 0)
                {
                    return meterReading;
                }
                Console.WriteLine("Invalid input value. Please re-enter.");
            }
        }

        static int GetCustomertype()
        {
            int customerType;
            while (true)
            {
                Console.WriteLine("List customer type: ");
                Console.WriteLine(" 1. Family ");
                Console.WriteLine(" 2. Administrative agency ");
                Console.WriteLine(" 3. Production unit ");
                Console.WriteLine(" 4. Business service ");
                Console.WriteLine("Please choose from the four cases above");
                if (int.TryParse(Console.ReadLine(), out customerType) && customerType >= 1 && customerType <= 4)
                {
                    return customerType;
                }
                Console.WriteLine("Invalid value entered. Please re-enter.");
            }
        }

        static int GetNumberOfPeople()
        {
            int numberOfPeople;
            while (true)
            {
                Console.Write("Enter the member of people in the household: ");
                if (int.TryParse(Console.ReadLine(), out numberOfPeople) && numberOfPeople > 0)
                {
                    return numberOfPeople;
                }
                Console.WriteLine("Invalid value entered. Please re-enter.");
            }
        }

        static int CalculateConsumption(int Watermasslastmonth, int Waterblockthismonth)
        {
            return Waterblockthismonth - Watermasslastmonth;
        }

        static double CalculateWaterBill(int consumption, int customerType, int numberOfPeople)
        {
            double money = 0;


            switch (customerType)
            {
                case 1:
                    if (consumption <= 10)
                    {
                        money = 5.973 * consumption;
                    }
                    else if (consumption <= 20)
                    {
                        money = 5.973 * 10 + 7.052 * (consumption - 10);
                    }
                    else if (consumption <= 30 - 20)
                    {
                        money = 5.973 * 10 + 7.052 * 10 + 8.699 * (consumption - 20);
                    }
                    else
                    {
                        money = 5.9873 * 10 + 7.052 * 10 + 8.699 * 10 + 15.929 * (consumption - 30);
                    }
                    break;
                case 2:
                    money = 9.955 * consumption;
                    break;
                case 3:
                    money = 11.615 * consumption;
                    break;
                case 4:
                    money = 22.068 * consumption;
                    break;
            }

            return money = money * 1.21;
        }

        static void PrintBill(string customername, int Watermasslastmonth, int Waterblockthismonth, int consumption, double amount)
        {
            Console.WriteLine("__________Bill__________");
            Console.WriteLine("Customer name: " + customername);
            Console.WriteLine("Last month's water meter readings: " + Watermasslastmonth);
            Console.WriteLine("This month's water meter readings: " + Waterblockthismonth);
            Console.WriteLine("Amount of water consumed: " + consumption + " m3");
            Console.WriteLine("Total amount payable: " + amount + " VND");
        }
    }
}
