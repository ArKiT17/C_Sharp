using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_4 {
	internal class Program {
		static void Main(string[] args) {
			int[][] matrix1 = new int[5][];
			int[][] matrix2 = new int[5][];
			for (int i = 0; i < 5; i++) {
				matrix1[i] = new int[5];
				matrix2[i] = new int[5];
			}
			Console.WriteLine("Матриця 1:");
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 5; j++) {
					matrix1[i][j] = i + j;
					matrix2[i][j] = i + j;
					Console.Write(matrix1[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\nМатриця 2:");
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 5; j++) {
					Console.Write(matrix2[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\nМноження матрицi 1 на число 5:");
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 5; j++) {
					matrix1[i][j] *= 5;
					Console.Write(matrix1[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\nМноження матриць 1 на 2:");
			int[][] result = new int[5][];
			for (int i = 0; i < 5; i++)
				result[i] = new int[5];
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 5; j++)
					for (int k = 0; k < 5; k++)
						result[i][j] += matrix1[i][k] * matrix2[k][j];
			
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 5; j++)
					Console.Write(result[i][j] + "\t");
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
