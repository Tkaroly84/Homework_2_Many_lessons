namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
//deklarálások
            double number1, number2, result;
            char operation;

//UI komunikáció
            Console.WriteLine("Üdvözöllek az Calculator játékunkban!");
            Console.WriteLine("A játék lényege, hogy adj meg 2 számot és egy műveletet (+;-;*;/)");
            Console.WriteLine();

//Első validálás
            Console.WriteLine("Kérem az első számot:");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
                Console.WriteLine("Kérem az új számot:");
            }

//Művelet bekérés és validálás
            while(true)
            {
                Console.WriteLine("Kérem adja meg a műveletet (+, -, *, /):");
                string input = Console.ReadLine();
                if (input.Length == 1 && "+-*/".Contains(input))
                {
                    operation = input[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Érvénytelen művelet, kérem próbálja újra!");
                }
            }

//Második validálás
            Console.WriteLine("Kérem a második számot:");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Érvénytelen szám, kérem próbálja újra!");
            }

//switch deklarálása
            switch (operation)
            {
                case '+':
                    Console.WriteLine("A választott művelet az összeadás volt");
                    result = number1 + number2;
                    break;
                case '-':
                    Console.WriteLine("A választott művelet a kivonás volt");
                    result = number1 - number2;
                    break;
                case '*':
                    Console.WriteLine("A választott művelet a szorzás volt");
                    result = number1 * number2;
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        Console.WriteLine("A választott művelet az osztás volt");
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Nullával való osztás nem megengedett!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Érvénytelen művelet.");
                    return;
            }

//Eredmény kiiratása
            Console.WriteLine("Az eredmény: " +result);
        }
    }
}
