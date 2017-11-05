using System;
using KemonomimiSharp;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            Kemonomimi Test = new Kemonomimi();

            Test.Name = "Kitsune";
            Test.Type = "fox";
            Test.Gender = "Female";
            Test.Weight = 200.00f;

            Test.LogAll();

            Console.WriteLine(" ");

            Console.WriteLine("Would you like to headpat " + Test.Name + "?");

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("A: Yes");

            Console.WriteLine(" ");

            Console.WriteLine("B: Yes");

            Console.WriteLine(" ");

            Console.WriteLine("P: Get the ammount of times patted");
                    
            Console.WriteLine(" ");

            start:

            String x = Console.ReadLine();

            if (x == "A" || x == "a")
            {
                Test.Headpat();
                Test.Patted = Test.Patted + 1;
                goto start;

            }

            if (x == "B" || x == "b")
            {
                Console.WriteLine("Ok then I guess.");
                goto start;
            }

            if (x == "P" || x == "p")
            {
                Console.WriteLine(Test.Patted);
                goto start;
            }
        }
    }
}
