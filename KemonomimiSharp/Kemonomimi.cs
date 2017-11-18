namespace KemonomimiSharp
{
    public class Kemonomimi
    {
        [MongoDB.Bson.Serialization.Attributes.BsonElement("Name")]
        public string Name;

        [MongoDB.Bson.Serialization.Attributes.BsonElement("Type")]
        public string Type;

        [MongoDB.Bson.Serialization.Attributes.BsonElement("Gender")]
        public string Gender = "Female";

        [MongoDB.Bson.Serialization.Attributes.BsonElement("Weight")]
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
                System.Console.WriteLine(Name);
                System.Console.WriteLine(Type);
                System.Console.WriteLine(Gender);
            }
            else
            {
                System.Console.WriteLine(Name);
                System.Console.WriteLine(" ");
                System.Console.WriteLine(Type);
                System.Console.WriteLine(" ");
                System.Console.WriteLine(Gender);
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
                    System.Console.WriteLine(Name + " " + pattedMessage);
                }
                else
                {
                    System.Console.WriteLine(pattedMessage);
                }
            }
            if (timesPatted > preferedPats)
            {
                if (nameBeforeMessage == true)
                {
                    System.Console.WriteLine(Name + " " + annoyedMessage);
                }
                else
                {
                    System.Console.WriteLine(annoyedMessage);
                }
            }
        }
    }
}
