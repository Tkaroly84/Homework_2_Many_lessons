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
                number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Kérem a második számot:");
                number2 = int.Parse(Console.ReadLine());

                int sum = number1 + number2;
                Console.WriteLine($"A megadott számok összege: {sum}");
            }
            while (number1 != 0 || number2 != 0);
            {
                Console.WriteLine("A játék véget ért!");
            }
        }
    }
}
