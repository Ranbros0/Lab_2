using System;

namespace Lab2_2
{
    public class CurrencyConverter
    {
        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }

        public CurrencyConverter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ConvertToUsd(double value)
        {
            return value / USD;
        }

        public double ConvertToEur(double value)
        {
            return value / EUR;
        }

        public double ConvertToRub(double value)
        {
            return value / RUB;
        }

        public double ConvertFromUsd(double value)
        {
            return USD * value;
        }

        public double ConvertFromEur(double value)
        {
            return EUR * value;
        }

        public double ConvertFromRub(double value)
        {
            return RUB * value;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var converter = new CurrencyConverter(23.65, 29.84, 0.1);

            Console.WriteLine("Choose option:");
            Console.WriteLine("1: Convert to hryvnia");
            Console.WriteLine("2: Convert from hryvnia");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertTo(converter);
                    break;
                case 2:
                    ConvertFrom(converter);
                    break;
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void ConvertTo(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1: Convert from USD");
            Console.WriteLine("2: Convert from EUR");
            Console.WriteLine("3: Convert from RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertFromUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertFromEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertFromRub(input));
                    break;
            }
        }

        private static void ConvertFrom(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1: Convert to USD");
            Console.WriteLine("2: Convert to EUR");
            Console.WriteLine("3: Convert to RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertToUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertToEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertToRub(input));
                    break;
            }
        }
    }
}
