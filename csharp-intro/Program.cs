using System; // So I can use Console
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using csharp_intro.Math; // So I can use calculator


// CTRL f5 to run
// CTRL Shift B to check

namespace csharp_intro
{

    


    class Program
    {
        static void Main(string[] args)
        {

            var sentence = "This is a really really really really long sentence";
            var summary = SummerizeText(sentence, 35);
            Console.WriteLine(summary);

        }

        static string SummerizeText(string text, int maxLength = 20)
        {
            
            if (text.Length < maxLength)
                return text;
            
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;

            }
            
            return String.Join(" ", summaryWords) + "...";

        }
    }
}
