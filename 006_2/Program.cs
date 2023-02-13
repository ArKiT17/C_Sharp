using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_2 {
	abstract class Device {
		public abstract void Sound();
		public abstract void Show();
		public abstract void Desc();

	}
	class Kettle : Device {
		public string Name { get; set; }
		public string Description { get; set; }
		public Kettle(string name = "", string desc = "") { Name = name; Description = desc; }
		public override void Sound() { Console.WriteLine("*свист чайника*"); }
		public override void Show() { Console.WriteLine($"Чайник {Name}"); }
		public override void Desc() { Console.WriteLine(Description); }
	}
	class Microwave : Device{
		public string Name { get; set; }
		public string Description { get; set; }
		public Microwave(string name = "", string desc = "") {
			Name = name;
			Description = desc;
		}
		public override void Sound() { Console.WriteLine("*бзинь*"); }
		public override void Show() { Console.WriteLine($"Мiкрохвильовка {Name}"); }
		public override void Desc() { Console.WriteLine(Description); }
	}
	class Car : Device {
		public string Name { get; set; }
		public double Speed { get; set; }
		public string Color { get; set; }
		public Car(string name, double speed, string color) {
			Name = name;
			Speed = speed;
			Color = color;
		}
		public override void Sound() { Console.WriteLine("*вжжж*"); }
		public override void Show() { Console.WriteLine($"Машина {Name}"); }
		public override void Desc() { Console.WriteLine($"Швидкiсть {Speed}, колiр {Color}"); }
	}
	class Ship : Device {
		public string Name { get; set; }
		public double Speed { get; set; }
		public string Color { get; set; }
		public Ship(string name, double speed, string color) {
			Name = name;
			Speed = speed;
			Color = color;
		}
		public override void Sound() { Console.WriteLine("*бульк*"); }
		public override void Show() { Console.WriteLine($"Корабель {Name}"); }
		public override void Desc() { Console.WriteLine($"Швидкiсть {Speed}, колiр {Color}"); }
	}
	internal class Program {
		static void Main(string[] args) {
			Kettle ch = new Kettle("Vinzer", "З пiдсвiткою");
			Microwave mi = new Microwave("Samsung", "Має запобiжник");
			Car mas = new Car("Audi", 350, "Синій");
			Ship kor = new Ship("Чорна Перлина", 100, "Чорний");

			ch.Sound();
			ch.Show();
			ch.Desc();
			Console.WriteLine();

			mi.Sound();
			mi.Show();
			mi.Desc();
			Console.WriteLine();

			mas.Sound();
			mas.Show();
			mas.Desc();
			Console.WriteLine();

			kor.Sound();
			kor.Show();
			kor.Desc();
		}
	}
}
