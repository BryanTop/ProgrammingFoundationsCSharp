using System;
using aP = anotherProgram.printAText;
using myN = myNamespace.AnotherProgram;

namespace lesson6HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            aP.printText();
            Console.WriteLine("Hello World!");
            myN.printText();
        }
    }
}
