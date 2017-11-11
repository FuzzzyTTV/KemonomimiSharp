using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            KemonomimiSharp.Kemonomimi Test = new KemonomimiSharp.Kemonomimi();
            Test.Name = "Kitsune";
            Test.Type = "Fox";
            Test.Gender = "Female";

            Test.logAll(false);

            Console.WriteLine("Would you like to headpat her?");
            Console.WriteLine(" ");
            Console.WriteLine("A: Yes");
            Console.WriteLine(" ");
            Console.WriteLine("B: No");
            Console.WriteLine(" ");
            Console.WriteLine("C: Check the ammount of times patted.");
            Console.WriteLine(" ");
            Console.WriteLine("D: Check if she likes you!");
            Console.WriteLine(" ");

            start:
            string Input = Console.ReadLine();

            if(Input == "A" || Input == "a")
            {
                Test.Headpat(true);
                goto start;
            }
            if (Input == "B" || Input == "b")
            {
                Console.WriteLine("Ok then I guess.");
                goto start;
            }
            if (Input == "C" || Input == "c")
            {
                Console.WriteLine(Test.timesPatted);
                goto start;
            }
            if (Input == "D" || Input == "d")
            {
                if(Test.LikesYou == true)
                {
                    Console.WriteLine("She likes you!");
                }
                if (Test.LikesYou == false)
                {
                    Console.WriteLine("She doesn't likes you! :( ");
                }
                goto start;
            }

        }
    }
}
