﻿using System; // So I can use Console
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

            var numbers = new int[5] {0, 1, 2, 3, 4};

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine("Index of 4: " + index);


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
