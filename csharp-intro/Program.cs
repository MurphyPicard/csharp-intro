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
            var summary = StringUtility.SummerizeText(sentence, 35); // notice how I changed maxLength
            Console.WriteLine(summary);

        }

    }
}
