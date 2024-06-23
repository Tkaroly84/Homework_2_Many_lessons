namespace Q_R
{
    internal class Program
    {
        static void Main(string[] args)
        {
// Deklarálások
            int number1, number2;
            double result;

// UI kommunikáció
            Console.WriteLine("Üdvözöllek az Q+R játékban!");
            Console.WriteLine("A játék lényege, hogy adj meg 2 számot és én elosztom Neked!");
            Console.WriteLine();

            while (true)
            {
// Első szám validálása
                Console.WriteLine("Kérem az első számot: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "x")
                {
                    break;
                }
                while (!int.TryParse(input, out number1) || number1 == 0)
                {
                    Console.WriteLine("Érvénytelen szám, kérem próbálja újra! Vagy nyomj 'x'-et a kilépéshez: ");
                    input = Console.ReadLine();
                    if (input.ToLower() == "x")
                    {
                        return;
                    }
                }

// Második szám validálása
                Console.WriteLine("Kérem a második számot: ");
                input = Console.ReadLine();
                if (input.ToLower() == "x")
                {
                    break;
                }
                while (!int.TryParse(input, out number2) || number2 == 0)
                {
                    Console.WriteLine("Érvénytelen szám, kérem próbálja újra! Vagy nyomj 'x'-et a kilépéshez: ");
                    input = Console.ReadLine();
                    if (input.ToLower() == "x")
                    {
                        return;
                    }
                }

// Eredmény számítása és kiírása
                result = (double)number1 / number2;
                Console.WriteLine("Az eredmény: " + result);
            }

            Console.WriteLine("A játék véget ért!");
        }
    }
}
