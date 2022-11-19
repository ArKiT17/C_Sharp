using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_4
{
	internal class Program
	{
		static void Main()
		{
			while (true) {
				Write("Введiть шестизначне число: ");
				string number = ReadLine();
				if (number.Length != 6) {
					WriteLine("Error");
					continue;
				}
				int numi = Convert.ToInt32(number);
				int[] nums = new int[6];
				for (int i = 5; i >= 0; i--) {
					nums[i] = numi % 10;
					numi /= 10;
				}
				Write("Введiть розряди, якi потрiбно помiняти мiсцями: ");
				string[] tmp = ReadLine().Split(' ');
				int a = nums[Convert.ToInt32(tmp[0]) - 1];
				nums[Convert.ToInt32(tmp[0]) - 1] = nums[Convert.ToInt32(tmp[1]) - 1];
                nums[Convert.ToInt32(tmp[1]) - 1] = a;
				foreach (var i in nums) {
					Write(i);
				}
				Write('\n');
			}
		}
	}
}
