﻿using System; // So I can use Console
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
            // var number = 2;


            // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //const float Pi = 3.14f;
            //Console.WriteLine(Pi);

            
            int i = 1;
            byte b = (byte)i; // Doing a cast
            Console.WriteLine(b);

        }
    }
}
