using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_4 {
	internal class Program {
		static void Main(string[] args) {
			try {
				using (FileStream file = new FileStream("file.txt", FileMode.Open, FileAccess.ReadWrite)) {
					StreamReader fout = new StreamReader(file);
					StreamWriter fin = new StreamWriter(file);
					char[] array = fout.ReadToEnd().ToCharArray();
					file.Position = 0;
					for (int i = array.Length - 1; i >= 0; i--)
						fin.Write(array[i]);
					fin.Close();
					fout.Close();
				}
			}
			catch (FileNotFoundException e){
				Console.WriteLine("Помилка вiдкриття файлу.");
			}
		}
	}
}
