using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _010 {
	class SortedQueue<T1, T2> : SortedDictionary<T1, T2> {}
	class RoundQueue<T> : Queue { }
	class OneList<T> : List<T> { }
	internal class Program {
		static void Swap<T>(ref T a, ref T b) {
			T tmp = a;
			a = b;
			b = tmp;
		}
		static void Main(string[] args) {
			Console.WriteLine("Функцiя Swap");
			int x = 9, y = 3;
			Console.WriteLine($"{x} {y}");
			Swap<int>(ref x, ref y);
			Console.WriteLine($"{x} {y}");

			Console.WriteLine("\nКлас черга");
			SortedQueue<int, string> q = new SortedQueue<int, string>();
			q.Add(1, "one");
			q.Add(3, "three");
			q.Add(2, "two");
			foreach(KeyValuePair<int, string> item in q) {
				Console.WriteLine($"{item.Key} {item.Value}");
			}

			Console.WriteLine("\nКлас кiльцева черга");
			RoundQueue<int> q2 = new RoundQueue<int>();
			q2.Enqueue(1);
			q2.Enqueue(3);
			q2.Enqueue(2);
			foreach (object item in q2) {
				Console.WriteLine(item);
			}

			Console.WriteLine("\nКлас список");
			OneList<char> oneL = new OneList<char>();
			oneL.Add('a');
			oneL.Add('d');
			oneL.Add('f');
			oneL.Add('c');
			oneL.Add('e');
			oneL.Add('b');
			foreach (object item in oneL) {
				Console.Write(item + " ");
			}
			Console.WriteLine();
			oneL.Sort();
			oneL.Remove('c');
			oneL.Reverse();
			foreach (object item in oneL) {
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}
	}
}
