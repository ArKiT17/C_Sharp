using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_3 {
	abstract class Worker {
		public abstract void Print();
	}
	class President : Worker{
		public override void Print() {
			Console.WriteLine("Я президент!");
		}
	}
	class Security : Worker {
		public override void Print() {
			Console.WriteLine("Я охоронець!");
		}
	}
	class Manager : Worker {
		public override void Print() {
			Console.WriteLine("Я менеджер!");
		}
	}
	class Engineer : Worker {
		public override void Print() {
			Console.WriteLine("Я iнженер!");
		}
	}

	internal class Program {
		static void Main(string[] args) {
			Worker[] workers = { new President(), new Security(), new Manager(), new Engineer() };
			foreach (Worker pearson in workers)
				pearson.Print();
		}
	}
}
