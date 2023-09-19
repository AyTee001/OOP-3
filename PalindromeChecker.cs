using System.Text.RegularExpressions;

namespace Palindroms
{
    public class PalindromeChecker
    {
        private readonly string _word;

        public PalindromeChecker(string word)
        {
            _word = word;
        }

        public bool IsWordPalindrom()
        {
            string clearedWord = Regex.Replace(_word, @"[\s\p{P}]+", "").ToLower();

            if (string.IsNullOrEmpty(clearedWord))
            {
                return false;
            }

            return clearedWord.Equals(ReverseString(clearedWord));
        }

        private string ReverseString(string stringToReverse)
        {
            var charArray = stringToReverse.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
