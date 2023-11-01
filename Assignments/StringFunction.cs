using System;
using System.Linq;

namespace StringFunctions
{
    public class StringUtils
    {
        public static int NumberOfCharacters(string sentence)
        {
            return sentence.Length;
        }

        public static bool IsPalindrome(string sentence)
        {
            sentence = sentence.ToLower().Replace(" ", "");
            string reversed = new string(sentence.Reverse().ToArray());
            return sentence == reversed;
        }

        public static string ReverseSentence(string sentence)
        {
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static (int vowels, int consonants, int digits, int specialChars) CountCharactersInSentence(string sentence)
        {
            int vowels = 0, consonants = 0, digits = 0, specialChars = 0;
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    char lowerC = char.ToLower(c);
                    if ("aeiou".Contains(lowerC))
                        vowels++;
                    else
                        consonants++;
                }
                else if (char.IsDigit(c))
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }
            return (vowels, consonants, digits, specialChars);
        }

        // Implement the remaining methods similarly
    }
}
