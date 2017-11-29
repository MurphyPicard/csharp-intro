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

            var files = Directory.GetFiles(@"C:\Users\ADMIN\source\repos\csharp-intro", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("hi");

        }

    }
}
