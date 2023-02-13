using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _012_1 {
	internal class Program {
		static bool IsPrime(int number) {
			for (int i = 2; i < number; i++) {
				if (number % i == 0)
					return false;
			}
			return true;
		}
		static void Main(string[] args) {
			try {
				int[] list = new int[100];
				Random rand = new Random();
				Console.WriteLine("Згенерованi числа:");
				for (int i = 0; i < 100; i++) {
					list[i] = rand.Next(100);
					Console.Write($"{list[i]} ");
				}
				FileStream fout = new FileStream("Prime.txt", FileMode.Create);
				StreamWriter foutw = new StreamWriter(fout);
				FileStream fout2 = new FileStream("Fibo.txt", FileMode.Create);
				StreamWriter fout2w = new StreamWriter(fout2);
				for (int i = 0; i < 99; i++) {
					if (IsPrime(list[i]))
						foutw.Write($"{list[i]} ");
					fout2w.Write($"{list[i] + list[i + 1]} ");
				}
				if (IsPrime(list[99]))
					foutw.Write($"{list[99]} ");
				foutw.Close();
				Console.WriteLine("\nПотiк foutw закрився (файл Prime.txt)");
				fout.Close();
				Console.WriteLine("Потiк fout закрився (файл Prime.txt)");
				fout2w.Close();
				Console.WriteLine("Потiк fout2w закрився (файл Fibo.txt)");
				fout2.Close();
				Console.WriteLine("Потiк fout2 закрився (файл Fibo.txt)");
			}
			catch (FileNotFoundException e) {
				Console.WriteLine("Помилка вiдкриття файлу.");
			}
		}
	}
}
