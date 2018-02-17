using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            for (; ; )
            {
                Greetting();

                Age();
                Settings();
            }
            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj, " + item);
            //}
        }

        private static void ValueTypes()
        {

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt " + maxInt);
            Console.WriteLine("minInt " + minInt);
            Console.WriteLine("maxLong " + maxLong);
            Console.WriteLine("minLong " + minLong);
        }


        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }


        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Możesz wypic piwko");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś nie poprawny wiek!");
            }
            else
            {
                Console.WriteLine("Możesz napic sie mleka :-)");
            }
        }


        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greetting()
        {
            Console.Write("Wpisz swoje Imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
