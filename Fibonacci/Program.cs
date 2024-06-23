using System.Threading.Channels;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

//deklarálások
            int number1, number2, quantity,result;

//UI komunikáció
            Console.WriteLine("Üdvözöllek az Fibonacci játékunkban!");
            Console.WriteLine("A játék lényege, hogy adj meg 2 számot amelyek az indító értékek lesznek, majd add meg hanyadik értékre vagy kíváncsi!");
            Console.WriteLine();

//Az első szám validálása
            Console.WriteLine("Kérem az első számot:");
            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
            }

//A második szám validálása
            Console.WriteLine("Kérem a második számot:");
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
            }

//A darabszám szám validálása
            Console.WriteLine("Kérem a darabszámot:");
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
            }
//Ha az első számo érdekli
            if (quantity == 1)
            {
                Console.WriteLine("Az eredmény: " + number1);
            }

//Ha a második szám érdekli
            else if (quantity == 2)
            {
                Console.WriteLine("Az eredmény: " + number2);
            }
//Fibonacci számítása
            else
            {
//For cuklussal növelek
                int fibonacci = 0;
                for (int i =2; i < quantity; i++)
                {
                    fibonacci = number1 + number2;
                    number1 = number2;
                    number2 = fibonacci;
                }
                Console.WriteLine($"Az {quantity}. Fibonacci szám a {fibonacci}");
            }
        }
    }
}
