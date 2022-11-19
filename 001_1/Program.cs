using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace _001_1
{
	internal class Program
	{
		static void Main()
		{
			while (true) {
				Write("Enter the number from 1 to 100: ");
				int number = Convert.ToInt32(ReadLine());
				if (number < 1 || number > 100) { 
					WriteLine("Wrong number. Please, try again.");
					continue;
				}
				if (number % 3 == 0)
                    WriteLine("Fizz");
				if (number % 5 == 0)
                    WriteLine("Buzz");
				if (number % 3 != 0 && number % 5 != 0)
					WriteLine(number);
			}
		}
	}
}
