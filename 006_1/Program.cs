using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_1 {
	class Money {
		public int Cash { get; set; }
		public int Cent { get; set; }
		public Money(int cash, int cent) { Cash = cash; Cent = cent; }
		public override string ToString() { return $"{Cash}.{Cent}"; }
	}
	class Product : Money{
		public Product(double num) : base((int)num, Convert.ToInt32((num - (int)num) * 100)) { }
		public void LessOn(double num) {
			int tmpCent = Convert.ToInt32((num - (int)num) * 100);
			Cash -= Convert.ToInt32(num);
			if (tmpCent > Cent)
				Cent += 100;
			Cent -= tmpCent;
		}
	}
	internal class Program {
		static void Main(string[] args) {
			Product p = new Product(16.7);
			p.LessOn(1.18);
			Console.WriteLine(p);
			p.LessOn(3.67);
			Console.WriteLine(p);
		}
	}
}
