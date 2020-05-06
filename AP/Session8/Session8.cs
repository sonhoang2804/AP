using System;
using System.Threading;

namespace AP.Session8
{
    public class Session8
    {
        private int number = 0;
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRun);
            t1.Start("Xin chao"); // chay luong moi
            
            Thread t2 = new Thread(new Session8().run2);
            t2.Start();
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main i = " + i);
                Thread.Sleep(100);
            }
        }

        public static void ThreadRun(object o) // ko co tham so hoac 1 tham so object 
        {
            string msg = (string) o; //down casting
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i = " + i);
                Thread.Sleep(100);
            }
        }

        public void run2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("run2 xyz = " + (number += 2));
                Thread.Sleep(100);
            }
        }

        
    }
}