using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_5 {
	internal class Program {
		static void Main(string[] args) {
			try {
				FileStream fout = new FileStream("file.txt", FileMode.Open, FileAccess.Read);
				StreamReader outMain = new StreamReader(fout);
				FileStream fPlus = new FileStream("Plus.txt", FileMode.Create, FileAccess.Write);
				StreamWriter outPlus = new StreamWriter(fPlus);
				FileStream fMinus = new FileStream("Minus.txt", FileMode.Create, FileAccess.Write);
				StreamWriter outMinus = new StreamWriter(fMinus);
				FileStream fTwo = new FileStream("Two.txt", FileMode.Create, FileAccess.Write);
				StreamWriter outTwo = new StreamWriter(fTwo);
				FileStream fFive = new FileStream("Five.txt", FileMode.Create, FileAccess.Write);
				StreamWriter outFive = new StreamWriter(fFive);
				string[] numbers = outMain.ReadToEnd().Split(' ', '\n');
				int countPlus = 0, countMinus = 0, countTwo = 0, countFive = 0, countOfNumbers, tmp;
				foreach (string num in numbers) {
					tmp = int.Parse(num);
					if (tmp >= 0) {
						countPlus++;
						outPlus.Write($"{num} ");
					}
					if (tmp < 0) {
						countMinus++;
						outMinus.Write($"{num} ");
					}
					countOfNumbers = 0;
					while (tmp != 0) {
						tmp /= 10;
						countOfNumbers++;
					}
					switch (countOfNumbers) {
						case 2: countTwo++; outTwo.Write($"{num} "); break;
						case 5: countFive++; outFive.Write($"{num} "); break;
					}
				}
				Console.WriteLine($"Кiлькiсть додатнiх чисел - {countPlus}");
				Console.WriteLine($"Кiлькiсть вiд'ємних чисел - {countMinus}");
				Console.WriteLine($"Кiлькiсть двозначних чисел - {countTwo}");
				Console.WriteLine($"Кiлькiсть п'ятизначних чисел - {countFive}");

				outFive.Close();
				fFive.Close();
				outTwo.Close();
				fTwo.Close();
				outMinus.Close();
				fMinus.Close();
				outPlus.Close();
				fPlus.Close();
				outMain.Close();
				fout.Close();
			}
			catch (FileNotFoundException e) {
				Console.WriteLine("Помилка вiдкриття файлу.");
			}
		}
	}
}
