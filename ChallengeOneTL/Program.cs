using System;

namespace ChallengeOneTL
{
    namespace Division2numbers
    {
        class Program
        {
            static void Main(string[] args)
            {
                //Used to construct strings. An interpolated string looks like a template string that contains interpolated expressions.
                 //An interpolated string returns a string that replaces the interpolated expressions that it contains with their string representations.
                int div = 0, nb_1 = 0, nb_2 = 0;
                Console.Write("Enter a number : ");
                nb_1 = int.Parse(Console.ReadLine());
                Console.Write("Enter a second number : ");
                nb_2 = int.Parse(Console.ReadLine());
                Console.WriteLine("You divided {0} by {1} and it = {2}.", nb_1, nb_2, div = nb_1 / nb_2);
            }
        }
    }
}