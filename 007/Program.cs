using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_1 {
	interface ICalc {
		int Less(int valueToCompare);
		int Greater(int valueToCompare);
	}
	interface ICalc2 {
		int CountDistinct();
		int EqualToValue(int valueToCompare);
	}
	interface IOutput2 {
		void ShowEven();
		void ShowOdd();
	}
	class Array : ICalc, ICalc2, IOutput2 {
		int[] arr;
		public Array(int count) {
			arr = new int[count];
			Random r = new Random();
			for (int i = 0; i < count; i++)
				arr[i] = r.Next(0, 100);
		}
		public int Less(int valueToCompare) {
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
				if (arr[i] < valueToCompare)
					count++;
			return count;
		}
		public int Greater(int valueToCompare) {
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
				if (arr[i] > valueToCompare)
					count++;
			return count;
		}
		public int CountDistinct() {
			bool unique;
			int count = 0;
			for (int i = 0; i < arr.Length; i++) {
				unique = true;
				for (int j = 0; j < arr.Length; j++)
					if (arr[i] == arr[j]) {
						unique = false;
						break;
					}
				if (unique)
					count++;
			}
			return count;
		}
		public int EqualToValue(int valueToCompare) {
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
				if (arr[i] == valueToCompare)
					count++;
			return count;
		}
		public void ShowEven() {
			for (int i = 0; i < arr.Length; i++)
				Console.Write(arr[i] % 2 == 0 ? "" + arr[i] + " " : "");
			Console.WriteLine();
		}
		public void ShowOdd() {
			for (int i = 0; i < arr.Length; i++)
				Console.Write(arr[i] % 2 != 0 ? "" + arr[i] + " " : "");
			Console.WriteLine();
		}
		public void ShowAll() {
			for (int i = 0; i < arr.Length; i++)
				Console.Write(arr[i] + " ");
			Console.WriteLine();
		}
	}
	internal class Program {
		static void Main(string[] args) {
			Array r = new Array(20);

			Console.Write("Масив: ");
			r.ShowAll();
			Console.WriteLine("Кiлькiсть чисел меньших за 50: " + r.Less(50));
			Console.WriteLine("Кiлькiсть чисел бiльших за 50: " + r.Greater(50));
			Console.WriteLine("Кiлькiсть унiкальних чисел: " + r.CountDistinct());
			Console.WriteLine("Кiлькiсть чисел рiвних 15: " + r.EqualToValue(15));
			Console.Write("Парнi числа: ");
			r.ShowEven();
			Console.Write("Непарнi числа: ");
			r.ShowOdd();
		}
	}
}
