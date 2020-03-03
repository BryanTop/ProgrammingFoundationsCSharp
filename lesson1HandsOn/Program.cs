using System;

namespace lesson1HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = false;
            bool atBeach = true;
            bool goAnyway = true;

            string wear = "Wear sunglasses!";
            string dontWear = "You don't need to wear sunglasses.";
            string sunblock  = "Sunblock is a good idea.";
            string noSunblock = "Sunblock isn't needed.";
            string going = "Awesome! Glad you don't mind clouds!";
            string nextTime = "No worries! Hopefully next time we will have some sun!";
            /*
            If it is sunny outside, print "Wear sunglasses!". If it is anything else, print "You don't need to wear sunglasses."
             */
            if(isSunny) {
                Console.WriteLine(wear);
                if(atBeach) {
                    Console.WriteLine(sunblock);
                } else {
                    Console.WriteLine(noSunblock);
                }
            } else {
                Console.WriteLine(dontWear);
                if(goAnyway) {
                    Console.WriteLine(going);
                } else {
                    Console.WriteLine(nextTime);
                }
            }

        }
    }
}
