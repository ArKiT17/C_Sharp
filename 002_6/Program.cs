using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_6 {
	internal class Program {
		static void Main(string[] args) {
			Console.Write("Введiть текст: ");
			string text = Console.ReadLine();
			char[] textC = text.ToCharArray();
			if (text[0] >= 'а' && text[0] <= 'я')
				textC[0] = (char)((int)textC[0] - 32);
			for (int i = 0; i < textC.Length; i++) {
				if (textC[i] == '.' || textC[i] == '!' || textC[i] == '?')
					if (text[i + 2] >= 'а' && text[i + 2] <= 'я')
						textC[i + 2] = (char)((int)textC[i + 2] - 32);
			}
			Console.WriteLine(textC);

			Console.ReadLine();
		}
	}
}
