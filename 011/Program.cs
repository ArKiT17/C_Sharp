using System;
using System.Xml;

namespace _011 {
	class Program {
		static void InfoChildNodes(XmlNode node) {
			Console.WriteLine($"Тип: {node.NodeType}\tIм'я: {node.Name}\tЗначення: {node.Value}");
			if (node.HasChildNodes)
				foreach (XmlNode n in node.ChildNodes)
					InfoChildNodes(n);
		}
		static void Main(string[] args) {
			try {
				XmlTextWriter writer = new XmlTextWriter("file.xml", System.Text.Encoding.Unicode);
				writer.Formatting = Formatting.Indented;
				writer.WriteStartDocument();

				writer.WriteStartElement("Виконавцi");
				for (int i = 0; i < 3; i++) {
					writer.WriteStartElement($"Виконавець{i + 1}");
					writer.WriteStartElement("Альбом");
					writer.WriteElementString("РiкВипуску", $"{2020 + i}");
					writer.WriteElementString("КiлькiстьПiсень", $"{5 + i * 5}");
					writer.WriteElementString("Опис", $"Опис{i + 1}");
					writer.WriteEndElement();
					writer.WriteEndElement();
				}
				writer.WriteEndElement();
				writer.WriteEndDocument();
				writer.Close();

				//-----------------------------------------------------------------

				XmlDocument document = new XmlDocument();
				document.Load("file.xml");
				XmlNode main = document.DocumentElement;
				InfoChildNodes(main);

				Console.WriteLine("\n\n");

				//-----------------------------------------------------------------

				XmlTextReader reader = new XmlTextReader("file.xml");
				reader.WhitespaceHandling = WhitespaceHandling.None;
				while (reader.Read()) {
					Console.WriteLine($"Тип: {reader.NodeType}" +
						$"{(reader.NodeType.ToString().Length < 10 ? "\t" : "")}\t" +
						$"Iм'я: {reader.Name}{(reader.Name.Length < 10 ? "\t" : "")}{(reader.Name.Length < 3 ? "\t" : "")}\t" +
						$"Значення: {reader.Value}");
				}
				reader.Close();
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			Console.ReadLine();
		}
	}
}
