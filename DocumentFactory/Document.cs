using System;
using System.Collections.Generic;

namespace DocumentFactory {
	/// <summary>
	/// The "Creator" abstract class
	/// </summary>
	abstract class Document {
		private List<Page> _pages = new List<Page>();
		//Constructor calls the abstract factory method
		public Document() {
			this.CreatePages();
		}

		public List<Page> Pages {
			get { return _pages; }
		}

		public abstract void CreatePages();
	}
}