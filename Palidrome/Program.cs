namespace Palidrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

// UI kommunikáció
            string input;

// UI kommunikáció
            Console.WriteLine("Üdvözöllek az Palidrome játékban!");
            Console.WriteLine("A játék lényege, hogy adj meg egy szöveget és én megmondom" +
                " 'Palidrome' vagy sem!");
            Console.WriteLine();

            Console.WriteLine("Kérem a szöveget:");
            input = Console.ReadLine().ToLower();

            string reversed = ReverseString(input);


            if (input == reversed)
            {
                Console.WriteLine("Palidrome a szöveg!");
            }
            else
            {
                Console.WriteLine("Nem Palidrome a szöveg: " + input);
            }
        }

        static string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
