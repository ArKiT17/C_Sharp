using System;
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
	}
	internal class Program {
		static void Main(string[] args) {
			Shop s = new Shop();
			s.Name = "ATB";
			s.Address = "Wesiola Street";
			s.Description = "The best shop!";
			s.Tel = "+380 98 876 5543";
			s.Email = "atb@shop.krop.ua";
			Console.WriteLine(s.Name + ", which located on " + s.Address + " is " + s.Description);
			Console.WriteLine("Contact phone: " + s.Tel + "\nE-mail: " + s.Email);
		}
	}
}
