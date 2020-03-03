using System;
using BlingBongText = BlingBong.BlingBongText;
using SequenceText = Sequence.SequenceText;

namespace finalProject
{
    class Program
    {
        static void Main(string[] args)
        {
           BlingBongText.StartBlingBong();
           SequenceText.AddPreviousNTimes(8);
        }
    }
}
