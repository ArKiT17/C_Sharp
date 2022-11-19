using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _001_7
{
	internal class Program
	{
		static void Main()
		{
			while (true) {
				Write("Введiть два числа: ");
				string[] tmp = ReadLine().Split(' ');
				int from = Convert.ToInt32(tmp[0]);
				int to = Convert.ToInt32(tmp[1]);
				if (from > to)
				{
					int a;
					a = from;
					from = to;
					to = a;
				}
				if (from % 2 != 0)
					from++;
				for (int i = from; i < to + 1; i += 2)
					Write($"{i} ");
				WriteLine();
			}
		}
	}
}
