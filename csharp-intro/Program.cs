using System; // So I can use Console
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CTRL f5 to run
// CTRL Shift B to check

namespace csharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 10;
            var b = 3;
            Console.WriteLine((float)a / (float)b);


            //try
            //{
            //    string str = "true";
            //    bool b = Convert.ToBoolean(str);
            //    // byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("number could not be converted to a byte");
            //}

           


            // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //const float Pi = 3.14f;
            //Console.WriteLine(Pi);

            
            // int i = 1000;
            // byte b = (byte)i; // Doing a cast
            // Console.WriteLine(b);

        }
    }
}
