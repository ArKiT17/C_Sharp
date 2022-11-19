using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_2
{
    internal class Program
    {
        static void Main()
        {
            while (true){
                Write("Enter two numbers: ");
                string numbers = ReadLine();
                string[] tmp = numbers.Split(' ');
                double one = Convert.ToDouble(tmp[0]);
                double two = Convert.ToDouble(tmp[1]);
                WriteLine($"Result: {one * (two / 100)}");
            }
        }
    }
}
