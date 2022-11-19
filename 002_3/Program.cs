using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_3 {
	internal class Program {
		static void Main(string[] args) {
			while (true) {
				Console.WriteLine("1. Зашифрувати стрiчку\n2. Розшифрувати стрiчку");
				string index = Console.ReadLine();
				Console.WriteLine("\nВведiть стрiчку: ");
				string line = Console.ReadLine();
				char[] tmp = line.ToCharArray();
				if (index == "1")
					for (int i = 0; i < line.Length; i++)
						tmp[i] = (char)((int)tmp[i] + 3);
				else if (index == "2")
					for (int i = 0; i < line.Length; i++)
						tmp[i] = (char)((int)tmp[i] - 3);
				else {
					Console.WriteLine("Неправильна цифра.");
					continue;
				}
				Console.WriteLine();
				Console.WriteLine(tmp);
			}
			Console.ReadLine();
		}
	}
}
