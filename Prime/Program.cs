namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
//deklarálások
            int number;
            bool isPrime = true;

//UI komunikáció
            Console.WriteLine("Üdvözöllek az Prime játékban!");
            Console.WriteLine("A játék lényege, hogy adj meg 1 számot és én megmondom" +
                " prímszám, vagy sem!");
            Console.WriteLine();

//Szám validálása
            Console.WriteLine("Kérem a számot: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
                Console.Write("Új szám megadása: ");
            }

// Prímszám ellenőrzés
            

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Ez a szám prímszám!");
            }
            else
            {
                Console.WriteLine("Ez nem prímszám!");
            }
        }
    }
}