using System;

namespace KemonomimiSharp
{
    public class Kemonomimi
    {
        public string Name;
        public string Type;
        public string Gender = "Female";
        public float Wieght;
        public int Points = 0;

        public bool LikesYou;

        public int timesPatted = 0;
        public int preferedPats = 2;
        public string pattedMessage = "Is really loving you right now!";
        public string annoyedMessage = "Is starting to get kind of annoyed.";

        public void logAll(bool Indents)
        {
            if (Indents == false)
            {
                Console.WriteLine(Name);
                Console.WriteLine(Type);
                Console.WriteLine(Gender);
            }
            else
            {
                Console.WriteLine(Name);
                Console.WriteLine(" ");
                Console.WriteLine(Type);
                Console.WriteLine(" ");
                Console.WriteLine(Gender);
            }
                
        }

        public void checkLike(int recommendedPoints)
        {
            if(Points >= recommendedPoints)
            {
                LikesYou = true;
            }
        }

        public void Headpat(bool nameBeforeMessage)
        {
            timesPatted = timesPatted + 1;
            checkLike(2);
            if (timesPatted <= preferedPats)
            {
                Points = Points + 1;
                if (nameBeforeMessage == true)
                {
                    Console.WriteLine(Name + " " + pattedMessage);
                }
                else
                {
                    Console.WriteLine(pattedMessage);
                }
            }
            if (timesPatted > preferedPats)
            {
                if (nameBeforeMessage == true)
                {
                    Console.WriteLine(Name + " " + annoyedMessage);
                }
                else
                {
                    Console.WriteLine(annoyedMessage);
                }
            }
        }
    }
}
