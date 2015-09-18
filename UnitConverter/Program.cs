using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Unit Converter -------");
            Console.WriteLine();
            string input;
            do
            {
                Console.Write("Select from temperature(t) or volume(v): ");
                input = Console.ReadLine();
            } while (input.ToUpper() != "T" && input.ToUpper() != "V");

            if (input == "t")
                Temperature();
            if (input == "v")
                Volume();
            Console.WriteLine();
            Console.Write("Press any key to quit... ");
            Console.ReadKey();
        }

        private static void Volume()
        {
            UnitConverter UC = new UnitConverter();
            Console.Clear();
            Console.WriteLine("----- Convert Volume -----");
            Console.WriteLine();
            Console.WriteLine("Litres to Gallons (1)");
            Console.WriteLine("Litres to Pints   (2)");
            Console.WriteLine("Gallons to Litres (3)");
            Console.WriteLine("Gallons to Pints  (4)");
            Console.WriteLine("Pints to Gallons  (5)");
            Console.WriteLine("Pints to Litres   (6)");
            Console.WriteLine();
            Console.Write("Which conversion? Please enter 1-6: ");
            string input = Console.ReadLine();
            int parsedinput = int.Parse(input);
            Console.Write("Enter actual amount to convert(ex: 8): ");
            string amount = Console.ReadLine();
            decimal parsedamount = decimal.Parse(amount);

            switch (parsedinput)
            {
                case 1:
                    UC.litretogallon = parsedamount;
                    Console.WriteLine("Gallons: {0}", UC.litretogallon);
                    break;
                case 2:
                    UC.litretoPint = parsedamount;
                    Console.WriteLine("Pints: {0}", UC.litretoPint);
                    break;
                case 3:
                    UC.gallontolitre = parsedamount;
                    Console.WriteLine("Litres: {0}", UC.gallontolitre);
                    break;
                case 4:
                    UC.gallontopint = parsedamount;
                    Console.WriteLine("Pints: {0}", UC.gallontopint);
                    break;
                case 5:
                    UC.pinttogallon = parsedamount;
                    Console.WriteLine("Gallons: {0}", UC.pinttogallon);
                    break;
                default:
                    UC.pinttolitre = parsedamount;
                    Console.WriteLine("Litres: {0}", UC.pinttolitre);
                    break;
            }

        }

        private static void Temperature()
        {
            UnitConverter UC = new UnitConverter();
            Console.Clear();
            Console.WriteLine("----- Convert Temperature -----");
            Console.WriteLine();
            Console.WriteLine("Fahrenheit to Celsius(1)");
            Console.WriteLine("Fahrenheit to Kelvin (2)");
            Console.WriteLine("Celsius to Kelvin    (3)");
            Console.WriteLine("Celsius to Fahrenheit(4)");
            Console.WriteLine("Kelvin to Fahrenheit (5)");
            Console.WriteLine("Kelvin to Celsius    (6)");
            Console.WriteLine();
            Console.Write("Which conversion? Please enter 1-6: ");
            string input = Console.ReadLine();
            int parsedinput = int.Parse(input);
            Console.Write("Enter actual amount to convert(ex: 32): ");
            string amount = Console.ReadLine();
            decimal parsedamount = decimal.Parse(amount);

            switch (parsedinput)
            {
                case 1:
                    UC.ftocelsius = parsedamount;
                    Console.WriteLine("Celsius: {0}", UC.ftocelsius);
                    break;
                case 2:
                    UC.ftokelvin = parsedamount;
                    Console.WriteLine("Kelvin: {0}", UC.ftokelvin);
                    break;
                case 3:
                    UC.celsiustokelvin = parsedamount;
                    Console.WriteLine("Kelvin: {0}", UC.celsiustokelvin);
                    break;
                case 4:
                    UC.celsiustof = parsedamount;
                    Console.WriteLine("Fahrenheit: {0}", UC.celsiustof);
                    break;
                case 5:
                    UC.kelvintof = parsedamount;
                    Console.WriteLine("Fahrenheit: {0}", UC.kelvintof);
                    break;
                default:
                    UC.kelvintocelsius = parsedamount;
                    Console.WriteLine("Celsius: {0}", UC.kelvintocelsius);
                    break;
            }

        }
    }
}
