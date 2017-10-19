using System;
using System.Collections.Generic;

namespace challengeThreeTL
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> roadtohire = new Dictionary<string, int>();

            roadtohire.Add("Miguel", 21);
            roadtohire.Add("Teia", 23);
            roadtohire.Add("Chris", 21);
            roadtohire.Add("Malik", 21);
            roadtohire.Add("Hunter", 19);
            roadtohire.Add("Lesly", 18);
            roadtohire.Add("Marcus", 18);
            roadtohire.Add("Angel", 19);
            roadtohire.Add("Mickey", 19);
            roadtohire.Add("Ivan", 18);
            roadtohire.Add("Victoria", 23);
            roadtohire.Add("Brittany", 23);
            roadtohire.Add("Ian", 20);
            roadtohire.Add("Juan", 19);
            roadtohire.Add("Maggie", 21);

            //Check how many keys are in a dictionary
            int count1 = roadtohire.Count;

            Console.WriteLine("They're "+ count1 + " students in the class." );
            ///So long pal, Just drop out!
            roadtohire.Remove("Maggie");
            //count again now that maggie left us :(
            int count2 = roadtohire.Count;

            Console.WriteLine("Oh, no! Maggie left to college now we have " + count2 + " students.");

            if (roadtohire.ContainsKey("Miguel"))
            {
                int Age = roadtohire["Miguel"];
                Console.WriteLine("Miguel is " + Age + " young.");
            }
        }
    }
}
