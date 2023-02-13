using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_3 {
	internal class Program {
		static void Main(string[] args) {
			try {
				Console.Write("Введiть шлях або назву файлу з текстом: ");
				string filePath = Console.ReadLine();
				Console.Write("Введiть шлях або назву файлу з модерованими словами: ");
				string moderatorPath = Console.ReadLine();
				FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
				FileStream moder = new FileStream(moderatorPath, FileMode.Open, FileAccess.Read);
				StreamReader fout = new StreamReader(file);
				string[] allWords = fout.ReadToEnd().Split(' ', '\r', '\n');
				StreamReader mout = new StreamReader(moder);
				string[] moderWords = mout.ReadToEnd().Split(' ', '\r', '\n');
				StreamWriter fin = new StreamWriter(file);
				file.Position = 0;
				string star = null;
				for (int i = 0; i < allWords.Length; i++) {
					for (int j = 0; j < moderWords.Length; j++) {
						if (allWords[i] == moderWords[j]) {
							star = "";
							for (int k = 0; k < allWords[i].Length; k++) {
								star = $"{star}*";
							}
							allWords[i] = star;
						}
					}
					fin.Write($"{allWords[i]} ");
				}
				fin.Close();
				mout.Close();
				fout.Close();
				moder.Close();
				file.Close();
			}
			catch (FileNotFoundException e) {
				Console.WriteLine("Помилка вiдкриття файлу.");
			}
		}
	}
}