using System;
using System.Runtime.CompilerServices;

namespace AbstractUygulama
{
    class Program
    {
        public abstract class Months
        {
            public int HoursOfADay()
            {
                return 24;
            }

            public virtual int DaysOfAMonth()
            {
                return 31;
            }
            public abstract int SequenceOfMonth();
        }

        class January : Months
        {
            public override int SequenceOfMonth()
            {
                return 1;
            }
        }

        class February : Months
        {
            public override int DaysOfAMonth()
            {
                return 28;
            }

            public override int SequenceOfMonth()
            {
                return 2;
            }
        }
        static void Main(string[] args)
        {
            January j1 = new January();
            Console.WriteLine($"This month is {j1.SequenceOfMonth()}th month of the year and has {j1.DaysOfAMonth()} days and one day has {j1.HoursOfADay()} hours");
            February f1 = new February();
            Console.WriteLine($"This month is {f1.SequenceOfMonth()}th month of the year and has {f1.DaysOfAMonth()} days");
        }
    }
}
