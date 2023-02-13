using System;
using System.Collections.Generic;
using System.IO;

namespace ekz {
	class MyDictionary {
		SortedList<string, string> OneTwo = new SortedList<string, string>();
		string from;
		string to;
		~MyDictionary() {
			FileStream fout1 = new FileStream(from, FileMode.Create, FileAccess.Write);
			StreamWriter rout1 = new StreamWriter(fout1);
			FileStream fout2 = new FileStream(to, FileMode.Create, FileAccess.Write);
			StreamWriter rout2 = new StreamWriter(fout2);
			foreach (var item in OneTwo) {
				rout1.WriteLine(item.Key);
				rout2.WriteLine(item.Value);
			}
			rout2.Close();
			fout2.Close();
			rout1.Close();
			fout1.Close();
		}
		public void LoadSome(string file1, string file2) {
			from = file1;
			to = file2;
			Load(file1, file2, ref OneTwo);
		}
		public void Load(string file, string file2, ref SortedList<string, string> m) {
			FileStream fin1 = new FileStream(file, FileMode.Open, FileAccess.Read);
			StreamReader rin1 = new StreamReader(fin1);
			FileStream fin2 = new FileStream(file2, FileMode.Open, FileAccess.Read);
			StreamReader rin2 = new StreamReader(fin2);
			string tmp;
			string tmp2;
			while (!rin1.EndOfStream) {
				tmp = rin1.ReadLine();
				tmp2 = rin2.ReadLine();
				try {
					m.Add(tmp, tmp2);
				}
				catch { }
			}
			rin2.Close();
			fin2.Close();
			rin1.Close();
			fin1.Close();
		}
		public string Translate(string word) {
			if (OneTwo == null)
				throw new Exception("Словники не завантаженi");
			if (word != "") {
				try {
					return OneTwo[word];
				}
				catch (Exception ex) { Console.WriteLine("Слово не знайдено"); }
			}
			return "";
		}
		public bool isLoad() { return (OneTwo != null); }
		public bool Add(string word, string word2) {
			if (word != "") {
				OneTwo.Add(word, word2);
				return true;
			}
			else
				return false;
		}
		public bool Remove(string word) {
			if (word != "" && OneTwo[word] != null) {
				OneTwo.Remove(word);
				return true;
			}
			else
				return false;
		}
		public bool Edit(string whatWord, string newWord) {
			if (newWord != "" && OneTwo[whatWord] != null) {
				OneTwo[whatWord] = newWord;
				return true;
			}
			else
				return false;
		}
	}
	internal class Program {
		static public void ChooseLanguages(ref string sfrom, ref string sto) {
			int from, to;
			while (true) {
				Console.WriteLine("З якої мови буде здiйснено переклад?");
				Console.WriteLine("1. English\n2. Українська\n3. Polski");
				from = int.Parse(Console.ReadLine());
				if (from > 1 || from < 3)
					break;
				Console.Clear();
				Console.WriteLine("Невiрно введена цифра. Повторiть спробу.");
			}
			Console.Clear();
			while (true) {
				Console.WriteLine("На яку мову буде здiйснено переклад?");
				Console.WriteLine("1. English\n2. Українська\n3. Polski");
				to = int.Parse(Console.ReadLine());
				if (to > 1 || to < 3)
					break;
				Console.Clear();
				Console.WriteLine("Невiрно введена цифра. Повторiть спробу.");
			}
			switch (from) {
				case 1: sfrom = "Eng.txt"; break;
				case 2: sfrom = "UA.txt"; break;
				case 3: sfrom = "PL.txt"; break;
			}
			switch (to) {
				case 1: sto = "Eng.txt"; break;
				case 2: sto = "UA.txt"; break;
				case 3: sto = "PL.txt"; break;
			}
		}
		static void Main(string[] args) {
			try {
				MyDictionary dict = new MyDictionary();
				int index;
				string from = null, to = null, word, newWord;
				Console.WriteLine("Перекладач готовий до роботи!\n");
				ChooseLanguages(ref from, ref to);
				dict.LoadSome(from, to);
				while (true) {
					Console.Clear();
					Console.WriteLine("1. Перекласти слово\n2. Додати слово\n3. Видалити слово");
					Console.WriteLine("4. Редагувати слово\n0. Вихiд");
					index = int.Parse(Console.ReadLine());
					switch (index) {
					case 0: return;
					case 1: {
						Console.Write("Введiть слово: ");
						word = Console.ReadLine();
						Console.WriteLine($"{word} - {dict.Translate(word)}");
						Console.WriteLine("Натиснiть Enter для продовження");
						Console.ReadLine();
						break;
					}
					case 2: {
						Console.Write("Введiть слово: ");
						word = Console.ReadLine();
						Console.Write("Введiть переклад слова: ");
						newWord = Console.ReadLine();
						Console.WriteLine(dict.Add(word, newWord) ? "Слово успiшно додано" : "Сталася помилка");
						Console.WriteLine("Натиснiть Enter для продовження");
						Console.ReadLine();
						break;
					}
					case 3: {
						Console.Write("Введiть слово: ");
						word = Console.ReadLine();
						Console.WriteLine(dict.Remove(word) ? "Слово успiшно видалено" : "Сталася помилка");
						Console.WriteLine("Натиснiть Enter для продовження");
						Console.ReadLine();
						break;
					}
					case 4: {
						Console.Write("Введiть старе слово: ");
						word = Console.ReadLine();
						Console.Write("Введiть нове слово: ");
						newWord = Console.ReadLine();
						Console.WriteLine(dict.Edit(word, newWord) ? "Слово вiдредаговано" : "Сталася помилка");
						Console.WriteLine("Натиснiть Enter для продовження");
						Console.ReadLine();
						break;
					}
					default:
						Console.WriteLine("Невiрно введена цифра. Повторiть спробу."); break;
					}
				}
			}
			catch (Exception e) { Console.WriteLine(e.ToString()); }
		}
	}
}
