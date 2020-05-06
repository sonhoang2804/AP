using System;
using System.Threading;

namespace AP.Session8
{
    public class Clock
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Run3);
            t1.Start(1);
        }

        public static void Run3(object o)
        {
            int n = (int) o;
            for (int i =n-1; i >= 0; i--)
            {
                for (int j = 59; j >= 0; j--)
                {
                    //key word: number format 01 02 in C#
                    Console.WriteLine(i.ToString("D2") + ":" + j.ToString("D2"));
                    Thread.Sleep(10);
                }
            }
            Console.WriteLine("Boom...");
        }
    }
}