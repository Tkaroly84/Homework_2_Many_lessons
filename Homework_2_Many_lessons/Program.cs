using System.Xml;

namespace Adder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek az Adder játékunkban!");
            Console.WriteLine("A játék lényege, hogy adj meg 2 számot, melyet össze fogok adni...(csak egész számok lehetnek és lehet negativ is!)");
            Console.WriteLine();

            int number1;
            int number2;

            do
            {
                Console.WriteLine("Kérem az első számot:");
                while (!int.TryParse(Console.ReadLine(), out number1))
                {
                    Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
                }
                if (number1 == 0) break;

                Console.WriteLine("Kérem a második számot:");
                while (!int.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
                }
                if (number2 == 0) break;

                int sum = number1 + number2;
                Console.WriteLine($"A megadott számok összege: {sum}");
            }
            while (true);

            Console.WriteLine("A játék véget ért!");
        }
    }
}