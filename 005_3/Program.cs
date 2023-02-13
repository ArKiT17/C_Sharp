using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_3 {
	class BooksList {
		List<string> array;
		public BooksList() { array = new List<string>(); }
		public static BooksList operator +(BooksList books, string newBook) {
			books.array.Add(newBook);
			return books;
		}
		public static BooksList operator -(BooksList books, string delBook) {
			if (books == delBook)
				books.array.Remove(delBook);
			return books;
		}
		public static bool operator==(BooksList books, string checkBook) {
			for (int i = 0; i < books.array.Count; i++) {
				if (books.array[i] == checkBook)
					return true;
			}
			return false;
		}
		public static bool operator !=(BooksList books, string checkBook) {
			for (int i = 0; i < books.array.Count; i++) {
				if (books.array[i] != checkBook)
					return true;
			}
			return false;
		}
		public string this[int index] {
			get {
				if (index > 0 && index < array.Count)
					return array[index];
				throw new Exception("Вихiд за межi масиву");
			}
			set {
				array.Add(value);
			}
		}
	}
	internal class Program {
		static void Main(string[] args) {
			try {
				BooksList booksList = new BooksList();
				booksList = booksList + "Людина-павук";
				booksList = booksList + "Местники";
				booksList = booksList + "Післязавтра";
				booksList = booksList + "Сімейка Адамсів";
				Console.WriteLine("Чи є \"Местники\" серед книжок? ");
				Console.WriteLine(booksList == "Местники");
				booksList = booksList - "Местники";
				Console.WriteLine("Чи є \"Местники\" серед книжок? ");
				Console.WriteLine(booksList == "Местники");
			}
			catch(Exception e) {
				Console.WriteLine(e.ToString());
			}
		}
	}
}
