using System.Text;

namespace Palindroms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make sure program can understand cyrillic symbols
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Please, give me your input and I will check it for being a palindrom");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("You entered nothing");
                return;
            }

            var checker = new PalindromeChecker(input);
            if (checker.IsWordPalindrom())
            {
                Console.WriteLine("That was a palindrome");
            }
            else
            {
                Console.WriteLine("That was not a palindrome");
            }
        }
    }
}