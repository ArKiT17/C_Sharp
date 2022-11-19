using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_2 {
	internal class Program {
		static void Main(string[] args) {
			int[,] arr = new int[5, 5];
			Random rand = new Random();
			int min = 101, max = -101;
			int[] arrLong = new int[25];
			int index = 0, arrLongFrom = 0, arrLongTo = 0;
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 5; j++) {
					arr[i, j] = rand.Next(-100, 100);
					arrLong[index] = arr[i, j];
					if (arrLong[index] > max) {
						max = arrLong[index];
						arrLongTo = index;
					}
					if (arrLong[index] < min) {
						min = arrLong[index];
						arrLongFrom = index;
					}
					index++;
				}
			if (arrLongFrom > arrLongTo) {
				int tmp = arrLongFrom;
				arrLongFrom = arrLongTo;
				arrLongTo = tmp;
			}
			int sum = 0;
			for (int i = arrLongFrom + 1; i < arrLongTo; i++)
				sum += arrLong[i];

			Console.WriteLine("Масив 5x5:");
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 5; j++)
					Console.Write(arr[i, j] + "\t");
				Console.WriteLine();
			}
			Console.WriteLine("\nСума елементiв мiж " + min + " та " + max + ": " + sum);
			Console.ReadLine();
		}
	}
}
