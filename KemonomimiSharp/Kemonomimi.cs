using System;

namespace KemonomimiSharp
{
    public class Kemonomimi
    {
        public String Name;
        public String Type;
        public String Gender;
        public float Weight;
        public bool LikesYou;
        public int Patted;
        public int Points;

        public void LogName()
        {
            Console.WriteLine(Name);
        }


        public void LogType()
        {
            Console.WriteLine(Type);
        }


        public void LogGender()
        {
            Console.WriteLine(Gender);
        }


        public void LogWeight()
        {
            Console.WriteLine(Weight);
        }


        public void LogLikes()
        {
            Console.WriteLine(LikesYou);
        }


        public void LogTimesPatted()
        {
            Console.WriteLine(Patted);
        }

        public void LogAll()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Type);
            Console.WriteLine(Gender);
            Console.WriteLine(Weight + " Pounds");
        }

        public void Headpat()
        {
            Test.Patted = Test.Patted + 1;

            if (Patted <= 2)
            {
                Points = Points + 1;
            }


            if (Patted > 2)
            {
                Points = Points - 1;
                Console.WriteLine(Name + " is starting to get kind of annoyed");
            }


            if (Type == "Fox" || Type == "fox" || Type == "Kitsune" || Type == "kitsune" || Type == "Bunny" || Type == "bunny" || Type == "Rabbit" || Type == "rabbit")
            {

                if (Patted < 2)
                {
                    Console.WriteLine(Name+ " Is really loving you right now!");
                }

            }


            if (Type == "Cat" || Type == "cat" || Type == "Neko" || Type == "neko")
            {
                Console.WriteLine(Name + " has started purring!");
            }


            if (Type == "Dog" || Type == "dog" || Type == "Wolf" || Type == "wolf" || Type == "Okami" || Type == "okami")
            {
                Console.WriteLine(Name + " has started panting in happyness!");
            }


        }

    }
}
