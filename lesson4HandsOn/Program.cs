using System;

namespace lesson4HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubled NUmber: " + DoubleMe(4));
            Console.WriteLine("Quadrupled Number: " + QuadrupleMe(5));
            Console.WriteLine("Number Doubled Many Times: " + DoubleNumberMultipleTimes(2, 3));
        }

        public static int DoubleMe(int number) {
            return number * 2;
        }

        public static int QuadrupleMe(int number) {
            return DoubleMe(number) + DoubleMe(number);
        }

        public static int DoubleNumberMultipleTimes(int number, int amountOfTimes) {
            int result = 0;
            int num = number;
            for(int i = 1; i <= amountOfTimes; i++) {
                result = DoubleMe(num);
                num = result;
            }
            return result;
        }
    }
}
