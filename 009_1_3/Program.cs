using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_1_3 {
	class Card {
		public string Number { get; set; }
		public string Owner { get; set; }
		public string Validity { get; set; }
		public string Pin { get; set; }
		public float CreditLimit { get; set; }
		public float Money { get; set; }
		public float WantedSum { get; set; }
		public Card(string number, string owner, string validity, string pin,
			float creditlimit, float wantedsum, float money = 0) {
			Number = number;
			Owner = owner;
			Validity = validity;
			Pin = pin;
			CreditLimit = creditlimit;
			WantedSum = wantedsum;
			Money = money;
		}
		public event EventHandler MoneyAdded;
		public event EventHandler MoneyRemoved;
		public event EventHandler UseCreditMoney;
		public event EventHandler ReachedDesiredAmount;
		public event EventHandler ChangedPIN;
		public void AddMoney(float value) {
			Money += value;
			if (MoneyAdded != null)
				MoneyAdded(this, EventArgs.Empty);
			if (Money >= WantedSum)
				if (ReachedDesiredAmount != null)
					ReachedDesiredAmount(this, EventArgs.Empty);
		}
		public void RemoveMoney(float value) {
			if (Money + CreditLimit < value) {
				Console.WriteLine("Недостатньо коштiв для здiйснення операцiї");
				return;
			}
			Money -= value;
			if (MoneyRemoved != null)
				MoneyRemoved(this, EventArgs.Empty);
			if (Money < 0)
				if (UseCreditMoney != null)
					UseCreditMoney(this, EventArgs.Empty);
		}
		public void ChargePIN() {
			Console.WriteLine("Введiть старий PIN: ");
			string oldPIN = Console.ReadLine();
			while (oldPIN != Pin) {
				Console.WriteLine("Ви ввели невiрний PIN!");
				Console.WriteLine("Введiть старий PIN: ");
				oldPIN = Console.ReadLine();
			}
			Console.WriteLine("Введiть новий PIN: ");
			Pin = Console.ReadLine();
			if (ChangedPIN != null)
				ChangedPIN(this, EventArgs.Empty);
		}
	}

	internal class Program {
		static void Main(string[] args) {
			Card card = new Card("123456789", "Ja", "2024-12-31", "0000", 50000, 1000, 0);
			card.MoneyAdded += Card_MoneyAdded;
			card.MoneyRemoved += Card_MoneyRemoved;
			card.UseCreditMoney += Card_UseCreditMoney;
			card.ReachedDesiredAmount += Card_ReachedDesiredAmount;
			card.ChangedPIN += Card_ChangedPIN;

			card.AddMoney(20000);
			Console.WriteLine();
			card.RemoveMoney(20500);
			Console.WriteLine();
			card.AddMoney(60000);
			Console.WriteLine();
			card.ChargePIN();
		}

		private static void Card_ChangedPIN(object sender, EventArgs e) {
			Console.WriteLine("PIN успiшно змiнено!");
		}
		private static void Card_ReachedDesiredAmount(object sender, EventArgs e) {
			Console.WriteLine("Ви досягли бажанної суми!");
		}
		private static void Card_UseCreditMoney(object sender, EventArgs e) {
			Console.WriteLine("Увага! Ви почали використовувати кредитнi кошти.");
		}
		private static void Card_MoneyRemoved(object sender, EventArgs e) {
			Console.WriteLine("Оплата пройшла успiшно!");
		}
		private static void Card_MoneyAdded(object sender, EventArgs e) {
			Console.WriteLine("Рахунок було поповнено!");
		}
	}
}