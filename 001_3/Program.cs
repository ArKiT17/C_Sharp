using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_3
{
	internal class Program
	{
		static void Main()
		{
			while (true) {
				Write("Enter 4 numbers: ");
				string[] numbers = ReadLine().Split(' ');
				if (numbers.Length != 4) {
					WriteLine("Error");
					continue;
				}
				int result = 0;
				for (int i = 0; i < 4; i++)	{
					if (Convert.ToInt32(numbers[i]) < 0 || Convert.ToInt32(numbers[i]) > 9) {
						WriteLine("Error");
						break;
					}
					result = result * 10 + Convert.ToInt32(numbers[i]);
				}
				WriteLine(result);
			}
		}
	}
}
