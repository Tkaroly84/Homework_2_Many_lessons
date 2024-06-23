using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
//deklarálások
            int number;

//UI komunikáció
            Console.WriteLine("Üdvözöllek az FizzBuzz játékban!");
            Console.WriteLine("A játék lényege, hogy adj meg 1 számot és én megmondom" +
                " Fizz (osztható-e 3-mal),vagy Buzz (osztható-e 5-tel).");
            Console.WriteLine();

//Szám validálása
            Console.WriteLine("Kérem a számot: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
                Console.Write("Új szám megadása: ");
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("A megadott szám sem 3-mal, sem 5-tel nem osztható maradék nélkül!");
                Console.Write(number);
            }
        }
    }
}
