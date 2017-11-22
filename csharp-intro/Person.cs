using System; // So I can use Console

// CTRL f5 to run
// CTRL Shift B to check

namespace csharp_intro
{
    public class Person
    {
        public string Firstname;
        public string Lastname;

        public void Introduce()
        {
            Console.WriteLine("My name is " + Firstname + " " + Lastname);
 
        }

    }
}
