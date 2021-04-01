using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace Laba8
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            string number = Console.ReadLine();
            if (number.Length == 4)
                Console.WriteLine(number);
            else
            {
                var res = Regex.Replace(number, ".{4}", "$0-");
                Console.WriteLine(res);
            }
            

        }
    }
}
