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

            System.Console.WriteLine("Would you like to headpat her?");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("A: Yes");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("B: No");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("C: Check the ammount of times patted.");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("D: Check if she likes you!");
            System.Console.WriteLine(" ");

            start:
            string Input = System.Console.ReadLine();

            if(Input == "A" || Input == "a")
            {
                Test.Headpat(true);
                goto start;
            }
            if (Input == "B" || Input == "b")
            {
                System.Console.WriteLine("Ok then I guess.");
                goto start;
            }
            if (Input == "C" || Input == "c")
            {
                System.Console.WriteLine(Test.timesPatted);
                goto start;
            }
            if (Input == "D" || Input == "d")
            {
                if(Test.LikesYou == true)
                {
                    System.Console.WriteLine("She likes you!");
                }
                if (Test.LikesYou == false)
                {
                    System.Console.WriteLine("She doesn't likes you! :( ");
                }
                goto start;
            }

        }
    }
}
