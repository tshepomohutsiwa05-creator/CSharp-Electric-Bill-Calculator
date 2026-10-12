using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C__Practic3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Units used: ");
            int units = int.Parse(Console.ReadLine());
            ElectricityBill(units, name);



        }
        static void ElectricityBill(int units, string name)
        {
            double totalBill = 0;
            if (units >= 0 && units <= 100)
            {
                double pricePerUnit = 1.50;
                totalBill = units * pricePerUnit;
                Console.WriteLine($"Customer: {name} \nUnits used: {units} \nPrice per unit: {pricePerUnit:0.00} \nTotal bill: R{totalBill:0.00}");
            }
            else if(units <= 200)
            {
                double pricePerUnit = 2.00;
                totalBill = units * pricePerUnit;
                Console.WriteLine($"Customer: {name} \nUnits used: {units} \nPrice per unit: {pricePerUnit:0.00} \nTotal bill: R{totalBill:0.00}");
            }
            else 
            {
                double pricePerUnit = 2.50;
                totalBill = units * pricePerUnit;
                Console.WriteLine($"Customer: {name} \nUnits used: {units} \nPrice per unit: {pricePerUnit:0.00} \nTotal bill: R{totalBill:0.00}");
            }
          
        }


    }
}
