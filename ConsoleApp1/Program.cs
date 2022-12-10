using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = { 300000, 1000000 };

            Console.WriteLine("Minimum number is " + arr.Min());
            Console.WriteLine("Maximum number is " + arr.Max());
        }
    }
}

   