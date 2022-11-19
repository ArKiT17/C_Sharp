using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_5 {
	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Введiть вираз: ");
			string[] line = Console.ReadLine().Split('+');
			int sum = 0;
			for (int i = 0; i < line.Length; i++) {
				if (line[i].IndexOf('-') == -1)
					sum += Convert.ToInt32(line[i]);
				else {
					string[] tmp = line[i].Split('-');
					sum += Convert.ToInt32(tmp[0]);
					for (int j = 1; j < tmp.Length; j++)
						sum -= Convert.ToInt32(tmp[j]);
				}
			}
			Console.WriteLine("Result: " + sum);
			Console.ReadLine();
		}
	}
}