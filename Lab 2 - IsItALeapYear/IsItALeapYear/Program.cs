using System;

namespace IsItALeapYear
{
    public class Program
    {
        public bool IsItALeapYear(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) ? true : false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
