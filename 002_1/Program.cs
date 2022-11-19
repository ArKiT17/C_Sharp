using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			float[] A = new float[5];
			float[,] B = new float[3, 4];
			Console.WriteLine("Введiть 5 чисел: ");
			string tmp = Console.ReadLine();
			string[] tmpMas = tmp.Split();
			for (int i = 0; i < A.Length; i++)
				A[i] = Convert.ToInt32(tmpMas[i]); //як записати числа (1\n 1 2\n)
			Random rand = new Random();
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 4; j++)
					B[i, j] = rand.Next(100);

			Console.Write("\nМасив А: ");
			for (int i = 0; i < A.Length; i++)
				Console.Write(A[i] + " ");
			Console.WriteLine("\n\nМасив B: ");
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 4; j++)
					Console.Write(B[i, j] + "\t");
				Console.WriteLine();
			}

			float min = A[0], max = A[0], sum = 0, multiply = 1, sumElA = 0, sumColB = 0;
			for (int i = 0; i < A.Length; i++) {
				if (A[i] < min)
					min = A[i];
				if (A[i] > max)
					max = A[i];
				sum += A[i];
				multiply *= A[i];
				if (A[i] % 2 == 0)
					sumElA += A[i];
			}
			Console.WriteLine("\nМаксимальний елемент матрицi А - " + max);
			Console.WriteLine("Мiнiмальний елемент матрицi А - " + min);
			Console.WriteLine("Сума елементiв матрицi А - " + sum);
			Console.WriteLine("Добуток елементiв матрицi А - " + multiply);
			Console.WriteLine("Сума парних елементiв матрицi А - " + sumElA + '\n');

			max = min = B[0, 0];
			sum = 0;
			multiply = 1;
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 4; j++) {
					if (B[i, j] < min)
						min = B[i, j];
					if (B[i, j] > max)
						max = B[i, j];
					sum += B[i, j];
					multiply *= B[i, j];
					if (j+1 % 2 != 0)
						sumColB += B[i, j];
				}
			}
			Console.WriteLine("Максимальний елемент матрицi B - " + max);
			Console.WriteLine("Мiнiмальний елемент матрицi B - " + min);
			Console.WriteLine("Сума елементiв матрицi B - " + sum);
			Console.WriteLine("Добуток елементiв матрицi B - " + multiply);
			Console.WriteLine("Сума елементiв непарних стовпцiв матрицi В - " + sumColB);

			Console.ReadLine();
		}
	}
}
