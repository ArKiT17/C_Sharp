using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_6
{
	internal class Program
	{
		static void Main()
		{
			while (true) {
				Write("Введiть температуру: ");
				double degree = Convert.ToDouble(Console.ReadLine());
				while (true) {
					WriteLine("1. Перевести з градусiв Цельсiю у Фарингейта");
                    WriteLine("2. Перевести з градусiв Фарингейта у Цельсiя");
					string choise = ReadLine();
					if (choise == "1") {
						WriteLine(degree * 1.8 + 32);
						break;
					}
					else if (choise == "2")	{
						WriteLine((degree - 32) / 1.8);
                        break;
					}
					else {
						WriteLine("Сталася помилка. Повторiть запит");
                        break;
                    }
                }
			}
		}
	}
}
