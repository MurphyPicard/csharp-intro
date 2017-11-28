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

            //////////////////////////////////////////////// Playing with Strings
            var fullname = "Ara Yags";
            Console.WriteLine("Trim: '{0}'", fullname.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullname.Trim().ToUpper());

            var index = fullname.IndexOf(' ');
            var firstname = fullname.Substring(0, index);
            var lastname = fullname.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstname);
            Console.WriteLine("lastname: " + lastname);





            //////////////////////////////////////////// Creating TimeSpan objects
            //var timespan = new TimeSpan(1,2,8);

            //var timespan1 = new TimeSpan(1,1,8);
            //TimeSpan.FromSeconds(8);

            //var start = DateTime.Now;
            //var end = DateTime.Now.AddSeconds(18);
            //var duration = end - start;
            //Console.WriteLine("Duration: " + duration);


            //// Two of many properties
            //Console.WriteLine("Minutes: " + timespan.Minutes);            // Displays just the minutes
            //Console.WriteLine("Total Minutes: " + timespan.TotalMinutes); // Displays the whole timespan in minutes


            ////////////////////////////////////////////////////// DateTime
            //var datetime = new DateTime(1999, 12, 31);
            //var now = DateTime.Now;
            //var today = DateTime.Today;

            //Console.WriteLine(datetime);
            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.ToString("yyyy MMMM dd hh:mm:ss"));
            //Console.WriteLine(today);

            //////////////////////////////////////////////////////////////////////
            //var numbers = new List<int>() {9,8,7,6};
            //numbers.Add(1);
            //numbers.AddRange(new int[3] {55,66,77});
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();
            //Console.WriteLine("numbers.indexof(6): " + numbers.IndexOf(6));
            //Console.WriteLine("numbers.lastindexof(6): " + numbers.LastIndexOf(6));
            //Console.WriteLine("numbers.count: " + numbers.Count);
            //Console.WriteLine("numbers.Contains(6): " + numbers.Contains(6));
            //Console.WriteLine("numbers.remove(6): " + numbers.Remove(6));
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            ////////////////////////////////////////////////////////
            //var numbers = new int[5] {4,3,2,1,0};

            //// Length
            //Console.WriteLine("Length: " + numbers.Length);

            //// IndexOf()
            //var index = Array.IndexOf(numbers, 4);
            //Console.WriteLine("Index of 4: " + index);
            //Console.WriteLine();

            //// Clear
            //Array.Clear(numbers, 0 ,2);
            //Console.WriteLine("Effect of Clear: ");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();

            //// Copy
            //var another = new int[3];
            //Array.Copy(numbers, another, 3);
            //Console.WriteLine("Effect of Copy: ");
            //foreach (var n in another)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine();

            //// Sort
            //Array.Sort(numbers);
            //Console.WriteLine("Effect of Sort: ");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();


            ////////////////////////////////////////////////////
            //var random = new Random();

            //const int passwordLength = 9;

            //var buffer = new char[passwordLength];

            //for (int i = 0; i < passwordLength; i++)
            //    buffer[i] = (char) ('a' + random.Next(0, 26));

            //var password = new string(buffer);

            //Console.WriteLine(password);






            //////////////////////////////////////////////////////////
            // Section 5-41 Exercise 3 ... landscape or portrait
            //Console.WriteLine("What is the height? ");
            //var height = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What is the width? ");
            //var width = Convert.ToInt32(Console.ReadLine());

            //// Perfect square pics will be portrait
            //var pic = (width > height) ? "Landscape" : "Portrait";
            //Console.WriteLine("The image is in " + pic + " mode.");

            ///////////////////////////////////////////////////////////
            // Section 5-41 Exercise 2 ... max of two numbers
            //Console.WriteLine("Please type the first number: ");
            //var first = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please type the second number: ");
            //var second = Convert.ToInt32(Console.ReadLine());

            //var bigger = (first > second) ? first : second;
            //Console.WriteLine("This is the bigger number: " + bigger);

            ///////////////////////////////////////////////////////////
            // Section 5-41 Exercise 1 ... pick 1 - 10
            //Console.WriteLine("Please enter a number between 1 and 10");
            //var pick = Convert.ToInt32(Console.ReadLine());

            //var isValid = (pick < 10 && pick > 1) ? true : false;
            //Console.WriteLine(isValid);

            //////////////////////////////////////////////////////////
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //// Imagine we are getting the number 3 from somewhere else
            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            //// Parsing a string
            //var methodName = "Express";
            //var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

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
