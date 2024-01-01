using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    internal class DayClass1
    {
        static void Main()
        {
            string inputSentence = "Today is Wednesday";

            string convertedSentence = ConvertCase(inputSentence);

            Console.WriteLine("Original Sentence: " + inputSentence);
            Console.WriteLine("Converted Sentence: " + convertedSentence);
        }

        static string ConvertCase(string sentence)
        {
            char[] charArray = sentence.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                else if (char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }

            return new string(charArray);
        }
    }
}