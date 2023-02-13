using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_2 {
	internal class Program {
		static void Main(string[] args) {
			try {
				Console.Write("Введiть шлях або назву файлу: ");
				string path = Console.ReadLine();
				Console.Write("Введiть шукане слово: ");
				string wrongWord = Console.ReadLine();
				Console.Write("Введiть слово для замiни: ");
				string newWord = Console.ReadLine();
				using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite)) {
					StreamReader fout = new StreamReader(file);
					string[] allWords = fout.ReadToEnd().Split(' ');
					StreamWriter fin = new StreamWriter(file);
					file.Position = 0;
					for (int i = 0; i < allWords.Length; i++) {
						if (allWords[i] == wrongWord)
							allWords[i] = newWord;
						fin.Write($"{allWords[i]} ");
					}
					fin.Close();
					fout.Close();
				}
			}
			catch (FileNotFoundException e) {
				Console.WriteLine("Помилка вiдкриття файлу.");
			}
		}
	}
}