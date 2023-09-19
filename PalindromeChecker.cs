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
            //Regex defines punctuation marks and whitespaces and gets rid of them, then word turned to lowercase
            string clearedWord = Regex.Replace(_word, @"[\s\p{P}]+", "").ToLower();

            //return false if resulting word is not valid
            if (string.IsNullOrEmpty(clearedWord))
            {
                return false;
            }

            //Compare values of a string and its reversed variant
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
