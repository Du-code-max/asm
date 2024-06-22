using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace b3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the customer's name: ");
            string customerName = Console.ReadLine();
            int Watermasslastmonth = GetMeterReading("Enter last month's water meter readings: ");
            int Waterblockthismonth = GetMeterReading("Enter this month's water meter readings: ");
            while (Waterblockthismonth < Watermasslastmonth)
            {
                Console.WriteLine("Invalid input value. Please re-enter.");
                Waterblockthismonth = GetMeterReading("Enter this month's water meter readings: ");
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

        static int GetMeterReading(string prompt)
        {
            int meterReading;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out meterReading))
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
                Console.WriteLine("Enter the customer type: ");
                Console.WriteLine(" 1. Family ");
                Console.WriteLine(" 2. Administrative agency ");
                Console.WriteLine(" 3. Production unit "); 
                Console.WriteLine(" 4. Business service ");
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
                Console.Write("Enter the number of people in the household: ");
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
                    if (consumption <= 10 * numberOfPeople)
                    {
                        money = 5.973;
                    }
                    else if (consumption <= 20 * numberOfPeople)
                    {
                        money = 7.052;
                    }
                    else if (consumption <= 30 * numberOfPeople)
                    {
                        money = 8.699;
                    }
                    else
                    {
                        money = 15.929;
                    }
                    break;
                case 2: 
                    money = 9.955;
                    break;
                case 3: 
                    money = 11.615;
                    break;
                case 4: 
                    money = 22.068;
                    break;
            }
            double waterBill = consumption * money;
            double VAT = money * 1.21;
            return waterBill + money + VAT;
        }

        static void PrintBill(string customername, int Watermasslastmonth, int Waterblockthismonth, int consumption, double amount)
        {
            Console.WriteLine("Customer name: " + customername);
            Console.WriteLine("Enter last month's water meter readings: " + Watermasslastmonth);
            Console.WriteLine("Enter this month's water meter readings: " + Waterblockthismonth);
            Console.WriteLine("Amount of water consumed: " + consumption + " m3");
            Console.WriteLine("Total amount payable: " + amount + " VND");
        }
    }
}
