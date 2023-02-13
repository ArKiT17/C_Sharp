using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009 {
	class Money {
		public int Cash { get; set; }
		public int Cent { get; set; }
		public Money(int cash, int cent) { Cash = cash; Cent = cent; }
		public override string ToString() { return $"{Cash}.{Cent}"; }
		public static Money operator+(Money a, Money b) {
			Money tmp = new Money(a.Cash + b.Cash, a.Cent + b.Cent);
			while (tmp.Cent > 99) {
				tmp.Cash++;
				tmp.Cent -= 100;
			}
			return tmp;
		}
		public static Money operator-(Money a, Money b) {
			Money tmp = new Money(a.Cash - b.Cash, a.Cent - b.Cent);
			while (tmp.Cent < 0) {
				tmp.Cash--;
				tmp.Cent += 100;
			}
			if (tmp.Cash < 0)
				throw new Exception("Банкрот");
			return tmp;
		}
		public static Money operator /(Money a, int b) {
			if (b < 1)
				throw new Exception("Банкрот");
			return new Money(a.Cash / b, a.Cent / b);
		}
		public static Money operator *(Money a, int b) {
			Money tmp = new Money(a.Cash * b, a.Cent * b);
			while (tmp.Cent > 99) {
				tmp.Cash++;
				tmp.Cent -= 100;
			}
			if (b < 1)
				throw new Exception("Банкрот");
			return tmp;
		}
		public static Money operator ++(Money a) {
			a.Cent++;
			if (a.Cent > 99) {
				a.Cash++;
				a.Cent -= 100;
			}
			return a;
		}
		public static Money operator --(Money a) {
			a.Cent--;
			while (a.Cent < 0) {
				a.Cash--;
				a.Cent += 100;
			}
			if (a.Cent < 0)
				throw new Exception("Банкрот");
			return a;
		}
		public static bool operator >(Money a, Money b) {
			if (a.Cash > b.Cash)
				return true;
			else
				if ((a.Cash == b.Cash) && (a.Cent > b.Cent))
					return true;
			return false;
		}
		public static bool operator <(Money a, Money b) {
			if (a.Cash < b.Cash)
				return true;
			else
				if ((a.Cash == b.Cash) && (a.Cent < b.Cent))
				return true;
			return false;
		}
		public static bool operator ==(Money a, Money b) {
			if ((a.Cash == b.Cash) && (a.Cent == b.Cent))
				return true;
			else
				return false;
		}
		public static bool operator !=(Money a, Money b) {
			if ((a.Cash != b.Cash) || (a.Cent != b.Cent))
				return true;
			else
				return false;
		}
	}
	internal class Program {
		static void Main(string[] args) {
			try {
				Money one = new Money(1, 5);
				Money two = new Money(1, 5);
				Money three = new Money(3, 7);
				Console.WriteLine(one == two);
				one = two - three; // банкрот
				Console.WriteLine(two * 3 - two / 2);	// вже не виконується 
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}