using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Algorithms
{
    class Program
    {
        static Boolean IsUppercase(string s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean IsLowercase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }

        static string NormalizeString(string input)
        {   
            return input.ToLower().Trim().Replace(",", "");
        }

        static void ParseContents(string s)
        {
            Console.WriteLine("Option 1");
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Option 2");
            for (int i=0; i<s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
        }

        static Boolean IsAtEvenIndex(string s, char item)
        {
            if(String.IsNullOrEmpty(s))
            {
                return false;
            }

            for (int i=0; i<s.Length/2 +1; i=i+2)
            {
                if (s[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
        static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder reversed = new StringBuilder(input.Length);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }

        static string Reverse2(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static string ReverseEachWord(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            string[] words = input.Split(' ');
            for (int i=0; i<words.Length; i++)
            {
                result.Append(Reverse(words[i]));
                if (i != words.Length-1)
                {
                    result.Append(" ");
                }
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));

            Console.WriteLine(Reverse("boram"));
            Console.WriteLine(Reverse(null));
            Console.WriteLine(Reverse("marob"));

            String input = "HeLLo";
            Console.WriteLine(IsAtEvenIndex(input, 'L'));
            Console.WriteLine(IsAtEvenIndex(input, 'T'));
            Console.WriteLine(IsAtEvenIndex("", 'H'));
            Console.WriteLine(IsAtEvenIndex(null, 'H'));

            Console.WriteLine(NormalizeString("HELLO"));
            Console.WriteLine(NormalizeString(" HELLO "));
            Console.WriteLine(NormalizeString(" H,E,L,L,O"));

            Console.WriteLine(IsPasswordComplex("1234"));
            Console.WriteLine(IsPasswordComplex("hello123"));
            Console.WriteLine(IsPasswordComplex("Helloe123"));
            
            Console.WriteLine(IsUppercase("hello"));
            Console.WriteLine(IsLowercase("hello"));
        }
    }
}
