using System;
using System.Collections.Generic;

namespace DocumentFactory {
	/// <summary>
	/// MainApp startup class
	/// </summary>
	class MainApp {
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		static void Main() {
			//Note; constructors call Factory method
			Document[] documents = new Document[2];

			documents[0] = new Resume();
			documents[1] = new Report();

			//Display document pages

			foreach (Document d in documents) {
				Console.WriteLine(d.GetType().Name);
				foreach (Page p in d.Pages) {
					Console.WriteLine("  "+p.GetType().Name);
				}
			}
			//Wait for user
			Console.ReadKey();
		}
	}
}
