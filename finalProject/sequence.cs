using System;

namespace Sequence
{
    public class SequenceText
    {
        public static void AddPreviousNTimes(int amountOfTImes = 0) {
            int firstNumber = 0;
            Console.WriteLine(firstNumber);
            int secondNumber = 1;
            Console.WriteLine(secondNumber);
            int thirdNumber = firstNumber + secondNumber;
            Console.WriteLine(thirdNumber);

            if(amountOfTImes < 0) {
                Console.WriteLine("Only Positives please");
            } else {
                for(int i = 0; i < amountOfTImes; i++) {
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = firstNumber + secondNumber;
                    Console.WriteLine(thirdNumber);
                }
            }

            
        }
    }
}