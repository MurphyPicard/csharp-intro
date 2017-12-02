using System; // So I can use Console
using System.Collections.Generic;
using System.IO;
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

            // Debugging practice
            var numbers = new List<int> {1,2,3,4,5,6};
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
            {
                Console.WriteLine(number);                
            }
        }


        // to be continued 10-78
        //public static List<int> GetSmallests(List<int> list, int count)

        //public static int GetSmallest(List<int> list)
    }
}
