using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_1 {
	class Numbers {
		public static void Rectangular(int width, int length, char symbol) {
			for (int i = 0; i < length; i++) {
				for (int j = 0; j < width; j++)
					Console.Write(symbol);
				Console.WriteLine();
			}
		}
		public static bool Palindrom(int num) {
			string snum = Convert.ToString(num);
			char[] cnum = snum.ToCharArray();
			bool f = true;
			for (int i = 0; i < cnum.Length / 2; i++)
				if (cnum[i] != cnum[cnum.Length - i - 1])
					f = false;
			return f;
		}
		public static void Filter(ref char[] origArr, char[] filterArr) {
			string tmp = new string(origArr);
			for (int i = 0; i < filterArr.Length; i++)
				if (tmp.IndexOf(filterArr[i]) != -1)
					tmp = tmp.Replace(filterArr[i], (char)32);
			origArr = tmp.ToCharArray();
		}
	}
	internal class Program {
		static void Main(string[] args) {
			Numbers.Rectangular(5, 3, '☻');
			//Console.Write("Введiть ширину, довжину та символ через пробiл: ");
			//string[] ar = Console.ReadLine().Split(' ');
			//Numbers.Rectangular(int.Parse(ar[0]), int.Parse(ar[1]), char.Parse(ar[2]));

			int num = 151;
			//Console.Write("Введiть число: ");
			//num = int.Parse(Console.ReadLine());
			Console.WriteLine($"Чи являється число {num} палiндромом?");
			Console.WriteLine(Numbers.Palindrom(num));

			char[] original = {'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' };
			char[] fltr = { 'l', 'o' };
			//Console.Write("Введiть стрiчку: ");
			//string line = Console.ReadLine();
			//Console.Write("Введiть стрiчку фiльтру: ");
			//fltr = Console.ReadLine().ToCharArray();
			//original = line.ToCharArray();
			Numbers.Filter(ref original, fltr);
			Console.WriteLine(original);
		}
	}
}
