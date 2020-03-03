using System;

namespace lesson2HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isStudent = true;

            int age = 44;
            int price;

            if(age >= 65) {
                price = 7;
            } else if(age <= 12 || isStudent) {
                price = 8;
            } else {
                price = 10;
            }

             if(age < 0) {
                Console.WriteLine("Invalid age");
            }  else {
                Console.WriteLine(price);
            }
        }
    }
}
