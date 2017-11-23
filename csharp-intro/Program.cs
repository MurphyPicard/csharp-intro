using System; // So I can use Console
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_intro.Math; // So I can use calculator


// CTRL f5 to run
// CTRL Shift B to check

namespace csharp_intro
{
    public enum ShippingMethod
    {
        Regular = 1,
        Registered = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            // Imagine we are getting the number 3 from somewhere else
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // var firstName = "Ara";


            //var numbers = new int[3] { 0, 1, 2 };
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;
            //for (var i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(flags[i]);
            //}

            //var names = new string[3] {"Jack", "John", "Mary"};

            //var zara = new Person();
            //zara.Firstname = "RoZara";
            //zara.Lastname = "Yaghsizian";
            //zara.Introduce();


            //Console.WriteLine("hi");

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(3, 7);
            //Console.WriteLine(result);


            //var a = 10;
            //var b = 3;
            //Console.WriteLine((float)a / (float)b);


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
