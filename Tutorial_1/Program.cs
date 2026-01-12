
using System;

namespace SystemInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- THONG TIN HE THONG ---");
            // 1. Phien ban OS
            Console.WriteLine("OS Version: " + Environment.OSVersion.ToString());
            
            // 2. Thu muc hien tai
            Console.WriteLine("Current Directory: " + Environment.CurrentDirectory);
            
            // 3. Thoi gian he thong
            Console.WriteLine("System Time: " + DateTime.Now.ToString());
            
            Console.ReadKey();
        }
    }
}
