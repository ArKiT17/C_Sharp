using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_1_1 {
	delegate void EvenNumbers(int[] nums);
	internal class Program {
		static void GetEvenNums(int[] nums) {
			foreach (int i in nums)
				if (i%2 ==0 )
					Console.Write($"{i} ");
			Console.WriteLine();
		}
		static void GetOddNums(int[] nums) {
			foreach (int i in nums)
				if (i % 2 != 0)
					Console.Write($"{i} ");
			Console.WriteLine();
		}
		static bool IsPrime(int number) {
			for (int i = 2; i < number; i++) {
				if (number % i == 0)
					return false;
			}
			return true;
		}
		static void GetPrimeNums(int[] nums) {
			foreach (int i in nums)
				if (IsPrime(i))
					Console.Write($"{i} ");
			Console.WriteLine();
		}
		static void GetFiboNums(int[] nums) {
			for (int i = 0; i < nums.Length - 1; i++) {
				Console.Write($"{nums[i] + nums[i+1]} ");
			}
			Console.WriteLine();
		}
		static void Main(string[] args) {
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			EvenNumbers del = GetEvenNums;
			del(array);
			del = GetOddNums;
			del(array);
			del = GetPrimeNums;
			del(array);
			del = GetFiboNums;
			del(array);
		}
	}
}
