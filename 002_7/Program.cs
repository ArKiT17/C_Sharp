using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_7 {
	internal class Program {
		static void Main(string[] args) {
			Console.Write("Введiть заборонене слово: ");
			string noneWord = Console.ReadLine();
			Console.Write("\nВведiть речення: ");
			string line = Console.ReadLine();
			Console.WriteLine(line.Replace(noneWord, "***"));
		}
	}
}