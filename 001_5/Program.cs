using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_5
{
	internal class Program
	{
		static void Main()
		{
			while (true) {
				Write("Введiть дату у форматi дд.мм.рррр: ");
				string[] d = ReadLine().Split('.');
				int[] dat = new int[3];
				for (int i = 0; i < 3; i++)
					dat[i] = Convert.ToInt32(d[i]);
				DateTime date = new DateTime(dat[2], dat[1], dat[0]);
				switch (dat[1])
				{
					case 12:
					case 1:
					case 2: Write("Winter "); break;
					case 3:
					case 4:
					case 5: Write("Spring "); break;
					case 6:
					case 7:
					case 8: Write("Summer "); break;
					default: Write("Autumn "); break;
				}
				WriteLine(date.DayOfWeek);
			}
		}
	}
}
