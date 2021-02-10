using System;
using System.Diagnostics;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test_Normal();
            //Test_StringBuilder();
        }

        private static void Test_Normal()
        {
            Console.WriteLine($"Start Normal: {DateTime.Now.ToLongTimeString()}");
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            string text = "";
            for (int i = 0; i < 250_000; i++)
            {
                text += "a";
            }
            
            Console.WriteLine($"End Normal: {DateTime.Now.ToLongTimeString()} ({sw.Elapsed.TotalSeconds} seconds)");
        }
        
        private static void Test_StringBuilder()
        {
            Console.WriteLine($"Start StringBuilder: {DateTime.Now.ToLongTimeString()}");
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            StringBuilder sb = new StringBuilder();
            
            string text = "";
            for (int i = 0; i < 250_000; i++)
            {
                sb.Append("a");
            }
            
            Console.WriteLine($"End StringBuilder: {DateTime.Now.ToLongTimeString()} ({sw.Elapsed.TotalSeconds} seconds)");
        }
    }
}