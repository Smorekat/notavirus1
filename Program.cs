using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace CodeBruh
{
    class Program
    {
        public static int s;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("bruh");
                s += 1;
                Console.WriteLine(s);
            }
        }
    }
}
