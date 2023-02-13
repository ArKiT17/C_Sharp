using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_2 {
	class Shop {
		public string Name { get; set; }
		public string Address { get; set; }
		public string Description { get; set; }
		public string Tel { get; set; }
		public string Email { get; set; }
		public int CountOfWorkers { get; set; }
		public static Shop operator+(Shop magaz, int num) {
			Shop newShop = magaz;
			newShop.CountOfWorkers += num;
			return newShop;
		}
		public static Shop operator-(Shop magaz, int num) {
			Shop newShop = magaz;
			newShop.CountOfWorkers -= num;
			return newShop;
		}
		public static bool operator ==(Shop magaz1, Shop magaz2) {
			return magaz1.CountOfWorkers == magaz2.CountOfWorkers;
		}
		public static bool operator !=(Shop magaz1, Shop magaz2) {
			return magaz1.CountOfWorkers != magaz2.CountOfWorkers;
		}
		public static bool operator >(Shop magaz1, Shop magaz2) {
			return magaz1.CountOfWorkers > magaz2.CountOfWorkers;
		}
		public static bool operator <(Shop magaz1, Shop magaz2) {
			return magaz1.CountOfWorkers < magaz2.CountOfWorkers;
		}
		public override bool Equals(object obj) {
			return this.GetHashCode() == obj.GetHashCode();
		}
	}
	internal class Program {
		static void Main(string[] args) {
			Shop s = new Shop();
			s.Name = "ATB";
			s.Address = "Wesiola Street";
			s.Description = "The best shop!";
			s.Tel = "+380 98 876 5543";
			s.Email = "atb@shop.krop.ua";
			s.CountOfWorkers = 100;
			Console.WriteLine(s.Name + ", which located on " + s.Address + " is " + s.Description);
			Console.WriteLine("Contact phone: " + s.Tel + "\nE-mail: " + s.Email);
			Console.WriteLine("\n\n\n");
			Console.WriteLine("Count of workers:\t" + s.CountOfWorkers);
			s = s + 10;
			Console.WriteLine("Count of workers + 10:\t" + s.CountOfWorkers);
			s = s - 30;
			Console.WriteLine("Count of workers - 30:\t" + s.CountOfWorkers);
			Shop shop1 = new Shop { CountOfWorkers = 10 }, shop2 = new Shop { CountOfWorkers = 15 };
			Console.WriteLine("Count of shop1:\t\t" + shop1.CountOfWorkers);
			Console.WriteLine("Count of shop2:\t\t" + shop2.CountOfWorkers);
			Console.WriteLine("Workers shop1 == shop2:\t" + (shop1 == shop2));
			Console.WriteLine("Workers shop1 != shop2:\t" + (shop1 != shop2));
			Console.WriteLine("Workers shop1 > shop2:\t" + (shop1 > shop2));
			Console.WriteLine("Workers shop1 < shop2:\t" + (shop1 < shop2));
		}
	}
}
