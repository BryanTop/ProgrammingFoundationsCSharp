using System;

namespace BlingBong
{
    public class BlingBongText
    {
        public static void StartBlingBong() {
            for(int i = 1; i <= 100; i++) {

                if( i%5 == 0 && i%3 == 0) {
                    Console.WriteLine("BlingBlong");
                    continue;
                }
                
                if ( i%3 == 0) {
                    Console.WriteLine("Bling");
                    continue;
                }

                if ( i%5 == 0) {
                    Console.WriteLine("Blong");
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}