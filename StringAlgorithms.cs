using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Example
{
   public class StringAlgorithms
    {
        //1- Introduction Section Algorithms
        public int findMaximum (int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c || a == c)
                {
                    return a;
                }
            }
            if (b > c)
            {
                if (b > a || a == b)
                {
                    return b;
                }
            }

            return c;
        }

        public int findMaximum2 (int a, int b, int c)
        {
            int max = a;


            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            return max;
        }

        //2- Validation Algorithms
        public bool isUpperCase (string s)
        {

            return s.All(char.IsUpper);
        }
        public bool isLowerCase (string s)
        {

            return s.All(char.IsLower);
        }

        public bool isPasswordComplex (string s)
        {

            return s.Any(char.IsLower) && s.Any(char.IsUpper) && s.Any(char.IsDigit);
        }

        //3- Normalize String Algorithms (Normalize to common form. Ex. lowercase )
        public string normalizeString (string input)
        {
            /*Long Form 
            string lowercased = input.ToLower();
            string trimmed = lowercased.Trim(); //remove extra whitespaces
            return trimmed.Replace(",", "");*/

            return input.ToLower().Trim().Replace(",", "");
        }

        //4- Parse and Search String
        public void ParseContents (string s)
        {
            Console.WriteLine("Option 1");

            foreach (char c in s)
            {

                Console.WriteLine(c);
            }


            Console.WriteLine("Option 2");

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
        }

        public Boolean IsAtEvenIndex (String s, char item)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }

            for (int i = 0; i < s.Length / 2 + 1; i = i + 2)
            {
                if (s[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        //5- Reverse Each Word
        public String Reverse (String input)
        {
            if (String.IsNullOrEmpty(input))
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



        public String Reverse2 (String input) //Convert String to array and then Convert back to String.
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            char[ ] arr = input.ToCharArray(); //converts string into a character array
            Array.Reverse(arr);
            var result = new String(arr);
            return result;

        }




        public String ReverseSentence (String input) //Convert String to array and then Convert back to String.
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            String[ ] spearator = { " " };

            string[ ] subs = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);


            foreach (var sub in subs)
            {

                Console.WriteLine($"Substring: {sub}"); // Print the words separately

            }


            StringBuilder reversed = new StringBuilder(input.Length);

            for (int j = 0; j < subs.Length; j++)
            {
                char[ ] arr = subs[j].ToCharArray(); //converts string into a character array
                Array.Reverse(arr);
                var result = new String(arr);
                reversed.Append(result + " ");

                Console.WriteLine("subs " + j + " reverse: " + result);
            }


            return reversed.ToString();

        }
    }
}

